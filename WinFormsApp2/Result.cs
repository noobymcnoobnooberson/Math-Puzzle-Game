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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            int NQ = GSettings.nquestions;
            int correct = 0;
            string[] ans = Game.ans;
            string[] user = Game.user;
            string[] leftover = Game.leftover;
            string[] userleftover = Game.userleftover;
            for (int i = 0; i < NQ; i++)
            {
                if (ans[i] == user[i] && leftover[i] == userleftover[i])
                {
                    correct++;
                }
            }
            resultlabel.Text = correct.ToString() + "/" + NQ.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            GSettings gSettings = new GSettings();
            gSettings.ShowDialog();
        }
    }
}
