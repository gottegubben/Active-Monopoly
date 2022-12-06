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
        public TileStepSimulation()
        {
            InitializeComponent();
        }

        private void TileStepSimulation_Load(object sender, EventArgs e)
        {
            //This will fix the alignment of the text of the rich text box.
            richTextBoxDescription.SelectAll();
            richTextBoxDescription.SelectionAlignment = HorizontalAlignment.Center;
        }

        //This method runs the simulation.
        private void buttonRun_Click(object sender, EventArgs e)
        {
            #region Init:
            //All the dices gathered in a list.
            List<Dice> dices = new List<Dice>()
            {
                new Dice(),
                new Dice()
            };

            //The player that will be used in the simulation.
            Player player = new Player();

            //Fetches all the tiles that exist in monopoly.
            List<Tile> tiles = MonopolyConfig.GetTiles();

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
                //Disables the button until the simulation is complete.
                buttonRun.Enabled = false;

                //This should be runned on a different thread:

                //Plays the desired amount of matches of monopoly with the total amount of rounds will be the round variable.
                for (int i = 0; i < matches; i++)
                {
                    //Plays the desired amount of rounds.
                    for (int y = 0; y < rounds; y++)
                    {
                    }
                }
            }
            else
            {
                //If the input is wrong!
            }
        }
    }
}
