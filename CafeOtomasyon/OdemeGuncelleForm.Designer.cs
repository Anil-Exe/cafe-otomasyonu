namespace CafeOtomasyon
{
    partial class OdemeGuncelleForm
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
            this.txtMasaID = new System.Windows.Forms.TextBox();
            this.txtSiparisID = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.cmbOdemeTuru = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblMasaID = new System.Windows.Forms.Label();
            this.lblSiparisID = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblOdemeTuru = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(120, 17);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(180, 22);
            this.txtID.TabIndex = 0;
            // 
            // txtMasaID
            // 
            this.txtMasaID.Location = new System.Drawing.Point(120, 49);
            this.txtMasaID.Name = "txtMasaID";
            this.txtMasaID.Size = new System.Drawing.Size(180, 22);
            this.txtMasaID.TabIndex = 1;
            // 
            // txtSiparisID
            // 
            this.txtSiparisID.Location = new System.Drawing.Point(120, 81);
            this.txtSiparisID.Name = "txtSiparisID";
            this.txtSiparisID.Size = new System.Drawing.Size(180, 22);
            this.txtSiparisID.TabIndex = 2;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(120, 113);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(180, 22);
            this.txtTutar.TabIndex = 3;
            this.txtTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTutar_KeyPress);
            // 
            // cmbOdemeTuru
            // 
            this.cmbOdemeTuru.FormattingEnabled = true;
            this.cmbOdemeTuru.Location = new System.Drawing.Point(120, 145);
            this.cmbOdemeTuru.Name = "cmbOdemeTuru";
            this.cmbOdemeTuru.Size = new System.Drawing.Size(180, 24);
            this.cmbOdemeTuru.TabIndex = 4;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(120, 177);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(180, 22);
            this.txtAciklama.TabIndex = 5;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(120, 220);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(85, 30);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(215, 220);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(85, 30);
            this.btnVazgec.TabIndex = 7;
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
            // lblMasaID
            // 
            this.lblMasaID.AutoSize = true;
            this.lblMasaID.Location = new System.Drawing.Point(20, 52);
            this.lblMasaID.Name = "lblMasaID";
            this.lblMasaID.Size = new System.Drawing.Size(57, 16);
            this.lblMasaID.TabIndex = 2;
            this.lblMasaID.Text = "Masa ID";
            // 
            // lblSiparisID
            // 
            this.lblSiparisID.AutoSize = true;
            this.lblSiparisID.Location = new System.Drawing.Point(20, 84);
            this.lblSiparisID.Name = "lblSiparisID";
            this.lblSiparisID.Size = new System.Drawing.Size(65, 16);
            this.lblSiparisID.TabIndex = 4;
            this.lblSiparisID.Text = "Sipariş ID";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(20, 116);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(38, 16);
            this.lblTutar.TabIndex = 6;
            this.lblTutar.Text = "Tutar";
            // 
            // lblOdemeTuru
            // 
            this.lblOdemeTuru.AutoSize = true;
            this.lblOdemeTuru.Location = new System.Drawing.Point(20, 148);
            this.lblOdemeTuru.Name = "lblOdemeTuru";
            this.lblOdemeTuru.Size = new System.Drawing.Size(82, 16);
            this.lblOdemeTuru.TabIndex = 8;
            this.lblOdemeTuru.Text = "Ödeme Türü";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(20, 180);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(63, 16);
            this.lblAciklama.TabIndex = 10;
            this.lblAciklama.Text = "Açıklama";
            // 
            // OdemeGuncelleForm
            // 
            this.ClientSize = new System.Drawing.Size(334, 271);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.cmbOdemeTuru);
            this.Controls.Add(this.lblOdemeTuru);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.txtSiparisID);
            this.Controls.Add(this.lblSiparisID);
            this.Controls.Add(this.txtMasaID);
            this.Controls.Add(this.lblMasaID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Name = "OdemeGuncelleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Güncelle";
            this.Load += new System.EventHandler(this.OdemeGuncelleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtMasaID;
        public System.Windows.Forms.TextBox txtSiparisID;
        public System.Windows.Forms.TextBox txtTutar;
        public System.Windows.Forms.ComboBox cmbOdemeTuru;
        public System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblMasaID;
        private System.Windows.Forms.Label lblSiparisID;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblOdemeTuru;
        private System.Windows.Forms.Label lblAciklama;
    }
}