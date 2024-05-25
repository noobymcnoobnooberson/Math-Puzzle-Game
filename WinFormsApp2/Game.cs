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
        int sign; // Khai báo int dấu
        String[] Question = new string[GSettings.nquestions + 1]; // Khai báo string array các câu hỏi
        int QNum = 1; // Khai báo int câu số mấy
        int NQuestion = GSettings.nquestions; // Khai báo số câu bằng giá trị số câu ở form GSettings
        public static String[] ans = new string[GSettings.nquestions + 1]; // String array đáp án đúng
        public static String[] leftover = new string[GSettings.nquestions + 1]; // String array phần dư đúng
        public static String[] user = new String[GSettings.nquestions + 1]; // String array đáp án người dùng
        public static String[] userleftover = new String[GSettings.nquestions + 1]; // String array phần dư người dùng nhập
        Random rnd = new Random(); // Hàm generate biến ngẫu nhiên
        int mins = GSettings.timerduration; // Thời gian lấy từ GSettings
        int secs = 0;
        private void timerupdate() // Cập nhật (giao diện) đếm giờ
        { // Những điều kiện kiểm tra giá trị của mins và secs sao cho hiển thị luôn có ít nhất hai số phần phút và giây
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
        private void calc(int i) // Hàm tính kết quả
        {
            DataTable dt = new DataTable();
            var v = dt.Compute(Question[i], ""); // Tính kết quả bằng DataTable
            ans[i] = ((int)decimal.Parse(v.ToString())).ToString(); // Chuyển v sang string, rồi parse thành decimal, và từ decimal 
                                                                    // ta mới chuyển dạng ra int được, rồi chuyển về thành string
                                                                    // làm thế này để giá trị kết quả luôn nguyên, cho bài toán chia
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Qlabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e) // Hàm khi timer của Form Tick một lần, mỗi Tick là một giây
        {
            if (secs > 0) // Nếu giá trị giây > 0
            {
                secs--; // Trừ dần
            }
            else if (secs == 0) // Nếu = 0
            {
                secs = 59; // Đặt lại thành 59 và và trừ giá trị phút
                mins--;
            }
            else if (mins == 0 && secs == 0) // Nếu hết giờ
            {
                this.Hide();
                Result result = new Result();
                result.ShowDialog();
            }
            timerupdate(); // Cập nhật giao diện đếm giờ
        }

        private void Game_Load(object sender, EventArgs e) // Khi form load
        {
            NQuestion = GSettings.nquestions; // Khai báo những giá trị
            Question = new string[GSettings.nquestions + 1];
            ans = new string[GSettings.nquestions + 1];
            leftover = new string[GSettings.nquestions + 1];
            userleftover = new String[GSettings.nquestions + 1];
            user = new String[GSettings.nquestions + 1];
            mins = GSettings.timerduration;
            label1.Text = "1" + "/" + NQuestion.ToString();
            Timer.Text = mins.ToString() + ":" + secs.ToString();
            if (GSettings.timer == true) // Kiểm tra xem có đếm giờ không
            {
                timer1.Enabled = true;
                Timer.Show();
            }
            else
            {
                timer1.Enabled = false;
                Timer.Hide();
            }
            for (int i = 0; i < GSettings.nquestions; i++) // Khởi tạo các câu hỏi
            {
                if (GSettings.difficulty == 1) // Nếu dễ
                {
                    sign = rnd.Next(1, 3); // Int sign quyết đinh dấu và dạng câu
                                           // 1: +; 2: -; 3: *; 4: /
                    if (sign == 1)
                    {
                        Question[i] = rnd.Next(1, 10).ToString() + "+" + rnd.Next(1, 10).ToString(); // Tạo câu hỏi
                        calc(i); // Tính kết quả và cho vào dãy kết quả tương ứng
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
                if (GSettings.difficulty == 2) // Nếu trung bình
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
                        Question[i] = a.ToString() + "/" + b.ToString(); // Nếu câu dạng chia, sẽ là chia lấy phần nguyên
                        leftover[i] = (a % b).ToString(); // Tính số dư cho vào dãy số dư
                        calc(i);
                        if (i == 0) // Điều kiện hiển thị hộp số dư nếu là câu 1
                        {
                            label3.Show();
                            UserLeft.Show();
                        }
                    }
                }
                if (GSettings.difficulty == 3) // Nếu khó
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
            QLabel.Text = Question[QNum - 1]; // Hiện thị câu hỏi 
            if (NQuestion == 1) // Nếu chỉ có 1 câu
            {
                Next.Hide();
                Back.Hide();
            }
            sign = 0;
        }

        private void Next_Click(object sender, EventArgs e) // Khi ấn nút next
        {
            if (QNum < NQuestion - 1) // Nếu chưa đền câu cuối
            {
                QNum++;
                QLabel.Text = Question[QNum - 1];
                Back.Show();
                Next.Show();
                UserAns.Text = user[QNum - 1];
                UserLeft.Text = userleftover[QNum - 1];
                label4.Text = ans[QNum - 1];
            }
            else if (QNum == NQuestion - 1) // Nếu đến câu cuối
            {
                QNum++;
                QLabel.Text = Question[QNum - 1];
                Back.Show();
                Next.Hide();
                UserAns.Text = user[QNum - 1];
                UserLeft.Text = userleftover[QNum - 1];
                label4.Text = ans[QNum - 1];
            }
            if (leftover[QNum - 1] != null) // Nếu câu có giá trị số dư
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

        private void Finish_Click(object sender, EventArgs e) // Khi ấn nút hoàn thành
        {
            this.Hide();
            Result result = new Result(); // Sang form result
            result.ShowDialog();
        }

        private void Back_Click(object sender, EventArgs e) // Khi ấn nút back
        {
            if (QNum > 2) // Nếu không phải câu thứ 2
            {
                QNum--;
                QLabel.Text = Question[QNum - 1];
                Back.Show();
                Next.Show();
                UserAns.Text = user[QNum - 1];
                UserLeft.Text = userleftover[QNum - 1];
                label4.Text = ans[QNum - 1];
            }
            else if (QNum == 2) // Nếu là câu thứ 2
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

        private void UserAns_TextChanged(object sender, EventArgs e) // Khi textbox đáp án người dùng thay đổi
        {
            user[QNum - 1] = UserAns.Text; // Thay đổi giá trị dãy đáp án người dùng
            label6.Text = UserAns.Text; // Debug
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void UserLeft_TextChanged(object sender, EventArgs e)
        {
            userleftover[QNum - 1] = UserLeft.Text; // Thay đổi giá trị dãy số dư người dùng
            label7.Text = UserLeft.Text; // Debug
        }
    }
}
