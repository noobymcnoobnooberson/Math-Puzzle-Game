using Math_Puzzle_Game;

namespace WinFormsApp2
{
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }
        String[] usernames = new string[10];
        String[] passwords = new string[10];
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool validuser = false;
            if (usernames != null)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (textBox1.Text == usernames[i])
                    {
                        if (textBox2.Text == passwords[i])
                        {
                            validuser = true;
                            Pick form2 = new Pick();
                            this.Hide();
                            form2.ShowDialog();
                            break;
                        }
                    }
                }
            }

            if (validuser == false)
            {
                MessageBox.Show("Sai thông tin");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            button1.Hide();
            linkLabel1.Hide();
            label3.Show();
            textBox3.Show();
            button2.Show();
            linkLabel2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (textBox2.Text == textBox3.Text && count < 10)
            {
                usernames[count] = textBox1.Text;
                passwords[count] = textBox2.Text;
                MessageBox.Show("Đăng kí thành công");
            }
            else
            {
                MessageBox.Show("Sai thông tin");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            button1.Show();
            linkLabel1.Show();
            label3.Hide();
            textBox3.Hide();
            button2.Hide();
            linkLabel2.Hide();
        }
    }
}
