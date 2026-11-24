namespace CafeOtomasyon
{
    partial class UrunRaporForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonRaporGetir;
        private System.Windows.Forms.ToolStripButton toolStripButtonYenile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.DataGridView dgvUrunRapor;
        private System.Windows.Forms.Label lblToplamAdet;
        private System.Windows.Forms.Label lblToplamGelir;

        // Arama Kontrolleri
        private System.Windows.Forms.GroupBox grpBirebirArama;
        private System.Windows.Forms.Button btnBirebirAra;
        private System.Windows.Forms.CheckBox chkUrunAdi;
        private System.Windows.Forms.TextBox txtBirebirUrunAdi;
        private System.Windows.Forms.CheckBox chkToplamGelir;
        private System.Windows.Forms.TextBox txtBirebirToplamGelir;

        private System.Windows.Forms.GroupBox grpHizliArama;
        private System.Windows.Forms.Label labelAramaTuru;
        private System.Windows.Forms.ComboBox cmbHizliAramaTuru;
        private System.Windows.Forms.GroupBox grpAlanSecimi;
        private System.Windows.Forms.RadioButton rdbUrunAdi;
        private System.Windows.Forms.RadioButton rdbToplamGelir;
        private System.Windows.Forms.Label lblHizliAramaDeger;
        private System.Windows.Forms.TextBox txtHizliAramaSecim;

        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonRaporGetir = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonYenile = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.lblBitis = new System.Windows.Forms.Label();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.dgvUrunRapor = new System.Windows.Forms.DataGridView();
            this.lblToplamAdet = new System.Windows.Forms.Label();
            this.lblToplamGelir = new System.Windows.Forms.Label();

            this.grpBirebirArama = new System.Windows.Forms.GroupBox();
            this.btnBirebirAra = new System.Windows.Forms.Button();
            this.chkUrunAdi = new System.Windows.Forms.CheckBox();
            this.txtBirebirUrunAdi = new System.Windows.Forms.TextBox();
            this.chkToplamGelir = new System.Windows.Forms.CheckBox();
            this.txtBirebirToplamGelir = new System.Windows.Forms.TextBox();

            this.grpHizliArama = new System.Windows.Forms.GroupBox();
            this.txtHizliAramaSecim = new System.Windows.Forms.TextBox();
            this.lblHizliAramaDeger = new System.Windows.Forms.Label();
            this.grpAlanSecimi = new System.Windows.Forms.GroupBox();
            this.rdbUrunAdi = new System.Windows.Forms.RadioButton();
            this.rdbToplamGelir = new System.Windows.Forms.RadioButton();
            this.cmbHizliAramaTuru = new System.Windows.Forms.ComboBox();
            this.labelAramaTuru = new System.Windows.Forms.Label();

            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunRapor)).BeginInit();
            this.grpBirebirArama.SuspendLayout();
            this.grpHizliArama.SuspendLayout();
            this.grpAlanSecimi.SuspendLayout();
            this.SuspendLayout();

            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRaporGetir,
            this.toolStripButtonYenile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1036, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";

            // 
            // toolStripButtonRaporGetir
            // 
            this.toolStripButtonRaporGetir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRaporGetir.Name = "toolStripButtonRaporGetir";
            this.toolStripButtonRaporGetir.Size = new System.Drawing.Size(70, 24);
            this.toolStripButtonRaporGetir.Text = "Rapor Getir";
            this.toolStripButtonRaporGetir.Click += new System.EventHandler(this.toolStripButtonRaporGetir_Click);

            // 
            // toolStripButtonYenile
            // 
            this.toolStripButtonYenile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonYenile.Name = "toolStripButtonYenile";
            this.toolStripButtonYenile.Size = new System.Drawing.Size(42, 24);
            this.toolStripButtonYenile.Text = "Yenile";
            this.toolStripButtonYenile.Click += new System.EventHandler(this.toolStripButtonYenile_Click);

            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÜRÜN RAPORU";

            // 
            // lblBaslangic
            // 
            this.lblBaslangic.Location = new System.Drawing.Point(20, 95);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(100, 23);
            this.lblBaslangic.TabIndex = 2;
            this.lblBaslangic.Text = "Başlangıç Tarihi:";

            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBaslangic.Location = new System.Drawing.Point(120, 92);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(120, 22);
            this.dtpBaslangic.TabIndex = 0;

            // 
            // lblBitis
            // 
            this.lblBitis.Location = new System.Drawing.Point(20, 135);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(100, 23);
            this.lblBitis.TabIndex = 3;
            this.lblBitis.Text = "Bitiş Tarihi:";

            // 
            // dtpBitis
            // 
            this.dtpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBitis.Location = new System.Drawing.Point(120, 132);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(120, 22);
            this.dtpBitis.TabIndex = 1;

            // 
            // grpBirebirArama
            // 
            this.grpBirebirArama.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.grpBirebirArama.Controls.Add(this.btnBirebirAra);
            this.grpBirebirArama.Controls.Add(this.txtBirebirToplamGelir);
            this.grpBirebirArama.Controls.Add(this.chkToplamGelir);
            this.grpBirebirArama.Controls.Add(this.txtBirebirUrunAdi);
            this.grpBirebirArama.Controls.Add(this.chkUrunAdi);
            this.grpBirebirArama.Location = new System.Drawing.Point(400, 40);
            this.grpBirebirArama.Name = "grpBirebirArama";
            this.grpBirebirArama.Size = new System.Drawing.Size(260, 210);
            this.grpBirebirArama.TabIndex = 11;
            this.grpBirebirArama.TabStop = false;
            this.grpBirebirArama.Text = "Birebir Arama";

            // 
            // btnBirebirAra
            // 
            this.btnBirebirAra.Location = new System.Drawing.Point(20, 150);
            this.btnBirebirAra.Name = "btnBirebirAra";
            this.btnBirebirAra.Size = new System.Drawing.Size(220, 35);
            this.btnBirebirAra.TabIndex = 4;
            this.btnBirebirAra.Text = "Ara";
            this.btnBirebirAra.UseVisualStyleBackColor = true;
            this.btnBirebirAra.Click += new System.EventHandler(this.btnBirebirAra_Click);

            // 
            // txtBirebirToplamGelir
            // 
            this.txtBirebirToplamGelir.Enabled = false;
            this.txtBirebirToplamGelir.Location = new System.Drawing.Point(125, 63);
            this.txtBirebirToplamGelir.Name = "txtBirebirToplamGelir";
            this.txtBirebirToplamGelir.Size = new System.Drawing.Size(115, 22);
            this.txtBirebirToplamGelir.TabIndex = 3;
            // 
            // chkToplamGelir
            // 
            this.chkToplamGelir.AutoSize = true;
            this.chkToplamGelir.Location = new System.Drawing.Point(15, 65);
            this.chkToplamGelir.Name = "chkToplamGelir";
            this.chkToplamGelir.Size = new System.Drawing.Size(107, 20);
            this.chkToplamGelir.TabIndex = 2;
            this.chkToplamGelir.Text = "Toplam Gelir";
            this.chkToplamGelir.UseVisualStyleBackColor = true;
            this.chkToplamGelir.CheckedChanged += new System.EventHandler(this.chkArama_CheckedChanged);
            // 
            // txtBirebirUrunAdi
            // 
            this.txtBirebirUrunAdi.Enabled = false;
            this.txtBirebirUrunAdi.Location = new System.Drawing.Point(125, 28);
            this.txtBirebirUrunAdi.Name = "txtBirebirUrunAdi";
            this.txtBirebirUrunAdi.Size = new System.Drawing.Size(115, 22);
            this.txtBirebirUrunAdi.TabIndex = 1;
            // 
            // chkUrunAdi
            // 
            this.chkUrunAdi.AutoSize = true;
            this.chkUrunAdi.Location = new System.Drawing.Point(15, 30);
            this.chkUrunAdi.Name = "chkUrunAdi";
            this.chkUrunAdi.Size = new System.Drawing.Size(80, 20);
            this.chkUrunAdi.TabIndex = 0;
            this.chkUrunAdi.Text = "Ürün Adı";
            this.chkUrunAdi.UseVisualStyleBackColor = true;
            this.chkUrunAdi.CheckedChanged += new System.EventHandler(this.chkArama_CheckedChanged);

            // 
            // grpHizliArama
            // 
            this.grpHizliArama.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.grpHizliArama.Controls.Add(this.txtHizliAramaSecim);
            this.grpHizliArama.Controls.Add(this.lblHizliAramaDeger);
            this.grpHizliArama.Controls.Add(this.grpAlanSecimi);
            this.grpHizliArama.Controls.Add(this.cmbHizliAramaTuru);
            this.grpHizliArama.Controls.Add(this.labelAramaTuru);
            this.grpHizliArama.Location = new System.Drawing.Point(700, 40);
            this.grpHizliArama.Name = "grpHizliArama";
            this.grpHizliArama.Size = new System.Drawing.Size(300, 210);
            this.grpHizliArama.TabIndex = 12;
            this.grpHizliArama.TabStop = false;
            this.grpHizliArama.Text = "Hızlı Arama";

            // 
            // labelAramaTuru
            // 
            this.labelAramaTuru.AutoSize = true;
            this.labelAramaTuru.Location = new System.Drawing.Point(15, 30);
            this.labelAramaTuru.Name = "labelAramaTuru";
            this.labelAramaTuru.Size = new System.Drawing.Size(77, 16);
            this.labelAramaTuru.TabIndex = 0;
            this.labelAramaTuru.Text = "Arama Türü";
            // 
            // cmbHizliAramaTuru
            // 
            this.cmbHizliAramaTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHizliAramaTuru.FormattingEnabled = true;
            this.cmbHizliAramaTuru.Items.AddRange(new object[] {
            "İçeren",
            "İle Başlayan",
            "Birebir Eşleşen"});
            this.cmbHizliAramaTuru.Location = new System.Drawing.Point(100, 27);
            this.cmbHizliAramaTuru.Name = "cmbHizliAramaTuru";
            this.cmbHizliAramaTuru.Size = new System.Drawing.Size(180, 24);
            this.cmbHizliAramaTuru.TabIndex = 1;
            // 
            // grpAlanSecimi
            // 
            this.grpAlanSecimi.Controls.Add(this.rdbToplamGelir);
            this.grpAlanSecimi.Controls.Add(this.rdbUrunAdi);
            this.grpAlanSecimi.Location = new System.Drawing.Point(18, 65);
            this.grpAlanSecimi.Name = "grpAlanSecimi";
            this.grpAlanSecimi.Size = new System.Drawing.Size(262, 60);
            this.grpAlanSecimi.TabIndex = 2;
            this.grpAlanSecimi.TabStop = false;
            this.grpAlanSecimi.Text = "Alan Seçimi";
            // 
            // rdbToplamGelir
            // 
            this.rdbToplamGelir.AutoSize = true;
            this.rdbToplamGelir.Location = new System.Drawing.Point(125, 25);
            this.rdbToplamGelir.Name = "rdbToplamGelir";
            this.rdbToplamGelir.Size = new System.Drawing.Size(108, 20);
            this.rdbToplamGelir.TabIndex = 1;
            this.rdbToplamGelir.Text = "Toplam Gelir";
            this.rdbToplamGelir.UseVisualStyleBackColor = true;
            this.rdbToplamGelir.CheckedChanged += new System.EventHandler(this.HizliAramaRadio_CheckedChanged);
            // 
            // rdbUrunAdi
            // 
            this.rdbUrunAdi.AutoSize = true;
            this.rdbUrunAdi.Checked = true;
            this.rdbUrunAdi.Location = new System.Drawing.Point(15, 25);
            this.rdbUrunAdi.Name = "rdbUrunAdi";
            this.rdbUrunAdi.Size = new System.Drawing.Size(79, 20);
            this.rdbUrunAdi.TabIndex = 0;
            this.rdbUrunAdi.TabStop = true;
            this.rdbUrunAdi.Text = "Ürün Adı";
            this.rdbUrunAdi.UseVisualStyleBackColor = true;
            this.rdbUrunAdi.CheckedChanged += new System.EventHandler(this.HizliAramaRadio_CheckedChanged);
            // 
            // lblHizliAramaDeger
            // 
            this.lblHizliAramaDeger.AutoSize = true;
            this.lblHizliAramaDeger.Location = new System.Drawing.Point(15, 150);
            this.lblHizliAramaDeger.Name = "lblHizliAramaDeger";
            this.lblHizliAramaDeger.Size = new System.Drawing.Size(61, 16);
            this.lblHizliAramaDeger.TabIndex = 3;
            this.lblHizliAramaDeger.Text = "Ürün Adı:";
            // 
            // txtHizliAramaSecim
            // 
            this.txtHizliAramaSecim.Location = new System.Drawing.Point(100, 147);
            this.txtHizliAramaSecim.Name = "txtHizliAramaSecim";
            this.txtHizliAramaSecim.Size = new System.Drawing.Size(180, 22);
            this.txtHizliAramaSecim.TabIndex = 4;
            this.txtHizliAramaSecim.TextChanged += new System.EventHandler(this.txtHizliAramaSecim_TextChanged);

            // 
            // dgvUrunRapor
            // 
            this.dgvUrunRapor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunRapor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUrunRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunRapor.Location = new System.Drawing.Point(12, 270);
            this.dgvUrunRapor.Name = "dgvUrunRapor";
            this.dgvUrunRapor.RowHeadersWidth = 51;
            this.dgvUrunRapor.RowTemplate.Height = 24;
            this.dgvUrunRapor.Size = new System.Drawing.Size(1000, 250);
            this.dgvUrunRapor.TabIndex = 6;
            this.dgvUrunRapor.TabStop = false;

            // 
            // lblToplamAdet
            // 
            this.lblToplamAdet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblToplamAdet.Location = new System.Drawing.Point(20, 540);
            this.lblToplamAdet.Name = "lblToplamAdet";
            this.lblToplamAdet.Size = new System.Drawing.Size(300, 25);
            this.lblToplamAdet.TabIndex = 7;
            this.lblToplamAdet.Text = "Toplam Adet: 0";

            // 
            // lblToplamGelir
            // 
            this.lblToplamGelir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblToplamGelir.Location = new System.Drawing.Point(400, 540);
            this.lblToplamGelir.Name = "lblToplamGelir";
            this.lblToplamGelir.Size = new System.Drawing.Size(300, 25);
            this.lblToplamGelir.TabIndex = 8;
            this.lblToplamGelir.Text = "Toplam Gelir: 0 TL";

            // 
            // UrunRaporForm
            // 
            this.ClientSize = new System.Drawing.Size(1036, 601);
            this.Controls.Add(this.grpHizliArama);
            this.Controls.Add(this.grpBirebirArama);
            this.Controls.Add(this.lblToplamGelir);
            this.Controls.Add(this.lblToplamAdet);
            this.Controls.Add(this.dgvUrunRapor);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.lblBitis);
            this.Controls.Add(this.lblBaslangic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UrunRaporForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Raporu ve Arama";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UrunRaporForm_FormClosing);
            this.Load += new System.EventHandler(this.UrunRaporForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunRapor)).EndInit();
            this.grpBirebirArama.ResumeLayout(false);
            this.grpBirebirArama.PerformLayout();
            this.grpHizliArama.ResumeLayout(false);
            this.grpHizliArama.PerformLayout();
            this.grpAlanSecimi.ResumeLayout(false);
            this.grpAlanSecimi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}