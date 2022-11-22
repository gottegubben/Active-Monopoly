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
        }
    }
}
