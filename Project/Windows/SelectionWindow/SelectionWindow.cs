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
    public partial class SelectionWindow : Form
    {
        public SelectionWindow()
        {
            InitializeComponent();
        }

        private void buttonTileStep_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (int.Parse(btn.Tag.ToString()))
            {
                case 1:
                    new TileStepSimulation().Show();
                    break;

                case 2:
                    new MonopolySimulation().Show();
                    break;

                case 3:
                    break;

                case 4:
                    new CreditWindow().Show();
                    break;
            }
        }
    }
}
