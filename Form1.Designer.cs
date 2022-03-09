namespace hangman
{
    partial class Hangman
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
            this.imgHang = new System.Windows.Forms.PictureBox();
            this.lstGuessed = new System.Windows.Forms.ListBox();
            this.lblWord = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lblGuessed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgHang)).BeginInit();
            this.SuspendLayout();
            // 
            // imgHang
            // 
            this.imgHang.Location = new System.Drawing.Point(12, 12);
            this.imgHang.Name = "imgHang";
            this.imgHang.Size = new System.Drawing.Size(151, 173);
            this.imgHang.TabIndex = 0;
            this.imgHang.TabStop = false;
            // 
            // lstGuessed
            // 
            this.lstGuessed.FormattingEnabled = true;
            this.lstGuessed.Location = new System.Drawing.Point(169, 38);
            this.lstGuessed.Name = "lstGuessed";
            this.lstGuessed.Size = new System.Drawing.Size(120, 121);
            this.lstGuessed.TabIndex = 1;
            // 
            // lblWord
            // 
            this.lblWord.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.ForeColor = System.Drawing.Color.DarkGray;
            this.lblWord.Location = new System.Drawing.Point(7, 219);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(278, 36);
            this.lblWord.TabIndex = 2;
            this.lblWord.Text = "_ _ _ _";
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(216, 166);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(73, 20);
            this.btnGuess.TabIndex = 3;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(169, 166);
            this.txtGuess.MaxLength = 1;
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(41, 20);
            this.txtGuess.TabIndex = 4;
            // 
            // lblGuessed
            // 
            this.lblGuessed.AutoSize = true;
            this.lblGuessed.Location = new System.Drawing.Point(187, 12);
            this.lblGuessed.Name = "lblGuessed";
            this.lblGuessed.Size = new System.Drawing.Size(87, 13);
            this.lblGuessed.TabIndex = 5;
            this.lblGuessed.Text = "Letters Guessed:";
            // 
            // Hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(297, 279);
            this.Controls.Add(this.lblGuessed);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lstGuessed);
            this.Controls.Add(this.imgHang);
            this.Name = "Hangman";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Hangman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgHang;
        private System.Windows.Forms.ListBox lstGuessed;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label lblGuessed;
    }
}

