using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class TileStepSimulation : Form
    {
        #region Constructors:
        public TileStepSimulation()
        {
            //Inits the list.
            ButtonTiles = new List<Button>();

            InitializeComponent();
        }
        #endregion

        #region Properties:
        //The tiles that will be in the simulation.
        public List<Tile> Tiles { get; set; }

        //A list of all the buttons that will work as a tile.
        public List<Button> ButtonTiles { get; set; }

        //A list that will contain all the simulated percentage of landing on a specific tile. 
        public float[] LandingPercentage { get; set; }
        #endregion

        #region Methods:
        //This method runs when the window is first runned.
        private void TileStepSimulation_Load(object sender, EventArgs e)
        {
            //This will fix the alignment of the text of the rich text box.
            richTextBoxDescription.SelectAll();
            richTextBoxDescription.SelectionAlignment = HorizontalAlignment.Center; 

            //Fetches all the tiles that exist in monopoly.
            Tiles = MonopolyConfig.GetTiles();

            //Inits the array.
            LandingPercentage = new float[Tiles.Count];

            //Adds all the button tiles controls to the button list.
            for (int i = 1; i < Tiles.Count + 1; i++)
            {
                Button btn = Controls.Find($"buttonTile{i}", false)[0] as Button;

                //Changes the tag to corrospond to the id of the button.
                btn.Tag = (i-1);

                ButtonTiles.Add(btn);
            }
        }

        //This method runs the simulation.
        private void buttonRun_Click(object sender, EventArgs e)
        {
            Log.WriteTitle("Tile Step Simulation");

            #region Check before running:
            //All the values from the textboxes:
            int matches = 0;
            int rounds = 0;
            int prisonTime = 0;

            //The value from the checkbox:
            bool diceBreakFree = checkBoxBreakFree.Checked;

            bool input1 = int.TryParse(textBoxAmountMatches.Text, out matches);
            bool input2 = int.TryParse(textBoxAmountRounds.Text, out rounds);
            bool input3 = int.TryParse(textBoxMaxPrisonTime.Text, out prisonTime);
            #endregion

            //Checks if the input is in the correct format.
            if (input1 && input2 && input3)
            {
                Log.TimeWrite($"Input worked!", Urgency.Correct);

                //The dice / dices for the game.
                Random rnd = new Random();

                List<Dice> dices = new List<Dice>()
                {
                    new Dice(rnd.Next(1, 100000)),
                    new Dice(rnd.Next(1, 100000))
                };

                //The player that will be used in the simulation.
                Player player = new Player();

                //Player position handler.
                PlayerPositionHandler posHandler = new PlayerPositionHandler()
                {
                    Positions = new List<PlayerPosition>()
                    {
                        new PlayerPosition()
                        {
                            PlayerId = player.Id,
                            Position = 0
                        }
                    }
                };

                //Disables the button until the simulation is complete.
                buttonRun.Enabled = false;

                float roundsPlayed = 0;

                float[] tileStepCount = new float[Tiles.Count];

                //Plays the desired amount of matches of monopoly with the total amount of rounds will be the round variable.
                for (int i = 0; i < matches; i++)
                {
                    int roundsStayedInJail = 0;

                    //Plays the desired amount of rounds.
                    for (int y = 0; y < rounds; y++)
                    {
                        int[] diceThrows = player.Throw(dices.ToArray());

                        Move move = new Move(player);
                        move.PrePosition = posHandler.GetPlayerPositionInt(player);

                        //This will check if the player has thrown duplicates and acts accordingly.
                        if (checkBoxBreakFree.Checked)
                        {
                            if (diceThrows.GroupBy(x => x).Any(g => g.Count() == diceThrows.Length))
                            {
                                player.CanMove = true;

                                roundsStayedInJail = 0;
                            }
                        }

                        if (player.CanMove)
                        {
                            posHandler.MovePlayerForward(player, diceThrows.Sum(), Tiles.Count);

                            tileStepCount[posHandler.GetPlayerPositionInt(player)]++;

                            //If the player lands on the "go to prison" tile then move to prison.
                            if(posHandler.GetPlayerPositionInt(player) == 30)
                            {
                                player.CanMove = false;

                                posHandler.SetPlayerPosition(player, 10);
                            }
                        }
                        else //If the player is still in jail.
                        { 
                            roundsStayedInJail++;

                            tileStepCount[10]++;

                            if(roundsStayedInJail >= prisonTime)
                            {
                                player.CanMove = true;
                            }
                        }

                        move.PostPosition = posHandler.GetPlayerPositionInt(player);

                        roundsPlayed++;

                        Log.PaintLine();
                        Log.TimeWrite($"[M:{i} R:{y}] Previous Position: {move.PrePosition}", Urgency.Normal);
                        Log.TimeWrite($"[M:{i} R:{y}] Post position    : {move.PostPosition}", Urgency.Normal);
                    }
                }

                Log.PaintLine();

                for (int i = 0; i < Tiles.Count; i++)
                {
                    LandingPercentage[i] = (tileStepCount[i] / roundsPlayed) *100;

                    Log.Write($"Tile {i}: {LandingPercentage[i]}%", Urgency.Result);
                }

                float[] sorted = LandingPercentage.OrderBy(x => x).ToArray();

                Log.PaintLine();

                Log.Write("Highest (Top 3):", Urgency.None);
                for (int i = 0; i < 3; i++)
                {
                    Log.Write($"{i + 1}: {sorted[sorted.Length - (i + 1)]}%", Urgency.Result);
                }
                Log.PaintSpace();
                Log.Write("Lowest (Top 3):", Urgency.None);
                for (int i = 0; i < 3; i++)
                {
                    Log.Write($"{i + 1}: {sorted[i]}%", Urgency.Result);
                }

                buttonRun.Enabled = true;
            }
            else
            {
                Log.TimeWrite($"The input was wrong!", Urgency.Incorrect);
            }
        }

        //This function is responsible for displaying the data of a tile if the tile is pressed.
        private void buttonTile1_Click(object sender, EventArgs e)
        {
            //Converts the sender to the button.
            Button btn = sender as Button;

            int btnId = (int)btn.Tag;

            textBoxTileDataName.Text = Tiles[btnId].TileName;

            textBoxTileDataTileId.Text = $"{Tiles[btnId].TileId}";

            panelTileDataTileColor.BackColor = Tiles[btnId].TileColor;

            textBoxTileDataType.Text = "Unidentified";

            textBoxTileDataChance.Text = $"{LandingPercentage[btnId]}";
        }
        #endregion

        #region Comments:

        /*
            En avgränsning med programmet är att man inte tar hänsyn till ifall spelaren slår två av samma siffror. Då ska man egentligen få slå ett till kast
            men i det här programmet finns inte det med. I försäg behövs inte det då det endast tittar vart man landar och det är helt irrelevant att veta hur många
            rundor spelaren har spelat då det endast är vart den landar. Visst kan man slå två slag på en runda men det spelar ingen roll i den här simuleringen ifall
            de slår en gång per runda istället.
        */

        #endregion
    }
}
