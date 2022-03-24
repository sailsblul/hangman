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
            this.lstGuessed = new System.Windows.Forms.ListBox();
            this.lblWord = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lblGuessed = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.imgHang = new System.Windows.Forms.PictureBox();
            this.grpAgain = new System.Windows.Forms.GroupBox();
            this.btnCustom = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgHang)).BeginInit();
            this.grpAgain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstGuessed
            // 
            this.lstGuessed.FormattingEnabled = true;
            this.lstGuessed.Location = new System.Drawing.Point(169, 39);
            this.lstGuessed.Name = "lstGuessed";
            this.lstGuessed.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstGuessed.Size = new System.Drawing.Size(120, 121);
            this.lstGuessed.TabIndex = 1;
            // 
            // lblWord
            // 
            this.lblWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.ForeColor = System.Drawing.Color.DarkGray;
            this.lblWord.Location = new System.Drawing.Point(100, 231);
            this.lblWord.Margin = new System.Windows.Forms.Padding(0);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(92, 30);
            this.lblWord.TabIndex = 2;
            this.lblWord.Text = "_ _ _ _";
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWord.SizeChanged += new System.EventHandler(this.lblWord_SizeChanged);
            // 
            // btnGuess
            // 
            this.btnGuess.Enabled = false;
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
            this.txtGuess.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGuess.Location = new System.Drawing.Point(169, 166);
            this.txtGuess.MaxLength = 1;
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(41, 20);
            this.txtGuess.TabIndex = 4;
            this.txtGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGuess.TextChanged += new System.EventHandler(this.txtGuess_TextChanged);
            // 
            // lblGuessed
            // 
            this.lblGuessed.AutoSize = true;
            this.lblGuessed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGuessed.Location = new System.Drawing.Point(187, 12);
            this.lblGuessed.Name = "lblGuessed";
            this.lblGuessed.Size = new System.Drawing.Size(87, 13);
            this.lblGuessed.TabIndex = 5;
            this.lblGuessed.Text = "Letters Guessed:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEnd.Location = new System.Drawing.Point(12, 189);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(53, 17);
            this.lblEnd.TabIndex = 6;
            this.lblEnd.Text = "label1";
            this.lblEnd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imgHang
            // 
            this.imgHang.Image = global::hangman.Properties.Resources.hang;
            this.imgHang.Location = new System.Drawing.Point(12, 13);
            this.imgHang.Name = "imgHang";
            this.imgHang.Size = new System.Drawing.Size(151, 173);
            this.imgHang.TabIndex = 0;
            this.imgHang.TabStop = false;
            // 
            // grpAgain
            // 
            this.grpAgain.Controls.Add(this.btnCustom);
            this.grpAgain.Controls.Add(this.btnRandom);
            this.grpAgain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpAgain.Location = new System.Drawing.Point(12, 264);
            this.grpAgain.Name = "grpAgain";
            this.grpAgain.Size = new System.Drawing.Size(272, 46);
            this.grpAgain.TabIndex = 7;
            this.grpAgain.TabStop = false;
            this.grpAgain.Text = "Play again?";
            this.grpAgain.Visible = false;
            // 
            // btnCustom
            // 
            this.btnCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.btnCustom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCustom.Location = new System.Drawing.Point(139, 15);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(127, 25);
            this.btnCustom.TabIndex = 1;
            this.btnCustom.Text = "Custom word";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.btnRandom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRandom.Location = new System.Drawing.Point(6, 15);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(128, 25);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "Random word";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(169, 189);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 23);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove this word";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Visible = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(297, 313);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.grpAgain);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblGuessed);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lstGuessed);
            this.Controls.Add(this.imgHang);
            this.Name = "Hangman";
            this.Text = "Hangman";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Hangman_FormClosed);
            this.Load += new System.EventHandler(this.Hangman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgHang)).EndInit();
            this.grpAgain.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.GroupBox grpAgain;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnRemove;
    }
}

