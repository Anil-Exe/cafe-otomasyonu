namespace CafeOtomasyon
{
    partial class StokForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonEkle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTemizle = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButtonTanimlamalar = new System.Windows.Forms.ToolStripDropDownButton();
            this.birimTanimlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriTanimlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonRaporlar = new System.Windows.Forms.ToolStripDropDownButton();
            this.stokRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.lblYildizUrunAd = new System.Windows.Forms.Label();
            this.lblYildizBirim = new System.Windows.Forms.Label();
            this.lblYildizFiyat = new System.Windows.Forms.Label();
            this.lblYildizStok = new System.Windows.Forms.Label();
            this.lblYildizKategori = new System.Windows.Forms.Label();
            this.grpBirebirArama = new System.Windows.Forms.GroupBox();
            this.btnBirebirAra = new System.Windows.Forms.Button();
            this.txtBirebirKategori = new System.Windows.Forms.TextBox();
            this.chkKategori = new System.Windows.Forms.CheckBox();
            this.txtBirebirUrunAdi = new System.Windows.Forms.TextBox();
            this.chkUrunAdi = new System.Windows.Forms.CheckBox();
            this.grpHizliArama = new System.Windows.Forms.GroupBox();
            this.txtHizliAramaSecim = new System.Windows.Forms.TextBox();
            this.lblHizliAramaDeger = new System.Windows.Forms.Label();
            this.grpAlanSecimi = new System.Windows.Forms.GroupBox();
            this.rdbKategori = new System.Windows.Forms.RadioButton();
            this.rdbUrunAd = new System.Windows.Forms.RadioButton();
            this.cmbHizliAramaTuru = new System.Windows.Forms.ComboBox();
            this.labelAramaTuru = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
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
            this.birimTanimlamaToolStripMenuItem,
            this.kategoriTanimlamaToolStripMenuItem});
            this.toolStripDropDownButtonTanimlamalar.Name = "toolStripDropDownButtonTanimlamalar";
            this.toolStripDropDownButtonTanimlamalar.Size = new System.Drawing.Size(104, 24);
            this.toolStripDropDownButtonTanimlamalar.Text = "Tanımlamalar";
            // 
            // birimTanimlamaToolStripMenuItem
            // 
            this.birimTanimlamaToolStripMenuItem.Name = "birimTanimlamaToolStripMenuItem";
            this.birimTanimlamaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.birimTanimlamaToolStripMenuItem.Text = "Birim Tanımlama";
            this.birimTanimlamaToolStripMenuItem.Click += new System.EventHandler(this.birimTanimlama_Click);
            // 
            // kategoriTanimlamaToolStripMenuItem
            // 
            this.kategoriTanimlamaToolStripMenuItem.Name = "kategoriTanimlamaToolStripMenuItem";
            this.kategoriTanimlamaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kategoriTanimlamaToolStripMenuItem.Text = "Kategori Tanımlama";
            this.kategoriTanimlamaToolStripMenuItem.Click += new System.EventHandler(this.kategoriTanimlama_Click);
            // 
            // toolStripDropDownButtonRaporlar
            // 
            this.toolStripDropDownButtonRaporlar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonRaporlar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokRaporuToolStripMenuItem});
            this.toolStripDropDownButtonRaporlar.Name = "toolStripDropDownButtonRaporlar";
            this.toolStripDropDownButtonRaporlar.Size = new System.Drawing.Size(75, 24);
            this.toolStripDropDownButtonRaporlar.Text = "Raporlar";
            // 
            // stokRaporuToolStripMenuItem
            // 
            this.stokRaporuToolStripMenuItem.Name = "stokRaporuToolStripMenuItem";
            this.stokRaporuToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.stokRaporuToolStripMenuItem.Text = "Stok Listesi";
            this.stokRaporuToolStripMenuItem.Click += new System.EventHandler(this.stokRaporuToolStripMenuItem_Click);
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Location = new System.Drawing.Point(12, 272);
            this.dgvUrunler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.RowHeadersWidth = 51;
            this.dgvUrunler.RowTemplate.Height = 24;
            this.dgvUrunler.Size = new System.Drawing.Size(1011, 318);
            this.dgvUrunler.TabIndex = 1;
            this.dgvUrunler.TabStop = false;
            this.dgvUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunler_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Adı";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(114, 39);
            this.txtUrunAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(220, 22);
            this.txtUrunAd.TabIndex = 0;
            this.txtUrunAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunAd_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Birim";
            // 
            // cmbBirim
            // 
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Location = new System.Drawing.Point(114, 77);
            this.cmbBirim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(220, 24);
            this.cmbBirim.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Satış Fiyatı";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(114, 115);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(220, 22);
            this.txtFiyat.TabIndex = 2;
            this.txtFiyat.TextChanged += new System.EventHandler(this.txtFiyat_TextChanged);
            this.txtFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiyat_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stok Miktarı";
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(114, 153);
            this.txtStok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(220, 22);
            this.txtStok.TabIndex = 3;
            this.txtStok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStok_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kategori";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(114, 191);
            this.cmbKategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(220, 24);
            this.cmbKategori.TabIndex = 4;
            // 
            // lblYildizUrunAd
            // 
            this.lblYildizUrunAd.Location = new System.Drawing.Point(0, 0);
            this.lblYildizUrunAd.Name = "lblYildizUrunAd";
            this.lblYildizUrunAd.Size = new System.Drawing.Size(100, 23);
            this.lblYildizUrunAd.TabIndex = 0;
            // 
            // lblYildizBirim
            // 
            this.lblYildizBirim.Location = new System.Drawing.Point(0, 0);
            this.lblYildizBirim.Name = "lblYildizBirim";
            this.lblYildizBirim.Size = new System.Drawing.Size(100, 23);
            this.lblYildizBirim.TabIndex = 0;
            // 
            // lblYildizFiyat
            // 
            this.lblYildizFiyat.Location = new System.Drawing.Point(0, 0);
            this.lblYildizFiyat.Name = "lblYildizFiyat";
            this.lblYildizFiyat.Size = new System.Drawing.Size(100, 23);
            this.lblYildizFiyat.TabIndex = 0;
            // 
            // lblYildizStok
            // 
            this.lblYildizStok.Location = new System.Drawing.Point(0, 0);
            this.lblYildizStok.Name = "lblYildizStok";
            this.lblYildizStok.Size = new System.Drawing.Size(100, 23);
            this.lblYildizStok.TabIndex = 0;
            // 
            // lblYildizKategori
            // 
            this.lblYildizKategori.Location = new System.Drawing.Point(0, 0);
            this.lblYildizKategori.Name = "lblYildizKategori";
            this.lblYildizKategori.Size = new System.Drawing.Size(100, 23);
            this.lblYildizKategori.TabIndex = 0;
            // 
            // grpBirebirArama
            // 
            this.grpBirebirArama.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.grpBirebirArama.Controls.Add(this.btnBirebirAra);
            this.grpBirebirArama.Controls.Add(this.txtBirebirKategori);
            this.grpBirebirArama.Controls.Add(this.chkKategori);
            this.grpBirebirArama.Controls.Add(this.txtBirebirUrunAdi);
            this.grpBirebirArama.Controls.Add(this.chkUrunAdi);
            this.grpBirebirArama.Location = new System.Drawing.Point(400, 39);
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
            // txtBirebirKategori
            // 
            this.txtBirebirKategori.Enabled = false;
            this.txtBirebirKategori.Location = new System.Drawing.Point(110, 63);
            this.txtBirebirKategori.Name = "txtBirebirKategori";
            this.txtBirebirKategori.Size = new System.Drawing.Size(130, 22);
            this.txtBirebirKategori.TabIndex = 3;
            // 
            // chkKategori
            // 
            this.chkKategori.AutoSize = true;
            this.chkKategori.Location = new System.Drawing.Point(20, 65);
            this.chkKategori.Name = "chkKategori";
            this.chkKategori.Size = new System.Drawing.Size(79, 20);
            this.chkKategori.TabIndex = 2;
            this.chkKategori.Text = "Kategori";
            this.chkKategori.UseVisualStyleBackColor = true;
            this.chkKategori.CheckedChanged += new System.EventHandler(this.chkKategori_CheckedChanged);
            // 
            // txtBirebirUrunAdi
            // 
            this.txtBirebirUrunAdi.Enabled = false;
            this.txtBirebirUrunAdi.Location = new System.Drawing.Point(110, 28);
            this.txtBirebirUrunAdi.Name = "txtBirebirUrunAdi";
            this.txtBirebirUrunAdi.Size = new System.Drawing.Size(130, 22);
            this.txtBirebirUrunAdi.TabIndex = 1;
            // 
            // chkUrunAdi
            // 
            this.chkUrunAdi.AutoSize = true;
            this.chkUrunAdi.Location = new System.Drawing.Point(20, 30);
            this.chkUrunAdi.Name = "chkUrunAdi";
            this.chkUrunAdi.Size = new System.Drawing.Size(80, 20);
            this.chkUrunAdi.TabIndex = 0;
            this.chkUrunAdi.Text = "Ürün Adı";
            this.chkUrunAdi.UseVisualStyleBackColor = true;
            this.chkUrunAdi.CheckedChanged += new System.EventHandler(this.chkUrunAdi_CheckedChanged);
            // 
            // grpHizliArama
            // 
            this.grpHizliArama.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.grpHizliArama.Controls.Add(this.txtHizliAramaSecim);
            this.grpHizliArama.Controls.Add(this.lblHizliAramaDeger);
            this.grpHizliArama.Controls.Add(this.grpAlanSecimi);
            this.grpHizliArama.Controls.Add(this.cmbHizliAramaTuru);
            this.grpHizliArama.Controls.Add(this.labelAramaTuru);
            this.grpHizliArama.Location = new System.Drawing.Point(680, 39);
            this.grpHizliArama.Name = "grpHizliArama";
            this.grpHizliArama.Size = new System.Drawing.Size(280, 210);
            this.grpHizliArama.TabIndex = 12;
            this.grpHizliArama.TabStop = false;
            this.grpHizliArama.Text = "Hızlı Arama";
            // 
            // txtHizliAramaSecim
            // 
            this.txtHizliAramaSecim.Location = new System.Drawing.Point(100, 147);
            this.txtHizliAramaSecim.Name = "txtHizliAramaSecim";
            this.txtHizliAramaSecim.Size = new System.Drawing.Size(160, 22);
            this.txtHizliAramaSecim.TabIndex = 4;
            this.txtHizliAramaSecim.TextChanged += new System.EventHandler(this.txtHizliAramaSecim_TextChanged);
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
            // grpAlanSecimi
            // 
            this.grpAlanSecimi.Controls.Add(this.rdbKategori);
            this.grpAlanSecimi.Controls.Add(this.rdbUrunAd);
            this.grpAlanSecimi.Location = new System.Drawing.Point(18, 65);
            this.grpAlanSecimi.Name = "grpAlanSecimi";
            this.grpAlanSecimi.Size = new System.Drawing.Size(242, 60);
            this.grpAlanSecimi.TabIndex = 2;
            this.grpAlanSecimi.TabStop = false;
            this.grpAlanSecimi.Text = "Alan Seçimi";
            // 
            // rdbKategori
            // 
            this.rdbKategori.AutoSize = true;
            this.rdbKategori.Location = new System.Drawing.Point(120, 25);
            this.rdbKategori.Name = "rdbKategori";
            this.rdbKategori.Size = new System.Drawing.Size(78, 20);
            this.rdbKategori.TabIndex = 1;
            this.rdbKategori.Text = "Kategori";
            this.rdbKategori.UseVisualStyleBackColor = true;
            this.rdbKategori.CheckedChanged += new System.EventHandler(this.HizliAramaRadio_CheckedChanged);
            // 
            // rdbUrunAd
            // 
            this.rdbUrunAd.AutoSize = true;
            this.rdbUrunAd.Checked = true;
            this.rdbUrunAd.Location = new System.Drawing.Point(15, 25);
            this.rdbUrunAd.Name = "rdbUrunAd";
            this.rdbUrunAd.Size = new System.Drawing.Size(79, 20);
            this.rdbUrunAd.TabIndex = 0;
            this.rdbUrunAd.TabStop = true;
            this.rdbUrunAd.Text = "Ürün Adı";
            this.rdbUrunAd.UseVisualStyleBackColor = true;
            this.rdbUrunAd.CheckedChanged += new System.EventHandler(this.HizliAramaRadio_CheckedChanged);
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
            this.cmbHizliAramaTuru.Size = new System.Drawing.Size(160, 24);
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
            // StokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 601);
            this.Controls.Add(this.grpHizliArama);
            this.Controls.Add(this.grpBirebirArama);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBirim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUrunler);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StokForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Form";
            this.Load += new System.EventHandler(this.StokForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
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
        private System.Windows.Forms.ToolStripButton toolStripButtonEkle;
        private System.Windows.Forms.ToolStripButton toolStripButtonSil;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuncelle;
        private System.Windows.Forms.ToolStripButton toolStripButtonTemizle;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonTanimlamalar;
        private System.Windows.Forms.ToolStripMenuItem birimTanimlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriTanimlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonRaporlar;
        private System.Windows.Forms.ToolStripMenuItem stokRaporuToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBirim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label lblYildizUrunAd;
        private System.Windows.Forms.Label lblYildizBirim;
        private System.Windows.Forms.Label lblYildizFiyat;
        private System.Windows.Forms.Label lblYildizStok;
        private System.Windows.Forms.Label lblYildizKategori;
        private System.Windows.Forms.GroupBox grpBirebirArama;
        private System.Windows.Forms.CheckBox chkUrunAdi;
        private System.Windows.Forms.TextBox txtBirebirUrunAdi;
        private System.Windows.Forms.CheckBox chkKategori;
        private System.Windows.Forms.TextBox txtBirebirKategori;
        private System.Windows.Forms.Button btnBirebirAra;
        private System.Windows.Forms.GroupBox grpHizliArama;
        private System.Windows.Forms.Label labelAramaTuru;
        private System.Windows.Forms.ComboBox cmbHizliAramaTuru;
        private System.Windows.Forms.GroupBox grpAlanSecimi;
        private System.Windows.Forms.RadioButton rdbUrunAd;  // İsim değişti
        private System.Windows.Forms.RadioButton rdbKategori; // İsim değişti
        private System.Windows.Forms.Label lblHizliAramaDeger;
        private System.Windows.Forms.TextBox txtHizliAramaSecim;
    }
}