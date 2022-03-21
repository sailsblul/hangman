namespace hangman
{
    partial class frmCustom
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
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblEnter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtWord
            // 
            this.txtWord.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtWord.Location = new System.Drawing.Point(12, 54);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(100, 20);
            this.txtWord.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(121, 52);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Location = new System.Drawing.Point(12, 22);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(121, 13);
            this.lblEnter.TabIndex = 2;
            this.lblEnter.Text = "Enter your custom word:";
            // 
            // frmCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 86);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtWord);
            this.Name = "frmCustom";
            this.Text = "Input Word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblEnter;
    }
}