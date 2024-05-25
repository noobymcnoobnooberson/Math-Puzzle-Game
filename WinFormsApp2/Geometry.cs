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
            label6.Hide();
            label8.Hide();
            Circ.Hide();
            Area.Hide();
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
            label6.Hide();
            label8.Hide();
            Circ.Hide();
            Area.Hide();
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
            label6.Hide();
            label8.Hide();
            Circ.Hide();
            Area.Hide();
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
            label6.Hide();
            label8.Hide();
            Circ.Hide();
            Area.Hide();
            Op = 4;
        }

        private void Solve_Click(object sender, EventArgs e)
        {
            switch (Op)
            {
                case 1:
                    if (textBox1 == null)
                    {
                        MessageBox.Show("Hãy điền giá trị");
                    }
                    else
                    {
                        label6.Show();
                        label8.Show();
                        Circ.Show();
                        Area.Show();
                        double C = Int32.Parse(textBox1.Text) * 4;
                        double S = Int32.Parse(textBox1.Text) * Int32.Parse(textBox1.Text);
                        Circ.Text = C.ToString();
                        Area.Text = S.ToString();
                    }
                    break;
                case 2:
                    if (textBox1 == null || textBox2 == null || textBox3 == null)
                    {
                        MessageBox.Show("Hãy điền giá trị");
                    }
                    else
                    {
                        label6.Show();
                        label8.Show();
                        Circ.Show();
                        Area.Show();
                        double C = Int32.Parse(textBox1.Text) + Int32.Parse(textBox2.Text) + Int32.Parse(textBox3.Text);
                        double S = Math.Sqrt((C / 2) * (C / 2 - Int32.Parse(textBox1.Text)) * (C / 2 - Int32.Parse(textBox2.Text)) * (C / 2 - Int32.Parse(textBox3.Text)));
                        Circ.Text = C.ToString();
                        Area.Text = S.ToString();
                    }
                    break;
                case 3:
                    if (textBox1 == null || textBox2 == null)
                    {
                        MessageBox.Show("Hãy điền giá trị");
                    }
                    else
                    {
                        label6.Show();
                        label8.Show();
                        Circ.Show();
                        Area.Show();
                        double C = (Int32.Parse(textBox1.Text) + Int32.Parse(textBox2.Text)) * 2;
                        double S = Int32.Parse(textBox1.Text) * Int32.Parse(textBox2.Text);
                        Circ.Text = C.ToString();
                        Area.Text = S.ToString();
                    }
                    break;
                case 4:
                    if (textBox1 == null)
                    {
                        MessageBox.Show("Hãy điền giá trị");
                    }
                    else
                    {
                        label6.Show();
                        label8.Show();
                        Circ.Show();
                        Area.Show();
                        double C = Int32.Parse(textBox1.Text) * 2 * Math.PI;
                        double S = Math.Pow(Int32.Parse(textBox1.Text), 2) * Math.PI;
                        Circ.Text = C.ToString();
                        Area.Text = S.ToString();
                    }
                    break;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pick pick = new Pick();
            this.Hide();
            pick.ShowDialog();
        }

        private void Geometry_Load(object sender, EventArgs e)
        {
            Chosen.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            Solve.Hide();
            label6.Hide();
            label8.Hide();
            Circ.Hide(); Area.Hide();
        }
    }
}
