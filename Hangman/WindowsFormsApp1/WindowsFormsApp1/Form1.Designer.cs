namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lblGuessPointer = new System.Windows.Forms.Label();
            this.btnCheckGuess = new System.Windows.Forms.Button();
            this.WordLabel = new System.Windows.Forms.Label();
            this.wrongWordLabel = new System.Windows.Forms.Label();
            this.hangmanLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(479, 261);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(100, 22);
            this.txtGuess.TabIndex = 0;
            this.txtGuess.TextChanged += new System.EventHandler(this.txtGuess_TextChanged);
            // 
            // lblGuessPointer
            // 
            this.lblGuessPointer.AutoSize = true;
            this.lblGuessPointer.Location = new System.Drawing.Point(420, 266);
            this.lblGuessPointer.Name = "lblGuessPointer";
            this.lblGuessPointer.Size = new System.Drawing.Size(53, 17);
            this.lblGuessPointer.TabIndex = 1;
            this.lblGuessPointer.Text = "Guess:";
            // 
            // btnCheckGuess
            // 
            this.btnCheckGuess.Location = new System.Drawing.Point(479, 305);
            this.btnCheckGuess.Name = "btnCheckGuess";
            this.btnCheckGuess.Size = new System.Drawing.Size(146, 23);
            this.btnCheckGuess.TabIndex = 2;
            this.btnCheckGuess.Text = "Hangman";
            this.btnCheckGuess.UseVisualStyleBackColor = true;
            this.btnCheckGuess.Click += new System.EventHandler(this.btnCheckGuess_Click);
            // 
            // WordLabel
            // 
            this.WordLabel.Location = new System.Drawing.Point(476, 207);
            this.WordLabel.Name = "WordLabel";
            this.WordLabel.Size = new System.Drawing.Size(168, 25);
            this.WordLabel.TabIndex = 4;
            this.WordLabel.Text = "___________";
            this.WordLabel.Click += new System.EventHandler(this.WordLabel_Click);
            // 
            // wrongWordLabel
            // 
            this.wrongWordLabel.AutoSize = true;
            this.wrongWordLabel.Location = new System.Drawing.Point(116, 371);
            this.wrongWordLabel.Name = "wrongWordLabel";
            this.wrongWordLabel.Size = new System.Drawing.Size(0, 17);
            this.wrongWordLabel.TabIndex = 5;
            this.wrongWordLabel.Click += new System.EventHandler(this.wrongWordLabel_Click);
            // 
            // hangmanLabel
            // 
            this.hangmanLabel.AutoSize = true;
            this.hangmanLabel.Location = new System.Drawing.Point(129, 229);
            this.hangmanLabel.Name = "hangmanLabel";
            this.hangmanLabel.Size = new System.Drawing.Size(0, 17);
            this.hangmanLabel.TabIndex = 6;
            this.hangmanLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hangmanLabel);
            this.Controls.Add(this.wrongWordLabel);
            this.Controls.Add(this.WordLabel);
            this.Controls.Add(this.btnCheckGuess);
            this.Controls.Add(this.lblGuessPointer);
            this.Controls.Add(this.txtGuess);
            this.Name = "Form1";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label lblGuessPointer;
        private System.Windows.Forms.Button btnCheckGuess;
        private System.Windows.Forms.Label WordLabel;
        private System.Windows.Forms.Label wrongWordLabel;
        private System.Windows.Forms.Label hangmanLabel;
    }
}

