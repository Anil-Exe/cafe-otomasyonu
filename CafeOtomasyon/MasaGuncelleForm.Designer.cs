namespace CafeOtomasyon
{
    partial class MasaGuncelleForm
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
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.txtMasaNo = new System.Windows.Forms.TextBox();
            this.lblKapasite = new System.Windows.Forms.Label();
            this.txtKapasite = new System.Windows.Forms.TextBox();
            this.lblKonum = new System.Windows.Forms.Label();
            this.cmbKonum = new System.Windows.Forms.ComboBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.lblYildizMasaNo = new System.Windows.Forms.Label();
            this.lblYildizKapasite = new System.Windows.Forms.Label();
            this.lblYildizKonum = new System.Windows.Forms.Label();
            this.lblYildizDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(39, 30);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(131, 27);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(220, 22);
            this.txtID.TabIndex = 0;
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.AutoSize = true;
            this.lblMasaNo.Location = new System.Drawing.Point(39, 67);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(61, 16);
            this.lblMasaNo.TabIndex = 2;
            this.lblMasaNo.Text = "Masa No";
            // 
            // txtMasaNo
            // 
            this.txtMasaNo.Location = new System.Drawing.Point(131, 64);
            this.txtMasaNo.Name = "txtMasaNo";
            this.txtMasaNo.Size = new System.Drawing.Size(220, 22);
            this.txtMasaNo.TabIndex = 1;
            // 
            // lblKapasite
            // 
            this.lblKapasite.AutoSize = true;
            this.lblKapasite.Location = new System.Drawing.Point(39, 104);
            this.lblKapasite.Name = "lblKapasite";
            this.lblKapasite.Size = new System.Drawing.Size(58, 16);
            this.lblKapasite.TabIndex = 4;
            this.lblKapasite.Text = "Kapasite";
            // 
            // txtKapasite
            // 
            this.txtKapasite.Location = new System.Drawing.Point(131, 101);
            this.txtKapasite.Name = "txtKapasite";
            this.txtKapasite.Size = new System.Drawing.Size(220, 22);
            this.txtKapasite.TabIndex = 2;
            // 
            // lblKonum
            // 
            this.lblKonum.AutoSize = true;
            this.lblKonum.Location = new System.Drawing.Point(39, 141);
            this.lblKonum.Name = "lblKonum";
            this.lblKonum.Size = new System.Drawing.Size(50, 16);
            this.lblKonum.TabIndex = 6;
            this.lblKonum.Text = "Konum";
            // 
            // cmbKonum
            // 
            this.cmbKonum.FormattingEnabled = true;
            this.cmbKonum.Location = new System.Drawing.Point(131, 138);
            this.cmbKonum.Name = "cmbKonum";
            this.cmbKonum.Size = new System.Drawing.Size(220, 24);
            this.cmbKonum.TabIndex = 3;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(39, 178);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(46, 16);
            this.lblDurum.TabIndex = 8;
            this.lblDurum.Text = "Durum";
            // 
            // cmbDurum
            // 
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Location = new System.Drawing.Point(131, 175);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(220, 24);
            this.cmbDurum.TabIndex = 4;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(131, 224);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 34);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(251, 224);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(100, 34);
            this.btnVazgec.TabIndex = 6;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // yildizlar
            // 
            this.lblYildizMasaNo.AutoSize = true;
            this.lblYildizMasaNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblYildizMasaNo.ForeColor = System.Drawing.Color.Red;
            this.lblYildizMasaNo.Location = new System.Drawing.Point(355, 60);
            this.lblYildizMasaNo.Text = "*";

            this.lblYildizKapasite.AutoSize = true;
            this.lblYildizKapasite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblYildizKapasite.ForeColor = System.Drawing.Color.Red;
            this.lblYildizKapasite.Location = new System.Drawing.Point(355, 97);
            this.lblYildizKapasite.Text = "*";

            this.lblYildizKonum.AutoSize = true;
            this.lblYildizKonum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblYildizKonum.ForeColor = System.Drawing.Color.Red;
            this.lblYildizKonum.Location = new System.Drawing.Point(355, 134);
            this.lblYildizKonum.Text = "*";

            this.lblYildizDurum.AutoSize = true;
            this.lblYildizDurum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblYildizDurum.ForeColor = System.Drawing.Color.Red;
            this.lblYildizDurum.Location = new System.Drawing.Point(355, 171);
            this.lblYildizDurum.Text = "*";
            // 
            // MasaGuncelleForm
            // 
            this.ClientSize = new System.Drawing.Size(406, 284);
            this.Controls.Add(this.lblYildizDurum);
            this.Controls.Add(this.lblYildizKonum);
            this.Controls.Add(this.lblYildizKapasite);
            this.Controls.Add(this.lblYildizMasaNo);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.cmbKonum);
            this.Controls.Add(this.lblKonum);
            this.Controls.Add(this.txtKapasite);
            this.Controls.Add(this.lblKapasite);
            this.Controls.Add(this.txtMasaNo);
            this.Controls.Add(this.lblMasaNo);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Name = "MasaGuncelleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masa Güncelle";
            this.Load += new System.EventHandler(this.MasaGuncelleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblID;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblMasaNo;
        public System.Windows.Forms.TextBox txtMasaNo;
        private System.Windows.Forms.Label lblKapasite;
        public System.Windows.Forms.TextBox txtKapasite;
        private System.Windows.Forms.Label lblKonum;
        public System.Windows.Forms.ComboBox cmbKonum;
        private System.Windows.Forms.Label lblDurum;
        public System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Label lblYildizMasaNo;
        private System.Windows.Forms.Label lblYildizKapasite;
        private System.Windows.Forms.Label lblYildizKonum;
        private System.Windows.Forms.Label lblYildizDurum;
    }
}