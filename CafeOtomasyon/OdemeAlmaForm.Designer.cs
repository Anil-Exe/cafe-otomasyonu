namespace CafeOtomasyon
{
    partial class OdemeAlmaForm
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
        private System.Windows.Forms.ToolStripMenuItem odemeTuruTanimlamaToolStripMenuItem;
        private System.Windows.Forms.TextBox txtMasaID;
        private System.Windows.Forms.TextBox txtSiparisID;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.ComboBox cmbOdemeTuru;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.DataGridView dgvOdemeler;
        private System.Windows.Forms.Label lblMasaID;
        private System.Windows.Forms.Label lblSiparisID;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblOdemeTuru;
        private System.Windows.Forms.Label lblAciklama;

        // Arama Kontrolleri
        private System.Windows.Forms.GroupBox grpBirebirArama;
        private System.Windows.Forms.Button btnBirebirAra;
        private System.Windows.Forms.CheckBox chkTutar;
        private System.Windows.Forms.TextBox txtBirebirTutar;
        private System.Windows.Forms.CheckBox chkOdemeTuru;
        private System.Windows.Forms.TextBox txtBirebirOdemeTuru;
        private System.Windows.Forms.CheckBox chkMasaID;
        private System.Windows.Forms.TextBox txtBirebirMasaID;

        private System.Windows.Forms.GroupBox grpHizliArama;
        private System.Windows.Forms.Label labelAramaTuru;
        private System.Windows.Forms.ComboBox cmbHizliAramaTuru;
        private System.Windows.Forms.GroupBox grpAlanSecimi;
        private System.Windows.Forms.RadioButton rdbTutar;
        private System.Windows.Forms.RadioButton rdbOdemeTuru;
        private System.Windows.Forms.RadioButton rdbMasaID;
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
            this.odemeTuruTanimlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMasaID = new System.Windows.Forms.TextBox();
            this.txtSiparisID = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.cmbOdemeTuru = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.dgvOdemeler = new System.Windows.Forms.DataGridView();
            this.lblMasaID = new System.Windows.Forms.Label();
            this.lblSiparisID = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblOdemeTuru = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();

            this.grpBirebirArama = new System.Windows.Forms.GroupBox();
            this.btnBirebirAra = new System.Windows.Forms.Button();
            this.txtBirebirTutar = new System.Windows.Forms.TextBox();
            this.chkTutar = new System.Windows.Forms.CheckBox();
            this.txtBirebirOdemeTuru = new System.Windows.Forms.TextBox();
            this.chkOdemeTuru = new System.Windows.Forms.CheckBox();
            this.txtBirebirMasaID = new System.Windows.Forms.TextBox();
            this.chkMasaID = new System.Windows.Forms.CheckBox();
            this.grpHizliArama = new System.Windows.Forms.GroupBox();
            this.txtHizliAramaSecim = new System.Windows.Forms.TextBox();
            this.lblHizliAramaDeger = new System.Windows.Forms.Label();
            this.grpAlanSecimi = new System.Windows.Forms.GroupBox();
            this.rdbTutar = new System.Windows.Forms.RadioButton();
            this.rdbOdemeTuru = new System.Windows.Forms.RadioButton();
            this.rdbMasaID = new System.Windows.Forms.RadioButton();
            this.cmbHizliAramaTuru = new System.Windows.Forms.ComboBox();
            this.labelAramaTuru = new System.Windows.Forms.Label();

            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdemeler)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(1036, 27);
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
            this.odemeTuruTanimlamaToolStripMenuItem});
            this.toolStripDropDownButtonTanimlamalar.Name = "toolStripDropDownButtonTanimlamalar";
            this.toolStripDropDownButtonTanimlamalar.Size = new System.Drawing.Size(104, 24);
            this.toolStripDropDownButtonTanimlamalar.Text = "Tanımlamalar";

            // 
            // odemeTuruTanimlamaToolStripMenuItem
            // 
            this.odemeTuruTanimlamaToolStripMenuItem.Name = "odemeTuruTanimlamaToolStripMenuItem";
            this.odemeTuruTanimlamaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.odemeTuruTanimlamaToolStripMenuItem.Text = "Ödeme Türü Tanımlama";
            this.odemeTuruTanimlamaToolStripMenuItem.Click += new System.EventHandler(this.odemeTuruTanimlama_Click);

            // 
            // txtMasaID
            // 
            this.txtMasaID.Location = new System.Drawing.Point(110, 42);
            this.txtMasaID.Name = "txtMasaID";
            this.txtMasaID.Size = new System.Drawing.Size(120, 22);
            this.txtMasaID.TabIndex = 0;
            this.txtMasaID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMasaID_KeyPress);

            // 
            // lblMasaID
            // 
            this.lblMasaID.AutoSize = true;
            this.lblMasaID.Location = new System.Drawing.Point(20, 45);
            this.lblMasaID.Name = "lblMasaID";
            this.lblMasaID.Size = new System.Drawing.Size(57, 16);
            this.lblMasaID.TabIndex = 1;
            this.lblMasaID.Text = "Masa ID";

            // 
            // txtSiparisID
            // 
            this.txtSiparisID.Location = new System.Drawing.Point(340, 42);
            this.txtSiparisID.Name = "txtSiparisID";
            this.txtSiparisID.Size = new System.Drawing.Size(120, 22);
            this.txtSiparisID.TabIndex = 1;
            this.txtSiparisID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSiparisID_KeyPress);

            // 
            // lblSiparisID
            // 
            this.lblSiparisID.AutoSize = true;
            this.lblSiparisID.Location = new System.Drawing.Point(250, 45);
            this.lblSiparisID.Name = "lblSiparisID";
            this.lblSiparisID.Size = new System.Drawing.Size(65, 16);
            this.lblSiparisID.TabIndex = 3;
            this.lblSiparisID.Text = "Sipariş ID";

            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(110, 77);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(120, 22);
            this.txtTutar.TabIndex = 2;
            this.txtTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTutar_KeyPress);

            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(20, 80);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(38, 16);
            this.lblTutar.TabIndex = 5;
            this.lblTutar.Text = "Tutar";

            // 
            // cmbOdemeTuru
            // 
            this.cmbOdemeTuru.FormattingEnabled = true;
            this.cmbOdemeTuru.Location = new System.Drawing.Point(340, 77);
            this.cmbOdemeTuru.Name = "cmbOdemeTuru";
            this.cmbOdemeTuru.Size = new System.Drawing.Size(140, 24);
            this.cmbOdemeTuru.TabIndex = 3;

            // 
            // lblOdemeTuru
            // 
            this.lblOdemeTuru.AutoSize = true;
            this.lblOdemeTuru.Location = new System.Drawing.Point(250, 80);
            this.lblOdemeTuru.Name = "lblOdemeTuru";
            this.lblOdemeTuru.Size = new System.Drawing.Size(82, 16);
            this.lblOdemeTuru.TabIndex = 7;
            this.lblOdemeTuru.Text = "Ödeme Türü";

            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(110, 112);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(370, 22);
            this.txtAciklama.TabIndex = 4;

            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(20, 115);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(63, 16);
            this.lblAciklama.TabIndex = 9;
            this.lblAciklama.Text = "Açıklama";

            // 
            // dgvOdemeler
            // 
            this.dgvOdemeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOdemeler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOdemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOdemeler.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOdemeler.Location = new System.Drawing.Point(12, 270);
            this.dgvOdemeler.Name = "dgvOdemeler";
            this.dgvOdemeler.RowHeadersWidth = 51;
            this.dgvOdemeler.RowTemplate.Height = 24;
            this.dgvOdemeler.Size = new System.Drawing.Size(1000, 250);
            this.dgvOdemeler.TabIndex = 11;
            this.dgvOdemeler.TabStop = false;
            this.dgvOdemeler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOdemeler_CellClick);

            // 
            // grpBirebirArama
            // 
            this.grpBirebirArama.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.grpBirebirArama.Controls.Add(this.btnBirebirAra);
            this.grpBirebirArama.Controls.Add(this.txtBirebirTutar);
            this.grpBirebirArama.Controls.Add(this.chkTutar);
            this.grpBirebirArama.Controls.Add(this.txtBirebirOdemeTuru);
            this.grpBirebirArama.Controls.Add(this.chkOdemeTuru);
            this.grpBirebirArama.Controls.Add(this.txtBirebirMasaID);
            this.grpBirebirArama.Controls.Add(this.chkMasaID);
            this.grpBirebirArama.Location = new System.Drawing.Point(520, 40);
            this.grpBirebirArama.Name = "grpBirebirArama";
            this.grpBirebirArama.Size = new System.Drawing.Size(240, 210);
            this.grpBirebirArama.TabIndex = 12;
            this.grpBirebirArama.TabStop = false;
            this.grpBirebirArama.Text = "Birebir Arama";
            // 
            // btnBirebirAra
            // 
            this.btnBirebirAra.Location = new System.Drawing.Point(20, 150);
            this.btnBirebirAra.Name = "btnBirebirAra";
            this.btnBirebirAra.Size = new System.Drawing.Size(200, 35);
            this.btnBirebirAra.TabIndex = 4;
            this.btnBirebirAra.Text = "Ara";
            this.btnBirebirAra.UseVisualStyleBackColor = true;
            this.btnBirebirAra.Click += new System.EventHandler(this.btnBirebirAra_Click);
            // 
            // txtBirebirTutar
            // 
            this.txtBirebirTutar.Enabled = false;
            this.txtBirebirTutar.Location = new System.Drawing.Point(120, 98);
            this.txtBirebirTutar.Name = "txtBirebirTutar";
            this.txtBirebirTutar.Size = new System.Drawing.Size(100, 22);
            this.txtBirebirTutar.TabIndex = 3;
            // 
            // chkTutar
            // 
            this.chkTutar.AutoSize = true;
            this.chkTutar.Location = new System.Drawing.Point(15, 100);
            this.chkTutar.Name = "chkTutar";
            this.chkTutar.Size = new System.Drawing.Size(60, 20);
            this.chkTutar.TabIndex = 2;
            this.chkTutar.Text = "Tutar";
            this.chkTutar.UseVisualStyleBackColor = true;
            this.chkTutar.CheckedChanged += new System.EventHandler(this.chkArama_CheckedChanged);
            // 
            // txtBirebirOdemeTuru
            // 
            this.txtBirebirOdemeTuru.Enabled = false;
            this.txtBirebirOdemeTuru.Location = new System.Drawing.Point(120, 63);
            this.txtBirebirOdemeTuru.Name = "txtBirebirOdemeTuru";
            this.txtBirebirOdemeTuru.Size = new System.Drawing.Size(100, 22);
            this.txtBirebirOdemeTuru.TabIndex = 3;
            // 
            // chkOdemeTuru
            // 
            this.chkOdemeTuru.AutoSize = true;
            this.chkOdemeTuru.Location = new System.Drawing.Point(15, 65);
            this.chkOdemeTuru.Name = "chkOdemeTuru";
            this.chkOdemeTuru.Size = new System.Drawing.Size(104, 20);
            this.chkOdemeTuru.TabIndex = 2;
            this.chkOdemeTuru.Text = "Ödeme Türü";
            this.chkOdemeTuru.UseVisualStyleBackColor = true;
            this.chkOdemeTuru.CheckedChanged += new System.EventHandler(this.chkArama_CheckedChanged);
            // 
            // txtBirebirMasaID
            // 
            this.txtBirebirMasaID.Enabled = false;
            this.txtBirebirMasaID.Location = new System.Drawing.Point(120, 28);
            this.txtBirebirMasaID.Name = "txtBirebirMasaID";
            this.txtBirebirMasaID.Size = new System.Drawing.Size(100, 22);
            this.txtBirebirMasaID.TabIndex = 1;
            // 
            // chkMasaID
            // 
            this.chkMasaID.AutoSize = true;
            this.chkMasaID.Location = new System.Drawing.Point(15, 30);
            this.chkMasaID.Name = "chkMasaID";
            this.chkMasaID.Size = new System.Drawing.Size(79, 20);
            this.chkMasaID.TabIndex = 0;
            this.chkMasaID.Text = "Masa ID";
            this.chkMasaID.UseVisualStyleBackColor = true;
            this.chkMasaID.CheckedChanged += new System.EventHandler(this.chkArama_CheckedChanged);

            // 
            // grpHizliArama
            // 
            this.grpHizliArama.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.grpHizliArama.Controls.Add(this.txtHizliAramaSecim);
            this.grpHizliArama.Controls.Add(this.lblHizliAramaDeger);
            this.grpHizliArama.Controls.Add(this.grpAlanSecimi);
            this.grpHizliArama.Controls.Add(this.cmbHizliAramaTuru);
            this.grpHizliArama.Controls.Add(this.labelAramaTuru);
            this.grpHizliArama.Location = new System.Drawing.Point(770, 40);
            this.grpHizliArama.Name = "grpHizliArama";
            this.grpHizliArama.Size = new System.Drawing.Size(240, 210);
            this.grpHizliArama.TabIndex = 13;
            this.grpHizliArama.TabStop = false;
            this.grpHizliArama.Text = "Hızlı Arama";
            // 
            // txtHizliAramaSecim
            // 
            this.txtHizliAramaSecim.Location = new System.Drawing.Point(100, 167);
            this.txtHizliAramaSecim.Name = "txtHizliAramaSecim";
            this.txtHizliAramaSecim.Size = new System.Drawing.Size(130, 22);
            this.txtHizliAramaSecim.TabIndex = 4;
            this.txtHizliAramaSecim.TextChanged += new System.EventHandler(this.txtHizliAramaSecim_TextChanged);
            // 
            // lblHizliAramaDeger
            // 
            this.lblHizliAramaDeger.AutoSize = true;
            this.lblHizliAramaDeger.Location = new System.Drawing.Point(10, 170);
            this.lblHizliAramaDeger.Name = "lblHizliAramaDeger";
            this.lblHizliAramaDeger.Size = new System.Drawing.Size(38, 16);
            this.lblHizliAramaDeger.TabIndex = 3;
            this.lblHizliAramaDeger.Text = "Tutar:";
            // 
            // grpAlanSecimi
            // 
            this.grpAlanSecimi.Controls.Add(this.rdbTutar);
            this.grpAlanSecimi.Controls.Add(this.rdbOdemeTuru);
            this.grpAlanSecimi.Controls.Add(this.rdbMasaID);
            this.grpAlanSecimi.Location = new System.Drawing.Point(15, 60);
            this.grpAlanSecimi.Name = "grpAlanSecimi";
            this.grpAlanSecimi.Size = new System.Drawing.Size(215, 95);
            this.grpAlanSecimi.TabIndex = 2;
            this.grpAlanSecimi.TabStop = false;
            this.grpAlanSecimi.Text = "Alan Seçimi";
            // 
            // rdbTutar
            // 
            this.rdbTutar.AutoSize = true;
            this.rdbTutar.Checked = true;
            this.rdbTutar.Location = new System.Drawing.Point(15, 20);
            this.rdbTutar.Name = "rdbTutar";
            this.rdbTutar.Size = new System.Drawing.Size(59, 20);
            this.rdbTutar.TabIndex = 2;
            this.rdbTutar.TabStop = true;
            this.rdbTutar.Text = "Tutar";
            this.rdbTutar.UseVisualStyleBackColor = true;
            this.rdbTutar.CheckedChanged += new System.EventHandler(this.HizliAramaRadio_CheckedChanged);
            // 
            // rdbOdemeTuru
            // 
            this.rdbOdemeTuru.AutoSize = true;
            this.rdbOdemeTuru.Location = new System.Drawing.Point(15, 45);
            this.rdbOdemeTuru.Name = "rdbOdemeTuru";
            this.rdbOdemeTuru.Size = new System.Drawing.Size(103, 20);
            this.rdbOdemeTuru.TabIndex = 1;
            this.rdbOdemeTuru.Text = "Ödeme Türü";
            this.rdbOdemeTuru.UseVisualStyleBackColor = true;
            this.rdbOdemeTuru.CheckedChanged += new System.EventHandler(this.HizliAramaRadio_CheckedChanged);
            // 
            // rdbMasaID
            // 
            this.rdbMasaID.AutoSize = true;
            this.rdbMasaID.Location = new System.Drawing.Point(15, 70);
            this.rdbMasaID.Name = "rdbMasaID";
            this.rdbMasaID.Size = new System.Drawing.Size(78, 20);
            this.rdbMasaID.TabIndex = 0;
            this.rdbMasaID.Text = "Masa ID";
            this.rdbMasaID.UseVisualStyleBackColor = true;
            this.rdbMasaID.CheckedChanged += new System.EventHandler(this.HizliAramaRadio_CheckedChanged);
            // 
            // cmbHizliAramaTuru
            // 
            this.cmbHizliAramaTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHizliAramaTuru.FormattingEnabled = true;
            this.cmbHizliAramaTuru.Items.AddRange(new object[] {
            "İçeren",
            "İle Başlayan",
            "Birebir Eşleşen"});
            this.cmbHizliAramaTuru.Location = new System.Drawing.Point(100, 25);
            this.cmbHizliAramaTuru.Name = "cmbHizliAramaTuru";
            this.cmbHizliAramaTuru.Size = new System.Drawing.Size(130, 24);
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
            // OdemeAlmaForm
            // 
            this.ClientSize = new System.Drawing.Size(1036, 601);
            this.Controls.Add(this.grpHizliArama);
            this.Controls.Add(this.grpBirebirArama);
            this.Controls.Add(this.dgvOdemeler);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.cmbOdemeTuru);
            this.Controls.Add(this.lblOdemeTuru);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.txtSiparisID);
            this.Controls.Add(this.lblSiparisID);
            this.Controls.Add(this.txtMasaID);
            this.Controls.Add(this.lblMasaID);
            this.Controls.Add(this.toolStrip1);
            this.Name = "OdemeAlmaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme Alma Formu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OdemeAlmaForm_FormClosing);
            this.Load += new System.EventHandler(this.OdemeAlmaForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdemeler)).EndInit();
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