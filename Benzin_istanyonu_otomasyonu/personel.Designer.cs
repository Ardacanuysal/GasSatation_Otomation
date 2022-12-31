namespace Benzin_istanyonu_otomasyonu
{
    partial class personel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personel));
            this.UserGroupbox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Tc = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmb_Position = new System.Windows.Forms.ComboBox();
            this.txt_Maas = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.mskd_TelefonNumarasi = new System.Windows.Forms.MaskedTextBox();
            this.mskd_DogumTarihi = new System.Windows.Forms.MaskedTextBox();
            this.txt_AdSoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Home = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_SearchTc = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.UserGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserGroupbox
            // 
            this.UserGroupbox.Controls.Add(this.label8);
            this.UserGroupbox.Controls.Add(this.txt_Tc);
            this.UserGroupbox.Controls.Add(this.pictureBox1);
            this.UserGroupbox.Controls.Add(this.cmb_Position);
            this.UserGroupbox.Controls.Add(this.txt_Maas);
            this.UserGroupbox.Controls.Add(this.txt_Email);
            this.UserGroupbox.Controls.Add(this.mskd_TelefonNumarasi);
            this.UserGroupbox.Controls.Add(this.mskd_DogumTarihi);
            this.UserGroupbox.Controls.Add(this.txt_AdSoyad);
            this.UserGroupbox.Controls.Add(this.label6);
            this.UserGroupbox.Controls.Add(this.label5);
            this.UserGroupbox.Controls.Add(this.label4);
            this.UserGroupbox.Controls.Add(this.label3);
            this.UserGroupbox.Controls.Add(this.label2);
            this.UserGroupbox.Controls.Add(this.label1);
            this.UserGroupbox.Font = new System.Drawing.Font("Verdana", 9.25F);
            this.UserGroupbox.ForeColor = System.Drawing.Color.White;
            this.UserGroupbox.Location = new System.Drawing.Point(25, 33);
            this.UserGroupbox.Name = "UserGroupbox";
            this.UserGroupbox.Size = new System.Drawing.Size(658, 289);
            this.UserGroupbox.TabIndex = 0;
            this.UserGroupbox.TabStop = false;
            this.UserGroupbox.Text = "Personel Bilgileri";
            this.UserGroupbox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(145, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "TC :";
            // 
            // txt_Tc
            // 
            this.txt_Tc.Location = new System.Drawing.Point(188, 43);
            this.txt_Tc.Mask = "00000000000";
            this.txt_Tc.Name = "txt_Tc";
            this.txt_Tc.Size = new System.Drawing.Size(121, 22);
            this.txt_Tc.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Benzin_istanyonu_otomasyonu.Properties.Resources.administrator_icon;
            this.pictureBox1.Location = new System.Drawing.Point(359, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 252);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // cmb_Position
            // 
            this.cmb_Position.FormattingEnabled = true;
            this.cmb_Position.Items.AddRange(new object[] {
            "Müdür",
            "Müdür Yardımcısı",
            "Teknisyen",
            "Pompacı",
            "Temizlikçi",
            "Yıkamacı",
            "Marketçi",
            "Güvenlikçi"});
            this.cmb_Position.Location = new System.Drawing.Point(188, 181);
            this.cmb_Position.Name = "cmb_Position";
            this.cmb_Position.Size = new System.Drawing.Size(121, 22);
            this.cmb_Position.TabIndex = 11;
            // 
            // txt_Maas
            // 
            this.txt_Maas.Location = new System.Drawing.Point(188, 211);
            this.txt_Maas.Name = "txt_Maas";
            this.txt_Maas.Size = new System.Drawing.Size(121, 22);
            this.txt_Maas.TabIndex = 10;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(188, 153);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(121, 22);
            this.txt_Email.TabIndex = 9;
            // 
            // mskd_TelefonNumarasi
            // 
            this.mskd_TelefonNumarasi.Location = new System.Drawing.Point(188, 125);
            this.mskd_TelefonNumarasi.Mask = "(999) 0000000";
            this.mskd_TelefonNumarasi.Name = "mskd_TelefonNumarasi";
            this.mskd_TelefonNumarasi.Size = new System.Drawing.Size(121, 22);
            this.mskd_TelefonNumarasi.TabIndex = 8;
            // 
            // mskd_DogumTarihi
            // 
            this.mskd_DogumTarihi.Location = new System.Drawing.Point(188, 97);
            this.mskd_DogumTarihi.Mask = "00/00/0000";
            this.mskd_DogumTarihi.Name = "mskd_DogumTarihi";
            this.mskd_DogumTarihi.Size = new System.Drawing.Size(121, 22);
            this.mskd_DogumTarihi.TabIndex = 7;
            this.mskd_DogumTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // txt_AdSoyad
            // 
            this.txt_AdSoyad.Location = new System.Drawing.Point(188, 69);
            this.txt_AdSoyad.Name = "txt_AdSoyad";
            this.txt_AdSoyad.Size = new System.Drawing.Size(121, 22);
            this.txt_AdSoyad.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(129, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Maaş :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(111, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pozisyon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(130, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon Numarası :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doğum Tarihi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Soyadı :";
            // 
            // Btn_Home
            // 
            this.Btn_Home.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Home.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Home.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Home.Image = global::Benzin_istanyonu_otomasyonu.Properties.Resources.home_icon;
            this.Btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Home.Location = new System.Drawing.Point(689, 42);
            this.Btn_Home.Name = "Btn_Home";
            this.Btn_Home.Size = new System.Drawing.Size(62, 65);
            this.Btn_Home.TabIndex = 4;
            this.Btn_Home.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Home.UseVisualStyleBackColor = false;
            this.Btn_Home.Click += new System.EventHandler(this.Btn_Home_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Update.ForeColor = System.Drawing.Color.White;
            this.Btn_Update.Image = global::Benzin_istanyonu_otomasyonu.Properties.Resources.update1;
            this.Btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Update.Location = new System.Drawing.Point(689, 257);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(62, 65);
            this.Btn_Update.TabIndex = 3;
            this.Btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Delete.ForeColor = System.Drawing.Color.White;
            this.Btn_Delete.Image = global::Benzin_istanyonu_otomasyonu.Properties.Resources.delete_icon;
            this.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Delete.Location = new System.Drawing.Point(689, 186);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(62, 65);
            this.Btn_Delete.TabIndex = 2;
            this.Btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Add.ForeColor = System.Drawing.Color.White;
            this.Btn_Add.Image = global::Benzin_istanyonu_otomasyonu.Properties.Resources.add_icon;
            this.Btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Add.Location = new System.Drawing.Point(689, 115);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(62, 65);
            this.Btn_Add.TabIndex = 1;
            this.Btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Navy;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 357);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(728, 204);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(25, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(309, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Silme ve Güncelleme İşlemi İçin Alttan Veriyi Seçiniz";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(493, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "TC :";
            // 
            // txt_SearchTc
            // 
            this.txt_SearchTc.Location = new System.Drawing.Point(531, 329);
            this.txt_SearchTc.Name = "txt_SearchTc";
            this.txt_SearchTc.Size = new System.Drawing.Size(121, 21);
            this.txt_SearchTc.TabIndex = 16;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Location = new System.Drawing.Point(659, 328);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(94, 23);
            this.Btn_Search.TabIndex = 17;
            this.Btn_Search.Text = "Ara";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(773, 578);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.txt_SearchTc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Home);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.UserGroupbox);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "personel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel İşlemleri";
            this.Load += new System.EventHandler(this.personel_Load);
            this.UserGroupbox.ResumeLayout(false);
            this.UserGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox UserGroupbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmb_Position;
        private System.Windows.Forms.TextBox txt_Maas;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.MaskedTextBox mskd_TelefonNumarasi;
        private System.Windows.Forms.MaskedTextBox mskd_DogumTarihi;
        private System.Windows.Forms.TextBox txt_AdSoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Home;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txt_Tc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_SearchTc;
        private System.Windows.Forms.Button Btn_Search;
    }
}