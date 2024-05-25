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

        private void Result_Load(object sender, EventArgs e) // Khi load form
        {
            int NQ = GSettings.nquestions; // Khai báo
            int correct = 0;
            string[] ans = Game.ans;
            string[] user = Game.user;
            string[] leftover = Game.leftover;
            string[] userleftover = Game.userleftover;
            for (int i = 0; i < NQ; i++) // Kiểm tra đáp án người dùng
            {
                if (ans[i] == user[i] && leftover[i] == userleftover[i]) // Nếu đáp án người dùng bằng đáp án bài
                {
                    correct++; // Tăng số câu đúng
                }
            }
            resultlabel.Text = correct.ToString() + "/" + NQ.ToString(); // Hiển thị số câu đúng
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Linklabel quay lại
        {
            this.Hide();
            GSettings gSettings = new GSettings(); 
            gSettings.ShowDialog(); // Quay về GSettings
        }
    }
}
