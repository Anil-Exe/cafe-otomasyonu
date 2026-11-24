namespace CafeOtomasyon
{
    partial class SahsiKasaSilForm
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
            this.lblIslemTuru = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblKullaniciID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtIslemTuru = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtKullaniciID = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(30, 26);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblIslemTuru
            // 
            this.lblIslemTuru.AutoSize = true;
            this.lblIslemTuru.Location = new System.Drawing.Point(30, 60);
            this.lblIslemTuru.Name = "lblIslemTuru";
            this.lblIslemTuru.Size = new System.Drawing.Size(69, 16);
            this.lblIslemTuru.TabIndex = 2;
            this.lblIslemTuru.Text = "İşlem Türü";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(30, 94);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(38, 16);
            this.lblTutar.TabIndex = 4;
            this.lblTutar.Text = "Tutar";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(30, 128);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(63, 16);
            this.lblAciklama.TabIndex = 6;
            this.lblAciklama.Text = "Açıklama";
            // 
            // lblKullaniciID
            // 
            this.lblKullaniciID.AutoSize = true;
            this.lblKullaniciID.Location = new System.Drawing.Point(30, 162);
            this.lblKullaniciID.Name = "lblKullaniciID";
            this.lblKullaniciID.Size = new System.Drawing.Size(72, 16);
            this.lblKullaniciID.TabIndex = 8;
            this.lblKullaniciID.Text = "Kullanıcı ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(132, 23);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(220, 22);
            this.txtID.TabIndex = 1;
            // 
            // txtIslemTuru
            // 
            this.txtIslemTuru.Enabled = false;
            this.txtIslemTuru.Location = new System.Drawing.Point(132, 57);
            this.txtIslemTuru.Name = "txtIslemTuru";
            this.txtIslemTuru.Size = new System.Drawing.Size(220, 22);
            this.txtIslemTuru.TabIndex = 3;
            // 
            // txtTutar
            // 
            this.txtTutar.Enabled = false;
            this.txtTutar.Location = new System.Drawing.Point(132, 91);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(220, 22);
            this.txtTutar.TabIndex = 5;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Enabled = false;
            this.txtAciklama.Location = new System.Drawing.Point(132, 125);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(220, 22);
            this.txtAciklama.TabIndex = 7;
            // 
            // txtKullaniciID
            // 
            this.txtKullaniciID.Enabled = false;
            this.txtKullaniciID.Location = new System.Drawing.Point(132, 159);
            this.txtKullaniciID.Name = "txtKullaniciID";
            this.txtKullaniciID.Size = new System.Drawing.Size(220, 22);
            this.txtKullaniciID.TabIndex = 9;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(132, 204);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(95, 34);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(257, 204);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(95, 34);
            this.btnVazgec.TabIndex = 1;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // SahsiKasaSilForm
            // 
            this.ClientSize = new System.Drawing.Size(394, 260);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblIslemTuru);
            this.Controls.Add(this.txtIslemTuru);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblKullaniciID);
            this.Controls.Add(this.txtKullaniciID);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnVazgec);
            this.Name = "SahsiKasaSilForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şahsi Kasa Sil";
            this.Load += new System.EventHandler(this.SahsiKasaSilForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblIslemTuru;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblKullaniciID;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtIslemTuru;
        public System.Windows.Forms.TextBox txtTutar;
        public System.Windows.Forms.TextBox txtAciklama;
        public System.Windows.Forms.TextBox txtKullaniciID;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnVazgec;
    }
}