namespace Math_Puzzle_Game
{
    partial class Geometry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Geometry));
            Square = new Button();
            Triangle = new Button();
            Rectangle = new Button();
            Circle = new Button();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            Chosen = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Solve = new Button();
            label6 = new Label();
            Circ = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label8 = new Label();
            Area = new Label();
            SuspendLayout();
            // 
            // Square
            // 
            Square.BackColor = Color.White;
            Square.Font = new Font("Segoe UI", 13F);
            Square.Location = new Point(75, 51);
            Square.Name = "Square";
            Square.Size = new Size(108, 40);
            Square.TabIndex = 0;
            Square.Text = "Vuông";
            Square.UseVisualStyleBackColor = false;
            Square.Click += Square_Click;
            // 
            // Triangle
            // 
            Triangle.BackColor = Color.White;
            Triangle.Font = new Font("Segoe UI", 13F);
            Triangle.Location = new Point(246, 51);
            Triangle.Name = "Triangle";
            Triangle.Size = new Size(131, 40);
            Triangle.TabIndex = 1;
            Triangle.Text = "Tam Giác";
            Triangle.UseVisualStyleBackColor = false;
            Triangle.Click += Triangle_Click;
            // 
            // Rectangle
            // 
            Rectangle.BackColor = Color.White;
            Rectangle.Font = new Font("Segoe UI", 13F);
            Rectangle.Location = new Point(440, 51);
            Rectangle.Name = "Rectangle";
            Rectangle.Size = new Size(113, 40);
            Rectangle.TabIndex = 2;
            Rectangle.Text = "Chữ Nhật";
            Rectangle.UseVisualStyleBackColor = false;
            Rectangle.Click += Rectangle_Click;
            // 
            // Circle
            // 
            Circle.BackColor = Color.White;
            Circle.Font = new Font("Segoe UI", 13F);
            Circle.Location = new Point(614, 51);
            Circle.Name = "Circle";
            Circle.Size = new Size(108, 40);
            Circle.TabIndex = 3;
            Circle.Text = "Tròn";
            Circle.UseVisualStyleBackColor = false;
            Circle.Click += Circle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(75, 118);
            label1.Name = "label1";
            label1.Size = new Size(143, 32);
            label1.TabIndex = 4;
            label1.Text = "Đang chọn: ";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 13F);
            linkLabel1.Location = new Point(40, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(121, 30);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "<- Quay lại";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Chosen
            // 
            Chosen.AutoSize = true;
            Chosen.BackColor = Color.Transparent;
            Chosen.Font = new Font("Segoe UI", 14F);
            Chosen.Location = new Point(209, 118);
            Chosen.Name = "Chosen";
            Chosen.Size = new Size(94, 32);
            Chosen.TabIndex = 9;
            Chosen.Text = "Chosen";
            Chosen.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(75, 192);
            label3.Name = "label3";
            label3.Size = new Size(71, 30);
            label3.TabIndex = 10;
            label3.Text = "label3";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(75, 246);
            label4.Name = "label4";
            label4.Size = new Size(71, 30);
            label4.TabIndex = 11;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(75, 303);
            label5.Name = "label5";
            label5.Size = new Size(71, 30);
            label5.TabIndex = 12;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // Solve
            // 
            Solve.BackColor = Color.White;
            Solve.Font = new Font("Segoe UI", 13F);
            Solve.Location = new Point(163, 350);
            Solve.Name = "Solve";
            Solve.Size = new Size(108, 40);
            Solve.TabIndex = 13;
            Solve.Text = "Giải";
            Solve.UseVisualStyleBackColor = false;
            Solve.Visible = false;
            Solve.Click += Solve_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 13F);
            label6.Location = new Point(482, 190);
            label6.Name = "label6";
            label6.Size = new Size(49, 30);
            label6.TabIndex = 15;
            label6.Text = "D =";
            label6.Visible = false;
            // 
            // Circ
            // 
            Circ.AutoSize = true;
            Circ.BackColor = Color.White;
            Circ.Font = new Font("Segoe UI", 13F);
            Circ.Location = new Point(537, 190);
            Circ.Name = "Circ";
            Circ.Size = new Size(71, 30);
            Circ.TabIndex = 16;
            Circ.Text = "label7";
            Circ.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(225, 192);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 27);
            textBox1.TabIndex = 17;
            textBox1.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(225, 248);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 27);
            textBox2.TabIndex = 18;
            textBox2.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(225, 303);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(236, 27);
            textBox3.TabIndex = 19;
            textBox3.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 13F);
            label8.Location = new Point(485, 246);
            label8.Name = "label8";
            label8.Size = new Size(46, 30);
            label8.TabIndex = 20;
            label8.Text = "S =";
            label8.Visible = false;
            // 
            // Area
            // 
            Area.AutoSize = true;
            Area.BackColor = Color.White;
            Area.Font = new Font("Segoe UI", 13F);
            Area.Location = new Point(537, 246);
            Area.Name = "Area";
            Area.Size = new Size(71, 30);
            Area.TabIndex = 21;
            Area.Text = "label9";
            Area.Visible = false;
            // 
            // Geometry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(Area);
            Controls.Add(label8);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Circ);
            Controls.Add(label6);
            Controls.Add(Solve);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Chosen);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(Circle);
            Controls.Add(Rectangle);
            Controls.Add(Triangle);
            Controls.Add(Square);
            Name = "Geometry";
            Text = "Geometry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Square;
        private Button Triangle;
        private Button Rectangle;
        private Button Circle;
        private Label label1;
        private LinkLabel linkLabel1;
        private Label Chosen;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Solve;
        private Label label6;
        private Label Circ;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label8;
        private Label Area;
    }
}