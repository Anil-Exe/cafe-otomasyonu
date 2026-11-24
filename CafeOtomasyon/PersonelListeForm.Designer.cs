namespace CafeOtomasyon
{
    partial class PersonelListeForm
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
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonTanimlamalar;
        private System.Windows.Forms.ToolStripMenuItem personelRolTanimlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonRaporlar;
        private System.Windows.Forms.ToolStripMenuItem personelRaporuToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Label lblTcNo;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblIseGirisTarihi;
        private System.Windows.Forms.DateTimePicker dtpIseGirisTarihi;
        private System.Windows.Forms.Label lblAktifMi;
        private System.Windows.Forms.CheckBox chkAktifMi;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.DataGridView dgvPersonel;
        private System.Windows.Forms.Label lblYildizAdSoyad;
        private System.Windows.Forms.Label lblYildizSifre;
        private System.Windows.Forms.Label lblYildizRol;
        private System.Windows.Forms.Label lblYildizMaas;
        private System.Windows.Forms.Label lblYildizTcNo;
        private System.Windows.Forms.Label lblYildizTelefon;
        private System.Windows.Forms.Label lblYildizAdres;

        // Arama Kontrolleri
        private System.Windows.Forms.GroupBox grpBirebirArama;
        private System.Windows.Forms.Button btnBirebirAra;
        private System.Windows.Forms.CheckBox chkAdSoyad;
        private System.Windows.Forms.TextBox txtBirebirAdSoyad;
        private System.Windows.Forms.CheckBox chkMaas;
        private System.Windows.Forms.TextBox txtBirebirMaas;
        private System.Windows.Forms.CheckBox chkTcNo;
        private System.Windows.Forms.TextBox txtBirebirTcNo;

        private System.Windows.Forms.GroupBox grpHizliArama;
        private System.Windows.Forms.Label labelAramaTuru;
        private System.Windows.Forms.ComboBox cmbHizliAramaTuru;
        private System.Windows.Forms.GroupBox grpAlanSecimi;
        private System.Windows.Forms.RadioButton rdbAdSoyad;
        private System.Windows.Forms.RadioButton rdbMaas;
        private System.Windows.Forms.RadioButton rdbTcNo;
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
            this.toolStripDropDownButtonTanimlamalar = new System.Windows.Forms.ToolStripDropDownButton();
            this.personelRolTanimlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonRaporlar = new System.Windows.Forms.ToolStripDropDownButton();
            this.personelRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblMaas = new System.Windows.Forms.Label();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.lblTcNo = new System.Windows.Forms.Label();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblIseGirisTarihi = new System.Windows.Forms.Label();
            this.dtpIseGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblAktifMi = new System.Windows.Forms.Label();
            this.chkAktifMi = new System.Windows.Forms.CheckBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.dgvPersonel = new System.Windows.Forms.DataGridView();
            this.lblYildizAdSoyad = new System.Windows.Forms.Label();
            this.lblYildizSifre = new System.Windows.Forms.Label();
            this.lblYildizRol = new System.Windows.Forms.Label();
            this.lblYildizMaas = new System.Windows.Forms.Label();
            this.lblYildizTcNo = new System.Windows.Forms.Label();
            this.lblYildizTelefon = new System.Windows.Forms.Label();
            this.lblYildizAdres = new System.Windows.Forms.Label();

            this.grpBirebirArama = new System.Windows.Forms.GroupBox();
            this.btnBirebirAra = new System.Windows.Forms.Button();
            this.txtBirebirAdSoyad = new System.Windows.Forms.TextBox();
            this.chkAdSoyad = new System.Windows.Forms.CheckBox();
            this.txtBirebirMaas = new System.Windows.Forms.TextBox();
            this.chkMaas = new System.Windows.Forms.CheckBox();
            this.txtBirebirTcNo = new System.Windows.Forms.TextBox();
            this.chkTcNo = new System.Windows.Forms.CheckBox();

            this.grpHizliArama = new System.Windows.Forms.GroupBox();
            this.txtHizliAramaSecim = new System.Windows.Forms.TextBox();
            this.lblHizliAramaDeger = new System.Windows.Forms.Label();
            this.grpAlanSecimi = new System.Windows.Forms.GroupBox();
            this.rdbAdSoyad = new System.Windows.Forms.RadioButton();
            this.rdbMaas = new System.Windows.Forms.RadioButton();
            this.rdbTcNo = new System.Windows.Forms.RadioButton();
            this.cmbHizliAramaTuru = new System.Windows.Forms.ComboBox();
            this.labelAramaTuru = new System.Windows.Forms.Label();

            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).BeginInit();
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
            this.toolStripDropDownButtonTanimlamalar,
            this.toolStripDropDownButtonRaporlar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1200, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";

            // 
            // toolStripButtonEkle
            // 
            this.toolStripButtonEkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEkle.Name = "toolStripButtonEkle";
            this.toolStripButtonEkle.Size = new System.Drawing.Size(40, 24);
            this.toolStripButtonEkle.Text = "Ekle";
            this.toolStripButtonEkle.Click += new System.EventHandler(this.toolStripButtonEkle_Click);

            // 
            // toolStripButtonSil
            // 
            this.toolStripButtonSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSil.Name = "toolStripButtonSil";
            this.toolStripButtonSil.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonSil.Text = "Sil";
            this.toolStripButtonSil.Click += new System.EventHandler(this.toolStripButtonSil_Click);

            // 
            // toolStripButtonGuncelle
            // 
            this.toolStripButtonGuncelle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonGuncelle.Name = "toolStripButtonGuncelle";
            this.toolStripButtonGuncelle.Size = new System.Drawing.Size(70, 24);
            this.toolStripButtonGuncelle.Text = "Güncelle";
            this.toolStripButtonGuncelle.Click += new System.EventHandler(this.toolStripButtonGuncelle_Click);

            // 
            // toolStripButtonTemizle
            // 
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
            this.personelRolTanimlamaToolStripMenuItem});
            this.toolStripDropDownButtonTanimlamalar.Name = "toolStripDropDownButtonTanimlamalar";
            this.toolStripDropDownButtonTanimlamalar.Size = new System.Drawing.Size(104, 24);
            this.toolStripDropDownButtonTanimlamalar.Text = "Tanımlamalar";
            // 
            // personelRolTanimlamaToolStripMenuItem
            // 
            this.personelRolTanimlamaToolStripMenuItem.Name = "personelRolTanimlamaToolStripMenuItem";
            this.personelRolTanimlamaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.personelRolTanimlamaToolStripMenuItem.Text = "Personel Rol Tanımlama";
            this.personelRolTanimlamaToolStripMenuItem.Click += new System.EventHandler(this.personelRolTanimlamaToolStripMenuItem_Click);

            // 
            // toolStripDropDownButtonRaporlar
            // 
            this.toolStripDropDownButtonRaporlar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonRaporlar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelRaporuToolStripMenuItem});
            this.toolStripDropDownButtonRaporlar.Name = "toolStripDropDownButtonRaporlar";
            this.toolStripDropDownButtonRaporlar.Size = new System.Drawing.Size(75, 24);
            this.toolStripDropDownButtonRaporlar.Text = "Raporlar";
            // 
            // personelRaporuToolStripMenuItem
            // 
            this.personelRaporuToolStripMenuItem.Name = "personelRaporuToolStripMenuItem";
            this.personelRaporuToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.personelRaporuToolStripMenuItem.Text = "Personel Listesi";
            this.personelRaporuToolStripMenuItem.Click += new System.EventHandler(this.personelRaporuToolStripMenuItem_Click);

            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 80);
            this.panel1.TabIndex = 1;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(450, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "PERSONEL DETAY LİSTESİ";

            // Veri Giriş Alanları (Değiştirilmedi, sadece konumları ayarlandı)
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(30, 125);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(67, 16);
            this.lblAdSoyad.TabIndex = 2;
            this.lblAdSoyad.Text = "Ad Soyad";

            this.txtAdSoyad.Location = new System.Drawing.Point(105, 122);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(190, 22);
            this.txtAdSoyad.TabIndex = 0;

            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(320, 125);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(34, 16);
            this.lblSifre.TabIndex = 4;
            this.lblSifre.Text = "Şifre";

            this.txtSifre.Location = new System.Drawing.Point(365, 122);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(130, 22);
            this.txtSifre.TabIndex = 1;

            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(520, 125);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(28, 16);
            this.lblRol.TabIndex = 6;
            this.lblRol.Text = "Rol";

            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(555, 122);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(70, 24);
            this.cmbRol.TabIndex = 2;

            this.lblMaas.AutoSize = true;
            this.lblMaas.Location = new System.Drawing.Point(650, 125);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(41, 16);
            this.lblMaas.TabIndex = 8;
            this.lblMaas.Text = "Maaş";

            this.txtMaas.Location = new System.Drawing.Point(700, 122);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(110, 22);
            this.txtMaas.TabIndex = 3;

            this.lblTcNo.AutoSize = true;
            this.lblTcNo.Location = new System.Drawing.Point(830, 125);
            this.lblTcNo.Name = "lblTcNo";
            this.lblTcNo.Size = new System.Drawing.Size(46, 16);
            this.lblTcNo.TabIndex = 10;
            this.lblTcNo.Text = "TC No";

            this.txtTcNo.Location = new System.Drawing.Point(885, 122);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(160, 22);
            this.txtTcNo.TabIndex = 4;

            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(30, 165);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(53, 16);
            this.lblTelefon.TabIndex = 12;
            this.lblTelefon.Text = "Telefon";

            this.txtTelefon.Location = new System.Drawing.Point(105, 162);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(190, 22);
            this.txtTelefon.TabIndex = 5;

            this.lblIseGirisTarihi.AutoSize = true;
            this.lblIseGirisTarihi.Location = new System.Drawing.Point(320, 165);
            this.lblIseGirisTarihi.Name = "lblIseGirisTarihi";
            this.lblIseGirisTarihi.Size = new System.Drawing.Size(82, 16);
            this.lblIseGirisTarihi.TabIndex = 14;
            this.lblIseGirisTarihi.Text = "İşe Giriş Tar.";

            this.dtpIseGirisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIseGirisTarihi.Location = new System.Drawing.Point(410, 162);
            this.dtpIseGirisTarihi.Name = "dtpIseGirisTarihi";
            this.dtpIseGirisTarihi.Size = new System.Drawing.Size(120, 22);
            this.dtpIseGirisTarihi.TabIndex = 6;

            this.lblAktifMi.AutoSize = true;
            this.lblAktifMi.Location = new System.Drawing.Point(555, 165);
            this.lblAktifMi.Name = "lblAktifMi";
            this.lblAktifMi.Size = new System.Drawing.Size(39, 16);
            this.lblAktifMi.TabIndex = 16;
            this.lblAktifMi.Text = "Aktif?";

            this.chkAktifMi.AutoSize = true;
            this.chkAktifMi.Location = new System.Drawing.Point(610, 164);
            this.chkAktifMi.Name = "chkAktifMi";
            this.chkAktifMi.Size = new System.Drawing.Size(54, 20);
            this.chkAktifMi.TabIndex = 7;
            this.chkAktifMi.Text = "Aktif";
            this.chkAktifMi.UseVisualStyleBackColor = true;

            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(30, 205);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(43, 16);
            this.lblAdres.TabIndex = 18;
            this.lblAdres.Text = "Adres";

            this.txtAdres.Location = new System.Drawing.Point(105, 202);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(490, 22);
            this.txtAdres.TabIndex = 8;

            // Gizli Yıldızlar (Basitleştirildi)
            this.lblYildizAdSoyad.Location = new System.Drawing.Point(0, 0); this.lblYildizAdSoyad.Name = "lblYildizAdSoyad"; this.lblYildizAdSoyad.Size = new System.Drawing.Size(10, 10);
            this.lblYildizSifre.Location = new System.Drawing.Point(0, 0); this.lblYildizSifre.Name = "lblYildizSifre"; this.lblYildizSifre.Size = new System.Drawing.Size(10, 10);
            this.lblYildizRol.Location = new System.Drawing.Point(0, 0); this.lblYildizRol.Name = "lblYildizRol"; this.lblYildizRol.Size = new System.Drawing.Size(10, 10);
            this.lblYildizMaas.Location = new System.Drawing.Point(0, 0); this.lblYildizMaas.Name = "lblYildizMaas"; this.lblYildizMaas.Size = new System.Drawing.Size(10, 10);
            this.lblYildizTcNo.Location = new System.Drawing.Point(0, 0); this.lblYildizTcNo.Name = "lblYildizTcNo"; this.lblYildizTcNo.Size = new System.Drawing.Size(10, 10);
            this.lblYildizTelefon.Location = new System.Drawing.Point(0, 0); this.lblYildizTelefon.Name = "lblYildizTelefon"; this.lblYildizTelefon.Size = new System.Drawing.Size(10, 10);
            this.lblYildizAdres.Location = new System.Drawing.Point(0, 0); this.lblYildizAdres.Name = "lblYildizAdres"; this.lblYildizAdres.Size = new System.Drawing.Size(10, 10);

            // 
            // grpBirebirArama
            // 
            this.grpBirebirArama.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.grpBirebirArama.Controls.Add(this.btnBirebirAra);
            this.grpBirebirArama.Controls.Add(this.txtBirebirTcNo);
            this.grpBirebirArama.Controls.Add(this.chkTcNo);
            this.grpBirebirArama.Controls.Add(this.txtBirebirMaas);
            this.grpBirebirArama.Controls.Add(this.chkMaas);
            this.grpBirebirArama.Controls.Add(this.txtBirebirAdSoyad);
            this.grpBirebirArama.Controls.Add(this.chkAdSoyad);
            this.grpBirebirArama.Location = new System.Drawing.Point(30, 240);
            this.grpBirebirArama.Name = "grpBirebirArama";
            this.grpBirebirArama.Size = new System.Drawing.Size(565, 110);
            this.grpBirebirArama.TabIndex = 28;
            this.grpBirebirArama.TabStop = false;
            this.grpBirebirArama.Text = "Birebir Arama";
            // 
            // btnBirebirAra
            // 
            this.btnBirebirAra.Location = new System.Drawing.Point(260, 60);
            this.btnBirebirAra.Name = "btnBirebirAra";
            this.btnBirebirAra.Size = new System.Drawing.Size(280, 35);
            this.btnBirebirAra.TabIndex = 4;
            this.btnBirebirAra.Text = "Ara";
            this.btnBirebirAra.UseVisualStyleBackColor = true;
            this.btnBirebirAra.Click += new System.EventHandler(this.btnBirebirAra_Click);
            // 
            // chkAdSoyad
            // 
            this.chkAdSoyad.AutoSize = true;
            this.chkAdSoyad.Location = new System.Drawing.Point(15, 30);
            this.chkAdSoyad.Name = "chkAdSoyad";
            this.chkAdSoyad.Size = new System.Drawing.Size(89, 20);
            this.chkAdSoyad.TabIndex = 0;
            this.chkAdSoyad.Text = "Ad Soyad";
            this.chkAdSoyad.UseVisualStyleBackColor = true;
            this.chkAdSoyad.CheckedChanged += new System.EventHandler(this.chkArama_CheckedChanged);
            // 
            // txtBirebirAdSoyad
            // 
            this.txtBirebirAdSoyad.Enabled = false;
            this.txtBirebirAdSoyad.Location = new System.Drawing.Point(110, 28);
            this.txtBirebirAdSoyad.Name = "txtBirebirAdSoyad";
            this.txtBirebirAdSoyad.Size = new System.Drawing.Size(130, 22);
            this.txtBirebirAdSoyad.TabIndex = 1;
            // 
            // chkMaas
            // 
            this.chkMaas.AutoSize = true;
            this.chkMaas.Location = new System.Drawing.Point(260, 30);
            this.chkMaas.Name = "chkMaas";
            this.chkMaas.Size = new System.Drawing.Size(63, 20);
            this.chkMaas.TabIndex = 2;
            this.chkMaas.Text = "Maaş";
            this.chkMaas.UseVisualStyleBackColor = true;
            this.chkMaas.CheckedChanged += new System.EventHandler(this.chkArama_CheckedChanged);
            // 
            // txtBirebirMaas
            // 
            this.txtBirebirMaas.Enabled = false;
            this.txtBirebirMaas.Location = new System.Drawing.Point(330, 28);
            this.txtBirebirMaas.Name = "txtBirebirMaas";
            this.txtBirebirMaas.Size = new System.Drawing.Size(80, 22);
            this.txtBirebirMaas.TabIndex = 3;
            // 
            // chkTcNo
            // 
            this.chkTcNo.AutoSize = true;
            this.chkTcNo.Location = new System.Drawing.Point(425, 30);
            this.chkTcNo.Name = "chkTcNo";
            this.chkTcNo.Size = new System.Drawing.Size(68, 20);
            this.chkTcNo.TabIndex = 4;
            this.chkTcNo.Text = "TC No";
            this.chkTcNo.UseVisualStyleBackColor = true;
            this.chkTcNo.CheckedChanged += new System.EventHandler(this.chkArama_CheckedChanged);
            // 
            // txtBirebirTcNo
            // 
            this.txtBirebirTcNo.Enabled = false;
            this.txtBirebirTcNo.Location = new System.Drawing.Point(495, 28);
            this.txtBirebirTcNo.Name = "txtBirebirTcNo";
            this.txtBirebirTcNo.Size = new System.Drawing.Size(45, 22); // Boyut sıkıntısından küçük tuttuk
            this.txtBirebirTcNo.TabIndex = 5;

            // 
            // grpHizliArama
            // 
            this.grpHizliArama.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.grpHizliArama.Controls.Add(this.txtHizliAramaSecim);
            this.grpHizliArama.Controls.Add(this.lblHizliAramaDeger);
            this.grpHizliArama.Controls.Add(this.grpAlanSecimi);
            this.grpHizliArama.Controls.Add(this.cmbHizliAramaTuru);
            this.grpHizliArama.Controls.Add(this.labelAramaTuru);
            this.grpHizliArama.Location = new System.Drawing.Point(620, 240);
            this.grpHizliArama.Name = "grpHizliArama";
            this.grpHizliArama.Size = new System.Drawing.Size(530, 110);
            this.grpHizliArama.TabIndex = 29;
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
            this.cmbHizliAramaTuru.Size = new System.Drawing.Size(130, 24);
            this.cmbHizliAramaTuru.TabIndex = 1;
            // 
            // grpAlanSecimi
            // 
            this.grpAlanSecimi.Controls.Add(this.rdbTcNo);
            this.grpAlanSecimi.Controls.Add(this.rdbMaas);
            this.grpAlanSecimi.Controls.Add(this.rdbAdSoyad);
            this.grpAlanSecimi.Location = new System.Drawing.Point(250, 15);
            this.grpAlanSecimi.Name = "grpAlanSecimi";
            this.grpAlanSecimi.Size = new System.Drawing.Size(265, 45);
            this.grpAlanSecimi.TabIndex = 2;
            this.grpAlanSecimi.TabStop = false;
            this.grpAlanSecimi.Text = "Alan Seçimi";
            // 
            // rdbAdSoyad
            // 
            this.rdbAdSoyad.AutoSize = true;
            this.rdbAdSoyad.Checked = true;
            this.rdbAdSoyad.Location = new System.Drawing.Point(10, 18);
            this.rdbAdSoyad.Name = "rdbAdSoyad";
            this.rdbAdSoyad.Size = new System.Drawing.Size(88, 20);
            this.rdbAdSoyad.TabIndex = 0;
            this.rdbAdSoyad.TabStop = true;
            this.rdbAdSoyad.Text = "Ad Soyad";
            this.rdbAdSoyad.UseVisualStyleBackColor = true;
            this.rdbAdSoyad.CheckedChanged += new System.EventHandler(this.HizliAramaRadio_CheckedChanged);
            // 
            // rdbMaas
            // 
            this.rdbMaas.AutoSize = true;
            this.rdbMaas.Location = new System.Drawing.Point(110, 18);
            this.rdbMaas.Name = "rdbMaas";
            this.rdbMaas.Size = new System.Drawing.Size(62, 20);
            this.rdbMaas.TabIndex = 1;
            this.rdbMaas.Text = "Maaş";
            this.rdbMaas.UseVisualStyleBackColor = true;
            this.rdbMaas.CheckedChanged += new System.EventHandler(this.HizliAramaRadio_CheckedChanged);
            // 
            // rdbTcNo
            // 
            this.rdbTcNo.AutoSize = true;
            this.rdbTcNo.Location = new System.Drawing.Point(185, 18);
            this.rdbTcNo.Name = "rdbTcNo";
            this.rdbTcNo.Size = new System.Drawing.Size(67, 20);
            this.rdbTcNo.TabIndex = 2;
            this.rdbTcNo.Text = "TC No";
            this.rdbTcNo.UseVisualStyleBackColor = true;
            this.rdbTcNo.CheckedChanged += new System.EventHandler(this.HizliAramaRadio_CheckedChanged);
            // 
            // lblHizliAramaDeger
            // 
            this.lblHizliAramaDeger.AutoSize = true;
            this.lblHizliAramaDeger.Location = new System.Drawing.Point(15, 75);
            this.lblHizliAramaDeger.Name = "lblHizliAramaDeger";
            this.lblHizliAramaDeger.Size = new System.Drawing.Size(70, 16);
            this.lblHizliAramaDeger.TabIndex = 3;
            this.lblHizliAramaDeger.Text = "Ad Soyad:";
            // 
            // txtHizliAramaSecim
            // 
            this.txtHizliAramaSecim.Location = new System.Drawing.Point(100, 72);
            this.txtHizliAramaSecim.Name = "txtHizliAramaSecim";
            this.txtHizliAramaSecim.Size = new System.Drawing.Size(415, 22);
            this.txtHizliAramaSecim.TabIndex = 4;
            this.txtHizliAramaSecim.TextChanged += new System.EventHandler(this.txtHizliAramaSecim_TextChanged);

            // 
            // dgvPersonel
            // 
            this.dgvPersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonel.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersonel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPersonel.Location = new System.Drawing.Point(0, 370);
            this.dgvPersonel.Name = "dgvPersonel";
            this.dgvPersonel.RowHeadersWidth = 51;
            this.dgvPersonel.RowTemplate.Height = 24;
            this.dgvPersonel.Size = new System.Drawing.Size(1200, 280);
            this.dgvPersonel.TabIndex = 20;
            this.dgvPersonel.TabStop = false;
            this.dgvPersonel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonel_CellClick);

            // 
            // PersonelListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.grpHizliArama);
            this.Controls.Add(this.grpBirebirArama);
            this.Controls.Add(this.lblYildizAdres);
            this.Controls.Add(this.lblYildizTelefon);
            this.Controls.Add(this.lblYildizTcNo);
            this.Controls.Add(this.lblYildizMaas);
            this.Controls.Add(this.lblYildizRol);
            this.Controls.Add(this.lblYildizSifre);
            this.Controls.Add(this.lblYildizAdSoyad);
            this.Controls.Add(this.dgvPersonel);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.chkAktifMi);
            this.Controls.Add(this.lblAktifMi);
            this.Controls.Add(this.dtpIseGirisTarihi);
            this.Controls.Add(this.lblIseGirisTarihi);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.lblTcNo);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.lblMaas);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "PersonelListeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Liste Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonelListeForm_FormClosing);
            this.Load += new System.EventHandler(this.PersonelListeForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).EndInit();
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