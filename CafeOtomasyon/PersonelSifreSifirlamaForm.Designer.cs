namespace CafeOtomasyon
{
    partial class PersonelSifreSifirlamaForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSifirla;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuncelle;
        private System.Windows.Forms.ToolStripButton toolStripButtonTemizle;
        private System.Windows.Forms.ToolStripButton toolStripButtonYenile;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.DataGridView dgvPersonel;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblYeniSifre;

        // Arama Kontrolleri
        private System.Windows.Forms.GroupBox grpBirebirArama;
        private System.Windows.Forms.Button btnBirebirAra;
        private System.Windows.Forms.CheckBox chkAdSoyad;
        private System.Windows.Forms.TextBox txtBirebirAdSoyad;
        private System.Windows.Forms.CheckBox chkSifre;
        private System.Windows.Forms.TextBox txtBirebirSifre;

        private System.Windows.Forms.GroupBox grpHizliArama;
        private System.Windows.Forms.Label labelAramaTuru;
        private System.Windows.Forms.ComboBox cmbHizliAramaTuru;
        private System.Windows.Forms.GroupBox grpAlanSecimi;
        private System.Windows.Forms.RadioButton rdbAdSoyad;
        private System.Windows.Forms.RadioButton rdbSifre;
        private System.Windows.Forms.Label lblHizliAramaDeger;
        private System.Windows.Forms.TextBox txtHizliAramaSecim;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSifirla = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTemizle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonYenile = new System.Windows.Forms.ToolStripButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.dgvPersonel = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblYeniSifre = new System.Windows.Forms.Label();

            this.grpBirebirArama = new System.Windows.Forms.GroupBox();
            this.btnBirebirAra = new System.Windows.Forms.Button();
            this.txtBirebirAdSoyad = new System.Windows.Forms.TextBox();
            this.chkAdSoyad = new System.Windows.Forms.CheckBox();
            this.txtBirebirSifre = new System.Windows.Forms.TextBox();
            this.chkSifre = new System.Windows.Forms.CheckBox();

            this.grpHizliArama = new System.Windows.Forms.GroupBox();
            this.txtHizliAramaSecim = new System.Windows.Forms.TextBox();
            this.lblHizliAramaDeger = new System.Windows.Forms.Label();
            this.grpAlanSecimi = new System.Windows.Forms.GroupBox();
            this.rdbAdSoyad = new System.Windows.Forms.RadioButton();
            this.rdbSifre = new System.Windows.Forms.RadioButton();
            this.cmbHizliAramaTuru = new System.Windows.Forms.ComboBox();
            this.labelAramaTuru = new System.Windows.Forms.Label();

            this.toolStrip1.SuspendLayout();
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
            this.toolStripButtonSifirla,
            this.toolStripButtonGuncelle,
            this.toolStripButtonTemizle,
            this.toolStripButtonYenile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1036, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";

            // 
            // toolStripButtonSifirla
            // 
            this.toolStripButtonSifirla.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSifirla.Name = "toolStripButtonSifirla";
            this.toolStripButtonSifirla.Size = new System.Drawing.Size(66, 24);
            this.toolStripButtonSifirla.Text = "Şifre Sıfırla";
            this.toolStripButtonSifirla.Click += new System.EventHandler(this.toolStripButtonSifirla_Click);

            // 
            // toolStripButtonGuncelle
            // 
            this.toolStripButtonGuncelle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonGuncelle.Name = "toolStripButtonGuncelle";
            this.toolStripButtonGuncelle.Size = new System.Drawing.Size(57, 24);
            this.toolStripButtonGuncelle.Text = "Güncelle";
            this.toolStripButtonGuncelle.Click += new System.EventHandler(this.toolStripButtonGuncelle_Click);

            // 
            // toolStripButtonTemizle
            // 
            this.toolStripButtonTemizle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonTemizle.Name = "toolStripButtonTemizle";
            this.toolStripButtonTemizle.Size = new System.Drawing.Size(50, 24);
            this.toolStripButtonTemizle.Text = "Temizle";
            this.toolStripButtonTemizle.Click += new System.EventHandler(this.toolStripButtonTemizle_Click);

            // 
            // toolStripButtonYenile
            // 
            this.toolStripButtonYenile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonYenile.Name = "toolStripButtonYenile";
            this.toolStripButtonYenile.Size = new System.Drawing.Size(42, 24);
            this.toolStripButtonYenile.Text = "Yenile";
            this.toolStripButtonYenile.Click += new System.EventHandler(this.toolStripButtonYenile_Click);

            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(100, 42);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(120, 22);
            this.txtID.TabIndex = 0;

            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(20, 45);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";

            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Enabled = false;
            this.txtAdSoyad.Location = new System.Drawing.Point(100, 77);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(220, 22);
            this.txtAdSoyad.TabIndex = 1;

            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(20, 80);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(67, 16);
            this.lblAdSoyad.TabIndex = 3;
            this.lblAdSoyad.Text = "Ad Soyad";

            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(100, 112);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(220, 22);
            this.txtYeniSifre.TabIndex = 2;

            // 
            // lblYeniSifre
            // 
            this.lblYeniSifre.AutoSize = true;
            this.lblYeniSifre.Location = new System.Drawing.Point(20, 115);
            this.lblYeniSifre.Name = "lblYeniSifre";
            this.lblYeniSifre.Size = new System.Drawing.Size(64, 16);
            this.lblYeniSifre.TabIndex = 5;
            this.lblYeniSifre.Text = "Yeni Şifre";

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
            this.dgvPersonel.Location = new System.Drawing.Point(12, 230);
            this.dgvPersonel.Name = "dgvPersonel";
            this.dgvPersonel.RowHeadersWidth = 51;
            this.dgvPersonel.RowTemplate.Height = 24;
            this.dgvPersonel.Size = new System.Drawing.Size(1000, 350);
            this.dgvPersonel.TabIndex = 7;
            this.dgvPersonel.TabStop = false;
            this.dgvPersonel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonel_CellClick);

            // 
            // grpBirebirArama
            // 
            this.grpBirebirArama.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.grpBirebirArama.Controls.Add(this.btnBirebirAra);
            this.grpBirebirArama.Controls.Add(this.txtBirebirSifre);
            this.grpBirebirArama.Controls.Add(this.chkSifre);
            this.grpBirebirArama.Controls.Add(this.txtBirebirAdSoyad);
            this.grpBirebirArama.Controls.Add(this.chkAdSoyad);
            this.grpBirebirArama.Location = new System.Drawing.Point(360, 40);
            this.grpBirebirArama.Name = "grpBirebirArama";
            this.grpBirebirArama.Size = new System.Drawing.Size(260, 150);
            this.grpBirebirArama.TabIndex = 8;
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
            // txtBirebirSifre
            // 
            this.txtBirebirSifre.Enabled = false;
            this.txtBirebirSifre.Location = new System.Drawing.Point(110, 63);
            this.txtBirebirSifre.Name = "txtBirebirSifre";
            this.txtBirebirSifre.Size = new System.Drawing.Size(130, 22);
            this.txtBirebirSifre.TabIndex = 3;
            // 
            // chkSifre
            // 
            this.chkSifre.AutoSize = true;
            this.chkSifre.Location = new System.Drawing.Point(20, 65);
            this.chkSifre.Name = "chkSifre";
            this.chkSifre.Size = new System.Drawing.Size(56, 20);
            this.chkSifre.TabIndex = 2;
            this.chkSifre.Text = "Şifre";
            this.chkSifre.UseVisualStyleBackColor = true;
            this.chkSifre.CheckedChanged += new System.EventHandler(this.chkArama_CheckedChanged);
            // 
            // txtBirebirAdSoyad
            // 
            this.txtBirebirAdSoyad.Enabled = false;
            this.txtBirebirAdSoyad.Location = new System.Drawing.Point(110, 28);
            this.txtBirebirAdSoyad.Name = "txtBirebirAdSoyad";
            this.txtBirebirAdSoyad.Size = new System.Drawing.Size(130, 22);
            this.txtBirebirAdSoyad.TabIndex = 1;
            // 
            // chkAdSoyad
            // 
            this.chkAdSoyad.AutoSize = true;
            this.chkAdSoyad.Location = new System.Drawing.Point(20, 30);
            this.chkAdSoyad.Name = "chkAdSoyad";
            this.chkAdSoyad.Size = new System.Drawing.Size(89, 20);
            this.chkAdSoyad.TabIndex = 0;
            this.chkAdSoyad.Text = "Ad Soyad";
            this.chkAdSoyad.UseVisualStyleBackColor = true;
            this.chkAdSoyad.CheckedChanged += new System.EventHandler(this.chkArama_CheckedChanged);

            // 
            // grpHizliArama
            // 
            this.grpHizliArama.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.grpHizliArama.Controls.Add(this.txtHizliAramaSecim);
            this.grpHizliArama.Controls.Add(this.lblHizliAramaDeger);
            this.grpHizliArama.Controls.Add(this.grpAlanSecimi);
            this.grpHizliArama.Controls.Add(this.cmbHizliAramaTuru);
            this.grpHizliArama.Controls.Add(this.labelAramaTuru);
            this.grpHizliArama.Location = new System.Drawing.Point(640, 40);
            this.grpHizliArama.Name = "grpHizliArama";
            this.grpHizliArama.Size = new System.Drawing.Size(300, 150);
            this.grpHizliArama.TabIndex = 9;
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
            this.lblHizliAramaDeger.Size = new System.Drawing.Size(70, 16);
            this.lblHizliAramaDeger.TabIndex = 3;
            this.lblHizliAramaDeger.Text = "Ad Soyad:";
            // 
            // grpAlanSecimi
            // 
            this.grpAlanSecimi.Controls.Add(this.rdbSifre);
            this.grpAlanSecimi.Controls.Add(this.rdbAdSoyad);
            this.grpAlanSecimi.Location = new System.Drawing.Point(15, 55);
            this.grpAlanSecimi.Name = "grpAlanSecimi";
            this.grpAlanSecimi.Size = new System.Drawing.Size(265, 50);
            this.grpAlanSecimi.TabIndex = 2;
            this.grpAlanSecimi.TabStop = false;
            this.grpAlanSecimi.Text = "Alan Seçimi";
            // 
            // rdbSifre
            // 
            this.rdbSifre.AutoSize = true;
            this.rdbSifre.Location = new System.Drawing.Point(120, 20);
            this.rdbSifre.Name = "rdbSifre";
            this.rdbSifre.Size = new System.Drawing.Size(55, 20);
            this.rdbSifre.TabIndex = 1;
            this.rdbSifre.Text = "Şifre";
            this.rdbSifre.UseVisualStyleBackColor = true;
            this.rdbSifre.CheckedChanged += new System.EventHandler(this.HizliAramaRadio_CheckedChanged);
            // 
            // rdbAdSoyad
            // 
            this.rdbAdSoyad.AutoSize = true;
            this.rdbAdSoyad.Checked = true;
            this.rdbAdSoyad.Location = new System.Drawing.Point(15, 20);
            this.rdbAdSoyad.Name = "rdbAdSoyad";
            this.rdbAdSoyad.Size = new System.Drawing.Size(88, 20);
            this.rdbAdSoyad.TabIndex = 0;
            this.rdbAdSoyad.TabStop = true;
            this.rdbAdSoyad.Text = "Ad Soyad";
            this.rdbAdSoyad.UseVisualStyleBackColor = true;
            this.rdbAdSoyad.CheckedChanged += new System.EventHandler(this.HizliAramaRadio_CheckedChanged);
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
            // PersonelSifreSifirlamaForm
            // 
            this.ClientSize = new System.Drawing.Size(1036, 601);
            this.Controls.Add(this.grpHizliArama);
            this.Controls.Add(this.grpBirebirArama);
            this.Controls.Add(this.dgvPersonel);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.lblYeniSifre);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.toolStrip1);
            this.Name = "PersonelSifreSifirlamaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Sıfırlama ve Arama";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonelSifreSifirlamaForm_FormClosing);
            this.Load += new System.EventHandler(this.PersonelSifreSifirlamaForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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