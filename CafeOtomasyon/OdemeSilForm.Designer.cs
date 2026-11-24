namespace CafeOtomasyon
{
    partial class OdemeSilForm
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
            this.lblMasaID = new System.Windows.Forms.Label();
            this.lblSiparisID = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblOdemeTuru = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtMasaID = new System.Windows.Forms.TextBox();
            this.txtSiparisID = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtOdemeTuru = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(28, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblMasaID
            // 
            this.lblMasaID.AutoSize = true;
            this.lblMasaID.Location = new System.Drawing.Point(28, 59);
            this.lblMasaID.Name = "lblMasaID";
            this.lblMasaID.Size = new System.Drawing.Size(57, 16);
            this.lblMasaID.TabIndex = 2;
            this.lblMasaID.Text = "Masa ID";
            // 
            // lblSiparisID
            // 
            this.lblSiparisID.AutoSize = true;
            this.lblSiparisID.Location = new System.Drawing.Point(28, 93);
            this.lblSiparisID.Name = "lblSiparisID";
            this.lblSiparisID.Size = new System.Drawing.Size(65, 16);
            this.lblSiparisID.TabIndex = 4;
            this.lblSiparisID.Text = "Sipariş ID";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(28, 127);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(38, 16);
            this.lblTutar.TabIndex = 6;
            this.lblTutar.Text = "Tutar";
            // 
            // lblOdemeTuru
            // 
            this.lblOdemeTuru.AutoSize = true;
            this.lblOdemeTuru.Location = new System.Drawing.Point(28, 161);
            this.lblOdemeTuru.Name = "lblOdemeTuru";
            this.lblOdemeTuru.Size = new System.Drawing.Size(82, 16);
            this.lblOdemeTuru.TabIndex = 8;
            this.lblOdemeTuru.Text = "Ödeme Türü";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(28, 195);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(63, 16);
            this.lblAciklama.TabIndex = 10;
            this.lblAciklama.Text = "Açıklama";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(125, 22);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(220, 22);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtMasaID
            // 
            this.txtMasaID.Enabled = false;
            this.txtMasaID.Location = new System.Drawing.Point(125, 56);
            this.txtMasaID.Name = "txtMasaID";
            this.txtMasaID.Size = new System.Drawing.Size(220, 22);
            this.txtMasaID.TabIndex = 3;
            this.txtMasaID.TextChanged += new System.EventHandler(this.txtMasaID_TextChanged);
            // 
            // txtSiparisID
            // 
            this.txtSiparisID.Enabled = false;
            this.txtSiparisID.Location = new System.Drawing.Point(125, 90);
            this.txtSiparisID.Name = "txtSiparisID";
            this.txtSiparisID.Size = new System.Drawing.Size(220, 22);
            this.txtSiparisID.TabIndex = 5;
            this.txtSiparisID.TextChanged += new System.EventHandler(this.txtSiparisID_TextChanged);
            // 
            // txtTutar
            // 
            this.txtTutar.Enabled = false;
            this.txtTutar.Location = new System.Drawing.Point(125, 124);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(220, 22);
            this.txtTutar.TabIndex = 7;
            // 
            // txtOdemeTuru
            // 
            this.txtOdemeTuru.Enabled = false;
            this.txtOdemeTuru.Location = new System.Drawing.Point(125, 158);
            this.txtOdemeTuru.Name = "txtOdemeTuru";
            this.txtOdemeTuru.Size = new System.Drawing.Size(220, 22);
            this.txtOdemeTuru.TabIndex = 9;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Enabled = false;
            this.txtAciklama.Location = new System.Drawing.Point(125, 192);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(220, 22);
            this.txtAciklama.TabIndex = 11;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(125, 235);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(95, 34);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(250, 235);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(95, 34);
            this.btnVazgec.TabIndex = 1;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // OdemeSilForm
            // 
            this.ClientSize = new System.Drawing.Size(382, 291);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblMasaID);
            this.Controls.Add(this.txtMasaID);
            this.Controls.Add(this.lblSiparisID);
            this.Controls.Add(this.txtSiparisID);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.lblOdemeTuru);
            this.Controls.Add(this.txtOdemeTuru);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnVazgec);
            this.Name = "OdemeSilForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Sil";
            this.Load += new System.EventHandler(this.OdemeSilForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblMasaID;
        private System.Windows.Forms.Label lblSiparisID;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblOdemeTuru;
        private System.Windows.Forms.Label lblAciklama;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtMasaID;
        public System.Windows.Forms.TextBox txtSiparisID;
        public System.Windows.Forms.TextBox txtTutar;
        public System.Windows.Forms.TextBox txtOdemeTuru;
        public System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnVazgec;
    }
}