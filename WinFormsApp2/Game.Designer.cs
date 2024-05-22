namespace Math_Puzzle_Game
{
    partial class Game
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            label1 = new Label();
            label2 = new Label();
            Timer = new Label();
            QLabel = new Label();
            label5 = new Label();
            UserAns = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            Next = new Button();
            Back = new Button();
            Finish = new Button();
            label3 = new Label();
            UserLeft = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(175, 9);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(67, 28);
            label1.TabIndex = 0;
            label1.Text = "12345";
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(235, 9);
            label2.Name = "label2";
            label2.Size = new Size(0, 28);
            label2.TabIndex = 1;
            // 
            // Timer
            // 
            Timer.AutoSize = true;
            Timer.BackColor = Color.Transparent;
            Timer.Font = new Font("Segoe UI", 12F);
            Timer.ImageAlign = ContentAlignment.MiddleLeft;
            Timer.Location = new Point(500, 9);
            Timer.Name = "Timer";
            Timer.RightToLeft = RightToLeft.No;
            Timer.Size = new Size(67, 28);
            Timer.TabIndex = 2;
            Timer.Text = "12345";
            Timer.TextAlign = ContentAlignment.MiddleRight;
            // 
            // QLabel
            // 
            QLabel.AutoSize = true;
            QLabel.BackColor = Color.Transparent;
            QLabel.Font = new Font("Segoe UI", 24F);
            QLabel.Location = new Point(219, 205);
            QLabel.Name = "QLabel";
            QLabel.RightToLeft = RightToLeft.No;
            QLabel.Size = new Size(133, 54);
            QLabel.TabIndex = 3;
            QLabel.Text = "12345";
            QLabel.TextAlign = ContentAlignment.MiddleCenter;
            QLabel.Click += Qlabel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 24F);
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(557, 205);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(50, 54);
            label5.TabIndex = 4;
            label5.Text = "=";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // UserAns
            // 
            UserAns.Font = new Font("Segoe UI", 24F);
            UserAns.Location = new Point(613, 205);
            UserAns.Name = "UserAns";
            UserAns.Size = new Size(175, 61);
            UserAns.TabIndex = 5;
            UserAns.TextChanged += UserAns_TextChanged;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Next
            // 
            Next.BackColor = Color.White;
            Next.Font = new Font("Segoe UI", 13F);
            Next.Location = new Point(334, 302);
            Next.Name = "Next";
            Next.Size = new Size(140, 43);
            Next.TabIndex = 6;
            Next.Text = "Tiếp";
            Next.UseVisualStyleBackColor = false;
            Next.Click += Next_Click;
            // 
            // Back
            // 
            Back.BackColor = Color.White;
            Back.Font = new Font("Segoe UI", 13F);
            Back.Location = new Point(95, 302);
            Back.Name = "Back";
            Back.Size = new Size(140, 43);
            Back.TabIndex = 7;
            Back.Text = "Trước";
            Back.UseVisualStyleBackColor = false;
            Back.Visible = false;
            Back.Click += Back_Click;
            // 
            // Finish
            // 
            Finish.BackColor = Color.White;
            Finish.Font = new Font("Segoe UI", 13F);
            Finish.Location = new Point(629, 31);
            Finish.Name = "Finish";
            Finish.Size = new Size(140, 43);
            Finish.TabIndex = 8;
            Finish.Text = "Hoàn thành";
            Finish.UseVisualStyleBackColor = false;
            Finish.Click += Finish_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 24F);
            label3.Location = new Point(532, 321);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(75, 54);
            label3.TabIndex = 9;
            label3.Text = "Dư";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Visible = false;
            // 
            // UserLeft
            // 
            UserLeft.Font = new Font("Segoe UI", 24F);
            UserLeft.Location = new Point(613, 321);
            UserLeft.Name = "UserLeft";
            UserLeft.Size = new Size(175, 61);
            UserLeft.TabIndex = 10;
            UserLeft.Visible = false;
            UserLeft.TextChanged += UserLeft_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 24F);
            label4.Location = new Point(26, 50);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(133, 54);
            label4.TabIndex = 11;
            label4.Text = "12345";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 24F);
            label6.Location = new Point(219, 64);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(133, 54);
            label6.TabIndex = 12;
            label6.Text = "12345";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 24F);
            label7.Location = new Point(386, 64);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(133, 54);
            label7.TabIndex = 13;
            label7.Text = "12345";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(UserLeft);
            Controls.Add(label3);
            Controls.Add(Finish);
            Controls.Add(Back);
            Controls.Add(Next);
            Controls.Add(UserAns);
            Controls.Add(label5);
            Controls.Add(QLabel);
            Controls.Add(Timer);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Game";
            Text = "Game";
            Load += Game_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label Timer;
        private Label QLabel;
        private Label label5;
        private TextBox UserAns;
        private System.Windows.Forms.Timer timer1;
        private Button Next;
        private Button Back;
        private Button Finish;
        private Label label3;
        private TextBox UserLeft;
        private Label label4;
        private Label label6;
        private Label label7;
    }
}