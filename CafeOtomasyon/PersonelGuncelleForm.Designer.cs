namespace CafeOtomasyon
{
    partial class PersonelGuncelleForm
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblTcNo = new System.Windows.Forms.Label();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblMaas = new System.Windows.Forms.Label();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.lblIseGirisTarihi = new System.Windows.Forms.Label();
            this.dtpIseGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblAktifMi = new System.Windows.Forms.Label();
            this.chkAktifMi = new System.Windows.Forms.CheckBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.lblYildizAdSoyad = new System.Windows.Forms.Label();
            this.lblYildizSifre = new System.Windows.Forms.Label();
            this.lblYildizRol = new System.Windows.Forms.Label();
            this.lblYildizTcNo = new System.Windows.Forms.Label();
            this.lblYildizTelefon = new System.Windows.Forms.Label();
            this.lblYildizAdres = new System.Windows.Forms.Label();
            this.lblYildizMaas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // alanlar
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(30, 25);
            this.lblID.Text = "ID";

            this.txtID.Location = new System.Drawing.Point(130, 22);
            this.txtID.Size = new System.Drawing.Size(240, 22);
            this.txtID.TabIndex = 0;

            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(30, 60);
            this.lblAdSoyad.Text = "Ad Soyad";

            this.txtAdSoyad.Location = new System.Drawing.Point(130, 57);
            this.txtAdSoyad.Size = new System.Drawing.Size(240, 22);
            this.txtAdSoyad.TabIndex = 1;

            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(30, 95);
            this.lblSifre.Text = "Şifre";

            this.txtSifre.Location = new System.Drawing.Point(130, 92);
            this.txtSifre.Size = new System.Drawing.Size(240, 22);
            this.txtSifre.TabIndex = 2;

            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(30, 130);
            this.lblRol.Text = "Rol";

            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(130, 127);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(240, 24);
            this.cmbRol.TabIndex = 3;

            this.lblTcNo.AutoSize = true;
            this.lblTcNo.Location = new System.Drawing.Point(30, 165);
            this.lblTcNo.Text = "TC No";

            this.txtTcNo.Location = new System.Drawing.Point(130, 162);
            this.txtTcNo.Size = new System.Drawing.Size(240, 22);
            this.txtTcNo.TabIndex = 4;

            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(30, 200);
            this.lblTelefon.Text = "Telefon";

            this.txtTelefon.Location = new System.Drawing.Point(130, 197);
            this.txtTelefon.Size = new System.Drawing.Size(240, 22);
            this.txtTelefon.TabIndex = 5;

            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(30, 235);
            this.lblAdres.Text = "Adres";

            this.txtAdres.Location = new System.Drawing.Point(130, 232);
            this.txtAdres.Size = new System.Drawing.Size(240, 22);
            this.txtAdres.TabIndex = 6;

            this.lblMaas.AutoSize = true;
            this.lblMaas.Location = new System.Drawing.Point(30, 270);
            this.lblMaas.Text = "Maaş";

            this.txtMaas.Location = new System.Drawing.Point(130, 267);
            this.txtMaas.Size = new System.Drawing.Size(240, 22);
            this.txtMaas.TabIndex = 7;

            this.lblIseGirisTarihi.AutoSize = true;
            this.lblIseGirisTarihi.Location = new System.Drawing.Point(30, 305);
            this.lblIseGirisTarihi.Text = "İşe Giriş Tarihi";

            this.dtpIseGirisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIseGirisTarihi.Location = new System.Drawing.Point(130, 302);
            this.dtpIseGirisTarihi.Size = new System.Drawing.Size(240, 22);
            this.dtpIseGirisTarihi.TabIndex = 8;

            this.lblAktifMi.AutoSize = true;
            this.lblAktifMi.Location = new System.Drawing.Point(30, 340);
            this.lblAktifMi.Text = "Aktif Mi";

            this.chkAktifMi.AutoSize = true;
            this.chkAktifMi.Location = new System.Drawing.Point(130, 340);
            this.chkAktifMi.Text = "Aktif";
            this.chkAktifMi.TabIndex = 9;

            this.btnGuncelle.Location = new System.Drawing.Point(130, 382);
            this.btnGuncelle.Size = new System.Drawing.Size(110, 34);
            this.btnGuncelle.TabIndex = 10;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);

            this.btnVazgec.Location = new System.Drawing.Point(260, 382);
            this.btnVazgec.Size = new System.Drawing.Size(110, 34);
            this.btnVazgec.TabIndex = 11;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);

            // yıldızlar
            this.lblYildizAdSoyad.AutoSize = true;
            this.lblYildizAdSoyad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblYildizAdSoyad.ForeColor = System.Drawing.Color.Red;
            this.lblYildizAdSoyad.Location = new System.Drawing.Point(374, 53);
            this.lblYildizAdSoyad.Text = "*";

            this.lblYildizSifre.AutoSize = true;
            this.lblYildizSifre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblYildizSifre.ForeColor = System.Drawing.Color.Red;
            this.lblYildizSifre.Location = new System.Drawing.Point(374, 88);
            this.lblYildizSifre.Text = "*";

            this.lblYildizRol.AutoSize = true;
            this.lblYildizRol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblYildizRol.ForeColor = System.Drawing.Color.Red;
            this.lblYildizRol.Location = new System.Drawing.Point(374, 123);
            this.lblYildizRol.Text = "*";

            this.lblYildizTcNo.AutoSize = true;
            this.lblYildizTcNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblYildizTcNo.ForeColor = System.Drawing.Color.Red;
            this.lblYildizTcNo.Location = new System.Drawing.Point(374, 158);
            this.lblYildizTcNo.Text = "*";

            this.lblYildizTelefon.AutoSize = true;
            this.lblYildizTelefon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblYildizTelefon.ForeColor = System.Drawing.Color.Red;
            this.lblYildizTelefon.Location = new System.Drawing.Point(374, 193);
            this.lblYildizTelefon.Text = "*";

            this.lblYildizAdres.AutoSize = true;
            this.lblYildizAdres.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblYildizAdres.ForeColor = System.Drawing.Color.Red;
            this.lblYildizAdres.Location = new System.Drawing.Point(374, 228);
            this.lblYildizAdres.Text = "*";

            this.lblYildizMaas.AutoSize = true;
            this.lblYildizMaas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblYildizMaas.ForeColor = System.Drawing.Color.Red;
            this.lblYildizMaas.Location = new System.Drawing.Point(374, 263);
            this.lblYildizMaas.Text = "*";

            // form
            this.ClientSize = new System.Drawing.Size(430, 440);
            this.Controls.Add(this.lblYildizMaas);
            this.Controls.Add(this.lblYildizAdres);
            this.Controls.Add(this.lblYildizTelefon);
            this.Controls.Add(this.lblYildizTcNo);
            this.Controls.Add(this.lblYildizRol);
            this.Controls.Add(this.lblYildizSifre);
            this.Controls.Add(this.lblYildizAdSoyad);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.chkAktifMi);
            this.Controls.Add(this.lblAktifMi);
            this.Controls.Add(this.dtpIseGirisTarihi);
            this.Controls.Add(this.lblIseGirisTarihi);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.lblMaas);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.lblTcNo);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Name = "PersonelGuncelleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Güncelle";
            this.Load += new System.EventHandler(this.PersonelGuncelleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblID;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblAdSoyad;
        public System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblSifre;
        public System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblRol;
        public System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label lblTcNo;
        public System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.Label lblTelefon;
        public System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblAdres;
        public System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblMaas;
        public System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Label lblIseGirisTarihi;
        public System.Windows.Forms.DateTimePicker dtpIseGirisTarihi;
        private System.Windows.Forms.Label lblAktifMi;
        public System.Windows.Forms.CheckBox chkAktifMi;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Label lblYildizAdSoyad;
        private System.Windows.Forms.Label lblYildizSifre;
        private System.Windows.Forms.Label lblYildizRol;
        private System.Windows.Forms.Label lblYildizTcNo;
        private System.Windows.Forms.Label lblYildizTelefon;
        private System.Windows.Forms.Label lblYildizAdres;
        private System.Windows.Forms.Label lblYildizMaas;
    }
}