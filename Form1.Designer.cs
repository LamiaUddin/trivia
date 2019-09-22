namespace ComputerScienceTrivia
{
    partial class frmHomePage
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnHowTo = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPlay.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(60, 268);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(167, 70);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play Game";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnHowTo
            // 
            this.btnHowTo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHowTo.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHowTo.Location = new System.Drawing.Point(342, 268);
            this.btnHowTo.Name = "btnHowTo";
            this.btnHowTo.Size = new System.Drawing.Size(167, 70);
            this.btnHowTo.TabIndex = 1;
            this.btnHowTo.Text = "How to Play";
            this.btnHowTo.UseVisualStyleBackColor = false;
            this.btnHowTo.Click += new System.EventHandler(this.btnHowTo_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblWelcome.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(108, 59);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(381, 167);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome to Computer Science Trivia!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictBackground
            // 
            this.pictBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictBackground.Image = global::ComputerScienceTrivia.Properties.Resources.lamia_cpt;
            this.pictBackground.Location = new System.Drawing.Point(0, 0);
            this.pictBackground.Name = "pictBackground";
            this.pictBackground.Size = new System.Drawing.Size(598, 416);
            this.pictBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBackground.TabIndex = 3;
            this.pictBackground.TabStop = false;
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 416);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnHowTo);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pictBackground);
            this.Name = "frmHomePage";
            this.Text = "Computer Science Trivia";
            this.Load += new System.EventHandler(this.frmHomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnHowTo;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictBackground;
    }
}

