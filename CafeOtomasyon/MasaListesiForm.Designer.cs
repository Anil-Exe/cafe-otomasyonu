namespace CafeOtomasyon
{
    partial class MasaListesiForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelBaslik;
        private System.Windows.Forms.Label lblMasaNo;
        private System.Windows.Forms.Label lblKapasite;
        private System.Windows.Forms.Label lblKonum;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.TextBox txtMasaNo;
        private System.Windows.Forms.TextBox txtKapasite;
        private System.Windows.Forms.ComboBox cmbKonum;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.DataGridView dgvMasalar;
        private System.Windows.Forms.Label lblYildizMasaNo;
        private System.Windows.Forms.Label lblYildizKapasite;
        private System.Windows.Forms.Label lblYildizKonum;
        private System.Windows.Forms.Label lblYildizDurum;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEkle;
        private System.Windows.Forms.ToolStripButton toolStripButtonSil;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuncelle;
        private System.Windows.Forms.ToolStripButton toolStripButtonTemizle;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonTanimlamalar;
        private System.Windows.Forms.ToolStripMenuItem masaKonumTanimlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masaDurumTanimlamaToolStripMenuItem;

        // Arama Kontrolleri
        private System.Windows.Forms.GroupBox grpBirebirArama;
        private System.Windows.Forms.Button btnBirebirAra;
        private System.Windows.Forms.CheckBox chkKonum;
        private System.Windows.Forms.TextBox txtBirebirKonum;
        private System.Windows.Forms.CheckBox chkKapasite;
        private System.Windows.Forms.TextBox txtBirebirKapasite;

        private System.Windows.Forms.GroupBox grpHizliArama;
        private System.Windows.Forms.Label labelAramaTuru;
        private System.Windows.Forms.ComboBox cmbHizliAramaTuru;
        private System.Windows.Forms.GroupBox grpAlanSecimi;
        private System.Windows.Forms.RadioButton rdbKonum;
        private System.Windows.Forms.RadioButton rdbKapasite;
        private System.Windows.Forms.Label lblHizliAramaDeger;
        private System.Windows.Forms.TextBox txtHizliAramaSecim;

        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonEkle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTemizle = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButtonTanimlamalar = new System.Windows.Forms.ToolStripDropDownButton();
            this.masaKonumTanimlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masaDurumTanimlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelBaslik = new System.Windows.Forms.Label();
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.lblKapasite = new System.Windows.Forms.Label();
            this.lblKonum = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.txtMasaNo = new System.Windows.Forms.TextBox();
            this.txtKapasite = new System.Windows.Forms.TextBox();
            this.cmbKonum = new System.Windows.Forms.ComboBox();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.dgvMasalar = new System.Windows.Forms.DataGridView();
            this.lblYildizMasaNo = new System.Windows.Forms.Label();
            this.lblYildizKapasite = new System.Windows.Forms.Label();
            this.lblYildizKonum = new System.Windows.Forms.Label();
            this.lblYildizDurum = new System.Windows.Forms.Label();

            this.grpBirebirArama = new System.Windows.Forms.GroupBox();
            this.btnBirebirAra = new System.Windows.Forms.Button();
            this.txtBirebirKonum = new System.Windows.Forms.TextBox();
            this.chkKonum = new System.Windows.Forms.CheckBox();
            this.txtBirebirKapasite = new System.Windows.Forms.TextBox();
            this.chkKapasite = new System.Windows.Forms.CheckBox();
            this.grpHizliArama = new System.Windows.Forms.GroupBox();
            this.txtHizliAramaSecim = new System.Windows.Forms.TextBox();
            this.lblHizliAramaDeger = new System.Windows.Forms.Label();
            this.grpAlanSecimi = new System.Windows.Forms.GroupBox();
            this.rdbKonum = new System.Windows.Forms.RadioButton();
            this.rdbKapasite = new System.Windows.Forms.RadioButton();
            this.cmbHizliAramaTuru = new System.Windows.Forms.ComboBox();
            this.labelAramaTuru = new System.Windows.Forms.Label();

            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasalar)).BeginInit();
            this.grpBirebirArama.SuspendLayout();
            this.grpHizliArama.SuspendLayout();
            this.grpAlanSecimi.SuspendLayout();
            this.SuspendLayout();

            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonEkle,
            this.toolStripButtonSil,
            this.toolStripButtonGuncelle,
            this.toolStripButtonTemizle,
            this.toolStripDropDownButtonTanimlamalar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1080, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";

            // 
            // toolStripButtonEkle vb. (Mevcut Butonlar)
            // 
            this.toolStripButtonEkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEkle.Name = "toolStripButtonEkle";
            this.toolStripButtonEkle.Size = new System.Drawing.Size(40, 24);
            this.toolStripButtonEkle.Text = "Ekle";
            this.toolStripButtonEkle.Click += new System.EventHandler(this.toolStripButtonEkle_Click);

            this.toolStripButtonSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSil.Name = "toolStripButtonSil";
            this.toolStripButtonSil.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonSil.Text = "Sil";
            this.toolStripButtonSil.Click += new System.EventHandler(this.toolStripButtonSil_Click);

            this.toolStripButtonGuncelle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonGuncelle.Name = "toolStripButtonGuncelle";
            this.toolStripButtonGuncelle.Size = new System.Drawing.Size(70, 24);
            this.toolStripButtonGuncelle.Text = "Güncelle";
            this.toolStripButtonGuncelle.Click += new System.EventHandler(this.toolStripButtonGuncelle_Click);

            this.toolStripButtonTemizle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonTemizle.Name = "toolStripButtonTemizle";
            this.toolStripButtonTemizle.Size = new System.Drawing.Size(64, 24);
            this.toolStripButtonTemizle.Text = "Temizle";
            this.toolStripButtonTemizle.Click += new System.EventHandler(this.toolStripButtonTemizle_Click);

            // 
            // toolStripDropDownButtonTanimlamalar
            // 
            this.toolStripDropDownButtonTanimlamalar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonTanimlamalar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masaKonumTanimlamaToolStripMenuItem,
            this.masaDurumTanimlamaToolStripMenuItem});
            this.toolStripDropDownButtonTanimlamalar.Name = "toolStripDropDownButtonTanimlamalar";
            this.toolStripDropDownButtonTanimlamalar.Size = new System.Drawing.Size(104, 24);
            this.toolStripDropDownButtonTanimlamalar.Text = "Tanımlamalar";
            // 
            // masaKonumTanimlamaToolStripMenuItem
            // 
            this.masaKonumTanimlamaToolStripMenuItem.Name = "masaKonumTanimlamaToolStripMenuItem";
            this.masaKonumTanimlamaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.masaKonumTanimlamaToolStripMenuItem.Text = "Masa Konum Tanımlama";
            this.masaKonumTanimlamaToolStripMenuItem.Click += new System.EventHandler(this.masaKonumTanimlamaToolStripMenuItem_Click);
            // 
            // masaDurumTanimlamaToolStripMenuItem
            // 
            this.masaDurumTanimlamaToolStripMenuItem.Name = "masaDurumTanimlamaToolStripMenuItem";
            this.masaDurumTanimlamaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.masaDurumTanimlamaToolStripMenuItem.Text = "Masa Durum Tanımlama";
            this.masaDurumTanimlamaToolStripMenuItem.Click += new System.EventHandler(this.masaDurumTanimlamaToolStripMenuItem_Click);

            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.labelBaslik);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 80);
            this.panel1.TabIndex = 1;

            // 
            // labelBaslik
            // 
            this.labelBaslik.AutoSize = true;
            this.labelBaslik.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelBaslik.ForeColor = System.Drawing.Color.White;
            this.labelBaslik.Location = new System.Drawing.Point(420, 25);
            this.labelBaslik.Name = "labelBaslik";
            this.labelBaslik.Size = new System.Drawing.Size(238, 31);
            this.labelBaslik.TabIndex = 0;
            this.labelBaslik.Text = "MASA DETAY LİSTESİ";

            // 
            // lblMasaNo, lblKapasite, lblKonum, lblDurum, txtMasaNo, vb. (Giriş Alanları)
            // 
            this.lblMasaNo.AutoSize = true;
            this.lblMasaNo.Location = new System.Drawing.Point(28, 129);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(62, 16);
            this.lblMasaNo.TabIndex = 2;
            this.lblMasaNo.Text = "Masa No";

            this.txtMasaNo.Location = new System.Drawing.Point(99, 126);
            this.txtMasaNo.Name = "txtMasaNo";
            this.txtMasaNo.Size = new System.Drawing.Size(111, 22);
            this.txtMasaNo.TabIndex = 0;

            this.lblYildizMasaNo.AutoSize = true;
            this.lblYildizMasaNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblYildizMasaNo.ForeColor = System.Drawing.Color.Red;
            this.lblYildizMasaNo.Location = new System.Drawing.Point(212, 124);
            this.lblYildizMasaNo.Name = "lblYildizMasaNo";
            this.lblYildizMasaNo.Size = new System.Drawing.Size(21, 28);
            this.lblYildizMasaNo.TabIndex = 11;
            this.lblYildizMasaNo.Text = "*";

            this.lblKapasite.AutoSize = true;
            this.lblKapasite.Location = new System.Drawing.Point(245, 129);
            this.lblKapasite.Name = "lblKapasite";
            this.lblKapasite.Size = new System.Drawing.Size(60, 16);
            this.lblKapasite.TabIndex = 3;
            this.lblKapasite.Text = "Kapasite";

            this.txtKapasite.Location = new System.Drawing.Point(315, 126);
            this.txtKapasite.Name = "txtKapasite";
            this.txtKapasite.Size = new System.Drawing.Size(93, 22);
            this.txtKapasite.TabIndex = 1;

            this.lblYildizKapasite.AutoSize = true;
            this.lblYildizKapasite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblYildizKapasite.ForeColor = System.Drawing.Color.Red;
            this.lblYildizKapasite.Location = new System.Drawing.Point(412, 124);
            this.lblYildizKapasite.Name = "lblYildizKapasite";
            this.lblYildizKapasite.Size = new System.Drawing.Size(21, 28);
            this.lblYildizKapasite.TabIndex = 12;
            this.lblYildizKapasite.Text = "*";

            this.lblKonum.AutoSize = true;
            this.lblKonum.Location = new System.Drawing.Point(444, 129);
            this.lblKonum.Name = "lblKonum";
            this.lblKonum.Size = new System.Drawing.Size(48, 16);
            this.lblKonum.TabIndex = 4;
            this.lblKonum.Text = "Konum";

            this.cmbKonum.FormattingEnabled = true;
            this.cmbKonum.Location = new System.Drawing.Point(507, 126);
            this.cmbKonum.Name = "cmbKonum";
            this.cmbKonum.Size = new System.Drawing.Size(139, 24);
            this.cmbKonum.TabIndex = 2;

            this.lblYildizKonum.AutoSize = true;
            this.lblYildizKonum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblYildizKonum.ForeColor = System.Drawing.Color.Red;
            this.lblYildizKonum.Location = new System.Drawing.Point(651, 123);
            this.lblYildizKonum.Name = "lblYildizKonum";
            this.lblYildizKonum.Size = new System.Drawing.Size(21, 28);
            this.lblYildizKonum.TabIndex = 13;
            this.lblYildizKonum.Text = "*";

            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(676, 129);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(46, 16);
            this.lblDurum.TabIndex = 5;
            this.lblDurum.Text = "Durum";

            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Location = new System.Drawing.Point(736, 126);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(121, 24);
            this.cmbDurum.TabIndex = 3;

            this.lblYildizDurum.AutoSize = true;
            this.lblYildizDurum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblYildizDurum.ForeColor = System.Drawing.Color.Red;
            this.lblYildizDurum.Location = new System.Drawing.Point(861, 123);
            this.lblYildizDurum.Name = "lblYildizDurum";
            this.lblYildizDurum.Size = new System.Drawing.Size(21, 28);
            this.lblYildizDurum.TabIndex = 14;
            this.lblYildizDurum.Text = "*";

            // 
            // grpBirebirArama
            // 
            this.grpBirebirArama.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.grpBirebirArama.Controls.Add(this.btnBirebirAra);
            this.grpBirebirArama.Controls.Add(this.txtBirebirKonum);
            this.grpBirebirArama.Controls.Add(this.chkKonum);
            this.grpBirebirArama.Controls.Add(this.txtBirebirKapasite);
            this.grpBirebirArama.Controls.Add(this.chkKapasite);
            this.grpBirebirArama.Location = new System.Drawing.Point(30, 180);
            this.grpBirebirArama.Name = "grpBirebirArama";
            this.grpBirebirArama.Size = new System.Drawing.Size(260, 150);
            this.grpBirebirArama.TabIndex = 15;
            this.grpBirebirArama.TabStop = false;
            this.grpBirebirArama.Text = "Birebir Arama";
            // 
            // btnBirebirAra
            // 
            this.btnBirebirAra.Location = new System.Drawing.Point(20, 100);
            this.btnBirebirAra.Name = "btnBirebirAra";
            this.btnBirebirAra.Size = new System.Drawing.Size(220, 35);
            this.btnBirebirAra.TabIndex = 4;
            this.btnBirebirAra.Text = "Ara";
            this.btnBirebirAra.UseVisualStyleBackColor = true;
            this.btnBirebirAra.Click += new System.EventHandler(this.btnBirebirAra_Click);
            // 
            // txtBirebirKonum
            // 
            this.txtBirebirKonum.Enabled = false;
            this.txtBirebirKonum.Location = new System.Drawing.Point(110, 63);
            this.txtBirebirKonum.Name = "txtBirebirKonum";
            this.txtBirebirKonum.Size = new System.Drawing.Size(130, 22);
            this.txtBirebirKonum.TabIndex = 3;
            // 
            // chkKonum
            // 
            this.chkKonum.AutoSize = true;
            this.chkKonum.Location = new System.Drawing.Point(20, 65);
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
            this.txtBirebirKapasite.Location = new System.Drawing.Point(110, 28);
            this.txtBirebirKapasite.Name = "txtBirebirKapasite";
            this.txtBirebirKapasite.Size = new System.Drawing.Size(130, 22);
            this.txtBirebirKapasite.TabIndex = 1;
            // 
            // chkKapasite
            // 
            this.chkKapasite.AutoSize = true;
            this.chkKapasite.Location = new System.Drawing.Point(20, 30);
            this.chkKapasite.Name = "chkKapasite";
            this.chkKapasite.Size = new System.Drawing.Size(82, 20);
            this.chkKapasite.TabIndex = 0;
            this.chkKapasite.Text = "Kapasite";
            this.chkKapasite.UseVisualStyleBackColor = true;
            this.chkKapasite.CheckedChanged += new System.EventHandler(this.chkArama_CheckedChanged);

            // 
            // grpHizliArama
            // 
            this.grpHizliArama.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.grpHizliArama.Controls.Add(this.txtHizliAramaSecim);
            this.grpHizliArama.Controls.Add(this.lblHizliAramaDeger);
            this.grpHizliArama.Controls.Add(this.grpAlanSecimi);
            this.grpHizliArama.Controls.Add(this.cmbHizliAramaTuru);
            this.grpHizliArama.Controls.Add(this.labelAramaTuru);
            this.grpHizliArama.Location = new System.Drawing.Point(315, 180);
            this.grpHizliArama.Name = "grpHizliArama";
            this.grpHizliArama.Size = new System.Drawing.Size(300, 150);
            this.grpHizliArama.TabIndex = 16;
            this.grpHizliArama.TabStop = false;
            this.grpHizliArama.Text = "Hızlı Arama";
            // 
            // txtHizliAramaSecim
            // 
            this.txtHizliAramaSecim.Location = new System.Drawing.Point(90, 115);
            this.txtHizliAramaSecim.Name = "txtHizliAramaSecim";
            this.txtHizliAramaSecim.Size = new System.Drawing.Size(190, 22);
            this.txtHizliAramaSecim.TabIndex = 4;
            this.txtHizliAramaSecim.TextChanged += new System.EventHandler(this.txtHizliAramaSecim_TextChanged);
            // 
            // lblHizliAramaDeger
            // 
            this.lblHizliAramaDeger.AutoSize = true;
            this.lblHizliAramaDeger.Location = new System.Drawing.Point(15, 118);
            this.lblHizliAramaDeger.Name = "lblHizliAramaDeger";
            this.lblHizliAramaDeger.Size = new System.Drawing.Size(63, 16);
            this.lblHizliAramaDeger.TabIndex = 3;
            this.lblHizliAramaDeger.Text = "Kapasite:";
            // 
            // grpAlanSecimi
            // 
            this.grpAlanSecimi.Controls.Add(this.rdbKonum);
            this.grpAlanSecimi.Controls.Add(this.rdbKapasite);
            this.grpAlanSecimi.Location = new System.Drawing.Point(15, 55);
            this.grpAlanSecimi.Name = "grpAlanSecimi";
            this.grpAlanSecimi.Size = new System.Drawing.Size(265, 50);
            this.grpAlanSecimi.TabIndex = 2;
            this.grpAlanSecimi.TabStop = false;
            this.grpAlanSecimi.Text = "Alan Seçimi";
            // 
            // rdbKonum
            // 
            this.rdbKonum.AutoSize = true;
            this.rdbKonum.Location = new System.Drawing.Point(120, 20);
            this.rdbKonum.Name = "rdbKonum";
            this.rdbKonum.Size = new System.Drawing.Size(69, 20);
            this.rdbKonum.TabIndex = 1;
            this.rdbKonum.Text = "Konum";
            this.rdbKonum.UseVisualStyleBackColor = true;
            this.rdbKonum.CheckedChanged += new System.EventHandler(this.HizliAramaRadio_CheckedChanged);
            // 
            // rdbKapasite
            // 
            this.rdbKapasite.AutoSize = true;
            this.rdbKapasite.Checked = true;
            this.rdbKapasite.Location = new System.Drawing.Point(15, 20);
            this.rdbKapasite.Name = "rdbKapasite";
            this.rdbKapasite.Size = new System.Drawing.Size(81, 20);
            this.rdbKapasite.TabIndex = 0;
            this.rdbKapasite.TabStop = true;
            this.rdbKapasite.Text = "Kapasite";
            this.rdbKapasite.UseVisualStyleBackColor = true;
            this.rdbKapasite.CheckedChanged += new System.EventHandler(this.HizliAramaRadio_CheckedChanged);
            // 
            // cmbHizliAramaTuru
            // 
            this.cmbHizliAramaTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHizliAramaTuru.FormattingEnabled = true;
            this.cmbHizliAramaTuru.Items.AddRange(new object[] {
            "İçeren",
            "İle Başlayan",
            "Birebir Eşleşen"});
            this.cmbHizliAramaTuru.Location = new System.Drawing.Point(100, 22);
            this.cmbHizliAramaTuru.Name = "cmbHizliAramaTuru";
            this.cmbHizliAramaTuru.Size = new System.Drawing.Size(180, 24);
            this.cmbHizliAramaTuru.TabIndex = 1;
            // 
            // labelAramaTuru
            // 
            this.labelAramaTuru.AutoSize = true;
            this.labelAramaTuru.Location = new System.Drawing.Point(15, 25);
            this.labelAramaTuru.Name = "labelAramaTuru";
            this.labelAramaTuru.Size = new System.Drawing.Size(77, 16);
            this.labelAramaTuru.TabIndex = 0;
            this.labelAramaTuru.Text = "Arama Türü";

            // 
            // dgvMasalar
            // 
            this.dgvMasalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMasalar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMasalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasalar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMasalar.Location = new System.Drawing.Point(0, 350);
            this.dgvMasalar.Name = "dgvMasalar";
            this.dgvMasalar.RowHeadersWidth = 51;
            this.dgvMasalar.RowTemplate.Height = 24;
            this.dgvMasalar.Size = new System.Drawing.Size(1080, 251);
            this.dgvMasalar.TabIndex = 10;
            this.dgvMasalar.TabStop = false;

            // 
            // MasaListesiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 601);
            this.Controls.Add(this.grpHizliArama);
            this.Controls.Add(this.grpBirebirArama);
            this.Controls.Add(this.lblYildizDurum);
            this.Controls.Add(this.lblYildizKonum);
            this.Controls.Add(this.lblYildizKapasite);
            this.Controls.Add(this.lblYildizMasaNo);
            this.Controls.Add(this.dgvMasalar);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.cmbKonum);
            this.Controls.Add(this.txtKapasite);
            this.Controls.Add(this.txtMasaNo);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblKonum);
            this.Controls.Add(this.lblKapasite);
            this.Controls.Add(this.lblMasaNo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MasaListesiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masa Listesi Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MasaListesiForm_FormClosing);
            this.Load += new System.EventHandler(this.MasaListesiForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasalar)).EndInit();
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