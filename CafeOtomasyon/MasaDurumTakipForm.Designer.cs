namespace CafeOtomasyon
{
    partial class MasaDurumTakipForm
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
            this.dgvMasalar = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonYenile = new System.Windows.Forms.ToolStripButton();

            // Arama Kontrolleri
            this.grpBirebirArama = new System.Windows.Forms.GroupBox();
            this.btnBirebirAra = new System.Windows.Forms.Button();
            this.txtBirebirKonum = new System.Windows.Forms.TextBox();
            this.chkKonum = new System.Windows.Forms.CheckBox();
            this.txtBirebirKapasite = new System.Windows.Forms.TextBox();
            this.chkKapasite = new System.Windows.Forms.CheckBox();
            this.txtBirebirMasaNo = new System.Windows.Forms.TextBox();
            this.chkMasaNo = new System.Windows.Forms.CheckBox();
            this.grpHizliArama = new System.Windows.Forms.GroupBox();
            this.txtHizliAramaSecim = new System.Windows.Forms.TextBox();
            this.lblHizliAramaDeger = new System.Windows.Forms.Label();
            this.grpAlanSecimi = new System.Windows.Forms.GroupBox();
            this.rdbKonum = new System.Windows.Forms.RadioButton();
            this.rdbKapasite = new System.Windows.Forms.RadioButton();
            this.rdbMasaNo = new System.Windows.Forms.RadioButton();
            this.cmbHizliAramaTuru = new System.Windows.Forms.ComboBox();
            this.labelAramaTuru = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvMasalar)).BeginInit();
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
            this.label1.TabIndex = 1;
            this.label1.Text = "MASA DURUM TAKİBİ";
            // 
            // dgvMasalar
            // 
            this.dgvMasalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMasalar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMasalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasalar.Location = new System.Drawing.Point(12, 270);
            this.dgvMasalar.Name = "dgvMasalar";
            this.dgvMasalar.RowHeadersWidth = 51;
            this.dgvMasalar.RowTemplate.Height = 24;
            this.dgvMasalar.Size = new System.Drawing.Size(1000, 250);
            this.dgvMasalar.TabIndex = 2;
            this.dgvMasalar.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonYenile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1036, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            this.grpBirebirArama.Controls.Add(this.txtBirebirKonum);
            this.grpBirebirArama.Controls.Add(this.chkKonum);
            this.grpBirebirArama.Controls.Add(this.txtBirebirKapasite);
            this.grpBirebirArama.Controls.Add(this.chkKapasite);
            this.grpBirebirArama.Controls.Add(this.txtBirebirMasaNo);
            this.grpBirebirArama.Controls.Add(this.chkMasaNo);
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
            // txtBirebirKonum
            // 
            this.txtBirebirKonum.Enabled = false;
            this.txtBirebirKonum.Location = new System.Drawing.Point(130, 98);
            this.txtBirebirKonum.Name = "txtBirebirKonum";
            this.txtBirebirKonum.Size = new System.Drawing.Size(130, 22);
            this.txtBirebirKonum.TabIndex = 3;
            // 
            // chkKonum
            // 
            this.chkKonum.AutoSize = true;
            this.chkKonum.Location = new System.Drawing.Point(20, 100);
            this.chkKonum.Name = "chkKonum";
            this.chkKonum.Size = new System.Drawing.Size(70, 20);
            this.chkKonum.TabIndex = 2;
            this.chkKonum.Text = "Konum";
            this.chkKonum.UseVisualStyleBackColor = true;
            this.chkKonum.CheckedChanged += new System.EventHandler(this.chkArama_CheckedChanged);
            // 
            // txtBirebirKapasite
            // 
            this.txtBirebirKapasite.Enabled = false;
            this.txtBirebirKapasite.Location = new System.Drawing.Point(130, 63);
            this.txtBirebirKapasite.Name = "txtBirebirKapasite";
            this.txtBirebirKapasite.Size = new System.Drawing.Size(130, 22);
            this.txtBirebirKapasite.TabIndex = 3;
            // 
            // chkKapasite
            // 
            this.chkKapasite.AutoSize = true;
            this.chkKapasite.Location = new System.Drawing.Point(20, 65);
            this.chkKapasite.Name = "chkKapasite";
            this.chkKapasite.Size = new System.Drawing.Size(82, 20);
            this.chkKapasite.TabIndex = 2;
            this.chkKapasite.Text = "Kapasite";
            this.chkKapasite.UseVisualStyleBackColor = true;
            this.chkKapasite.CheckedChanged += new System.EventHandler(this.chkArama_CheckedChanged);
            // 
            // txtBirebirMasaNo
            // 
            this.txtBirebirMasaNo.Enabled = false;
            this.txtBirebirMasaNo.Location = new System.Drawing.Point(130, 28);
            this.txtBirebirMasaNo.Name = "txtBirebirMasaNo";
            this.txtBirebirMasaNo.Size = new System.Drawing.Size(130, 22);
            this.txtBirebirMasaNo.TabIndex = 1;
            // 
            // chkMasaNo
            // 
            this.chkMasaNo.AutoSize = true;
            this.chkMasaNo.Location = new System.Drawing.Point(20, 30);
            this.chkMasaNo.Name = "chkMasaNo";
            this.chkMasaNo.Size = new System.Drawing.Size(84, 20);
            this.chkMasaNo.TabIndex = 0;
            this.chkMasaNo.Text = "Masa No";
            this.chkMasaNo.UseVisualStyleBackColor = true;
            this.chkMasaNo.CheckedChanged += new System.EventHandler(this.chkArama_CheckedChanged);
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
            this.txtHizliAramaSecim.Location = new System.Drawing.Point(100, 157);
            this.txtHizliAramaSecim.Name = "txtHizliAramaSecim";
            this.txtHizliAramaSecim.Size = new System.Drawing.Size(190, 22);
            this.txtHizliAramaSecim.TabIndex = 4;
            this.txtHizliAramaSecim.TextChanged += new System.EventHandler(this.txtHizliAramaSecim_TextChanged);
            // 
            // lblHizliAramaDeger
            // 
            this.lblHizliAramaDeger.AutoSize = true;
            this.lblHizliAramaDeger.Location = new System.Drawing.Point(15, 160);
            this.lblHizliAramaDeger.Name = "lblHizliAramaDeger";
            this.lblHizliAramaDeger.Size = new System.Drawing.Size(65, 16);
            this.lblHizliAramaDeger.TabIndex = 3;
            this.lblHizliAramaDeger.Text = "Masa No:";
            // 
            // grpAlanSecimi
            // 
            this.grpAlanSecimi.Controls.Add(this.rdbKonum);
            this.grpAlanSecimi.Controls.Add(this.rdbKapasite);
            this.grpAlanSecimi.Controls.Add(this.rdbMasaNo);
            this.grpAlanSecimi.Location = new System.Drawing.Point(18, 65);
            this.grpAlanSecimi.Name = "grpAlanSecimi";
            this.grpAlanSecimi.Size = new System.Drawing.Size(272, 80);
            this.grpAlanSecimi.TabIndex = 2;
            this.grpAlanSecimi.TabStop = false;
            this.grpAlanSecimi.Text = "Alan Seçimi";
            // 
            // rdbKonum
            // 
            this.rdbKonum.AutoSize = true;
            this.rdbKonum.Location = new System.Drawing.Point(15, 50);
            this.rdbKonum.Name = "rdbKonum";
            this.rdbKonum.Size = new System.Drawing.Size(69, 20);
            this.rdbKonum.TabIndex = 2;
            this.rdbKonum.Text = "Konum";
            this.rdbKonum.UseVisualStyleBackColor = true;
            this.rdbKonum.CheckedChanged += new System.EventHandler(this.HizliAramaRadio_CheckedChanged);
            // 
            // rdbKapasite
            // 
            this.rdbKapasite.AutoSize = true;
            this.rdbKapasite.Location = new System.Drawing.Point(135, 25);
            this.rdbKapasite.Name = "rdbKapasite";
            this.rdbKapasite.Size = new System.Drawing.Size(81, 20);
            this.rdbKapasite.TabIndex = 1;
            this.rdbKapasite.Text = "Kapasite";
            this.rdbKapasite.UseVisualStyleBackColor = true;
            this.rdbKapasite.CheckedChanged += new System.EventHandler(this.HizliAramaRadio_CheckedChanged);
            // 
            // rdbMasaNo
            // 
            this.rdbMasaNo.AutoSize = true;
            this.rdbMasaNo.Checked = true;
            this.rdbMasaNo.Location = new System.Drawing.Point(15, 25);
            this.rdbMasaNo.Name = "rdbMasaNo";
            this.rdbMasaNo.Size = new System.Drawing.Size(83, 20);
            this.rdbMasaNo.TabIndex = 0;
            this.rdbMasaNo.TabStop = true;
            this.rdbMasaNo.Text = "Masa No";
            this.rdbMasaNo.UseVisualStyleBackColor = true;
            this.rdbMasaNo.CheckedChanged += new System.EventHandler(this.HizliAramaRadio_CheckedChanged);
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
            // MasaDurumTakipForm
            // 
            this.ClientSize = new System.Drawing.Size(1036, 601);
            this.Controls.Add(this.grpHizliArama);
            this.Controls.Add(this.grpBirebirArama);
            this.Controls.Add(this.dgvMasalar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MasaDurumTakipForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masa Durum Takibi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MasaDurumTakipForm_FormClosing);
            this.Load += new System.EventHandler(this.MasaDurumTakipForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasalar)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvMasalar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonYenile;

        // Arama Kontrolleri
        private System.Windows.Forms.GroupBox grpBirebirArama;
        private System.Windows.Forms.Button btnBirebirAra;
        private System.Windows.Forms.CheckBox chkMasaNo;
        private System.Windows.Forms.TextBox txtBirebirMasaNo;
        private System.Windows.Forms.CheckBox chkKapasite;
        private System.Windows.Forms.TextBox txtBirebirKapasite;
        private System.Windows.Forms.CheckBox chkKonum;
        private System.Windows.Forms.TextBox txtBirebirKonum;

        private System.Windows.Forms.GroupBox grpHizliArama;
        private System.Windows.Forms.Label labelAramaTuru;
        private System.Windows.Forms.ComboBox cmbHizliAramaTuru;
        private System.Windows.Forms.GroupBox grpAlanSecimi;
        private System.Windows.Forms.RadioButton rdbMasaNo;
        private System.Windows.Forms.RadioButton rdbKapasite;
        private System.Windows.Forms.RadioButton rdbKonum;
        private System.Windows.Forms.Label lblHizliAramaDeger;
        private System.Windows.Forms.TextBox txtHizliAramaSecim;
    }
}