namespace FlappyBird
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
            this.components = new System.ComponentModel.Container();
            this.Bird = new System.Windows.Forms.PictureBox();
            this.topPipe = new System.Windows.Forms.PictureBox();
            this.bottomPipe = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // Bird
            // 
            this.Bird.BackColor = System.Drawing.Color.Transparent;
            this.Bird.Image = global::FlappyBird.Properties.Resources.bird1;
            this.Bird.Location = new System.Drawing.Point(188, 163);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(80, 60);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bird.TabIndex = 3;
            this.Bird.TabStop = false;
            this.Bird.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // topPipe
            // 
            this.topPipe.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.topPipe.Location = new System.Drawing.Point(727, -14);
            this.topPipe.Name = "topPipe";
            this.topPipe.Size = new System.Drawing.Size(100, 156);
            this.topPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topPipe.TabIndex = 2;
            this.topPipe.TabStop = false;
            // 
            // bottomPipe
            // 
            this.bottomPipe.Image = global::FlappyBird.Properties.Resources.pipe;
            this.bottomPipe.Location = new System.Drawing.Point(652, 278);
            this.bottomPipe.Name = "bottomPipe";
            this.bottomPipe.Size = new System.Drawing.Size(107, 161);
            this.bottomPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bottomPipe.TabIndex = 1;
            this.bottomPipe.TabStop = false;
            this.bottomPipe.Click += new System.EventHandler(this.bottomPipe_Click);
            // 
            // ground
            // 
            this.ground.Image = global::FlappyBird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-27, 436);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1086, 69);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(32, 33);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(91, 23);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1042, 486);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.bottomPipe);
            this.Controls.Add(this.topPipe);
            this.Controls.Add(this.Bird);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox bottomPipe;
        private System.Windows.Forms.PictureBox topPipe;
        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer gameTimer;
    }
}

