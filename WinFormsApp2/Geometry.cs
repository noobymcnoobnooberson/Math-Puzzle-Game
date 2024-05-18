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
    public partial class Geometry : Form
    {
        public Geometry()
        {
            InitializeComponent();
        }
        int Op = 0;
        private void Square_Click(object sender, EventArgs e)
        {
            Chosen.Text = "Vuông";
            label3.Show();
            label4.Hide();
            label5.Hide();
            textBox1.Show();
            textBox2.Hide();
            textBox3.Hide();
            Solve.Show();
            label3.Text = "Độ dài cạnh: ";
            Op = 1;
        }
        private void Triangle_Click(object sender, EventArgs e)
        {
            Chosen.Text = "Tam Giác";
            label3.Show();
            label4.Show();
            label5.Show();
            textBox1.Show();
            textBox2.Show();
            textBox3.Show();
            label3.Text = "Độ dài cạnh 1: ";
            label4.Text = "Độ dài cạnh 2: ";
            label5.Text = "Độ dài cạnh 3: ";
            Solve.Show();
            Op = 2;
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            Chosen.Text = "Hình chữ nhật";
            label3.Show();
            label4.Show();
            label5.Hide();
            textBox1.Show();
            textBox2.Show();
            textBox3.Hide();
            label3.Text = "Độ dài: ";
            label4.Text = "Độ rộng: ";
            Solve.Show();
            Op = 3;
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            Chosen.Text = "Hình tròn";
            label3.Show();
            label4.Hide();
            label5.Hide();
            textBox1.Show();
            textBox2.Hide();
            textBox3.Hide();
            label3.Text = "Bán kính: ";
            Solve.Show();
            Op = 4;
        }
    }
}
