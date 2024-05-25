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
        public static int nquestions = 0; // Khai báo những giá trị
        public static int difficulty = 0;
        public static bool timer = false;
        public static int timerduration = 0;
        public GSettings()
        {
            InitializeComponent();
        }
        private void buttoncheck() // Hàm kiểm tra độ ẩn của nút bắt đầu
        {
            if (textBox1.Text.All(char.IsDigit) && textBox1.Text != "") //Kiểm tra nếu giá trị của hộp số câu là số
            {
                nquestions = Int32.Parse(textBox1.Text); // Chuyển giá trị của nquestion từ hộp số câu
                if ((difficulty != 0 && timer == false) || (difficulty != 0 && timer == true && textBox2.Text.All(char.IsDigit) && textBox2.Text != ""))
                { // 2 điều kiện để nút hiển thị: Nếu chọn số câu và độ khó mà không chọn tính giờ
                    // Nếu có chọn tính giờ thì giá trị thời gian phải hợp lệ (Là số hết)
                    button1.Show(); // Hiển thị và kích hoạt nút "Bắt đầu"
                    button1.Enabled = true;
                }
                else // Nếu không hợp lệ
                {
                    button1.Hide(); //Ẩn và vô hiệu nút "Bắt đầu"
                    button1.Enabled = false;
                }
            }
            else // Nếu không hợp lệ
            {
                button1.Hide();
                button1.Enabled = false;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e) // Khi chữ hộp số câu thay đổi
        {
            buttoncheck(); // Kiểm tra điều kiện nút
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Khi nhấn nút "Quay lại"
        {
            Pick pick = new Pick(); 
            this.Hide();
            pick.ShowDialog(); // Quay về hàm Pick
        }

        private void button1_Click(object sender, EventArgs e) // Khi ấn nút "Bắt đầu"
        {
            nquestions = Int32.Parse(textBox1.Text);
            Game game = new Game();
            this.Hide();
            game.ShowDialog(); // Mở form Game
        }

        private void button2_Click(object sender, EventArgs e) // Khí ấn nút "Dễ"
        {
            difficulty = 1;
            Diff.Text = "Dễ"; // Đặt độ khó
            buttoncheck();
        }

        private void button3_Click(object sender, EventArgs e) // Khí ấn nút "Trung bình"
        {
            difficulty = 2;
            Diff.Text = "Trung bình"; // Đặt độ khó
            buttoncheck();
        }

        private void button4_Click(object sender, EventArgs e) // Khi ấn nút "Khó"
        {
            difficulty = 3;
            Diff.Text = "Khó"; // Đặt độ khó
            buttoncheck();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) // Khi trạng thái hộp tick thay đổi
        {
            if (checkBox1.Checked == true) // Nếu được tích
            {
                textBox2.Show(); // Hiển thị textBox timer
                label5.Show();
                timer = true; // Đặt trạng thái đếm giờ là true
            }
            if (checkBox1.Checked == false) // Nếu không được tích
            {
                textBox2.Hide(); // Giấu textBox timer
                label5.Hide();
                timer = false; // Đặt trạng thái đếm giờ là false
            }
            buttoncheck(); // Kiểm tra trạng thái nút
        }

        private void textBox2_TextChanged(object sender, EventArgs e) // Nếu hộp số phút thay đổi
        {
            if (textBox2.Text.All(char.IsDigit)) // Kiểm tra có phải số không
            {
                if (textBox2.Text != "") // Kiểm tra có phải rỗng không
                {
                    timerduration = Int32.Parse(textBox2.Text); // Đặt timerduration là giá trị int của textBox
                }
            }
            buttoncheck(); // Kiểm tra nút
        }

        private void GSettings_Load(object sender, EventArgs e) // Khi form load
        {
            textBox2.Hide(); // Chỉnh giao diện và các giá trị ban đầu
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
