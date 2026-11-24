namespace CafeOtomasyon
{
    partial class GunSonuForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblYildizToplamSiparis = new System.Windows.Forms.Label();
            this.lblYildizToplamOdeme = new System.Windows.Forms.Label();
            this.lblYildizNakit = new System.Windows.Forms.Label();
            this.lblYildizKart = new System.Windows.Forms.Label();
            this.lblYildizSahsiKasa = new System.Windows.Forms.Label();
            this.lblYildizNetCiro = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonHesapla = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonYenile = new System.Windows.Forms.ToolStripButton();
            this.dtpRaporTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtToplamSiparisTutari = new System.Windows.Forms.TextBox();
            this.txtToplamOdeme = new System.Windows.Forms.TextBox();
            this.txtNakitToplam = new System.Windows.Forms.TextBox();
            this.txtKartToplam = new System.Windows.Forms.TextBox();
            this.txtSahsiKasaToplam = new System.Windows.Forms.TextBox();
            this.txtNetCiro = new System.Windows.Forms.TextBox();
            this.dgvGunSonu = new System.Windows.Forms.DataGridView();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblToplamSiparis = new System.Windows.Forms.Label();
            this.lblToplamOdeme = new System.Windows.Forms.Label();
            this.lblNakit = new System.Windows.Forms.Label();
            this.lblKart = new System.Windows.Forms.Label();
            this.lblSahsiKasa = new System.Windows.Forms.Label();
            this.lblNetCiro = new System.Windows.Forms.Label();

            // Arama Kontrolleri
            this.grpBirebirArama = new System.Windows.Forms.GroupBox();
            this.btnBirebirAra = new System.Windows.Forms.Button();
            this.txtBirebirRaporTarihi = new System.Windows.Forms.TextBox();
            this.chkRaporTarihi = new System.Windows.Forms.CheckBox();
            this.txtBirebirNetCiro = new System.Windows.Forms.TextBox();
            this.chkNetCiro = new System.Windows.Forms.CheckBox();
            this.grpHizliArama = new System.Windows.Forms.GroupBox();
            this.txtHizliAramaSecim = new System.Windows.Forms.TextBox();
            this.lblHizliAramaDeger = new System.Windows.Forms.Label();
            this.grpAlanSecimi = new System.Windows.Forms.GroupBox();
            this.rdbRaporTarihi = new System.Windows.Forms.RadioButton();
            this.rdbNetCiro = new System.Windows.Forms.RadioButton();
            this.cmbHizliAramaTuru = new System.Windows.Forms.ComboBox();
            this.labelAramaTuru = new System.Windows.Forms.Label();

            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGunSonu)).BeginInit();
            this.grpBirebirArama.SuspendLayout();
            this.grpHizliArama.SuspendLayout();
            this.grpAlanSecimi.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblYildizToplamSiparis vb (Gizli Yıldızlar)
            // 
            this.lblYildizToplamSiparis.Location = new System.Drawing.Point(0, 0);
            this.lblYildizToplamSiparis.Name = "lblYildizToplamSiparis";
            this.lblYildizToplamSiparis.Size = new System.Drawing.Size(100, 23);
            this.lblYildizToplamSiparis.TabIndex = 0;
            this.lblYildizToplamOdeme.Location = new System.Drawing.Point(0, 0);
            this.lblYildizToplamOdeme.Name = "lblYildizToplamOdeme";
            this.lblYildizToplamOdeme.Size = new System.Drawing.Size(100, 23);
            this.lblYildizToplamOdeme.TabIndex = 0;
            this.lblYildizNakit.Location = new System.Drawing.Point(0, 0);
            this.lblYildizNakit.Name = "lblYildizNakit";
            this.lblYildizNakit.Size = new System.Drawing.Size(100, 23);
            this.lblYildizNakit.TabIndex = 0;
            this.lblYildizKart.Location = new System.Drawing.Point(0, 0);
            this.lblYildizKart.Name = "lblYildizKart";
            this.lblYildizKart.Size = new System.Drawing.Size(100, 23);
            this.lblYildizKart.TabIndex = 0;
            this.lblYildizSahsiKasa.Location = new System.Drawing.Point(0, 0);
            this.lblYildizSahsiKasa.Name = "lblYildizSahsiKasa";
            this.lblYildizSahsiKasa.Size = new System.Drawing.Size(100, 23);
            this.lblYildizSahsiKasa.TabIndex = 0;
            this.lblYildizNetCiro.Location = new System.Drawing.Point(0, 0);
            this.lblYildizNetCiro.Name = "lblYildizNetCiro";
            this.lblYildizNetCiro.Size = new System.Drawing.Size(100, 23);
            this.lblYildizNetCiro.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonHesapla,
            this.toolStripButtonKaydet,
            this.toolStripButtonSil,
            this.toolStripButtonYenile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1036, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonHesapla
            // 
            this.toolStripButtonHesapla.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonHesapla.Name = "toolStripButtonHesapla";
            this.toolStripButtonHesapla.Size = new System.Drawing.Size(67, 24);
            this.toolStripButtonHesapla.Text = "Hesapla";
            this.toolStripButtonHesapla.Click += new System.EventHandler(this.toolStripButtonHesapla_Click);
            // 
            // toolStripButtonKaydet
            // 
            this.toolStripButtonKaydet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonKaydet.Name = "toolStripButtonKaydet";
            this.toolStripButtonKaydet.Size = new System.Drawing.Size(59, 24);
            this.toolStripButtonKaydet.Text = "Kaydet";
            this.toolStripButtonKaydet.Click += new System.EventHandler(this.toolStripButtonKaydet_Click);
            // 
            // toolStripButtonSil
            // 
            this.toolStripButtonSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSil.Name = "toolStripButtonSil";
            this.toolStripButtonSil.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonSil.Text = "Sil";
            this.toolStripButtonSil.Click += new System.EventHandler(this.toolStripButtonSil_Click);
            // 
            // toolStripButtonYenile
            // 
            this.toolStripButtonYenile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonYenile.Name = "toolStripButtonYenile";
            this.toolStripButtonYenile.Size = new System.Drawing.Size(52, 24);
            this.toolStripButtonYenile.Text = "Yenile";
            this.toolStripButtonYenile.Click += new System.EventHandler(this.toolStripButtonYenile_Click);
            // 
            // dtpRaporTarihi
            // 
            this.dtpRaporTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRaporTarihi.Location = new System.Drawing.Point(160, 40);
            this.dtpRaporTarihi.Name = "dtpRaporTarihi";
            this.dtpRaporTarihi.Size = new System.Drawing.Size(120, 22);
            this.dtpRaporTarihi.TabIndex = 0;
            // 
            // txtToplamSiparisTutari
            // 
            this.txtToplamSiparisTutari.Location = new System.Drawing.Point(160, 75);
            this.txtToplamSiparisTutari.Name = "txtToplamSiparisTutari";
            this.txtToplamSiparisTutari.Size = new System.Drawing.Size(120, 22);
            this.txtToplamSiparisTutari.TabIndex = 2;
            // 
            // txtToplamOdeme
            // 
            this.txtToplamOdeme.Location = new System.Drawing.Point(160, 107);
            this.txtToplamOdeme.Name = "txtToplamOdeme";
            this.txtToplamOdeme.Size = new System.Drawing.Size(120, 22);
            this.txtToplamOdeme.TabIndex = 4;
            // 
            // txtNetCiro
            // 
            this.txtNetCiro.Location = new System.Drawing.Point(160, 139);
            this.txtNetCiro.Name = "txtNetCiro";
            this.txtNetCiro.Size = new System.Drawing.Size(120, 22);
            this.txtNetCiro.TabIndex = 6;
            // 
            // txtNakitToplam
            // 
            this.txtNakitToplam.Location = new System.Drawing.Point(400, 40);
            this.txtNakitToplam.Name = "txtNakitToplam";
            this.txtNakitToplam.Size = new System.Drawing.Size(120, 22);
            this.txtNakitToplam.TabIndex = 1;
            // 
            // txtKartToplam
            // 
            this.txtKartToplam.Location = new System.Drawing.Point(400, 72);
            this.txtKartToplam.Name = "txtKartToplam";
            this.txtKartToplam.Size = new System.Drawing.Size(120, 22);
            this.txtKartToplam.TabIndex = 3;
            // 
            // txtSahsiKasaToplam
            // 
            this.txtSahsiKasaToplam.Location = new System.Drawing.Point(400, 104);
            this.txtSahsiKasaToplam.Name = "txtSahsiKasaToplam";
            this.txtSahsiKasaToplam.Size = new System.Drawing.Size(120, 22);
            this.txtSahsiKasaToplam.TabIndex = 5;
            // 
            // dgvGunSonu
            // 
            this.dgvGunSonu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGunSonu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGunSonu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGunSonu.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGunSonu.Location = new System.Drawing.Point(12, 200);
            this.dgvGunSonu.Name = "dgvGunSonu";
            this.dgvGunSonu.RowHeadersWidth = 51;
            this.dgvGunSonu.RowTemplate.Height = 24;
            this.dgvGunSonu.Size = new System.Drawing.Size(1000, 380);
            this.dgvGunSonu.TabIndex = 15;
            this.dgvGunSonu.TabStop = false;
            this.dgvGunSonu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGunSonu_CellClick);
            // 
            // lblTarih vb...
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(15, 43);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(82, 16);
            this.lblTarih.TabIndex = 1;
            this.lblTarih.Text = "Rapor Tarihi";

            this.lblToplamSiparis.AutoSize = true;
            this.lblToplamSiparis.Location = new System.Drawing.Point(15, 78);
            this.lblToplamSiparis.Name = "lblToplamSiparis";
            this.lblToplamSiparis.Size = new System.Drawing.Size(136, 16);
            this.lblToplamSiparis.TabIndex = 3;
            this.lblToplamSiparis.Text = "Toplam Sipariş Tutarı";

            this.lblToplamOdeme.AutoSize = true;
            this.lblToplamOdeme.Location = new System.Drawing.Point(15, 110);
            this.lblToplamOdeme.Name = "lblToplamOdeme";
            this.lblToplamOdeme.Size = new System.Drawing.Size(102, 16);
            this.lblToplamOdeme.TabIndex = 5;
            this.lblToplamOdeme.Text = "Toplam Ödeme";

            this.lblNetCiro.AutoSize = true;
            this.lblNetCiro.Location = new System.Drawing.Point(15, 142);
            this.lblNetCiro.Name = "lblNetCiro";
            this.lblNetCiro.Size = new System.Drawing.Size(55, 16);
            this.lblNetCiro.TabIndex = 13;
            this.lblNetCiro.Text = "Net Ciro";

            this.lblNakit.AutoSize = true;
            this.lblNakit.Location = new System.Drawing.Point(300, 43);
            this.lblNakit.Name = "lblNakit";
            this.lblNakit.Size = new System.Drawing.Size(88, 16);
            this.lblNakit.TabIndex = 7;
            this.lblNakit.Text = "Nakit Toplam";

            this.lblKart.AutoSize = true;
            this.lblKart.Location = new System.Drawing.Point(300, 75);
            this.lblKart.Name = "lblKart";
            this.lblKart.Size = new System.Drawing.Size(80, 16);
            this.lblKart.TabIndex = 9;
            this.lblKart.Text = "Kart Toplam";

            this.lblSahsiKasa.AutoSize = true;
            this.lblSahsiKasa.Location = new System.Drawing.Point(300, 107);
            this.lblSahsiKasa.Name = "lblSahsiKasa";
            this.lblSahsiKasa.Size = new System.Drawing.Size(106, 16);
            this.lblSahsiKasa.TabIndex = 11;
            this.lblSahsiKasa.Text = "Şahsi Kasa Top.";

            // 
            // grpBirebirArama
            // 
            this.grpBirebirArama.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.grpBirebirArama.Controls.Add(this.btnBirebirAra);
            this.grpBirebirArama.Controls.Add(this.txtBirebirRaporTarihi);
            this.grpBirebirArama.Controls.Add(this.chkRaporTarihi);
            this.grpBirebirArama.Controls.Add(this.txtBirebirNetCiro);
            this.grpBirebirArama.Controls.Add(this.chkNetCiro);
            this.grpBirebirArama.Location = new System.Drawing.Point(540, 40);
            this.grpBirebirArama.Name = "grpBirebirArama";
            this.grpBirebirArama.Size = new System.Drawing.Size(220, 150);
            this.grpBirebirArama.TabIndex = 11;
            this.grpBirebirArama.TabStop = false;
            this.grpBirebirArama.Text = "Birebir Arama";
            // 
            // btnBirebirAra
            // 
            this.btnBirebirAra.Location = new System.Drawing.Point(15, 100);
            this.btnBirebirAra.Name = "btnBirebirAra";
            this.btnBirebirAra.Size = new System.Drawing.Size(185, 35);
            this.btnBirebirAra.TabIndex = 4;
            this.btnBirebirAra.Text = "Ara";
            this.btnBirebirAra.UseVisualStyleBackColor = true;
            this.btnBirebirAra.Click += new System.EventHandler(this.btnBirebirAra_Click);
            // 
            // txtBirebirRaporTarihi
            // 
            this.txtBirebirRaporTarihi.Enabled = false;
            this.txtBirebirRaporTarihi.Location = new System.Drawing.Point(100, 63);
            this.txtBirebirRaporTarihi.Name = "txtBirebirRaporTarihi";
            this.txtBirebirRaporTarihi.Size = new System.Drawing.Size(100, 22);
            this.txtBirebirRaporTarihi.TabIndex = 3;
            // 
            // chkRaporTarihi
            // 
            this.chkRaporTarihi.AutoSize = true;
            this.chkRaporTarihi.Location = new System.Drawing.Point(15, 65);
            this.chkRaporTarihi.Name = "chkRaporTarihi";
            this.chkRaporTarihi.Size = new System.Drawing.Size(73, 20);
            this.chkRaporTarihi.TabIndex = 2;
            this.chkRaporTarihi.Text = "Tarih";
            this.chkRaporTarihi.UseVisualStyleBackColor = true;
            this.chkRaporTarihi.CheckedChanged += new System.EventHandler(this.chkArama_CheckedChanged);
            // 
            // txtBirebirNetCiro
            // 
            this.txtBirebirNetCiro.Enabled = false;
            this.txtBirebirNetCiro.Location = new System.Drawing.Point(100, 28);
            this.txtBirebirNetCiro.Name = "txtBirebirNetCiro";
            this.txtBirebirNetCiro.Size = new System.Drawing.Size(100, 22);
            this.txtBirebirNetCiro.TabIndex = 1;
            // 
            // chkNetCiro
            // 
            this.chkNetCiro.AutoSize = true;
            this.chkNetCiro.Location = new System.Drawing.Point(15, 30);
            this.chkNetCiro.Name = "chkNetCiro";
            this.chkNetCiro.Size = new System.Drawing.Size(76, 20);
            this.chkNetCiro.TabIndex = 0;
            this.chkNetCiro.Text = "Net Ciro";
            this.chkNetCiro.UseVisualStyleBackColor = true;
            this.chkNetCiro.CheckedChanged += new System.EventHandler(this.chkArama_CheckedChanged);
            // 
            // grpHizliArama
            // 
            this.grpHizliArama.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.grpHizliArama.Controls.Add(this.txtHizliAramaSecim);
            this.grpHizliArama.Controls.Add(this.lblHizliAramaDeger);
            this.grpHizliArama.Controls.Add(this.grpAlanSecimi);
            this.grpHizliArama.Controls.Add(this.cmbHizliAramaTuru);
            this.grpHizliArama.Controls.Add(this.labelAramaTuru);
            this.grpHizliArama.Location = new System.Drawing.Point(775, 40);
            this.grpHizliArama.Name = "grpHizliArama";
            this.grpHizliArama.Size = new System.Drawing.Size(240, 150);
            this.grpHizliArama.TabIndex = 12;
            this.grpHizliArama.TabStop = false;
            this.grpHizliArama.Text = "Hızlı Arama";
            // 
            // txtHizliAramaSecim
            // 
            this.txtHizliAramaSecim.Location = new System.Drawing.Point(90, 115);
            this.txtHizliAramaSecim.Name = "txtHizliAramaSecim";
            this.txtHizliAramaSecim.Size = new System.Drawing.Size(135, 22);
            this.txtHizliAramaSecim.TabIndex = 4;
            this.txtHizliAramaSecim.TextChanged += new System.EventHandler(this.txtHizliAramaSecim_TextChanged);
            // 
            // lblHizliAramaDeger
            // 
            this.lblHizliAramaDeger.AutoSize = true;
            this.lblHizliAramaDeger.Location = new System.Drawing.Point(10, 118);
            this.lblHizliAramaDeger.Name = "lblHizliAramaDeger";
            this.lblHizliAramaDeger.Size = new System.Drawing.Size(58, 16);
            this.lblHizliAramaDeger.TabIndex = 3;
            this.lblHizliAramaDeger.Text = "Net Ciro:";
            // 
            // grpAlanSecimi
            // 
            this.grpAlanSecimi.Controls.Add(this.rdbRaporTarihi);
            this.grpAlanSecimi.Controls.Add(this.rdbNetCiro);
            this.grpAlanSecimi.Location = new System.Drawing.Point(13, 58);
            this.grpAlanSecimi.Name = "grpAlanSecimi";
            this.grpAlanSecimi.Size = new System.Drawing.Size(212, 50);
            this.grpAlanSecimi.TabIndex = 2;
            this.grpAlanSecimi.TabStop = false;
            this.grpAlanSecimi.Text = "Alan Seçimi";
            // 
            // rdbRaporTarihi
            // 
            this.rdbRaporTarihi.AutoSize = true;
            this.rdbRaporTarihi.Location = new System.Drawing.Point(115, 20);
            this.rdbRaporTarihi.Name = "rdbRaporTarihi";
            this.rdbRaporTarihi.Size = new System.Drawing.Size(87, 20);
            this.rdbRaporTarihi.TabIndex = 1;
            this.rdbRaporTarihi.Text = "Rapor Tarihi";
            this.rdbRaporTarihi.UseVisualStyleBackColor = true;
            this.rdbRaporTarihi.CheckedChanged += new System.EventHandler(this.HizliAramaRadio_CheckedChanged);
            // 
            // rdbNetCiro
            // 
            this.rdbNetCiro.AutoSize = true;
            this.rdbNetCiro.Checked = true;
            this.rdbNetCiro.Location = new System.Drawing.Point(10, 20);
            this.rdbNetCiro.Name = "rdbNetCiro";
            this.rdbNetCiro.Size = new System.Drawing.Size(76, 20);
            this.rdbNetCiro.TabIndex = 0;
            this.rdbNetCiro.TabStop = true;
            this.rdbNetCiro.Text = "Net Ciro";
            this.rdbNetCiro.UseVisualStyleBackColor = true;
            this.rdbNetCiro.CheckedChanged += new System.EventHandler(this.HizliAramaRadio_CheckedChanged);
            // 
            // cmbHizliAramaTuru
            // 
            this.cmbHizliAramaTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHizliAramaTuru.FormattingEnabled = true;
            this.cmbHizliAramaTuru.Items.AddRange(new object[] {
            "İçeren",
            "İle Başlayan",
            "Birebir Eşleşen"});
            this.cmbHizliAramaTuru.Location = new System.Drawing.Point(90, 25);
            this.cmbHizliAramaTuru.Name = "cmbHizliAramaTuru";
            this.cmbHizliAramaTuru.Size = new System.Drawing.Size(135, 24);
            this.cmbHizliAramaTuru.TabIndex = 1;
            // 
            // labelAramaTuru
            // 
            this.labelAramaTuru.AutoSize = true;
            this.labelAramaTuru.Location = new System.Drawing.Point(10, 28);
            this.labelAramaTuru.Name = "labelAramaTuru";
            this.labelAramaTuru.Size = new System.Drawing.Size(77, 16);
            this.labelAramaTuru.TabIndex = 0;
            this.labelAramaTuru.Text = "Arama Türü";
            // 
            // GunSonuForm
            // 
            this.ClientSize = new System.Drawing.Size(1036, 601);
            this.Controls.Add(this.grpHizliArama);
            this.Controls.Add(this.grpBirebirArama);
            this.Controls.Add(this.dgvGunSonu);
            this.Controls.Add(this.txtNetCiro);
            this.Controls.Add(this.lblNetCiro);
            this.Controls.Add(this.txtSahsiKasaToplam);
            this.Controls.Add(this.lblSahsiKasa);
            this.Controls.Add(this.txtKartToplam);
            this.Controls.Add(this.lblKart);
            this.Controls.Add(this.txtNakitToplam);
            this.Controls.Add(this.lblNakit);
            this.Controls.Add(this.txtToplamOdeme);
            this.Controls.Add(this.lblToplamOdeme);
            this.Controls.Add(this.txtToplamSiparisTutari);
            this.Controls.Add(this.lblToplamSiparis);
            this.Controls.Add(this.dtpRaporTarihi);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.toolStrip1);
            this.Name = "GunSonuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gün Sonu Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GunSonuForm_FormClosing);
            this.Load += new System.EventHandler(this.GunSonuForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGunSonu)).EndInit();
            this.grpBirebirArama.ResumeLayout(false);
            this.grpBirebirArama.PerformLayout();
            this.grpHizliArama.ResumeLayout(false);
            this.grpHizliArama.PerformLayout();
            this.grpAlanSecimi.ResumeLayout(false);
            this.grpAlanSecimi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonHesapla;
        private System.Windows.Forms.ToolStripButton toolStripButtonKaydet;
        private System.Windows.Forms.ToolStripButton toolStripButtonSil;
        private System.Windows.Forms.ToolStripButton toolStripButtonYenile;
        private System.Windows.Forms.DateTimePicker dtpRaporTarihi;
        private System.Windows.Forms.TextBox txtToplamSiparisTutari;
        private System.Windows.Forms.TextBox txtToplamOdeme;
        private System.Windows.Forms.TextBox txtNakitToplam;
        private System.Windows.Forms.TextBox txtKartToplam;
        private System.Windows.Forms.TextBox txtSahsiKasaToplam;
        private System.Windows.Forms.TextBox txtNetCiro;
        private System.Windows.Forms.DataGridView dgvGunSonu;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblToplamSiparis;
        private System.Windows.Forms.Label lblToplamOdeme;
        private System.Windows.Forms.Label lblNakit;
        private System.Windows.Forms.Label lblKart;
        private System.Windows.Forms.Label lblSahsiKasa;
        private System.Windows.Forms.Label lblNetCiro;
        private System.Windows.Forms.Label lblYildizToplamSiparis;
        private System.Windows.Forms.Label lblYildizToplamOdeme;
        private System.Windows.Forms.Label lblYildizNakit;
        private System.Windows.Forms.Label lblYildizKart;
        private System.Windows.Forms.Label lblYildizSahsiKasa;
        private System.Windows.Forms.Label lblYildizNetCiro;

        // Arama Kontrolleri
        private System.Windows.Forms.GroupBox grpBirebirArama;
        private System.Windows.Forms.Button btnBirebirAra;
        private System.Windows.Forms.CheckBox chkRaporTarihi;
        private System.Windows.Forms.TextBox txtBirebirRaporTarihi;
        private System.Windows.Forms.CheckBox chkNetCiro;
        private System.Windows.Forms.TextBox txtBirebirNetCiro;

        private System.Windows.Forms.GroupBox grpHizliArama;
        private System.Windows.Forms.Label labelAramaTuru;
        private System.Windows.Forms.ComboBox cmbHizliAramaTuru;
        private System.Windows.Forms.GroupBox grpAlanSecimi;
        private System.Windows.Forms.RadioButton rdbNetCiro;
        private System.Windows.Forms.RadioButton rdbRaporTarihi;
        private System.Windows.Forms.Label lblHizliAramaDeger;
        private System.Windows.Forms.TextBox txtHizliAramaSecim;
    }
}