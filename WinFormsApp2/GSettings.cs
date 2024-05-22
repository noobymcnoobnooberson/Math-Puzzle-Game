using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Math_Puzzle_Game
{
    public partial class GSettings : Form
    {
        public static int nquestions = 0;
        public static int difficulty = 0;
        public static bool timer = false;
        public static int timerduration = 0;
        public GSettings()
        {
            InitializeComponent();
        }
        private void buttoncheck()
        {
            if (textBox1.Text.All(char.IsDigit))
            {
                nquestions = Int32.Parse(textBox1.Text);
                if ((difficulty != 0 && timer == false) || (difficulty != 0 && timer == true && textBox2.Text.All(char.IsDigit) && textBox2.Text != ""))
                {
                    button1.Show();
                    button1.Enabled = true;
                }
                else
                {
                    button1.Hide();
                    button1.Enabled = false;
                }
            }
            else
            {
                button1.Hide();
                button1.Enabled = false;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.All(char.IsDigit) && textBox1.Text != "")
            {
                nquestions = Int32.Parse(textBox1.Text);
                if ((difficulty != 0 && timer == false) || (difficulty != 0 && timer == true && textBox2.Text.All(char.IsDigit)))
                {
                    button1.Show();
                }
                else
                {
                    button1.Hide();
                }
            }
            else
            {
                button1.Hide();
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pick pick = new Pick();
            this.Hide();
            pick.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nquestions = Int32.Parse(textBox1.Text);
            Game game = new Game();
            this.Hide();
            game.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            difficulty = 1;
            Diff.Text = "Dễ";
            buttoncheck();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            difficulty = 2;
            Diff.Text = "Trung bình";
            buttoncheck();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            difficulty = 3;
            Diff.Text = "Khó";
            buttoncheck();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.Show();
                label5.Show();
                timer = true;
            }
            if (checkBox1.Checked == false)
            {
                textBox2.Hide();
                label5.Hide();
                timer = false;
            }
            buttoncheck();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.All(char.IsDigit))
            {
                if (textBox2.Text != "")
                {
                    timerduration = Int32.Parse(textBox2.Text);
                }
            }
            buttoncheck();
        }

        private void GSettings_Load(object sender, EventArgs e)
        {
            textBox2.Hide();
            label5.Hide();
            button1.Hide();
            checkBox1.Checked = false;
            Diff.Text = "";
            difficulty = 0;
            timer = false;
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
