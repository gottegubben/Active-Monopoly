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
        private List<TextBox> textBoxesBotCount { get; set; }
        public MonopolySimulation()
        {
            InitializeComponent();

            textBoxesBotCount = new List<TextBox>()
            {
                textBoxBotAggMax,
                textBoxBotAggMin,
                textBoxBotBal,
                textBoxBotPas,
                textBoxBotDead
            };
        }

        private void buttonRunSim_Click(object sender, EventArgs e)
        {
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
                roundCap = int.Parse(textBoxRoundCap.Text);
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

            #endregion

            //If the inputs are of the correct format:
            if(botCountCheck && gameCounterCheck && roundCapChecked && seedChecked)
            {

            }
            else
            {
                //Log.Write
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
    }
}
