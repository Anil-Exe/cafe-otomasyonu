namespace CafeOtomasyon
{
    partial class RezervasyonGuncelleForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtMasaID = new System.Windows.Forms.TextBox();
            this.txtKisiSayisi = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.dtpRezervasyonTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblMusteriAdi = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblMasaID = new System.Windows.Forms.Label();
            this.lblKisiSayisi = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(120, 17);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(200, 22);
            this.txtID.TabIndex = 0;
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Location = new System.Drawing.Point(120, 49);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(200, 22);
            this.txtMusteriAdi.TabIndex = 1;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(120, 81);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(200, 22);
            this.txtTelefon.TabIndex = 2;
            // 
            // txtMasaID
            // 
            this.txtMasaID.Location = new System.Drawing.Point(120, 113);
            this.txtMasaID.Name = "txtMasaID";
            this.txtMasaID.Size = new System.Drawing.Size(200, 22);
            this.txtMasaID.TabIndex = 3;
            this.txtMasaID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMasaID_KeyPress);
            // 
            // txtKisiSayisi
            // 
            this.txtKisiSayisi.Location = new System.Drawing.Point(120, 145);
            this.txtKisiSayisi.Name = "txtKisiSayisi";
            this.txtKisiSayisi.Size = new System.Drawing.Size(200, 22);
            this.txtKisiSayisi.TabIndex = 4;
            this.txtKisiSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKisiSayisi_KeyPress);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(120, 241);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(200, 22);
            this.txtAciklama.TabIndex = 7;
            // 
            // cmbDurum
            // 
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Location = new System.Drawing.Point(120, 209);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(200, 24);
            this.cmbDurum.TabIndex = 6;
            // 
            // dtpRezervasyonTarihi
            // 
            this.dtpRezervasyonTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRezervasyonTarihi.Location = new System.Drawing.Point(120, 177);
            this.dtpRezervasyonTarihi.Name = "dtpRezervasyonTarihi";
            this.dtpRezervasyonTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpRezervasyonTarihi.TabIndex = 5;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(120, 285);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(90, 30);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(230, 285);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(90, 30);
            this.btnVazgec.TabIndex = 9;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(20, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblMusteriAdi
            // 
            this.lblMusteriAdi.AutoSize = true;
            this.lblMusteriAdi.Location = new System.Drawing.Point(20, 52);
            this.lblMusteriAdi.Name = "lblMusteriAdi";
            this.lblMusteriAdi.Size = new System.Drawing.Size(73, 16);
            this.lblMusteriAdi.TabIndex = 2;
            this.lblMusteriAdi.Text = "Müşteri Adı";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(20, 84);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(53, 16);
            this.lblTelefon.TabIndex = 4;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblMasaID
            // 
            this.lblMasaID.AutoSize = true;
            this.lblMasaID.Location = new System.Drawing.Point(20, 116);
            this.lblMasaID.Name = "lblMasaID";
            this.lblMasaID.Size = new System.Drawing.Size(57, 16);
            this.lblMasaID.TabIndex = 6;
            this.lblMasaID.Text = "Masa ID";
            // 
            // lblKisiSayisi
            // 
            this.lblKisiSayisi.AutoSize = true;
            this.lblKisiSayisi.Location = new System.Drawing.Point(20, 148);
            this.lblKisiSayisi.Name = "lblKisiSayisi";
            this.lblKisiSayisi.Size = new System.Drawing.Size(68, 16);
            this.lblKisiSayisi.TabIndex = 8;
            this.lblKisiSayisi.Text = "Kişi Sayısı";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(20, 180);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(38, 16);
            this.lblTarih.TabIndex = 10;
            this.lblTarih.Text = "Tarih";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(20, 212);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(46, 16);
            this.lblDurum.TabIndex = 12;
            this.lblDurum.Text = "Durum";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(20, 244);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(63, 16);
            this.lblAciklama.TabIndex = 14;
            this.lblAciklama.Text = "Açıklama";
            // 
            // RezervasyonGuncelleForm
            // 
            this.ClientSize = new System.Drawing.Size(354, 336);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.dtpRezervasyonTarihi);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.txtKisiSayisi);
            this.Controls.Add(this.lblKisiSayisi);
            this.Controls.Add(this.txtMasaID);
            this.Controls.Add(this.lblMasaID);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtMusteriAdi);
            this.Controls.Add(this.lblMusteriAdi);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Name = "RezervasyonGuncelleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervasyon Güncelle";
            this.Load += new System.EventHandler(this.RezervasyonGuncelleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtMusteriAdi;
        public System.Windows.Forms.TextBox txtTelefon;
        public System.Windows.Forms.TextBox txtMasaID;
        public System.Windows.Forms.TextBox txtKisiSayisi;
        public System.Windows.Forms.TextBox txtAciklama;
        public System.Windows.Forms.ComboBox cmbDurum;
        public System.Windows.Forms.DateTimePicker dtpRezervasyonTarihi;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblMusteriAdi;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblMasaID;
        private System.Windows.Forms.Label lblKisiSayisi;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblAciklama;
    }
}