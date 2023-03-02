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
    public partial class Testing : Form
    {
        public Testing()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            List<Tile> tiles = MonopolyConfig.GetTiles();

            List<string> propertiesName = new List<string>();

            foreach (Tile tile in tiles)
            {
                if (tile is Property)
                {
                    propertiesName.Add($"{tile.TileId}");
                }
            }

            string[] comparer1 = propertiesName.ToArray();

            double[] comparer2 = new double[]
            {
                393.21d,
                192.03d,
                204.56d,
                198.76d,
                178.38d,
                180.90d,
                174.46d,
                146.21d,
                135.58d,
                132.93d,
                137.52d,
                140.70d,
                142.64d,
                135.21d,
                132.39d,
                129.23d,
                126.91d,
                130.25d,
                133.82d,
                137.11d,
                139.62d,
                110.41d
            };

            Array.Sort(comparer2, comparer1);

            for (int i = 0; i < comparer1.Length; i++)
            {
                richTextBox.Text += $"{comparer1[i]} {comparer2[i]}\n";
            }
        }
    }
}
