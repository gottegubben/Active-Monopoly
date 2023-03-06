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
    public partial class MonopolySimulation : Form
    {
        private Game game { get; set; }
        private Random rnd { get; set; }
        private List<StatCollection> statCollection { get; set; }
        private List<TextBox> textBoxesBotCount { get; set; }
        private int defHeight { get; set; }
        private int defTop { get; set; }
        private double[] percPlayerWins { get; set; }
        private double[] percMostPaidRent { get; set; }
        public MonopolySimulation()
        {
            InitializeComponent();

            statCollection = new List<StatCollection>();

            textBoxesBotCount = new List<TextBox>()
            {
                textBoxBotAggMax,
                textBoxBotAggMin,
                textBoxBotBal,
                textBoxBotPas,
                textBoxBotDead
            };

            defHeight = buttonBotA.Height;
            defTop = buttonBotA.Top;
        }

        private void buttonRunSim_Click(object sender, EventArgs e)
        {
            /* Inputs:
             * gameCounter
             * gameCondition
             * roundCap
             * botCounts
             * seed
            */

            #region Validate Inputs

            #region Player Settings:
            //Amounts of bots of each type.
            List<int> botCounts = new List<int>();

            //This will indicate if the textbox inputs were correctly written.
            bool botCountCheck = true;
            foreach (TextBox item in textBoxesBotCount)
            {
                if(item.Enabled == true)
                {
                    try
                    {
                        botCounts.Add(int.Parse(item.Text));
                    }
                    catch { botCountCheck = false; }
                }
                else
                {
                    botCounts.Add(0);
                }
            }
            #endregion

            #region Sim Settings
            #region Game Counter
            //This bool will be the variable that stores if the game counter textbox input is correct or not.
            bool gameCounterCheck = true;

            int gameCounter = 0;
            try
            {
                gameCounter = int.Parse(textBoxGameCount.Text);
            }
            catch { gameCounterCheck = false; }
            #endregion

            #region Game Condition
            /*
                Annihilation = 1
                Property = 2
                Money = 3
            */

            int gameCondition = 0;

            if (radioButtonWinAnn.Checked)
            {
                gameCondition = 1;
            }
            else if (radioButtonWinProp.Checked)
            {
                gameCondition = 2;
            }
            else if (radioButtonWinMon.Checked)
            {
                gameCondition = 3;
            }
            #endregion

            #region Round Cap
            //The bool that indicates if the roundCap input is the correct format or not.
            bool roundCapChecked = true;

            int roundCap = 0;
            try
            {
                if (checkBoxEnableRoundCap.Checked)
                {
                    roundCap = int.Parse(textBoxRoundCap.Text);
                }
            }
            catch
            {
                roundCapChecked = false;
            }
            #endregion
            #endregion

            #region Seed settings
            //The bool that shows you if the seed input was of the correct format.
            bool seedChecked = true;

            int seed = 0;
            try
            {
                seed = int.Parse(textBoxSeed.Text);
            }
            catch
            {
                seedChecked = false;
            }
            #endregion

            #region Other
            int startBalance = 200;
            int maxConstruction = 3;

            try
            {
                startBalance = int.Parse(textBoxPlayerBalance.Text);
                maxConstruction = int.Parse(textBoxMaxConstruct.Text);
            }
            catch
            {
            }
            #endregion

            #endregion

            //If the inputs are of the correct format:
            if (botCountCheck && gameCounterCheck && roundCapChecked && seedChecked)
            {
                rnd = new Random(seed);

                //Mix the botcounts!

                Game gm = new Game(rnd, roundCap, startBalance, maxConstruction);
                gm.AddPlayers(botCounts.ToArray());

                List<Button> buttonText = new List<Button>()
                {
                    buttonBotA,
                    buttonBotB,
                    buttonBotC,
                    buttonBotD,
                    buttonBotE
                };
                List<TextBox> textBoxText = new List<TextBox>()
                {
                    textBoxBotA,
                    textBoxBotB,
                    textBoxBotC,
                    textBoxBotD,
                    textBoxBotE
                };
                for (int i = 0; i < buttonText.Count; i++)
                {
                    buttonText[i].Text = "";
                    textBoxText[i].Text = "";
                }
                for (int i = 0; i < gm.Data.Players.Count; i++)
                {
                    textBoxText[i].Text = $"Con: [{(gm.Data.Players[i] as Bot).BuildingChance}] Pur: [{(gm.Data.Players[i] as Bot).PurchaseChance}]";
                    buttonText[i].Height = defHeight;
                    buttonText[i].Top = defTop;
                    buttonText[i].Text = "";
                }

                /*
                 * repeat for all games:
                 * new game()
                 * tell how many players are playing and call them by the config class.
                 * start the match by calling the method.
                 * let the match play out.
                */
                for (int i = 0; i < gameCounter; i++)
                {
                    game = new Game(rnd, roundCap, startBalance, maxConstruction);

                    game.AddPlayers(botCounts.ToArray());

                    statCollection.Add(game.StartMatch());
                }

                int[] playerWins = new int[gm.Data.Players.Count];
                int[] mostPaidRent = new int[gm.Data.Tiles.Count];

                statCollection.ForEach((x) => 
                { 
                    playerWins[x.PlayerPedestal[0].Id]++;

                    for (int i = 0; i < x.RentCountOfTile.Length; i++)
                    {
                        mostPaidRent[i] += x.RentCountOfTile[i];
                    }
                });

                percPlayerWins = new double[playerWins.Length];
                percMostPaidRent = new double[mostPaidRent.Length];

                for (int i = 0; i < playerWins.Length; i++)
                {
                    percPlayerWins[i] = (double)playerWins[i] / (double)playerWins.Sum();
                }
                for (int i = 0; i < mostPaidRent.Length; i++)
                {
                    percMostPaidRent[i] = (double)mostPaidRent[i] / (double)mostPaidRent.Sum();
                }

                foreach (Button item in buttonText)
                {
                    item.Height = 0;
                }

                for (int i = 0; i < percPlayerWins.Length; i++)
                {
                    int newHeight = (int)((double)defHeight * percPlayerWins[i]);
                    buttonText[i].Height = newHeight;
                    buttonText[i].Top += defHeight-newHeight;
                    buttonText[i].Text = $"{Convert.ToDouble(percPlayerWins[i].ToString("N4"))*100}%";
                }

                //Make sense of the statCollection list.
                //Write out the stats.
            }
            else
            {
                Log.TimeWrite($"The inputs were written in the wrong format!", Urgency.Incorrect);
            }
        }

        private void checkBoxBotAggMax_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chBox = sender as CheckBox;

            int val = Convert.ToInt16(chBox.Tag);

            if (chBox.Checked)
            {
                textBoxesBotCount[val - 1].Enabled = true;
            }
            else
            {
                textBoxesBotCount[val - 1].Enabled = false;
                textBoxesBotCount[val - 1].Text = "";
            }
        }

        private void checkBoxEnableRoundCap_CheckedChanged(object sender, EventArgs e)
        {
            if((sender as CheckBox).Checked == true)
            {
                textBoxRoundCap.Enabled = true;
            }
            else
            {
                textBoxRoundCap.Enabled = false;
                textBoxRoundCap.Text = "";
            }
        }

        private void buttonWTCWinRate_Click(object sender, EventArgs e)
        {
            Log.Write("Players present each block!",Urgency.Normal);
            Log.Write($"Win Rate:    [{string.Join("|",percPlayerWins)}]", Urgency.Result);
        }

        private void buttonWTCRent_Click(object sender, EventArgs e)
        {
            Log.Write("Tiles present each block!", Urgency.Normal);
            Log.Write($"Rent:    [{string.Join("|", percMostPaidRent)}]", Urgency.Result);
        }
    }
}
