namespace CafeOtomasyon
{
    partial class GunSonuSilForm
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
            this.lblRaporTarihi = new System.Windows.Forms.Label();
            this.lblToplamSiparis = new System.Windows.Forms.Label();
            this.lblToplamOdeme = new System.Windows.Forms.Label();
            this.lblNetCiro = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtRaporTarihi = new System.Windows.Forms.TextBox();
            this.txtToplamSiparis = new System.Windows.Forms.TextBox();
            this.txtToplamOdeme = new System.Windows.Forms.TextBox();
            this.txtNetCiro = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(30, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblRaporTarihi
            // 
            this.lblRaporTarihi.AutoSize = true;
            this.lblRaporTarihi.Location = new System.Drawing.Point(30, 59);
            this.lblRaporTarihi.Name = "lblRaporTarihi";
            this.lblRaporTarihi.Size = new System.Drawing.Size(82, 16);
            this.lblRaporTarihi.TabIndex = 2;
            this.lblRaporTarihi.Text = "Rapor Tarihi";
            // 
            // lblToplamSiparis
            // 
            this.lblToplamSiparis.AutoSize = true;
            this.lblToplamSiparis.Location = new System.Drawing.Point(30, 93);
            this.lblToplamSiparis.Name = "lblToplamSiparis";
            this.lblToplamSiparis.Size = new System.Drawing.Size(99, 16);
            this.lblToplamSiparis.TabIndex = 4;
            this.lblToplamSiparis.Text = "Toplam Sipariş";
            // 
            // lblToplamOdeme
            // 
            this.lblToplamOdeme.AutoSize = true;
            this.lblToplamOdeme.Location = new System.Drawing.Point(30, 127);
            this.lblToplamOdeme.Name = "lblToplamOdeme";
            this.lblToplamOdeme.Size = new System.Drawing.Size(102, 16);
            this.lblToplamOdeme.TabIndex = 6;
            this.lblToplamOdeme.Text = "Toplam Ödeme";
            // 
            // lblNetCiro
            // 
            this.lblNetCiro.AutoSize = true;
            this.lblNetCiro.Location = new System.Drawing.Point(30, 161);
            this.lblNetCiro.Name = "lblNetCiro";
            this.lblNetCiro.Size = new System.Drawing.Size(55, 16);
            this.lblNetCiro.TabIndex = 8;
            this.lblNetCiro.Text = "Net Ciro";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(145, 22);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(220, 22);
            this.txtID.TabIndex = 1;
            // 
            // txtRaporTarihi
            // 
            this.txtRaporTarihi.Enabled = false;
            this.txtRaporTarihi.Location = new System.Drawing.Point(145, 56);
            this.txtRaporTarihi.Name = "txtRaporTarihi";
            this.txtRaporTarihi.Size = new System.Drawing.Size(220, 22);
            this.txtRaporTarihi.TabIndex = 3;
            // 
            // txtToplamSiparis
            // 
            this.txtToplamSiparis.Enabled = false;
            this.txtToplamSiparis.Location = new System.Drawing.Point(145, 90);
            this.txtToplamSiparis.Name = "txtToplamSiparis";
            this.txtToplamSiparis.Size = new System.Drawing.Size(220, 22);
            this.txtToplamSiparis.TabIndex = 5;
            // 
            // txtToplamOdeme
            // 
            this.txtToplamOdeme.Enabled = false;
            this.txtToplamOdeme.Location = new System.Drawing.Point(145, 124);
            this.txtToplamOdeme.Name = "txtToplamOdeme";
            this.txtToplamOdeme.Size = new System.Drawing.Size(220, 22);
            this.txtToplamOdeme.TabIndex = 7;
            // 
            // txtNetCiro
            // 
            this.txtNetCiro.Enabled = false;
            this.txtNetCiro.Location = new System.Drawing.Point(145, 158);
            this.txtNetCiro.Name = "txtNetCiro";
            this.txtNetCiro.Size = new System.Drawing.Size(220, 22);
            this.txtNetCiro.TabIndex = 9;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(145, 204);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(95, 34);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(270, 204);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(95, 34);
            this.btnVazgec.TabIndex = 1;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // GunSonuSilForm
            // 
            this.ClientSize = new System.Drawing.Size(401, 258);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblRaporTarihi);
            this.Controls.Add(this.txtRaporTarihi);
            this.Controls.Add(this.lblToplamSiparis);
            this.Controls.Add(this.txtToplamSiparis);
            this.Controls.Add(this.lblToplamOdeme);
            this.Controls.Add(this.txtToplamOdeme);
            this.Controls.Add(this.lblNetCiro);
            this.Controls.Add(this.txtNetCiro);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnVazgec);
            this.Name = "GunSonuSilForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gün Sonu Sil";
            this.Load += new System.EventHandler(this.GunSonuSilForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblRaporTarihi;
        private System.Windows.Forms.Label lblToplamSiparis;
        private System.Windows.Forms.Label lblToplamOdeme;
        private System.Windows.Forms.Label lblNetCiro;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtRaporTarihi;
        public System.Windows.Forms.TextBox txtToplamSiparis;
        public System.Windows.Forms.TextBox txtToplamOdeme;
        public System.Windows.Forms.TextBox txtNetCiro;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnVazgec;
    }
}