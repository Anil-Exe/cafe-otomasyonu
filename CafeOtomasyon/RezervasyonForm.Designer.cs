namespace CafeOtomasyon
{
    partial class RezervasyonForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEkle;
        private System.Windows.Forms.ToolStripButton toolStripButtonSil;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuncelle;
        private System.Windows.Forms.ToolStripButton toolStripButtonTemizle;
        private System.Windows.Forms.TextBox txtMusteriAdi;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtMasaID;
        private System.Windows.Forms.TextBox txtKisiSayisi;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.DateTimePicker dtpRezervasyonTarihi;
        private System.Windows.Forms.DataGridView dgvRezervasyon;
        private System.Windows.Forms.Label lblMusteriAdi;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblMasaID;
        private System.Windows.Forms.Label lblKisiSayisi;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblAciklama;

        // Arama Kontrolleri
        private System.Windows.Forms.GroupBox grpBirebirArama;
        private System.Windows.Forms.Button btnBirebirAra;
        private System.Windows.Forms.CheckBox chkMusteriAdi;
        private System.Windows.Forms.TextBox txtBirebirMusteriAdi;
        private System.Windows.Forms.CheckBox chkTelefon;
        private System.Windows.Forms.TextBox txtBirebirTelefon;
        private System.Windows.Forms.CheckBox chkDurum;
        private System.Windows.Forms.TextBox txtBirebirDurum;
        private System.Windows.Forms.CheckBox chkTarih;
        private System.Windows.Forms.TextBox txtBirebirTarih;

        private System.Windows.Forms.GroupBox grpHizliArama;
        private System.Windows.Forms.Label labelAramaTuru;
        private System.Windows.Forms.ComboBox cmbHizliAramaTuru;
        private System.Windows.Forms.GroupBox grpAlanSecimi;
        private System.Windows.Forms.RadioButton rdbMusteriAdi;
        private System.Windows.Forms.RadioButton rdbTelefon;
        private System.Windows.Forms.RadioButton rdbDurum;
        private System.Windows.Forms.RadioButton rdbTarih;
        private System.Windows.Forms.Label lblHizliAramaDeger;
        private System.Windows.Forms.TextBox txtHizliAramaSecim;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonEkle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTemizle = new System.Windows.Forms.ToolStripButton();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtMasaID = new System.Windows.Forms.TextBox();
            this.txtKisiSayisi = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.dtpRezervasyonTarihi = new System.Windows.Forms.DateTimePicker();
            this.dgvRezervasyon = new System.Windows.Forms.DataGridView();
            this.lblMusteriAdi = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblMasaID = new System.Windows.Forms.Label();
            this.lblKisiSayisi = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();

            this.grpBirebirArama = new System.Windows.Forms.GroupBox();
            this.btnBirebirAra = new System.Windows.Forms.Button();
            this.chkMusteriAdi = new System.Windows.Forms.CheckBox();
            this.txtBirebirMusteriAdi = new System.Windows.Forms.TextBox();
            this.chkTelefon = new System.Windows.Forms.CheckBox();
            this.txtBirebirTelefon = new System.Windows.Forms.TextBox();
            this.chkDurum = new System.Windows.Forms.CheckBox();
            this.txtBirebirDurum = new System.Windows.Forms.TextBox();
            this.chkTarih = new System.Windows.Forms.CheckBox();
            this.txtBirebirTarih = new System.Windows.Forms.TextBox();

            this.grpHizliArama = new System.Windows.Forms.GroupBox();
            this.txtHizliAramaSecim = new System.Windows.Forms.TextBox();
            this.lblHizliAramaDeger = new System.Windows.Forms.Label();
            this.grpAlanSecimi = new System.Windows.Forms.GroupBox();
            this.rdbMusteriAdi = new System.Windows.Forms.RadioButton();
            this.rdbTelefon = new System.Windows.Forms.RadioButton();
            this.rdbDurum = new System.Windows.Forms.RadioButton();
            this.rdbTarih = new System.Windows.Forms.RadioButton();
            this.cmbHizliAramaTuru = new System.Windows.Forms.ComboBox();
            this.labelAramaTuru = new System.Windows.Forms.Label();

            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervasyon)).BeginInit();
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
            this.toolStripButtonTemizle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1150, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";

            // 
            // toolStripButtonEkle vb. Butonlar
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
            // Giriş Alanları
            // 
            this.lblMusteriAdi.AutoSize = true;
            this.lblMusteriAdi.Location = new System.Drawing.Point(20, 45);
            this.lblMusteriAdi.Name = "lblMusteriAdi";
            this.lblMusteriAdi.Size = new System.Drawing.Size(73, 16);
            this.lblMusteriAdi.TabIndex = 1;
            this.lblMusteriAdi.Text = "Müşteri Adı";

            this.txtMusteriAdi.Location = new System.Drawing.Point(100, 42);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(180, 22);
            this.txtMusteriAdi.TabIndex = 0;

            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(300, 45);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(53, 16);
            this.lblTelefon.TabIndex = 3;
            this.lblTelefon.Text = "Telefon";

            this.txtTelefon.Location = new System.Drawing.Point(365, 42);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(150, 22);
            this.txtTelefon.TabIndex = 1;

            this.lblMasaID.AutoSize = true;
            this.lblMasaID.Location = new System.Drawing.Point(20, 80);
            this.lblMasaID.Name = "lblMasaID";
            this.lblMasaID.Size = new System.Drawing.Size(57, 16);
            this.lblMasaID.TabIndex = 5;
            this.lblMasaID.Text = "Masa ID";

            this.txtMasaID.Location = new System.Drawing.Point(100, 77);
            this.txtMasaID.Name = "txtMasaID";
            this.txtMasaID.Size = new System.Drawing.Size(100, 22);
            this.txtMasaID.TabIndex = 2;
            this.txtMasaID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMasaID_KeyPress);

            this.lblKisiSayisi.AutoSize = true;
            this.lblKisiSayisi.Location = new System.Drawing.Point(220, 80);
            this.lblKisiSayisi.Name = "lblKisiSayisi";
            this.lblKisiSayisi.Size = new System.Drawing.Size(68, 16);
            this.lblKisiSayisi.TabIndex = 7;
            this.lblKisiSayisi.Text = "Kişi Sayısı";

            this.txtKisiSayisi.Location = new System.Drawing.Point(295, 77);
            this.txtKisiSayisi.Name = "txtKisiSayisi";
            this.txtKisiSayisi.Size = new System.Drawing.Size(80, 22);
            this.txtKisiSayisi.TabIndex = 3;
            this.txtKisiSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKisiSayisi_KeyPress);

            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(390, 80);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(38, 16);
            this.lblTarih.TabIndex = 9;
            this.lblTarih.Text = "Tarih";

            this.dtpRezervasyonTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRezervasyonTarihi.Location = new System.Drawing.Point(435, 77);
            this.dtpRezervasyonTarihi.Name = "dtpRezervasyonTarihi";
            this.dtpRezervasyonTarihi.Size = new System.Drawing.Size(120, 22);
            this.dtpRezervasyonTarihi.TabIndex = 4;

            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(20, 115);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(46, 16);
            this.lblDurum.TabIndex = 11;
            this.lblDurum.Text = "Durum";

            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Location = new System.Drawing.Point(100, 112);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(150, 24);
            this.cmbDurum.TabIndex = 5;

            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(270, 115);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(63, 16);
            this.lblAciklama.TabIndex = 13;
            this.lblAciklama.Text = "Açıklama";

            this.txtAciklama.Location = new System.Drawing.Point(335, 112);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(220, 22);
            this.txtAciklama.TabIndex = 6;

            // 
            // grpBirebirArama
            // 
            this.grpBirebirArama.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.grpBirebirArama.Controls.Add(this.btnBirebirAra);
            this.grpBirebirArama.Controls.Add(this.txtBirebirTarih);
            this.grpBirebirArama.Controls.Add(this.chkTarih);
            this.grpBirebirArama.Controls.Add(this.txtBirebirDurum);
            this.grpBirebirArama.Controls.Add(this.chkDurum);
            this.grpBirebirArama.Controls.Add(this.txtBirebirTelefon);
            this.grpBirebirArama.Controls.Add(this.chkTelefon);
            this.grpBirebirArama.Controls.Add(this.txtBirebirMusteriAdi);
            this.grpBirebirArama.Controls.Add(this.chkMusteriAdi);
            this.grpBirebirArama.Location = new System.Drawing.Point(580, 40);
            this.grpBirebirArama.Name = "grpBirebirArama";
            this.grpBirebirArama.Size = new System.Drawing.Size(240, 200);
            this.grpBirebirArama.TabIndex = 14;
            this.grpBirebirArama.TabStop = false;
            this.grpBirebirArama.Text = "Birebir Arama";
            // 
            // chkMusteriAdi
            // 
            this.chkMusteriAdi.AutoSize = true;
            this.chkMusteriAdi.Location = new System.Drawing.Point(15, 30);
            this.chkMusteriAdi.Name = "chkMusteriAdi";
            this.chkMusteriAdi.Size = new System.Drawing.Size(95, 20);
            this.chkMusteriAdi.TabIndex = 0;
            this.chkMusteriAdi.Text = "Müşteri Adı";
            this.chkMusteriAdi.UseVisualStyleBackColor = true;
            this.chkMusteriAdi.CheckedChanged += new System.EventHandler(this.chkArama_CheckedChanged);
            // 
            // txtBirebirMusteriAdi
            // 
            this.txtBirebirMusteriAdi.Enabled = false;
            this.txtBirebirMusteriAdi.Location = new System.Drawing.Point(120, 28);
            this.txtBirebirMusteriAdi.Name = "txtBirebirMusteriAdi";
            this.txtBirebirMusteriAdi.Size = new System.Drawing.Size(105, 22);
            this.txtBirebirMusteriAdi.TabIndex = 1;
            // 
            // chkTelefon
            // 
            this.chkTelefon.AutoSize = true;
            this.chkTelefon.Location = new System.Drawing.Point(15, 60);
            this.chkTelefon.Name = "chkTelefon";
            this.chkTelefon.Size = new System.Drawing.Size(75, 20);
            this.chkTelefon.TabIndex = 2;
            this.chkTelefon.Text = "Telefon";
            this.chkTelefon.UseVisualStyleBackColor = true;
            this.chkTelefon.CheckedChanged += new System.EventHandler(this.chkArama_CheckedChanged);
            // 
            // txtBirebirTelefon
            // 
            this.txtBirebirTelefon.Enabled = false;
            this.txtBirebirTelefon.Location = new System.Drawing.Point(120, 58);
            this.txtBirebirTelefon.Name = "txtBirebirTelefon";
            this.txtBirebirTelefon.Size = new System.Drawing.Size(105, 22);
            this.txtBirebirTelefon.TabIndex = 3;
            // 
            // chkDurum
            // 
            this.chkDurum.AutoSize = true;
            this.chkDurum.Location = new System.Drawing.Point(15, 90);
            this.chkDurum.Name = "chkDurum";
            this.chkDurum.Size = new System.Drawing.Size(68, 20);
            this.chkDurum.TabIndex = 4;
            this.chkDurum.Text = "Durum";
            this.chkDurum.UseVisualStyleBackColor = true;
            this.chkDurum.CheckedChanged += new System.EventHandler(this.chkArama_CheckedChanged);
            // 
            // txtBirebirDurum
            // 
            this.txtBirebirDurum.Enabled = false;
            this.txtBirebirDurum.Location = new System.Drawing.Point(120, 88);
            this.txtBirebirDurum.Name = "txtBirebirDurum";
            this.txtBirebirDurum.Size = new System.Drawing.Size(105, 22);
            this.txtBirebirDurum.TabIndex = 5;
            // 
            // chkTarih
            // 
            this.chkTarih.AutoSize = true;
            this.chkTarih.Location = new System.Drawing.Point(15, 120);
            this.chkTarih.Name = "chkTarih";
            this.chkTarih.Size = new System.Drawing.Size(60, 20);
            this.chkTarih.TabIndex = 6;
            this.chkTarih.Text = "Tarih";
            this.chkTarih.UseVisualStyleBackColor = true;
            this.chkTarih.CheckedChanged += new System.EventHandler(this.chkArama_CheckedChanged);
            // 
            // txtBirebirTarih
            // 
            this.txtBirebirTarih.Enabled = false;
            this.txtBirebirTarih.Location = new System.Drawing.Point(120, 118);
            this.txtBirebirTarih.Name = "txtBirebirTarih";
            this.txtBirebirTarih.Size = new System.Drawing.Size(105, 22);
            this.txtBirebirTarih.TabIndex = 7;
            // 
            // btnBirebirAra
            // 
            this.btnBirebirAra.Location = new System.Drawing.Point(15, 155);
            this.btnBirebirAra.Name = "btnBirebirAra";
            this.btnBirebirAra.Size = new System.Drawing.Size(210, 30);
            this.btnBirebirAra.TabIndex = 8;
            this.btnBirebirAra.Text = "Ara";
            this.btnBirebirAra.UseVisualStyleBackColor = true;
            this.btnBirebirAra.Click += new System.EventHandler(this.btnBirebirAra_Click);

            // 
            // grpHizliArama
            // 
            this.grpHizliArama.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.grpHizliArama.Controls.Add(this.txtHizliAramaSecim);
            this.grpHizliArama.Controls.Add(this.lblHizliAramaDeger);
            this.grpHizliArama.Controls.Add(this.grpAlanSecimi);
            this.grpHizliArama.Controls.Add(this.cmbHizliAramaTuru);
            this.grpHizliArama.Controls.Add(this.labelAramaTuru);
            this.grpHizliArama.Location = new System.Drawing.Point(835, 40);
            this.grpHizliArama.Name = "grpHizliArama";
            this.grpHizliArama.Size = new System.Drawing.Size(295, 200);
            this.grpHizliArama.TabIndex = 15;
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
            this.grpAlanSecimi.Controls.Add(this.rdbTarih);
            this.grpAlanSecimi.Controls.Add(this.rdbDurum);
            this.grpAlanSecimi.Controls.Add(this.rdbTelefon);
            this.grpAlanSecimi.Controls.Add(this.rdbMusteriAdi);
            this.grpAlanSecimi.Location = new System.Drawing.Point(15, 60);
            this.grpAlanSecimi.Name = "grpAlanSecimi";
            this.grpAlanSecimi.Size = new System.Drawing.Size(265, 80);
            this.grpAlanSecimi.TabIndex = 2;
            this.grpAlanSecimi.TabStop = false;
            this.grpAlanSecimi.Text = "Alan Seçimi";
            // 
            // rdbMusteriAdi
            // 
            this.rdbMusteriAdi.AutoSize = true;
            this.rdbMusteriAdi.Checked = true;
            this.rdbMusteriAdi.Location = new System.Drawing.Point(10, 20);
            this.rdbMusteriAdi.Name = "rdbMusteriAdi";
            this.rdbMusteriAdi.Size = new System.Drawing.Size(94, 20);
            this.rdbMusteriAdi.TabIndex = 0;
            this.rdbMusteriAdi.TabStop = true;
            this.rdbMusteriAdi.Text = "Müşteri Adı";
            this.rdbMusteriAdi.UseVisualStyleBackColor = true;
            this.rdbMusteriAdi.CheckedChanged += new System.EventHandler(this.HizliAramaRadio_CheckedChanged);
            // 
            // rdbTelefon
            // 
            this.rdbTelefon.AutoSize = true;
            this.rdbTelefon.Location = new System.Drawing.Point(140, 20);
            this.rdbTelefon.Name = "rdbTelefon";
            this.rdbTelefon.Size = new System.Drawing.Size(74, 20);
            this.rdbTelefon.TabIndex = 1;
            this.rdbTelefon.Text = "Telefon";
            this.rdbTelefon.UseVisualStyleBackColor = true;
            this.rdbTelefon.CheckedChanged += new System.EventHandler(this.HizliAramaRadio_CheckedChanged);
            // 
            // rdbDurum
            // 
            this.rdbDurum.AutoSize = true;
            this.rdbDurum.Location = new System.Drawing.Point(10, 45);
            this.rdbDurum.Name = "rdbDurum";
            this.rdbDurum.Size = new System.Drawing.Size(67, 20);
            this.rdbDurum.TabIndex = 2;
            this.rdbDurum.Text = "Durum";
            this.rdbDurum.UseVisualStyleBackColor = true;
            this.rdbDurum.CheckedChanged += new System.EventHandler(this.HizliAramaRadio_CheckedChanged);
            // 
            // rdbTarih
            // 
            this.rdbTarih.AutoSize = true;
            this.rdbTarih.Location = new System.Drawing.Point(140, 45);
            this.rdbTarih.Name = "rdbTarih";
            this.rdbTarih.Size = new System.Drawing.Size(59, 20);
            this.rdbTarih.TabIndex = 3;
            this.rdbTarih.Text = "Tarih";
            this.rdbTarih.UseVisualStyleBackColor = true;
            this.rdbTarih.CheckedChanged += new System.EventHandler(this.HizliAramaRadio_CheckedChanged);
            // 
            // lblHizliAramaDeger
            // 
            this.lblHizliAramaDeger.AutoSize = true;
            this.lblHizliAramaDeger.Location = new System.Drawing.Point(15, 155);
            this.lblHizliAramaDeger.Name = "lblHizliAramaDeger";
            this.lblHizliAramaDeger.Size = new System.Drawing.Size(76, 16);
            this.lblHizliAramaDeger.TabIndex = 3;
            this.lblHizliAramaDeger.Text = "Müşteri Adı:";
            // 
            // txtHizliAramaSecim
            // 
            this.txtHizliAramaSecim.Location = new System.Drawing.Point(100, 152);
            this.txtHizliAramaSecim.Name = "txtHizliAramaSecim";
            this.txtHizliAramaSecim.Size = new System.Drawing.Size(180, 22);
            this.txtHizliAramaSecim.TabIndex = 4;
            this.txtHizliAramaSecim.TextChanged += new System.EventHandler(this.txtHizliAramaSecim_TextChanged);

            // 
            // dgvRezervasyon
            // 
            this.dgvRezervasyon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRezervasyon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRezervasyon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRezervasyon.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRezervasyon.Location = new System.Drawing.Point(12, 260);
            this.dgvRezervasyon.Name = "dgvRezervasyon";
            this.dgvRezervasyon.RowHeadersWidth = 51;
            this.dgvRezervasyon.RowTemplate.Height = 24;
            this.dgvRezervasyon.Size = new System.Drawing.Size(1118, 300);
            this.dgvRezervasyon.TabIndex = 16;
            this.dgvRezervasyon.TabStop = false;
            this.dgvRezervasyon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRezervasyon_CellClick);

            // 
            // RezervasyonForm
            // 
            this.ClientSize = new System.Drawing.Size(1150, 580);
            this.Controls.Add(this.grpHizliArama);
            this.Controls.Add(this.grpBirebirArama);
            this.Controls.Add(this.dgvRezervasyon);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.dtpRezervasyonTarihi);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.txtKisiSayisi);
            this.Controls.Add(this.lblKisiSayisi);
            this.Controls.Add(this.txtMasaID);
            this.Controls.Add(this.lblMasaID);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtMusteriAdi);
            this.Controls.Add(this.lblMusteriAdi);
            this.Controls.Add(this.toolStrip1);
            this.Name = "RezervasyonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervasyon Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RezervasyonForm_FormClosing);
            this.Load += new System.EventHandler(this.RezervasyonForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervasyon)).EndInit();
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