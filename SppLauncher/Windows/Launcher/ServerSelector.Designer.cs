namespace SppLauncher.Windows.Launcher
{
    partial class ServerSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerSelector));
            this.ClassicBtn = new System.Windows.Forms.Button();
            this.TbcBtn = new System.Windows.Forms.Button();
            this.WotlkBtn = new System.Windows.Forms.Button();
            this.ClassicImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClassicImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassicBtn
            // 
            this.ClassicBtn.BackColor = System.Drawing.Color.Transparent;
            this.ClassicBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClassicBtn.Font = new System.Drawing.Font("LifeCraft", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassicBtn.ForeColor = System.Drawing.Color.Black;
            this.ClassicBtn.Location = new System.Drawing.Point(95, 359);
            this.ClassicBtn.Name = "ClassicBtn";
            this.ClassicBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ClassicBtn.Size = new System.Drawing.Size(112, 27);
            this.ClassicBtn.TabIndex = 0;
            this.ClassicBtn.Text = "Classic";
            this.ClassicBtn.UseVisualStyleBackColor = false;
            this.ClassicBtn.Click += new System.EventHandler(this.ClassicBtn_Click);
            // 
            // TbcBtn
            // 
            this.TbcBtn.BackColor = System.Drawing.Color.Transparent;
            this.TbcBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TbcBtn.Font = new System.Drawing.Font("LifeCraft", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbcBtn.ForeColor = System.Drawing.Color.Black;
            this.TbcBtn.Location = new System.Drawing.Point(331, 359);
            this.TbcBtn.Name = "TbcBtn";
            this.TbcBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TbcBtn.Size = new System.Drawing.Size(112, 27);
            this.TbcBtn.TabIndex = 1;
            this.TbcBtn.Text = "TBC";
            this.TbcBtn.UseVisualStyleBackColor = false;
            this.TbcBtn.Click += new System.EventHandler(this.TbcBtn_Click);
            // 
            // WotlkBtn
            // 
            this.WotlkBtn.Font = new System.Drawing.Font("LifeCraft", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WotlkBtn.Location = new System.Drawing.Point(563, 359);
            this.WotlkBtn.Name = "WotlkBtn";
            this.WotlkBtn.Size = new System.Drawing.Size(112, 27);
            this.WotlkBtn.TabIndex = 2;
            this.WotlkBtn.Text = "WoTLK";
            this.WotlkBtn.UseVisualStyleBackColor = true;
            this.WotlkBtn.Click += new System.EventHandler(this.WotlkBtn_Click);
            // 
            // ClassicImage
            // 
            this.ClassicImage.BackColor = System.Drawing.Color.Transparent;
            this.ClassicImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClassicImage.Image = ((System.Drawing.Image)(resources.GetObject("ClassicImage.Image")));
            this.ClassicImage.Location = new System.Drawing.Point(69, 222);
            this.ClassicImage.Name = "ClassicImage";
            this.ClassicImage.Size = new System.Drawing.Size(157, 131);
            this.ClassicImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClassicImage.TabIndex = 3;
            this.ClassicImage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(309, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(539, 211);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 142);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LifeCraft", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(264, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Your Server";
            // 
            // ServerSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::SppLauncher.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(758, 432);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ClassicImage);
            this.Controls.Add(this.WotlkBtn);
            this.Controls.Add(this.TbcBtn);
            this.Controls.Add(this.ClassicBtn);
            this.Name = "ServerSelector";
            this.Text = "ServerSelector";
            ((System.ComponentModel.ISupportInitialize)(this.ClassicImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClassicBtn;
        private System.Windows.Forms.Button TbcBtn;
        private System.Windows.Forms.Button WotlkBtn;
        private System.Windows.Forms.PictureBox ClassicImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}