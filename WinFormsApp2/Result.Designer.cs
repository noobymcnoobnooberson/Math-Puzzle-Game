namespace Math_Puzzle_Game
{
    partial class Result
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
            resultlabel = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // resultlabel
            // 
            resultlabel.AutoSize = true;
            resultlabel.Font = new Font("Segoe UI", 18F);
            resultlabel.Location = new Point(326, 188);
            resultlabel.Name = "resultlabel";
            resultlabel.Size = new Size(97, 41);
            resultlabel.TabIndex = 0;
            resultlabel.Text = "label1";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 13F);
            linkLabel1.Location = new Point(46, 39);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(121, 30);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "<- Quay lại";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Result
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(resultlabel);
            Name = "Result";
            Text = "Result";
            Load += Result_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label resultlabel;
        private LinkLabel linkLabel1;
    }
}