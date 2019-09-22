namespace ComputerScienceTrivia
{
    partial class frmHowToPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHowToPage));
            this.lblInstructions = new System.Windows.Forms.Label();
            this.pictTriviaGif = new System.Windows.Forms.PictureBox();
            this.lblListOfInstructions = new System.Windows.Forms.Label();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictTriviaGif)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(90, 24);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(168, 43);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Instructions:";
            // 
            // pictTriviaGif
            // 
            this.pictTriviaGif.Image = global::ComputerScienceTrivia.Properties.Resources.lamia_cpt2;
            this.pictTriviaGif.Location = new System.Drawing.Point(4, 80);
            this.pictTriviaGif.Name = "pictTriviaGif";
            this.pictTriviaGif.Size = new System.Drawing.Size(255, 211);
            this.pictTriviaGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictTriviaGif.TabIndex = 1;
            this.pictTriviaGif.TabStop = false;
            // 
            // lblListOfInstructions
            // 
            this.lblListOfInstructions.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfInstructions.Location = new System.Drawing.Point(264, 54);
            this.lblListOfInstructions.Name = "lblListOfInstructions";
            this.lblListOfInstructions.Size = new System.Drawing.Size(479, 426);
            this.lblListOfInstructions.TabIndex = 2;
            this.lblListOfInstructions.Text = resources.GetString("lblListOfInstructions.Text");
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblGreeting.Location = new System.Drawing.Point(24, 402);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(696, 35);
            this.lblGreeting.TabIndex = 3;
            this.lblGreeting.Text = "Have Fun Playing Computer Science Trivia!";
            this.lblGreeting.Click += new System.EventHandler(this.lblGreeting_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightGray;
            this.btnBack.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 445);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 35);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmHowToPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(748, 489);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.lblListOfInstructions);
            this.Controls.Add(this.pictTriviaGif);
            this.Controls.Add(this.lblInstructions);
            this.Name = "frmHowToPage";
            this.Text = "Game Instructions";
            ((System.ComponentModel.ISupportInitialize)(this.pictTriviaGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.PictureBox pictTriviaGif;
        private System.Windows.Forms.Label lblListOfInstructions;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Button btnBack;
    }
}