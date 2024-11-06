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
            this.btn00 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btnComputer = new System.Windows.Forms.Button();
            this.btnFriend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn00
            // 
            this.btn00.Location = new System.Drawing.Point(233, 30);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(100, 100);
            this.btn00.TabIndex = 0;
            this.btn00.UseVisualStyleBackColor = true;
            // 
            // btn01
            // 
            this.btn01.Location = new System.Drawing.Point(339, 30);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(100, 100);
            this.btn01.TabIndex = 1;
            this.btn01.UseVisualStyleBackColor = true;
            // 
            // btn02
            // 
            this.btn02.Location = new System.Drawing.Point(445, 30);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(100, 100);
            this.btn02.TabIndex = 2;
            this.btn02.UseVisualStyleBackColor = true;
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(233, 136);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(100, 100);
            this.btn10.TabIndex = 3;
            this.btn10.UseVisualStyleBackColor = true;
            // 
            // btn11
            // 
            this.btn11.Location = new System.Drawing.Point(339, 136);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(100, 100);
            this.btn11.TabIndex = 4;
            this.btn11.UseVisualStyleBackColor = true;
            // 
            // btn12
            // 
            this.btn12.Location = new System.Drawing.Point(445, 136);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(100, 100);
            this.btn12.TabIndex = 5;
            this.btn12.UseVisualStyleBackColor = true;
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(233, 242);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(100, 100);
            this.btn20.TabIndex = 6;
            this.btn20.UseVisualStyleBackColor = true;
            // 
            // btn21
            // 
            this.btn21.Location = new System.Drawing.Point(339, 242);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(100, 100);
            this.btn21.TabIndex = 7;
            this.btn21.UseVisualStyleBackColor = true;
            // 
            // btn22
            // 
            this.btn22.Location = new System.Drawing.Point(445, 242);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(100, 100);
            this.btn22.TabIndex = 8;
            this.btn22.UseVisualStyleBackColor = true;
            this.btn22.Click += new System.EventHandler(this.btn22_Click);
            // 
            // btnComputer
            // 
            this.btnComputer.Location = new System.Drawing.Point(282, 395);
            this.btnComputer.Name = "btnComputer";
            this.btnComputer.Size = new System.Drawing.Size(90, 23);
            this.btnComputer.TabIndex = 9;
            this.btnComputer.Text = "Computer";
            this.btnComputer.UseVisualStyleBackColor = true;
            this.btnComputer.Click += new System.EventHandler(this.btnComputer_Click);
            // 
            // btnFriend
            // 
            this.btnFriend.Location = new System.Drawing.Point(391, 395);
            this.btnFriend.Name = "btnFriend";
            this.btnFriend.Size = new System.Drawing.Size(132, 23);
            this.btnFriend.TabIndex = 10;
            this.btnFriend.Text = "Play with friends";
            this.btnFriend.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFriend);
            this.Controls.Add(this.btnComputer);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.btn00);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btnComputer;
        private System.Windows.Forms.Button btnFriend;
    }
}

