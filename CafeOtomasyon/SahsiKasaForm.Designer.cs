namespace CafeOtomasyon
{
    partial class SahsiKasaForm
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
        private System.Windows.Forms.ComboBox cmbIslemTuru;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtKullaniciID;
        private System.Windows.Forms.DataGridView dgvKasa;
        private System.Windows.Forms.Label lblIslemTuru;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblKullaniciID;

        // Arama Kontrolleri
        private System.Windows.Forms.GroupBox grpBirebirArama;
        private System.Windows.Forms.Button btnBirebirAra;
        private System.Windows.Forms.CheckBox chkIslemTuru;
        private System.Windows.Forms.TextBox txtBirebirIslemTuru;
        private System.Windows.Forms.CheckBox chkTutar;
        private System.Windows.Forms.TextBox txtBirebirTutar;

        private System.Windows.Forms.GroupBox grpHizliArama;
        private System.Windows.Forms.Label labelAramaTuru;
        private System.Windows.Forms.ComboBox cmbHizliAramaTuru;
        private System.Windows.Forms.GroupBox grpAlanSecimi;
        private System.Windows.Forms.RadioButton rdbIslemTuru;
        private System.Windows.Forms.RadioButton rdbTutar;
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
            this.cmbIslemTuru = new System.Windows.Forms.ComboBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtKullaniciID = new System.Windows.Forms.TextBox();
            this.dgvKasa = new System.Windows.Forms.DataGridView();
            this.lblIslemTuru = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblKullaniciID = new System.Windows.Forms.Label();

            this.grpBirebirArama = new System.Windows.Forms.GroupBox();
            this.btnBirebirAra = new System.Windows.Forms.Button();
            this.chkIslemTuru = new System.Windows.Forms.CheckBox();
            this.txtBirebirIslemTuru = new System.Windows.Forms.TextBox();
            this.chkTutar = new System.Windows.Forms.CheckBox();
            this.txtBirebirTutar = new System.Windows.Forms.TextBox();

            this.grpHizliArama = new System.Windows.Forms.GroupBox();
            this.txtHizliAramaSecim = new System.Windows.Forms.TextBox();
            this.lblHizliAramaDeger = new System.Windows.Forms.Label();
            this.grpAlanSecimi = new System.Windows.Forms.GroupBox();
            this.rdbIslemTuru = new System.Windows.Forms.RadioButton();
            this.rdbTutar = new System.Windows.Forms.RadioButton();
            this.cmbHizliAramaTuru = new System.Windows.Forms.ComboBox();
            this.labelAramaTuru = new System.Windows.Forms.Label();

            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKasa)).BeginInit();
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
            // cmbIslemTuru
            // 
            this.cmbIslemTuru.FormattingEnabled = true;
            this.cmbIslemTuru.Location = new System.Drawing.Point(100, 42);
            this.cmbIslemTuru.Name = "cmbIslemTuru";
            this.cmbIslemTuru.Size = new System.Drawing.Size(170, 24);
            this.cmbIslemTuru.TabIndex = 0;

            // 
            // lblIslemTuru
            // 
            this.lblIslemTuru.AutoSize = true;
            this.lblIslemTuru.Location = new System.Drawing.Point(20, 45);
            this.lblIslemTuru.Name = "lblIslemTuru";
            this.lblIslemTuru.Size = new System.Drawing.Size(69, 16);
            this.lblIslemTuru.TabIndex = 1;
            this.lblIslemTuru.Text = "İşlem Türü";

            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(100, 77);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(170, 22);
            this.txtTutar.TabIndex = 2;
            this.txtTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTutar_KeyPress);

            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(20, 80);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(38, 16);
            this.lblTutar.TabIndex = 3;
            this.lblTutar.Text = "Tutar";

            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(100, 112);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(360, 22);
            this.txtAciklama.TabIndex = 3;

            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(20, 115);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(63, 16);
            this.lblAciklama.TabIndex = 5;
            this.lblAciklama.Text = "Açıklama";

            // 
            // txtKullaniciID
            // 
            this.txtKullaniciID.Location = new System.Drawing.Point(360, 42);
            this.txtKullaniciID.Name = "txtKullaniciID";
            this.txtKullaniciID.Size = new System.Drawing.Size(100, 22);
            this.txtKullaniciID.TabIndex = 1;
            this.txtKullaniciID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullaniciID_KeyPress);

            // 
            // lblKullaniciID
            // 
            this.lblKullaniciID.AutoSize = true;
            this.lblKullaniciID.Location = new System.Drawing.Point(280, 45);
            this.lblKullaniciID.Name = "lblKullaniciID";
            this.lblKullaniciID.Size = new System.Drawing.Size(72, 16);
            this.lblKullaniciID.TabIndex = 7;
            this.lblKullaniciID.Text = "Kullanıcı ID";

            // 
            // dgvKasa
            // 
            this.dgvKasa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKasa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKasa.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKasa.Location = new System.Drawing.Point(12, 180);
            this.dgvKasa.Name = "dgvKasa";
            this.dgvKasa.RowHeadersWidth = 51;
            this.dgvKasa.RowTemplate.Height = 24;
            this.dgvKasa.Size = new System.Drawing.Size(1000, 400);
            this.dgvKasa.TabIndex = 9;
            this.dgvKasa.TabStop = false;
            this.dgvKasa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKasa_CellClick);

            // 
            // grpBirebirArama
            // 
            this.grpBirebirArama.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.grpBirebirArama.Controls.Add(this.btnBirebirAra);
            this.grpBirebirArama.Controls.Add(this.txtBirebirTutar);
            this.grpBirebirArama.Controls.Add(this.chkTutar);
            this.grpBirebirArama.Controls.Add(this.txtBirebirIslemTuru);
            this.grpBirebirArama.Controls.Add(this.chkIslemTuru);
            this.grpBirebirArama.Location = new System.Drawing.Point(490, 40);
            this.grpBirebirArama.Name = "grpBirebirArama";
            this.grpBirebirArama.Size = new System.Drawing.Size(240, 120);
            this.grpBirebirArama.TabIndex = 10;
            this.grpBirebirArama.TabStop = false;
            this.grpBirebirArama.Text = "Birebir Arama";
            // 
            // btnBirebirAra
            // 
            this.btnBirebirAra.Location = new System.Drawing.Point(15, 80);
            this.btnBirebirAra.Name = "btnBirebirAra";
            this.btnBirebirAra.Size = new System.Drawing.Size(210, 30);
            this.btnBirebirAra.TabIndex = 4;
            this.btnBirebirAra.Text = "Ara";
            this.btnBirebirAra.UseVisualStyleBackColor = true;
            this.btnBirebirAra.Click += new System.EventHandler(this.btnBirebirAra_Click);
            // 
            // chkIslemTuru
            // 
            this.chkIslemTuru.AutoSize = true;
            this.chkIslemTuru.Location = new System.Drawing.Point(15, 25);
            this.chkIslemTuru.Name = "chkIslemTuru";
            this.chkIslemTuru.Size = new System.Drawing.Size(90, 20);
            this.chkIslemTuru.TabIndex = 0;
            this.chkIslemTuru.Text = "İşlem Türü";
            this.chkIslemTuru.UseVisualStyleBackColor = true;
            this.chkIslemTuru.CheckedChanged += new System.EventHandler(this.chkArama_CheckedChanged);
            // 
            // txtBirebirIslemTuru
            // 
            this.txtBirebirIslemTuru.Enabled = false;
            this.txtBirebirIslemTuru.Location = new System.Drawing.Point(120, 23);
            this.txtBirebirIslemTuru.Name = "txtBirebirIslemTuru";
            this.txtBirebirIslemTuru.Size = new System.Drawing.Size(105, 22);
            this.txtBirebirIslemTuru.TabIndex = 1;
            // 
            // chkTutar
            // 
            this.chkTutar.AutoSize = true;
            this.chkTutar.Location = new System.Drawing.Point(15, 55);
            this.chkTutar.Name = "chkTutar";
            this.chkTutar.Size = new System.Drawing.Size(60, 20);
            this.chkTutar.TabIndex = 2;
            this.chkTutar.Text = "Tutar";
            this.chkTutar.UseVisualStyleBackColor = true;
            this.chkTutar.CheckedChanged += new System.EventHandler(this.chkArama_CheckedChanged);
            // 
            // txtBirebirTutar
            // 
            this.txtBirebirTutar.Enabled = false;
            this.txtBirebirTutar.Location = new System.Drawing.Point(120, 53);
            this.txtBirebirTutar.Name = "txtBirebirTutar";
            this.txtBirebirTutar.Size = new System.Drawing.Size(105, 22);
            this.txtBirebirTutar.TabIndex = 3;

            // 
            // grpHizliArama
            // 
            this.grpHizliArama.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.grpHizliArama.Controls.Add(this.txtHizliAramaSecim);
            this.grpHizliArama.Controls.Add(this.lblHizliAramaDeger);
            this.grpHizliArama.Controls.Add(this.grpAlanSecimi);
            this.grpHizliArama.Controls.Add(this.cmbHizliAramaTuru);
            this.grpHizliArama.Controls.Add(this.labelAramaTuru);
            this.grpHizliArama.Location = new System.Drawing.Point(745, 40);
            this.grpHizliArama.Name = "grpHizliArama";
            this.grpHizliArama.Size = new System.Drawing.Size(270, 120);
            this.grpHizliArama.TabIndex = 11;
            this.grpHizliArama.TabStop = false;
            this.grpHizliArama.Text = "Hızlı Arama";
            // 
            // labelAramaTuru
            // 
            this.labelAramaTuru.AutoSize = true;
            this.labelAramaTuru.Location = new System.Drawing.Point(10, 25);
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
            this.cmbHizliAramaTuru.Location = new System.Drawing.Point(95, 22);
            this.cmbHizliAramaTuru.Name = "cmbHizliAramaTuru";
            this.cmbHizliAramaTuru.Size = new System.Drawing.Size(160, 24);
            this.cmbHizliAramaTuru.TabIndex = 1;
            // 
            // grpAlanSecimi
            // 
            this.grpAlanSecimi.Controls.Add(this.rdbTutar);
            this.grpAlanSecimi.Controls.Add(this.rdbIslemTuru);
            this.grpAlanSecimi.Location = new System.Drawing.Point(10, 45);
            this.grpAlanSecimi.Name = "grpAlanSecimi";
            this.grpAlanSecimi.Size = new System.Drawing.Size(245, 45);
            this.grpAlanSecimi.TabIndex = 2;
            this.grpAlanSecimi.TabStop = false;
            this.grpAlanSecimi.Text = "Alan Seçimi";
            // 
            // rdbIslemTuru
            // 
            this.rdbIslemTuru.AutoSize = true;
            this.rdbIslemTuru.Checked = true;
            this.rdbIslemTuru.Location = new System.Drawing.Point(10, 18);
            this.rdbIslemTuru.Name = "rdbIslemTuru";
            this.rdbIslemTuru.Size = new System.Drawing.Size(90, 20);
            this.rdbIslemTuru.TabIndex = 0;
            this.rdbIslemTuru.TabStop = true;
            this.rdbIslemTuru.Text = "İşlem Türü";
            this.rdbIslemTuru.UseVisualStyleBackColor = true;
            this.rdbIslemTuru.CheckedChanged += new System.EventHandler(this.HizliAramaRadio_CheckedChanged);
            // 
            // rdbTutar
            // 
            this.rdbTutar.AutoSize = true;
            this.rdbTutar.Location = new System.Drawing.Point(130, 18);
            this.rdbTutar.Name = "rdbTutar";
            this.rdbTutar.Size = new System.Drawing.Size(59, 20);
            this.rdbTutar.TabIndex = 1;
            this.rdbTutar.Text = "Tutar";
            this.rdbTutar.UseVisualStyleBackColor = true;
            this.rdbTutar.CheckedChanged += new System.EventHandler(this.HizliAramaRadio_CheckedChanged);
            // 
            // lblHizliAramaDeger
            // 
            this.lblHizliAramaDeger.AutoSize = true;
            this.lblHizliAramaDeger.Location = new System.Drawing.Point(10, 95);
            this.lblHizliAramaDeger.Name = "lblHizliAramaDeger";
            this.lblHizliAramaDeger.Size = new System.Drawing.Size(72, 16);
            this.lblHizliAramaDeger.TabIndex = 3;
            this.lblHizliAramaDeger.Text = "İşlem Türü:";
            // 
            // txtHizliAramaSecim
            // 
            this.txtHizliAramaSecim.Location = new System.Drawing.Point(95, 92);
            this.txtHizliAramaSecim.Name = "txtHizliAramaSecim";
            this.txtHizliAramaSecim.Size = new System.Drawing.Size(160, 22);
            this.txtHizliAramaSecim.TabIndex = 4;
            this.txtHizliAramaSecim.TextChanged += new System.EventHandler(this.txtHizliAramaSecim_TextChanged);

            // 
            // SahsiKasaForm
            // 
            this.ClientSize = new System.Drawing.Size(1036, 601);
            this.Controls.Add(this.grpHizliArama);
            this.Controls.Add(this.grpBirebirArama);
            this.Controls.Add(this.dgvKasa);
            this.Controls.Add(this.txtKullaniciID);
            this.Controls.Add(this.lblKullaniciID);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.cmbIslemTuru);
            this.Controls.Add(this.lblIslemTuru);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SahsiKasaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şahsi Kasa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SahsiKasaForm_FormClosing);
            this.Load += new System.EventHandler(this.SahsiKasaForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKasa)).EndInit();
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