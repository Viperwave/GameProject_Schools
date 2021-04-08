namespace BrainGames
{
    partial class fmPart3
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
            this.btnFourth = new System.Windows.Forms.Button();
            this.btnThird = new System.Windows.Forms.Button();
            this.btnSecond = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFourth
            // 
            this.btnFourth.Location = new System.Drawing.Point(427, 369);
            this.btnFourth.Name = "btnFourth";
            this.btnFourth.Size = new System.Drawing.Size(285, 45);
            this.btnFourth.TabIndex = 8;
            this.btnFourth.Tag = "4";
            this.btnFourth.Text = "button4";
            this.btnFourth.UseVisualStyleBackColor = true;
            this.btnFourth.Click += new System.EventHandler(this.checkAnwerEvent);
            // 
            // btnThird
            // 
            this.btnThird.Location = new System.Drawing.Point(88, 369);
            this.btnThird.Name = "btnThird";
            this.btnThird.Size = new System.Drawing.Size(285, 45);
            this.btnThird.TabIndex = 7;
            this.btnThird.Tag = "3";
            this.btnThird.Text = "button3";
            this.btnThird.UseVisualStyleBackColor = true;
            this.btnThird.Click += new System.EventHandler(this.checkAnwerEvent);
            // 
            // btnSecond
            // 
            this.btnSecond.Location = new System.Drawing.Point(427, 294);
            this.btnSecond.Name = "btnSecond";
            this.btnSecond.Size = new System.Drawing.Size(285, 45);
            this.btnSecond.TabIndex = 6;
            this.btnSecond.Tag = "2";
            this.btnSecond.Text = "button2";
            this.btnSecond.UseVisualStyleBackColor = true;
            this.btnSecond.Click += new System.EventHandler(this.checkAnwerEvent);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(88, 294);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(285, 45);
            this.btnFirst.TabIndex = 5;
            this.btnFirst.Tag = "1";
            this.btnFirst.Text = "button1";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.checkAnwerEvent);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("MiedingerMediumW00-Regular", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblQuestion.Location = new System.Drawing.Point(85, 262);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(96, 15);
            this.lblQuestion.TabIndex = 10;
            this.lblQuestion.Text = "QUESTION";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox1.BackgroundImage = global::BrainGames.Properties.Resources.wallhaven_73zg19;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(88, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(624, 231);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // fmPart3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFourth);
            this.Controls.Add(this.btnThird);
            this.Controls.Add(this.btnSecond);
            this.Controls.Add(this.btnFirst);
            this.Name = "fmPart3";
            this.Text = "SecondPart";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFourth;
        private System.Windows.Forms.Button btnThird;
        private System.Windows.Forms.Button btnSecond;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label lblQuestion;
    }
}