namespace CafeOtomasyon
{
    partial class GarsonSiparisIslemForm
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
            this.dgvSiparisler = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSiparisID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonIptalEt = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonYenile = new System.Windows.Forms.ToolStripButton();

            // Arama Kontrolleri
            this.grpBirebirArama = new System.Windows.Forms.GroupBox();
            this.btnBirebirAra = new System.Windows.Forms.Button();
            this.txtBirebirDurum = new System.Windows.Forms.TextBox();
            this.chkDurum = new System.Windows.Forms.CheckBox();
            this.txtBirebirToplamTutar = new System.Windows.Forms.TextBox();
            this.chkToplamTutar = new System.Windows.Forms.CheckBox();
            this.txtBirebirOdemeTipi = new System.Windows.Forms.TextBox();
            this.chkOdemeTipi = new System.Windows.Forms.CheckBox();
            this.grpHizliArama = new System.Windows.Forms.GroupBox();
            this.txtHizliAramaSecim = new System.Windows.Forms.TextBox();
            this.lblHizliAramaDeger = new System.Windows.Forms.Label();
            this.grpAlanSecimi = new System.Windows.Forms.GroupBox();
            this.rdbDurum = new System.Windows.Forms.RadioButton();
            this.rdbToplamTutar = new System.Windows.Forms.RadioButton();
            this.rdbOdemeTipi = new System.Windows.Forms.RadioButton();
            this.cmbHizliAramaTuru = new System.Windows.Forms.ComboBox();
            this.labelAramaTuru = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.grpBirebirArama.SuspendLayout();
            this.grpHizliArama.SuspendLayout();
            this.grpAlanSecimi.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "GARSON SİPARİŞ İŞLEMLERİ";
            // 
            // dgvSiparisler
            // 
            this.dgvSiparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparisler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisler.Location = new System.Drawing.Point(12, 270);
            this.dgvSiparisler.Name = "dgvSiparisler";
            this.dgvSiparisler.RowHeadersWidth = 51;
            this.dgvSiparisler.RowTemplate.Height = 24;
            this.dgvSiparisler.Size = new System.Drawing.Size(1000, 250);
            this.dgvSiparisler.TabIndex = 5;
            this.dgvSiparisler.TabStop = false;
            this.dgvSiparisler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSiparisler_CellClick);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 540);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sipariş ID";
            // 
            // txtSiparisID
            // 
            this.txtSiparisID.Location = new System.Drawing.Point(92, 537);
            this.txtSiparisID.Name = "txtSiparisID";
            this.txtSiparisID.ReadOnly = true;
            this.txtSiparisID.Size = new System.Drawing.Size(100, 22);
            this.txtSiparisID.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(212, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Durum";
            // 
            // cmbDurum
            // 
            this.cmbDurum.Location = new System.Drawing.Point(278, 537);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(150, 24);
            this.cmbDurum.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonGuncelle,
            this.toolStripButtonIptalEt,
            this.toolStripButtonYenile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1036, 27);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonGuncelle
            // 
            this.toolStripButtonGuncelle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonGuncelle.Name = "toolStripButtonGuncelle";
            this.toolStripButtonGuncelle.Size = new System.Drawing.Size(70, 24);
            this.toolStripButtonGuncelle.Text = "Güncelle";
            this.toolStripButtonGuncelle.Click += new System.EventHandler(this.toolStripButtonGuncelle_Click);
            // 
            // toolStripButtonIptalEt
            // 
            this.toolStripButtonIptalEt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonIptalEt.Name = "toolStripButtonIptalEt";
            this.toolStripButtonIptalEt.Size = new System.Drawing.Size(60, 24);
            this.toolStripButtonIptalEt.Text = "İptal Et";
            this.toolStripButtonIptalEt.Click += new System.EventHandler(this.toolStripButtonIptalEt_Click);
            // 
            // toolStripButtonYenile
            // 
            this.toolStripButtonYenile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonYenile.Name = "toolStripButtonYenile";
            this.toolStripButtonYenile.Size = new System.Drawing.Size(52, 24);
            this.toolStripButtonYenile.Text = "Yenile";
            this.toolStripButtonYenile.Click += new System.EventHandler(this.toolStripButtonYenile_Click);
            // 
            // grpBirebirArama
            // 
            this.grpBirebirArama.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.grpBirebirArama.Controls.Add(this.btnBirebirAra);
            this.grpBirebirArama.Controls.Add(this.txtBirebirDurum);
            this.grpBirebirArama.Controls.Add(this.chkDurum);
            this.grpBirebirArama.Controls.Add(this.txtBirebirToplamTutar);
            this.grpBirebirArama.Controls.Add(this.chkToplamTutar);
            this.grpBirebirArama.Controls.Add(this.txtBirebirOdemeTipi);
            this.grpBirebirArama.Controls.Add(this.chkOdemeTipi);
            this.grpBirebirArama.Location = new System.Drawing.Point(400, 40);
            this.grpBirebirArama.Name = "grpBirebirArama";
            this.grpBirebirArama.Size = new System.Drawing.Size(280, 210);
            this.grpBirebirArama.TabIndex = 11;
            this.grpBirebirArama.TabStop = false;
            this.grpBirebirArama.Text = "Birebir Arama";
            // 
            // btnBirebirAra
            // 
            this.btnBirebirAra.Location = new System.Drawing.Point(20, 150);
            this.btnBirebirAra.Name = "btnBirebirAra";
            this.btnBirebirAra.Size = new System.Drawing.Size(240, 35);
            this.btnBirebirAra.TabIndex = 4;
            this.btnBirebirAra.Text = "Ara";
            this.btnBirebirAra.UseVisualStyleBackColor = true;
            this.btnBirebirAra.Click += new System.EventHandler(this.btnBirebirAra_Click);
            // 
            // txtBirebirDurum
            // 
            this.txtBirebirDurum.Enabled = false;
            this.txtBirebirDurum.Location = new System.Drawing.Point(130, 98);
            this.txtBirebirDurum.Name = "txtBirebirDurum";
            this.txtBirebirDurum.Size = new System.Drawing.Size(130, 22);
            this.txtBirebirDurum.TabIndex = 3;
            // 
            // chkDurum
            // 
            this.chkDurum.AutoSize = true;
            this.chkDurum.Location = new System.Drawing.Point(20, 100);
            this.chkDurum.Name = "chkDurum";
            this.chkDurum.Size = new System.Drawing.Size(68, 20);
            this.chkDurum.TabIndex = 2;
            this.chkDurum.Text = "Durum";
            this.chkDurum.UseVisualStyleBackColor = true;
            this.chkDurum.CheckedChanged += new System.EventHandler(this.chkArama_CheckedChanged);
            // 
            // txtBirebirToplamTutar
            // 
            this.txtBirebirToplamTutar.Enabled = false;
            this.txtBirebirToplamTutar.Location = new System.Drawing.Point(130, 63);
            this.txtBirebirToplamTutar.Name = "txtBirebirToplamTutar";
            this.txtBirebirToplamTutar.Size = new System.Drawing.Size(130, 22);
            this.txtBirebirToplamTutar.TabIndex = 3;
            // 
            // chkToplamTutar
            // 
            this.chkToplamTutar.AutoSize = true;
            this.chkToplamTutar.Location = new System.Drawing.Point(20, 65);
            this.chkToplamTutar.Name = "chkToplamTutar";
            this.chkToplamTutar.Size = new System.Drawing.Size(110, 20);
            this.chkToplamTutar.TabIndex = 2;
            this.chkToplamTutar.Text = "Toplam Tutar";
            this.chkToplamTutar.UseVisualStyleBackColor = true;
            this.chkToplamTutar.CheckedChanged += new System.EventHandler(this.chkArama_CheckedChanged);
            // 
            // txtBirebirOdemeTipi
            // 
            this.txtBirebirOdemeTipi.Enabled = false;
            this.txtBirebirOdemeTipi.Location = new System.Drawing.Point(130, 28);
            this.txtBirebirOdemeTipi.Name = "txtBirebirOdemeTipi";
            this.txtBirebirOdemeTipi.Size = new System.Drawing.Size(130, 22);
            this.txtBirebirOdemeTipi.TabIndex = 1;
            // 
            // chkOdemeTipi
            // 
            this.chkOdemeTipi.AutoSize = true;
            this.chkOdemeTipi.Location = new System.Drawing.Point(20, 30);
            this.chkOdemeTipi.Name = "chkOdemeTipi";
            this.chkOdemeTipi.Size = new System.Drawing.Size(100, 20);
            this.chkOdemeTipi.TabIndex = 0;
            this.chkOdemeTipi.Text = "Ödeme Tipi";
            this.chkOdemeTipi.UseVisualStyleBackColor = true;
            this.chkOdemeTipi.CheckedChanged += new System.EventHandler(this.chkArama_CheckedChanged);
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
            this.grpHizliArama.Size = new System.Drawing.Size(310, 210);
            this.grpHizliArama.TabIndex = 12;
            this.grpHizliArama.TabStop = false;
            this.grpHizliArama.Text = "Hızlı Arama";
            // 
            // txtHizliAramaSecim
            // 
            this.txtHizliAramaSecim.Location = new System.Drawing.Point(120, 157);
            this.txtHizliAramaSecim.Name = "txtHizliAramaSecim";
            this.txtHizliAramaSecim.Size = new System.Drawing.Size(170, 22);
            this.txtHizliAramaSecim.TabIndex = 4;
            this.txtHizliAramaSecim.TextChanged += new System.EventHandler(this.txtHizliAramaSecim_TextChanged);
            // 
            // lblHizliAramaDeger
            // 
            this.lblHizliAramaDeger.AutoSize = true;
            this.lblHizliAramaDeger.Location = new System.Drawing.Point(15, 160);
            this.lblHizliAramaDeger.Name = "lblHizliAramaDeger";
            this.lblHizliAramaDeger.Size = new System.Drawing.Size(81, 16);
            this.lblHizliAramaDeger.TabIndex = 3;
            this.lblHizliAramaDeger.Text = "Ödeme Tipi:";
            // 
            // grpAlanSecimi
            // 
            this.grpAlanSecimi.Controls.Add(this.rdbDurum);
            this.grpAlanSecimi.Controls.Add(this.rdbToplamTutar);
            this.grpAlanSecimi.Controls.Add(this.rdbOdemeTipi);
            this.grpAlanSecimi.Location = new System.Drawing.Point(18, 65);
            this.grpAlanSecimi.Name = "grpAlanSecimi";
            this.grpAlanSecimi.Size = new System.Drawing.Size(272, 80);
            this.grpAlanSecimi.TabIndex = 2;
            this.grpAlanSecimi.TabStop = false;
            this.grpAlanSecimi.Text = "Alan Seçimi";
            // 
            // rdbDurum
            // 
            this.rdbDurum.AutoSize = true;
            this.rdbDurum.Location = new System.Drawing.Point(15, 50);
            this.rdbDurum.Name = "rdbDurum";
            this.rdbDurum.Size = new System.Drawing.Size(67, 20);
            this.rdbDurum.TabIndex = 2;
            this.rdbDurum.Text = "Durum";
            this.rdbDurum.UseVisualStyleBackColor = true;
            this.rdbDurum.CheckedChanged += new System.EventHandler(this.HizliAramaRadio_CheckedChanged);
            // 
            // rdbToplamTutar
            // 
            this.rdbToplamTutar.AutoSize = true;
            this.rdbToplamTutar.Location = new System.Drawing.Point(135, 25);
            this.rdbToplamTutar.Name = "rdbToplamTutar";
            this.rdbToplamTutar.Size = new System.Drawing.Size(109, 20);
            this.rdbToplamTutar.TabIndex = 1;
            this.rdbToplamTutar.Text = "Toplam Tutar";
            this.rdbToplamTutar.UseVisualStyleBackColor = true;
            this.rdbToplamTutar.CheckedChanged += new System.EventHandler(this.HizliAramaRadio_CheckedChanged);
            // 
            // rdbOdemeTipi
            // 
            this.rdbOdemeTipi.AutoSize = true;
            this.rdbOdemeTipi.Checked = true;
            this.rdbOdemeTipi.Location = new System.Drawing.Point(15, 25);
            this.rdbOdemeTipi.Name = "rdbOdemeTipi";
            this.rdbOdemeTipi.Size = new System.Drawing.Size(99, 20);
            this.rdbOdemeTipi.TabIndex = 0;
            this.rdbOdemeTipi.TabStop = true;
            this.rdbOdemeTipi.Text = "Ödeme Tipi";
            this.rdbOdemeTipi.UseVisualStyleBackColor = true;
            this.rdbOdemeTipi.CheckedChanged += new System.EventHandler(this.HizliAramaRadio_CheckedChanged);
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
            this.cmbHizliAramaTuru.Size = new System.Drawing.Size(190, 24);
            this.cmbHizliAramaTuru.TabIndex = 1;
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
            // GarsonSiparisIslemForm
            // 
            this.ClientSize = new System.Drawing.Size(1036, 601);
            this.Controls.Add(this.grpHizliArama);
            this.Controls.Add(this.grpBirebirArama);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSiparisID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSiparisler);
            this.Controls.Add(this.label1);
            this.Name = "GarsonSiparisIslemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garson Sipariş İşlem Formu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GarsonSiparisIslemForm_FormClosing);
            this.Load += new System.EventHandler(this.GarsonSiparisIslemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpBirebirArama.ResumeLayout(false);
            this.grpBirebirArama.PerformLayout();
            this.grpHizliArama.ResumeLayout(false);
            this.grpHizliArama.PerformLayout();
            this.grpAlanSecimi.ResumeLayout(false);
            this.grpAlanSecimi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSiparisler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSiparisID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuncelle;
        private System.Windows.Forms.ToolStripButton toolStripButtonIptalEt;
        private System.Windows.Forms.ToolStripButton toolStripButtonYenile;

        // Arama Kontrolleri Tanımlamaları
        private System.Windows.Forms.GroupBox grpBirebirArama;
        private System.Windows.Forms.Button btnBirebirAra;
        private System.Windows.Forms.CheckBox chkOdemeTipi;
        private System.Windows.Forms.TextBox txtBirebirOdemeTipi;
        private System.Windows.Forms.CheckBox chkToplamTutar;
        private System.Windows.Forms.TextBox txtBirebirToplamTutar;
        private System.Windows.Forms.CheckBox chkDurum;
        private System.Windows.Forms.TextBox txtBirebirDurum;

        private System.Windows.Forms.GroupBox grpHizliArama;
        private System.Windows.Forms.Label labelAramaTuru;
        private System.Windows.Forms.ComboBox cmbHizliAramaTuru;
        private System.Windows.Forms.GroupBox grpAlanSecimi;
        private System.Windows.Forms.RadioButton rdbOdemeTipi;
        private System.Windows.Forms.RadioButton rdbToplamTutar;
        private System.Windows.Forms.RadioButton rdbDurum;
        private System.Windows.Forms.Label lblHizliAramaDeger;
        private System.Windows.Forms.TextBox txtHizliAramaSecim;
    }
}