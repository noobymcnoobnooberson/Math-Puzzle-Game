using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Math_Puzzle_Game
{
    public partial class Game : Form
    {

        public Game()
        {
            InitializeComponent();
        }
        int sign;
        String[] Question = new string[GSettings.nquestions + 1];
        int QNum = 1;
        int NQuestion = GSettings.nquestions;
        public static String[] ans = new string[GSettings.nquestions + 1];
        public static String[] leftover = new string[GSettings.nquestions + 1];
        public static String[] user = new String[GSettings.nquestions + 1];
        Random rnd = new Random();
        int mins = GSettings.timerduration;
        int secs = 0;
        public static String[] userleftover = new String[GSettings.nquestions + 1];
        private void timerupdate()
        {
            if (mins > 9 && secs > 9)
            {
                Timer.Text = mins.ToString() + ":" + secs.ToString();
            }
            if (mins < 10 && secs > 9)
            {
                Timer.Text = "0" + mins.ToString() + ":" + secs.ToString();
            }
            if (secs < 10 && mins > 9)
            {
                Timer.Text = mins.ToString() + ":" + "0" + secs.ToString();
            }
            if (secs < 10 && mins < 10)
            {
                Timer.Text = "0" + mins.ToString() + ":" + "0" + secs.ToString();
            }
        }
        private void calc(int i)
        {
            DataTable dt = new DataTable();
            var v = dt.Compute(Question[i], "");
            ans[i] = ((int)decimal.Parse(v.ToString())).ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Qlabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (secs > 0)
            {
                secs--;
            }
            else if (secs == 0)
            {
                secs = 59;
                mins--;
            }
            else if (mins == 0 && secs == 0)
            {
                this.Hide();
            }
            timerupdate();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            NQuestion = GSettings.nquestions;
            Question = new string[GSettings.nquestions + 1];
            ans = new string[GSettings.nquestions + 1];
            leftover = new string[GSettings.nquestions + 1];
            userleftover = new String[GSettings.nquestions + 1];
            user = new String[GSettings.nquestions + 1];
            mins = GSettings.timerduration;
            label1.Text = "1" + "/" + NQuestion.ToString();
            Timer.Text = mins.ToString() + ":" + secs.ToString();
            if (GSettings.timer == true)
            {
                timer1.Enabled = true;
                Timer.Show();
            }
            else
            {
                timer1.Enabled = false;
                Timer.Hide();
            }
            for (int i = 0; i < GSettings.nquestions; i++)
            {
                if (GSettings.difficulty == 1)
                {
                    sign = rnd.Next(1, 3);
                    if (sign == 1)
                    {
                        Question[i] = rnd.Next(1, 10).ToString() + "+" + rnd.Next(1, 10).ToString();
                        calc(i);
                    }
                    if (sign == 2)
                    {
                        int a = rnd.Next(1, 10);
                        int b = rnd.Next(1, 10);
                        while (a < b)
                        {
                            a = rnd.Next(1, 10);
                            b = rnd.Next(1, 10);
                        }
                        Question[i] = a.ToString() + "-" + b.ToString();
                        calc(i);
                    }
                }
                if (GSettings.difficulty == 2)
                {
                    sign = rnd.Next(1, 5);
                    if (sign == 1)
                    {
                        Question[i] = rnd.Next(1, 100).ToString() + "+" + rnd.Next(1, 100).ToString();
                        calc(i);
                    }
                    if (sign == 2)
                    {
                        int a = rnd.Next(1, 100);
                        int b = rnd.Next(1, 100);
                        while (a < b)
                        {
                            a = rnd.Next(1, 100);
                            b = rnd.Next(1, 100);
                        }
                        Question[i] = a.ToString() + "-" + b.ToString();
                        calc(i);
                    }
                    if (sign == 3)
                    {
                        Question[i] = rnd.Next(1, 10).ToString() + "*" + rnd.Next(1, 10).ToString();
                        calc(i);
                    }
                    if (sign == 4)
                    {
                        int a = rnd.Next(1, 100);
                        int b = rnd.Next(1, 10);
                        Question[i] = a.ToString() + "/" + b.ToString();
                        leftover[i] = (a % b).ToString();
                        calc(i);
                        if (i == 0)
                        {
                            label3.Show();
                            UserLeft.Show();
                        }
                    }
                }
                if (GSettings.difficulty == 3)
                {
                    sign = rnd.Next(1, 5);
                    if (sign == 1)
                    {
                        Question[i] = rnd.Next(1, 1000).ToString() + "+" + rnd.Next(1, 1000).ToString();
                        calc(i);
                    }
                    if (sign == 2)
                    {
                        int a = rnd.Next(1, 1000);
                        int b = rnd.Next(1, 1000);
                        while (a < b)
                        {
                            a = rnd.Next(1, 1000);
                            b = rnd.Next(1, 1000);
                        }
                        Question[i] = a.ToString() + "-" + b.ToString();
                        calc(i);
                    }
                    if (sign == 3)
                    {
                        Question[i] = rnd.Next(1, 100).ToString() + "*" + rnd.Next(1, 100).ToString();
                        calc(i);
                    }
                    if (sign == 4)
                    {
                        int a = rnd.Next(1, 1000);
                        int b = rnd.Next(1, 100);
                        Question[i] = a.ToString() + "/" + b.ToString();
                        leftover[i] = (a % b).ToString();
                        calc(i);
                        if (i == 0)
                        {
                            label3.Show();
                            UserLeft.Show();
                        }
                    }
                }
            }
            QLabel.Text = Question[QNum - 1];
            if (NQuestion == 1)
            {
                Next.Hide();
                Back.Hide();
            }
            sign = 0;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (QNum < NQuestion - 1)
            {
                QNum++;
                QLabel.Text = Question[QNum - 1];
                Back.Show();
                Next.Show();
                UserAns.Text = user[QNum - 1];
                UserLeft.Text = userleftover[QNum - 1];
                label4.Text = ans[QNum - 1];
            }
            else if (QNum == NQuestion - 1)
            {
                QNum++;
                QLabel.Text = Question[QNum - 1];
                Back.Show();
                Next.Hide();
                UserAns.Text = user[QNum - 1];
                UserLeft.Text = userleftover[QNum - 1];
                label4.Text = ans[QNum - 1];
            }
            if (leftover[QNum - 1] != null)
            {
                label3.Show();
                UserLeft.Show();
            }
            else
            {
                label3.Hide();
                UserLeft.Hide();
            }
            label1.Text = QNum.ToString() + "/" + NQuestion.ToString();
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            this.Hide();
            Result result = new Result();
            result.ShowDialog();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (QNum > 2)
            {
                QNum--;
                QLabel.Text = Question[QNum - 1];
                Back.Show();
                Next.Show();
                UserAns.Text = user[QNum - 1];
                UserLeft.Text = userleftover[QNum - 1];
                label4.Text = ans[QNum - 1];
            }
            else if (QNum == 2)
            {
                QNum--;
                QLabel.Text = Question[QNum - 1];
                Back.Hide();
                Next.Show();
                UserAns.Text = user[QNum - 1];
                UserLeft.Text = userleftover[QNum - 1];
                label4.Text = ans[QNum - 1];
            }
            if (leftover[QNum - 1] != null)
            {
                label3.Show();
                UserLeft.Show();
            }
            else
            {
                label3.Hide();
                UserLeft.Hide();
            }
            label1.Text = QNum.ToString() + "/" + NQuestion.ToString();
        }

        private void UserAns_TextChanged(object sender, EventArgs e)
        {
            user[QNum - 1] = UserAns.Text;
            label6.Text = UserAns.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void UserLeft_TextChanged(object sender, EventArgs e)
        {
            userleftover[QNum - 1] = UserLeft.Text;
            label7.Text = UserLeft.Text;
        }
    }
}
