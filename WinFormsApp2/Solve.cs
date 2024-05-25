using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Math_Puzzle_Game
{
    public partial class Solve : Form
    {
        public Solve()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Khi nhấn nút "Giải"
        {
            string equation = (string)this.textBox1.Text; // Khai báo string phương trình là chữ của textbox
            DataTable dt = new DataTable();
            var v = dt.Compute(equation, ""); // Tính bằng DataTable
            label5.Text = v.ToString(); // Giá trị ô kết quả là v sang string
            label5.Show(); // Hiển thị kết quả
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Khi nhấn link quay về
        {
            Pick pick = new Pick(); 
            this.Hide();
            pick.ShowDialog(); // Trở về form Pick
        }
    }
}
