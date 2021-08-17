namespace kütüphane_otomasyonu
{
    partial class kitap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitap));
            this.ogrenciislemleri = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rapor = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbkitapara = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbtur = new System.Windows.Forms.ComboBox();
            this.tbsayi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbkitapkodu = new System.Windows.Forms.TextBox();
            this.iptal = new System.Windows.Forms.Button();
            this.oduncver = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.kaydet = new System.Windows.Forms.Button();
            this.duzelt = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.yenikayit = new System.Windows.Forms.Button();
            this.dtpbasimtarihi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbbasimevi = new System.Windows.Forms.TextBox();
            this.tbbasimyeri = new System.Windows.Forms.TextBox();
            this.tbyazar = new System.Windows.Forms.TextBox();
            this.tbkitapadi = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ogrenciislemleri
            // 
            this.ogrenciislemleri.AutoSize = true;
            this.ogrenciislemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogrenciislemleri.ForeColor = System.Drawing.Color.DarkCyan;
            this.ogrenciislemleri.Location = new System.Drawing.Point(301, 504);
            this.ogrenciislemleri.Name = "ogrenciislemleri";
            this.ogrenciislemleri.Size = new System.Drawing.Size(172, 24);
            this.ogrenciislemleri.TabIndex = 4;
            this.ogrenciislemleri.Text = "Öğrenci İşlemleri....";
            this.ogrenciislemleri.Click += new System.EventHandler(this.ogrenciislemleri_Click);
            this.ogrenciislemleri.MouseEnter += new System.EventHandler(this.ogrenciislemleri_MouseEnter);
            this.ogrenciislemleri.MouseLeave += new System.EventHandler(this.ogrenciislemleri_MouseLeave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rapor);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.tbkitapara);
            this.groupBox2.Location = new System.Drawing.Point(479, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 546);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arama";
            // 
            // rapor
            // 
            this.rapor.Location = new System.Drawing.Point(518, 466);
            this.rapor.Name = "rapor";
            this.rapor.Size = new System.Drawing.Size(124, 29);
            this.rapor.TabIndex = 6;
            this.rapor.Text = "Raporla";
            this.rapor.UseVisualStyleBackColor = true;
            this.rapor.Click += new System.EventHandler(this.rapor_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(558, 56);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Tümünü Gör";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(653, 376);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ara:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(631, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tbkitapara
            // 
            this.tbkitapara.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbkitapara.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbkitapara.Location = new System.Drawing.Point(366, 21);
            this.tbkitapara.Name = "tbkitapara";
            this.tbkitapara.Size = new System.Drawing.Size(259, 22);
            this.tbkitapara.TabIndex = 0;
            this.tbkitapara.Text = "Kitap kodu,adı,yazarı...";
            this.tbkitapara.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbkitapara_MouseClick);
            this.tbkitapara.TextChanged += new System.EventHandler(this.tbkitapara_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbtur);
            this.groupBox1.Controls.Add(this.tbsayi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbkitapkodu);
            this.groupBox1.Controls.Add(this.iptal);
            this.groupBox1.Controls.Add(this.oduncver);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.kaydet);
            this.groupBox1.Controls.Add(this.duzelt);
            this.groupBox1.Controls.Add(this.sil);
            this.groupBox1.Controls.Add(this.yenikayit);
            this.groupBox1.Controls.Add(this.dtpbasimtarihi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbbasimevi);
            this.groupBox1.Controls.Add(this.tbbasimyeri);
            this.groupBox1.Controls.Add(this.tbyazar);
            this.groupBox1.Controls.Add(this.tbkitapadi);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 489);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Kitap Türü:";
            // 
            // cbtur
            // 
            this.cbtur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtur.FormattingEnabled = true;
            this.cbtur.Items.AddRange(new object[] {
            "Arkeoloji",
            "Bİlim",
            "Biyografi",
            "Deneme",
            "Felsefe",
            "Hukuk",
            "İktisat",
            "Mitoloji",
            "Öykü",
            "Roman",
            "Şiir",
            "Sosyal Bilimler",
            "Tarih",
            "Teknoloji"});
            this.cbtur.Location = new System.Drawing.Point(140, 284);
            this.cbtur.Name = "cbtur";
            this.cbtur.Size = new System.Drawing.Size(312, 24);
            this.cbtur.Sorted = true;
            this.cbtur.TabIndex = 28;
            // 
            // tbsayi
            // 
            this.tbsayi.Location = new System.Drawing.Point(140, 322);
            this.tbsayi.Name = "tbsayi";
            this.tbsayi.Size = new System.Drawing.Size(312, 22);
            this.tbsayi.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Kitap Kodu:";
            // 
            // tbkitapkodu
            // 
            this.tbkitapkodu.Location = new System.Drawing.Point(140, 46);
            this.tbkitapkodu.Name = "tbkitapkodu";
            this.tbkitapkodu.ReadOnly = true;
            this.tbkitapkodu.Size = new System.Drawing.Size(312, 22);
            this.tbkitapkodu.TabIndex = 24;
            // 
            // iptal
            // 
            this.iptal.Enabled = false;
            this.iptal.Location = new System.Drawing.Point(6, 425);
            this.iptal.Name = "iptal";
            this.iptal.Size = new System.Drawing.Size(272, 34);
            this.iptal.TabIndex = 23;
            this.iptal.Text = "İptal";
            this.iptal.UseVisualStyleBackColor = true;
            this.iptal.Click += new System.EventHandler(this.iptal_Click);
            // 
            // oduncver
            // 
            this.oduncver.ForeColor = System.Drawing.Color.Maroon;
            this.oduncver.Location = new System.Drawing.Point(319, 421);
            this.oduncver.Name = "oduncver";
            this.oduncver.Size = new System.Drawing.Size(133, 38);
            this.oduncver.TabIndex = 1;
            this.oduncver.Text = "Ödünç Ver";
            this.oduncver.UseVisualStyleBackColor = true;
            this.oduncver.Click += new System.EventHandler(this.oduncver_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Kitap Adeti:";
            // 
            // kaydet
            // 
            this.kaydet.Enabled = false;
            this.kaydet.Location = new System.Drawing.Point(319, 379);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(133, 36);
            this.kaydet.TabIndex = 20;
            this.kaydet.Text = "Kaydet";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // duzelt
            // 
            this.duzelt.Enabled = false;
            this.duzelt.Location = new System.Drawing.Point(200, 383);
            this.duzelt.Name = "duzelt";
            this.duzelt.Size = new System.Drawing.Size(78, 36);
            this.duzelt.TabIndex = 17;
            this.duzelt.Text = "Düzelt";
            this.duzelt.UseVisualStyleBackColor = true;
            this.duzelt.Click += new System.EventHandler(this.duzelt_Click);
            // 
            // sil
            // 
            this.sil.Enabled = false;
            this.sil.Location = new System.Drawing.Point(106, 383);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(79, 36);
            this.sil.TabIndex = 16;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // yenikayit
            // 
            this.yenikayit.Location = new System.Drawing.Point(6, 383);
            this.yenikayit.Name = "yenikayit";
            this.yenikayit.Size = new System.Drawing.Size(94, 36);
            this.yenikayit.TabIndex = 15;
            this.yenikayit.Text = "Yeni Kayıt";
            this.yenikayit.UseVisualStyleBackColor = true;
            this.yenikayit.Click += new System.EventHandler(this.yenikayit_Click);
            // 
            // dtpbasimtarihi
            // 
            this.dtpbasimtarihi.Location = new System.Drawing.Point(140, 241);
            this.dtpbasimtarihi.Name = "dtpbasimtarihi";
            this.dtpbasimtarihi.Size = new System.Drawing.Size(312, 22);
            this.dtpbasimtarihi.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Basım Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Basım Yeri:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Basım Evi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Yazarı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kitap Adı:";
            // 
            // tbbasimevi
            // 
            this.tbbasimevi.Location = new System.Drawing.Point(140, 158);
            this.tbbasimevi.Name = "tbbasimevi";
            this.tbbasimevi.Size = new System.Drawing.Size(312, 22);
            this.tbbasimevi.TabIndex = 4;
            // 
            // tbbasimyeri
            // 
            this.tbbasimyeri.Location = new System.Drawing.Point(140, 195);
            this.tbbasimyeri.Name = "tbbasimyeri";
            this.tbbasimyeri.Size = new System.Drawing.Size(312, 22);
            this.tbbasimyeri.TabIndex = 6;
            // 
            // tbyazar
            // 
            this.tbyazar.Location = new System.Drawing.Point(140, 120);
            this.tbyazar.Name = "tbyazar";
            this.tbyazar.Size = new System.Drawing.Size(312, 22);
            this.tbyazar.TabIndex = 7;
            // 
            // tbkitapadi
            // 
            this.tbkitapadi.Location = new System.Drawing.Point(140, 80);
            this.tbkitapadi.Name = "tbkitapadi";
            this.tbkitapadi.Size = new System.Drawing.Size(312, 22);
            this.tbkitapadi.TabIndex = 0;
            // 
            // kitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 560);
            this.Controls.Add(this.ogrenciislemleri);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "kitap";
            this.Text = "islemler";
            this.Load += new System.EventHandler(this.kitap_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ogrenciislemleri;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbkitapara;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbkitapkodu;
        private System.Windows.Forms.Button iptal;
        private System.Windows.Forms.Button oduncver;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.Button duzelt;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button yenikayit;
        private System.Windows.Forms.DateTimePicker dtpbasimtarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbbasimevi;
        private System.Windows.Forms.TextBox tbbasimyeri;
        private System.Windows.Forms.TextBox tbyazar;
        private System.Windows.Forms.TextBox tbkitapadi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbsayi;
        private System.Windows.Forms.ComboBox cbtur;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button rapor;
    }
}