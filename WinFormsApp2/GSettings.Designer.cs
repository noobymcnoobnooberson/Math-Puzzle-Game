namespace Math_Puzzle_Game
{
    partial class GSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GSettings));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            Diff = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(41, 88);
            label1.Name = "label1";
            label1.Size = new Size(90, 32);
            label1.TabIndex = 5;
            label1.Text = "Số câu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(41, 202);
            label2.Name = "label2";
            label2.Size = new Size(97, 32);
            label2.TabIndex = 6;
            label2.Text = "Độ khó:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(43, 309);
            label3.Name = "label3";
            label3.Size = new Size(113, 32);
            label3.TabIndex = 7;
            label3.Text = "Tính giờ?";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(137, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(49, 39);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(41, 237);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 9;
            label4.Text = "Đang chọn:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 18F);
            checkBox1.Location = new Point(162, 324);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 10;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 13F);
            linkLabel1.Location = new Point(41, 27);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(121, 30);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "<- Quay lại";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Enabled = false;
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(590, 59);
            button1.Name = "button1";
            button1.Size = new Size(148, 61);
            button1.TabIndex = 12;
            button1.Text = "Bắt đầu";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(153, 196);
            button2.Name = "button2";
            button2.Size = new Size(56, 38);
            button2.TabIndex = 13;
            button2.Text = "Dễ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(234, 196);
            button3.Name = "button3";
            button3.Size = new Size(118, 38);
            button3.TabIndex = 14;
            button3.Text = "Trung bình";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(379, 196);
            button4.Name = "button4";
            button4.Size = new Size(59, 38);
            button4.TabIndex = 15;
            button4.Text = "Khó";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Diff
            // 
            Diff.AutoSize = true;
            Diff.BackColor = Color.Transparent;
            Diff.Font = new Font("Segoe UI", 9F);
            Diff.Location = new Point(131, 237);
            Diff.Name = "Diff";
            Diff.Size = new Size(84, 20);
            Diff.TabIndex = 16;
            Diff.Text = "Đang chọn:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14F);
            textBox2.Location = new Point(230, 309);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(59, 39);
            textBox2.TabIndex = 17;
            textBox2.Visible = false;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(295, 312);
            label5.Name = "label5";
            label5.Size = new Size(63, 32);
            label5.TabIndex = 18;
            label5.Text = "Phút";
            label5.Visible = false;
            // 
            // GSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(Diff);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GSettings";
            Text = "GSettings";
            Load += GSettings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label Diff;
        private TextBox textBox2;
        private Label label5;
    }
}