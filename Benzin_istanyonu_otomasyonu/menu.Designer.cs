namespace Benzin_istanyonu_otomasyonu
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.Btn_Personel = new System.Windows.Forms.Button();
            this.btn_Musteri = new System.Windows.Forms.Button();
            this.Btn_Satis = new System.Windows.Forms.Button();
            this.Btn_Akaryakit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Personel
            // 
            this.Btn_Personel.BackColor = System.Drawing.Color.DarkRed;
            this.Btn_Personel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Personel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Personel.ForeColor = System.Drawing.Color.White;
            this.Btn_Personel.Image = global::Benzin_istanyonu_otomasyonu.Properties.Resources.Groups_Meeting_Light_icon;
            this.Btn_Personel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Personel.Location = new System.Drawing.Point(265, 254);
            this.Btn_Personel.Name = "Btn_Personel";
            this.Btn_Personel.Size = new System.Drawing.Size(209, 65);
            this.Btn_Personel.TabIndex = 3;
            this.Btn_Personel.Text = "Personel İşlemleri";
            this.Btn_Personel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Personel.UseVisualStyleBackColor = false;
            this.Btn_Personel.Click += new System.EventHandler(this.Btn_Personel_Click);
            // 
            // btn_Musteri
            // 
            this.btn_Musteri.BackColor = System.Drawing.Color.Orange;
            this.btn_Musteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Musteri.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Musteri.ForeColor = System.Drawing.Color.White;
            this.btn_Musteri.Image = global::Benzin_istanyonu_otomasyonu.Properties.Resources.car;
            this.btn_Musteri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Musteri.Location = new System.Drawing.Point(12, 325);
            this.btn_Musteri.Name = "btn_Musteri";
            this.btn_Musteri.Size = new System.Drawing.Size(217, 65);
            this.btn_Musteri.TabIndex = 2;
            this.btn_Musteri.Text = "Müşteri İşlemleri";
            this.btn_Musteri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Musteri.UseVisualStyleBackColor = false;
            this.btn_Musteri.Click += new System.EventHandler(this.btn_Musteri_Click);
            // 
            // Btn_Satis
            // 
            this.Btn_Satis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Btn_Satis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Satis.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Satis.ForeColor = System.Drawing.Color.White;
            this.Btn_Satis.Image = global::Benzin_istanyonu_otomasyonu.Properties.Resources.gas;
            this.Btn_Satis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Satis.Location = new System.Drawing.Point(12, 254);
            this.Btn_Satis.Name = "Btn_Satis";
            this.Btn_Satis.Size = new System.Drawing.Size(217, 65);
            this.Btn_Satis.TabIndex = 1;
            this.Btn_Satis.Text = "Satış İşlemleri";
            this.Btn_Satis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Satis.UseVisualStyleBackColor = false;
            this.Btn_Satis.Click += new System.EventHandler(this.Btn_Satis_Click);
            // 
            // Btn_Akaryakit
            // 
            this.Btn_Akaryakit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.Btn_Akaryakit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Akaryakit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Akaryakit.ForeColor = System.Drawing.Color.White;
            this.Btn_Akaryakit.Image = global::Benzin_istanyonu_otomasyonu.Properties.Resources.Oil_Delivery_icon;
            this.Btn_Akaryakit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Akaryakit.Location = new System.Drawing.Point(265, 325);
            this.Btn_Akaryakit.Name = "Btn_Akaryakit";
            this.Btn_Akaryakit.Size = new System.Drawing.Size(209, 65);
            this.Btn_Akaryakit.TabIndex = 0;
            this.Btn_Akaryakit.Text = "Akaryakıt İşlemleri";
            this.Btn_Akaryakit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Akaryakit.UseVisualStyleBackColor = false;
            this.Btn_Akaryakit.Click += new System.EventHandler(this.Btn_Akaryakit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(121, -78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(486, 392);
            this.Controls.Add(this.Btn_Personel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Musteri);
            this.Controls.Add(this.Btn_Satis);
            this.Controls.Add(this.Btn_Akaryakit);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Akaryakit;
        private System.Windows.Forms.Button Btn_Satis;
        private System.Windows.Forms.Button btn_Musteri;
        private System.Windows.Forms.Button Btn_Personel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}