namespace CafeOtomasyon
{
    partial class RezervasyonSilForm
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblMusteriAdi = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblMasaID = new System.Windows.Forms.Label();
            this.lblKisiSayisi = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtMasaID = new System.Windows.Forms.TextBox();
            this.txtKisiSayisi = new System.Windows.Forms.TextBox();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(30, 24);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblMusteriAdi
            // 
            this.lblMusteriAdi.AutoSize = true;
            this.lblMusteriAdi.Location = new System.Drawing.Point(30, 58);
            this.lblMusteriAdi.Name = "lblMusteriAdi";
            this.lblMusteriAdi.Size = new System.Drawing.Size(73, 16);
            this.lblMusteriAdi.TabIndex = 2;
            this.lblMusteriAdi.Text = "Müşteri Adı";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(30, 92);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(53, 16);
            this.lblTelefon.TabIndex = 4;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblMasaID
            // 
            this.lblMasaID.AutoSize = true;
            this.lblMasaID.Location = new System.Drawing.Point(30, 126);
            this.lblMasaID.Name = "lblMasaID";
            this.lblMasaID.Size = new System.Drawing.Size(57, 16);
            this.lblMasaID.TabIndex = 6;
            this.lblMasaID.Text = "Masa ID";
            // 
            // lblKisiSayisi
            // 
            this.lblKisiSayisi.AutoSize = true;
            this.lblKisiSayisi.Location = new System.Drawing.Point(30, 160);
            this.lblKisiSayisi.Name = "lblKisiSayisi";
            this.lblKisiSayisi.Size = new System.Drawing.Size(68, 16);
            this.lblKisiSayisi.TabIndex = 8;
            this.lblKisiSayisi.Text = "Kişi Sayısı";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(30, 194);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(46, 16);
            this.lblDurum.TabIndex = 10;
            this.lblDurum.Text = "Durum";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(132, 21);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(220, 22);
            this.txtID.TabIndex = 1;
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Enabled = false;
            this.txtMusteriAdi.Location = new System.Drawing.Point(132, 55);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(220, 22);
            this.txtMusteriAdi.TabIndex = 3;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Enabled = false;
            this.txtTelefon.Location = new System.Drawing.Point(132, 89);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(220, 22);
            this.txtTelefon.TabIndex = 5;
            // 
            // txtMasaID
            // 
            this.txtMasaID.Enabled = false;
            this.txtMasaID.Location = new System.Drawing.Point(132, 123);
            this.txtMasaID.Name = "txtMasaID";
            this.txtMasaID.Size = new System.Drawing.Size(220, 22);
            this.txtMasaID.TabIndex = 7;
            // 
            // txtKisiSayisi
            // 
            this.txtKisiSayisi.Enabled = false;
            this.txtKisiSayisi.Location = new System.Drawing.Point(132, 157);
            this.txtKisiSayisi.Name = "txtKisiSayisi";
            this.txtKisiSayisi.Size = new System.Drawing.Size(220, 22);
            this.txtKisiSayisi.TabIndex = 9;
            // 
            // txtDurum
            // 
            this.txtDurum.Enabled = false;
            this.txtDurum.Location = new System.Drawing.Point(132, 191);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(220, 22);
            this.txtDurum.TabIndex = 11;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(132, 234);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(95, 34);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(257, 234);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(95, 34);
            this.btnVazgec.TabIndex = 1;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // RezervasyonSilForm
            // 
            this.ClientSize = new System.Drawing.Size(394, 288);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblMusteriAdi);
            this.Controls.Add(this.txtMusteriAdi);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblMasaID);
            this.Controls.Add(this.txtMasaID);
            this.Controls.Add(this.lblKisiSayisi);
            this.Controls.Add(this.txtKisiSayisi);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.txtDurum);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnVazgec);
            this.Name = "RezervasyonSilForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervasyon Sil";
            this.Load += new System.EventHandler(this.RezervasyonSilForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblMusteriAdi;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblMasaID;
        private System.Windows.Forms.Label lblKisiSayisi;
        private System.Windows.Forms.Label lblDurum;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtMusteriAdi;
        public System.Windows.Forms.TextBox txtTelefon;
        public System.Windows.Forms.TextBox txtMasaID;
        public System.Windows.Forms.TextBox txtKisiSayisi;
        public System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnVazgec;
    }
}