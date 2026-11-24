namespace CafeOtomasyon
{
    partial class MasaSilOnayForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblID = new System.Windows.Forms.Label();
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.lblKapasite = new System.Windows.Forms.Label();
            this.lblKonum = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtMasaNo = new System.Windows.Forms.TextBox();
            this.txtKapasite = new System.Windows.Forms.TextBox();
            this.txtKonum = new System.Windows.Forms.TextBox();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(28, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.AutoSize = true;
            this.lblMasaNo.Location = new System.Drawing.Point(28, 60);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(50, 13);
            this.lblMasaNo.TabIndex = 1;
            this.lblMasaNo.Text = "Masa No";
            // 
            // lblKapasite
            // 
            this.lblKapasite.AutoSize = true;
            this.lblKapasite.Location = new System.Drawing.Point(28, 95);
            this.lblKapasite.Name = "lblKapasite";
            this.lblKapasite.Size = new System.Drawing.Size(48, 13);
            this.lblKapasite.TabIndex = 2;
            this.lblKapasite.Text = "Kapasite";
            // 
            // lblKonum
            // 
            this.lblKonum.AutoSize = true;
            this.lblKonum.Location = new System.Drawing.Point(28, 130);
            this.lblKonum.Name = "lblKonum";
            this.lblKonum.Size = new System.Drawing.Size(40, 13);
            this.lblKonum.TabIndex = 3;
            this.lblKonum.Text = "Konum";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(28, 165);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(38, 13);
            this.lblDurum.TabIndex = 4;
            this.lblDurum.Text = "Durum";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(110, 22);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(220, 20);
            this.txtID.TabIndex = 5;
            // 
            // txtMasaNo
            // 
            this.txtMasaNo.Enabled = false;
            this.txtMasaNo.Location = new System.Drawing.Point(110, 57);
            this.txtMasaNo.Name = "txtMasaNo";
            this.txtMasaNo.ReadOnly = true;
            this.txtMasaNo.Size = new System.Drawing.Size(220, 20);
            this.txtMasaNo.TabIndex = 6;
            // 
            // txtKapasite
            // 
            this.txtKapasite.Enabled = false;
            this.txtKapasite.Location = new System.Drawing.Point(110, 92);
            this.txtKapasite.Name = "txtKapasite";
            this.txtKapasite.ReadOnly = true;
            this.txtKapasite.Size = new System.Drawing.Size(220, 20);
            this.txtKapasite.TabIndex = 7;
            // 
            // txtKonum
            // 
            this.txtKonum.Enabled = false;
            this.txtKonum.Location = new System.Drawing.Point(110, 127);
            this.txtKonum.Name = "txtKonum";
            this.txtKonum.ReadOnly = true;
            this.txtKonum.Size = new System.Drawing.Size(220, 20);
            this.txtKonum.TabIndex = 8;
            // 
            // txtDurum
            // 
            this.txtDurum.Enabled = false;
            this.txtDurum.Location = new System.Drawing.Point(110, 162);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.ReadOnly = true;
            this.txtDurum.Size = new System.Drawing.Size(220, 20);
            this.txtDurum.TabIndex = 9;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(144, 209);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(90, 32);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(240, 209);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(90, 32);
            this.btnVazgec.TabIndex = 1;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // MasaSilOnayForm
            // 
            this.ClientSize = new System.Drawing.Size(367, 264);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtDurum);
            this.Controls.Add(this.txtKonum);
            this.Controls.Add(this.txtKapasite);
            this.Controls.Add(this.txtMasaNo);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblKonum);
            this.Controls.Add(this.lblKapasite);
            this.Controls.Add(this.lblMasaNo);
            this.Controls.Add(this.lblID);
            this.Name = "MasaSilOnayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Masa Silme Onayı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblMasaNo;
        private System.Windows.Forms.Label lblKapasite;
        private System.Windows.Forms.Label lblKonum;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtMasaNo;
        private System.Windows.Forms.TextBox txtKapasite;
        private System.Windows.Forms.TextBox txtKonum;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnVazgec;
    }
}