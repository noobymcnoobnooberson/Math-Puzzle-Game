using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Puzzle_Game
{
    public partial class Pick : Form
    {
        public Pick()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Solve solve = new Solve();
            this.Hide();
            solve.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e) { 

        }
    }
}
