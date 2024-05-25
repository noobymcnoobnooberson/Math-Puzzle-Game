using Math_Puzzle_Game;

namespace WinFormsApp2
{
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }
        String[] usernames = new string[10]; // Khai báo
        String[] passwords = new string[10];
        int count = 0; // khai báo số lượng người dùng đăng kí
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Kiểm tra thông tin đăng nhập khi nhấn nút "Đăng nhập"
        {
            bool validuser = false;
            if (usernames != null)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (textBox1.Text == usernames[i]) // Nếu tên và mật khẩu trùng với cặp tên và mật khẩu trong danh sách 
                    {
                        if (textBox2.Text == passwords[i])
                        {
                            validuser = true; // Đặt giá trị người dùng hợp lệ là true
                            Pick form2 = new Pick(); // Mở form Pick và ẩn form này
                            this.Hide();
                            form2.ShowDialog();
                            break;
                        }
                    }
                }
            }

            if (validuser == false) // Nếu người dùng không hợp lệ
            {
                MessageBox.Show("Sai thông tin"); // Tạo hộp thoại
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Nhấn vào linklabel "Đăng kí"
        {
            button1.Hide(); // Điều chỉnh giao diện
            linkLabel1.Hide();
            label3.Show();
            textBox3.Show();
            button2.Show();
            linkLabel2.Show();
        }

        private void button2_Click(object sender, EventArgs e) // Nhấn vào nút "Đăng kí"
        {
            if (textBox2.Text == textBox3.Text && count < 10) // Nếu mật khẩu hợp lệ và còn chỗ trong danh sách
            {
                usernames[count] = textBox1.Text;
                passwords[count] = textBox2.Text;
                MessageBox.Show("Đăng kí thành công");
                count++;
            }
            else if (count == 10) // Nếu danh sách hết chỗ, chèn lại người dùng đầu tiên
            {
                count = 0;
                usernames[count] = textBox1.Text;
                passwords[count] = textBox2.Text;
                MessageBox.Show("Đăng kí thành công");
                count++;
            }
            else // Nếu mật khẩu không đúng
            {
                MessageBox.Show("Sai thông tin");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Nhấn linklabel "Đăng nhập"
        {
            button1.Show(); // Thay đổi giao diện
            linkLabel1.Show();
            label3.Hide();
            textBox3.Hide();
            button2.Hide();
            linkLabel2.Hide();
        }
    }
}
