using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Math_Puzzle_Game
{
    public partial class Solve : Form
    {
        public Solve()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string equation = (string)this.textBox1.Text;
            DataTable dt = new DataTable();
            var v = dt.Compute(equation, "");
            label5.Text = v.ToString();
            label5.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pick pick = new Pick();
            this.Hide();
            pick.ShowDialog();
        }
    }
}
