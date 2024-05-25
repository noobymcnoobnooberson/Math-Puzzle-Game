namespace WinFormsApp2
{
    partial class Signin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signin));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            button2 = new Button();
            linkLabel2 = new LinkLabel();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(256, 172);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(256, 239);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(274, 309);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Đăng Nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(459, 313);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(62, 20);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Đăng Kí";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F);
            label1.Location = new Point(127, 172);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 4;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F);
            label2.Location = new Point(164, 242);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 5;
            label2.Text = "Mật khẩu";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(256, 306);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 6;
            textBox3.Visible = false;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F);
            label3.Location = new Point(100, 309);
            label3.Name = "label3";
            label3.Size = new Size(150, 20);
            label3.TabIndex = 7;
            label3.Text = "Xác nhận mật khẩu";
            label3.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(274, 366);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Đăng Kí";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(459, 313);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(85, 20);
            linkLabel2.TabIndex = 9;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Đăng Nhập";
            linkLabel2.Visible = false;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(211, 100);
            label4.Name = "label4";
            label4.Size = new Size(212, 35);
            label4.TabIndex = 10;
            label4.Text = "phanmemgiaitoan";
            // 
            // Signin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(640, 461);
            Controls.Add(label4);
            Controls.Add(linkLabel2);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Signin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Button button2;
        private LinkLabel linkLabel2;
        private Label label4;
    }
}
