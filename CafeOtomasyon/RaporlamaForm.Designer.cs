namespace CafeOtomasyon
{
    partial class RaporlamaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelMasa = new System.Windows.Forms.Label();
            this.labelPersonel = new System.Windows.Forms.Label();
            this.labelUrun = new System.Windows.Forms.Label();
            this.labelOdeme = new System.Windows.Forms.Label();
            this.labelNetCiro = new System.Windows.Forms.Label();
            this.lblToplamMasa = new System.Windows.Forms.Label();
            this.lblToplamPersonel = new System.Windows.Forms.Label();
            this.lblToplamUrun = new System.Windows.Forms.Label();
            this.lblToplamOdeme = new System.Windows.Forms.Label();
            this.lblToplamNetCiro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(120, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "GENEL RAPORLAMA";
            // 
            // labelMasa
            // 
            this.labelMasa.Location = new System.Drawing.Point(40, 90);
            this.labelMasa.Name = "labelMasa";
            this.labelMasa.Size = new System.Drawing.Size(140, 23);
            this.labelMasa.TabIndex = 1;
            this.labelMasa.Text = "Toplam Masa:";
            // 
            // labelPersonel
            // 
            this.labelPersonel.Location = new System.Drawing.Point(40, 130);
            this.labelPersonel.Name = "labelPersonel";
            this.labelPersonel.Size = new System.Drawing.Size(140, 23);
            this.labelPersonel.TabIndex = 2;
            this.labelPersonel.Text = "Toplam Personel:";
            // 
            // labelUrun
            // 
            this.labelUrun.Location = new System.Drawing.Point(40, 170);
            this.labelUrun.Name = "labelUrun";
            this.labelUrun.Size = new System.Drawing.Size(140, 23);
            this.labelUrun.TabIndex = 3;
            this.labelUrun.Text = "Toplam Ürün:";
            // 
            // labelOdeme
            // 
            this.labelOdeme.Location = new System.Drawing.Point(40, 210);
            this.labelOdeme.Name = "labelOdeme";
            this.labelOdeme.Size = new System.Drawing.Size(140, 23);
            this.labelOdeme.TabIndex = 4;
            this.labelOdeme.Text = "Toplam Ödeme:";
            // 
            // labelNetCiro
            // 
            this.labelNetCiro.Location = new System.Drawing.Point(40, 250);
            this.labelNetCiro.Name = "labelNetCiro";
            this.labelNetCiro.Size = new System.Drawing.Size(140, 23);
            this.labelNetCiro.TabIndex = 5;
            this.labelNetCiro.Text = "Toplam Net Ciro:";
            // 
            // lblToplamMasa
            // 
            this.lblToplamMasa.Location = new System.Drawing.Point(220, 90);
            this.lblToplamMasa.Name = "lblToplamMasa";
            this.lblToplamMasa.Size = new System.Drawing.Size(180, 23);
            this.lblToplamMasa.TabIndex = 0;
            // 
            // lblToplamPersonel
            // 
            this.lblToplamPersonel.Location = new System.Drawing.Point(220, 130);
            this.lblToplamPersonel.Name = "lblToplamPersonel";
            this.lblToplamPersonel.Size = new System.Drawing.Size(180, 23);
            this.lblToplamPersonel.TabIndex = 1;
            // 
            // lblToplamUrun
            // 
            this.lblToplamUrun.Location = new System.Drawing.Point(220, 170);
            this.lblToplamUrun.Name = "lblToplamUrun";
            this.lblToplamUrun.Size = new System.Drawing.Size(180, 23);
            this.lblToplamUrun.TabIndex = 2;
            // 
            // lblToplamOdeme
            // 
            this.lblToplamOdeme.Location = new System.Drawing.Point(220, 210);
            this.lblToplamOdeme.Name = "lblToplamOdeme";
            this.lblToplamOdeme.Size = new System.Drawing.Size(180, 23);
            this.lblToplamOdeme.TabIndex = 3;
            // 
            // lblToplamNetCiro
            // 
            this.lblToplamNetCiro.Location = new System.Drawing.Point(220, 250);
            this.lblToplamNetCiro.Name = "lblToplamNetCiro";
            this.lblToplamNetCiro.Size = new System.Drawing.Size(180, 23);
            this.lblToplamNetCiro.TabIndex = 4;
            // 
            // RaporlamaForm
            // 
            this.ClientSize = new System.Drawing.Size(470, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMasa);
            this.Controls.Add(this.labelPersonel);
            this.Controls.Add(this.labelUrun);
            this.Controls.Add(this.labelOdeme);
            this.Controls.Add(this.labelNetCiro);
            this.Controls.Add(this.lblToplamMasa);
            this.Controls.Add(this.lblToplamPersonel);
            this.Controls.Add(this.lblToplamUrun);
            this.Controls.Add(this.lblToplamOdeme);
            this.Controls.Add(this.lblToplamNetCiro);
            this.Name = "RaporlamaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporlama";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RaporlamaForm_FormClosing);
            this.Load += new System.EventHandler(this.RaporlamaForm_Load);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMasa;
        private System.Windows.Forms.Label labelPersonel;
        private System.Windows.Forms.Label labelUrun;
        private System.Windows.Forms.Label labelOdeme;
        private System.Windows.Forms.Label labelNetCiro;
        private System.Windows.Forms.Label lblToplamMasa;
        private System.Windows.Forms.Label lblToplamPersonel;
        private System.Windows.Forms.Label lblToplamUrun;
        private System.Windows.Forms.Label lblToplamOdeme;
        private System.Windows.Forms.Label lblToplamNetCiro;
    }
}