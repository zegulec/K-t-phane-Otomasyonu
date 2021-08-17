namespace kütüphane_otomasyonu
{
    partial class Form1
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
            this.lbteslimedildi = new System.Windows.Forms.ListBox();
            this.lbedilmedi = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Al = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kitapadi = new System.Windows.Forms.Label();
            this.verilis = new System.Windows.Forms.Label();
            this.teslim = new System.Windows.Forms.DateTimePicker();
            this.kitapkodu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbteslimedildi
            // 
            this.lbteslimedildi.FormattingEnabled = true;
            this.lbteslimedildi.ItemHeight = 16;
            this.lbteslimedildi.Location = new System.Drawing.Point(12, 49);
            this.lbteslimedildi.Name = "lbteslimedildi";
            this.lbteslimedildi.Size = new System.Drawing.Size(221, 484);
            this.lbteslimedildi.TabIndex = 0;
            // 
            // lbedilmedi
            // 
            this.lbedilmedi.FormattingEnabled = true;
            this.lbedilmedi.ItemHeight = 16;
            this.lbedilmedi.Location = new System.Drawing.Point(620, 49);
            this.lbedilmedi.Name = "lbedilmedi";
            this.lbedilmedi.Size = new System.Drawing.Size(236, 484);
            this.lbedilmedi.TabIndex = 1;
            this.lbedilmedi.SelectedIndexChanged += new System.EventHandler(this.lbedilmedi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Teslim Edildi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(626, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Teslim Edilmedi";
            // 
            // Al
            // 
            this.Al.Location = new System.Drawing.Point(360, 274);
            this.Al.Name = "Al";
            this.Al.Size = new System.Drawing.Size(84, 39);
            this.Al.TabIndex = 4;
            this.Al.Text = "Teslim Al";
            this.Al.UseVisualStyleBackColor = true;
            this.Al.Click += new System.EventHandler(this.Al_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kitap Kodu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kitap Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(273, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Veriliş Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(271, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Teslim Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 9;
            // 
            // kitapadi
            // 
            this.kitapadi.AutoSize = true;
            this.kitapadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitapadi.Location = new System.Drawing.Point(357, 134);
            this.kitapadi.Name = "kitapadi";
            this.kitapadi.Size = new System.Drawing.Size(14, 17);
            this.kitapadi.TabIndex = 10;
            this.kitapadi.Text = "-";
            // 
            // verilis
            // 
            this.verilis.AutoSize = true;
            this.verilis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verilis.Location = new System.Drawing.Point(392, 176);
            this.verilis.Name = "verilis";
            this.verilis.Size = new System.Drawing.Size(14, 17);
            this.verilis.TabIndex = 11;
            this.verilis.Text = "-";
            // 
            // teslim
            // 
            this.teslim.Location = new System.Drawing.Point(387, 221);
            this.teslim.Name = "teslim";
            this.teslim.Size = new System.Drawing.Size(200, 22);
            this.teslim.TabIndex = 12;
            // 
            // kitapkodu
            // 
            this.kitapkodu.AutoSize = true;
            this.kitapkodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitapkodu.Location = new System.Drawing.Point(384, 87);
            this.kitapkodu.Name = "kitapkodu";
            this.kitapkodu.Size = new System.Drawing.Size(14, 17);
            this.kitapkodu.TabIndex = 13;
            this.kitapkodu.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 560);
            this.Controls.Add(this.kitapkodu);
            this.Controls.Add(this.teslim);
            this.Controls.Add(this.verilis);
            this.Controls.Add(this.kitapadi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Al);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbedilmedi);
            this.Controls.Add(this.lbteslimedildi);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbteslimedildi;
        private System.Windows.Forms.ListBox lbedilmedi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Al;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label kitapadi;
        private System.Windows.Forms.Label verilis;
        private System.Windows.Forms.DateTimePicker teslim;
        private System.Windows.Forms.Label kitapkodu;
    }
}