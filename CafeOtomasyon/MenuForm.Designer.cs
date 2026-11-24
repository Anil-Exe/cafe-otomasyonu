namespace CafeOtomasyon
{
    partial class MenuForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yoneticiPaneliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sifreSifirlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odemeAlmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sahsiKasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gunSonuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelListeFormuToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem masaYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masaIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem durumTakibiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem garsonPaneliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniSiparisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iptalGuncelleToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem siparisPaneliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokFormuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparisListeFormuToolStripMenuItem;

        private System.Windows.Forms.Label lblBilgi;

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yoneticiPaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sifreSifirlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odemeAlmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sahsiKasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gunSonuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelListeFormuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.garsonPaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniSiparisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iptalGuncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masaYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masaIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.durumTakibiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervasyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparisPaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokFormuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparisListeFormuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yoneticiPaneliToolStripMenuItem,
            this.garsonPaneliToolStripMenuItem,
            this.masaYonetimiToolStripMenuItem,
            this.siparisPaneliToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yoneticiPaneliToolStripMenuItem
            // 
            this.yoneticiPaneliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sifreSifirlamaToolStripMenuItem,
            this.odemeAlmaToolStripMenuItem,
            this.sahsiKasaToolStripMenuItem,
            this.gunSonuToolStripMenuItem,
            this.raporlamaToolStripMenuItem,
            this.personelListeFormuToolStripMenuItem});
            this.yoneticiPaneliToolStripMenuItem.Image = global::CafeOtomasyon.Properties.Resources.user_business;
            this.yoneticiPaneliToolStripMenuItem.Name = "yoneticiPaneliToolStripMenuItem";
            this.yoneticiPaneliToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.yoneticiPaneliToolStripMenuItem.Text = "Yönetici Paneli";
            // 
            // sifreSifirlamaToolStripMenuItem
            // 
            this.sifreSifirlamaToolStripMenuItem.Image = global::CafeOtomasyon.Properties.Resources.arrow_refresh;
            this.sifreSifirlamaToolStripMenuItem.Name = "sifreSifirlamaToolStripMenuItem";
            this.sifreSifirlamaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.sifreSifirlamaToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.sifreSifirlamaToolStripMenuItem.Text = "Şifre Sıfırlama";
            this.sifreSifirlamaToolStripMenuItem.Click += new System.EventHandler(this.sifreSifirlamaToolStripMenuItem_Click);
            // 
            // odemeAlmaToolStripMenuItem
            // 
            this.odemeAlmaToolStripMenuItem.Image = global::CafeOtomasyon.Properties.Resources.application_add;
            this.odemeAlmaToolStripMenuItem.Name = "odemeAlmaToolStripMenuItem";
            this.odemeAlmaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.odemeAlmaToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.odemeAlmaToolStripMenuItem.Text = "Ödeme Alma";
            this.odemeAlmaToolStripMenuItem.Click += new System.EventHandler(this.odemeAlmaToolStripMenuItem_Click);
            // 
            // sahsiKasaToolStripMenuItem
            // 
            this.sahsiKasaToolStripMenuItem.Image = global::CafeOtomasyon.Properties.Resources.application_add;
            this.sahsiKasaToolStripMenuItem.Name = "sahsiKasaToolStripMenuItem";
            this.sahsiKasaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F3)));
            this.sahsiKasaToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.sahsiKasaToolStripMenuItem.Text = "Şahsi Kasa Alımı";
            this.sahsiKasaToolStripMenuItem.Click += new System.EventHandler(this.sahsiKasaToolStripMenuItem_Click);
            // 
            // gunSonuToolStripMenuItem
            // 
            this.gunSonuToolStripMenuItem.Image = global::CafeOtomasyon.Properties.Resources.user_business;
            this.gunSonuToolStripMenuItem.Name = "gunSonuToolStripMenuItem";
            this.gunSonuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.gunSonuToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.gunSonuToolStripMenuItem.Text = "Gün Sonu";
            this.gunSonuToolStripMenuItem.Click += new System.EventHandler(this.gunSonuToolStripMenuItem_Click);
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.Image = global::CafeOtomasyon.Properties.Resources.ipod;
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5)));
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.raporlamaToolStripMenuItem.Text = "Raporlama";
            this.raporlamaToolStripMenuItem.Click += new System.EventHandler(this.raporlamaToolStripMenuItem_Click);
            // 
            // personelListeFormuToolStripMenuItem
            // 
            this.personelListeFormuToolStripMenuItem.Image = global::CafeOtomasyon.Properties.Resources.group;
            this.personelListeFormuToolStripMenuItem.Name = "personelListeFormuToolStripMenuItem";
            this.personelListeFormuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F6)));
            this.personelListeFormuToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.personelListeFormuToolStripMenuItem.Text = "Personel Listesi";
            this.personelListeFormuToolStripMenuItem.Click += new System.EventHandler(this.personelListeFormuToolStripMenuItem_Click);
            // 
            // garsonPaneliToolStripMenuItem
            // 
            this.garsonPaneliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniSiparisToolStripMenuItem,
            this.iptalGuncelleToolStripMenuItem});
            this.garsonPaneliToolStripMenuItem.Image = global::CafeOtomasyon.Properties.Resources.group;
            this.garsonPaneliToolStripMenuItem.Name = "garsonPaneliToolStripMenuItem";
            this.garsonPaneliToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.garsonPaneliToolStripMenuItem.Text = "Garson Paneli";
            // 
            // yeniSiparisToolStripMenuItem
            // 
            this.yeniSiparisToolStripMenuItem.Image = global::CafeOtomasyon.Properties.Resources.application_add;
            this.yeniSiparisToolStripMenuItem.Name = "yeniSiparisToolStripMenuItem";
            this.yeniSiparisToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F1)));
            this.yeniSiparisToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.yeniSiparisToolStripMenuItem.Text = "Yeni Sipariş";
            this.yeniSiparisToolStripMenuItem.Click += new System.EventHandler(this.yeniSiparisToolStripMenuItem_Click);
            // 
            // iptalGuncelleToolStripMenuItem
            // 
            this.iptalGuncelleToolStripMenuItem.Image = global::CafeOtomasyon.Properties.Resources.arrow_refresh;
            this.iptalGuncelleToolStripMenuItem.Name = "iptalGuncelleToolStripMenuItem";
            this.iptalGuncelleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F2)));
            this.iptalGuncelleToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.iptalGuncelleToolStripMenuItem.Text = "İptal / Güncelleme";
            this.iptalGuncelleToolStripMenuItem.Click += new System.EventHandler(this.iptalGuncelleToolStripMenuItem_Click);
            // 
            // masaYonetimiToolStripMenuItem
            // 
            this.masaYonetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masaIslemleriToolStripMenuItem,
            this.durumTakibiToolStripMenuItem,
            this.rezervasyonToolStripMenuItem});
            this.masaYonetimiToolStripMenuItem.Image = global::CafeOtomasyon.Properties.Resources.ipod;
            this.masaYonetimiToolStripMenuItem.Name = "masaYonetimiToolStripMenuItem";
            this.masaYonetimiToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.masaYonetimiToolStripMenuItem.Text = "Masa Yönetimi";
            // 
            // masaIslemleriToolStripMenuItem
            // 
            this.masaIslemleriToolStripMenuItem.Image = global::CafeOtomasyon.Properties.Resources.application_add;
            this.masaIslemleriToolStripMenuItem.Name = "masaIslemleriToolStripMenuItem";
            this.masaIslemleriToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F1)));
            this.masaIslemleriToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.masaIslemleriToolStripMenuItem.Text = "Masa Ekleme / Silme";
            this.masaIslemleriToolStripMenuItem.Click += new System.EventHandler(this.masaIslemleriToolStripMenuItem_Click);
            // 
            // durumTakibiToolStripMenuItem
            // 
            this.durumTakibiToolStripMenuItem.Image = global::CafeOtomasyon.Properties.Resources.ipod;
            this.durumTakibiToolStripMenuItem.Name = "durumTakibiToolStripMenuItem";
            this.durumTakibiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F2)));
            this.durumTakibiToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.durumTakibiToolStripMenuItem.Text = "Durum Takibi";
            this.durumTakibiToolStripMenuItem.Click += new System.EventHandler(this.durumTakibiToolStripMenuItem_Click);
            // 
            // rezervasyonToolStripMenuItem
            // 
            this.rezervasyonToolStripMenuItem.Image = global::CafeOtomasyon.Properties.Resources.user_business;
            this.rezervasyonToolStripMenuItem.Name = "rezervasyonToolStripMenuItem";
            this.rezervasyonToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F3)));
            this.rezervasyonToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.rezervasyonToolStripMenuItem.Text = "Rezervasyon";
            this.rezervasyonToolStripMenuItem.Click += new System.EventHandler(this.rezervasyonToolStripMenuItem_Click);
            // 
            // siparisPaneliToolStripMenuItem
            // 
            this.siparisPaneliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urunRaporuToolStripMenuItem,
            this.stokFormuToolStripMenuItem,
            this.siparisListeFormuToolStripMenuItem});
            this.siparisPaneliToolStripMenuItem.Image = global::CafeOtomasyon.Properties.Resources.application_edit;
            this.siparisPaneliToolStripMenuItem.Name = "siparisPaneliToolStripMenuItem";
            this.siparisPaneliToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.siparisPaneliToolStripMenuItem.Text = "Sipariş Paneli";
            // 
            // urunRaporuToolStripMenuItem
            // 
            this.urunRaporuToolStripMenuItem.Name = "urunRaporuToolStripMenuItem";
            this.urunRaporuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F10)));
            this.urunRaporuToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.urunRaporuToolStripMenuItem.Text = "Ürün Raporu";
            this.urunRaporuToolStripMenuItem.Click += new System.EventHandler(this.urunRaporuToolStripMenuItem_Click);
            // 
            // stokFormuToolStripMenuItem
            // 
            this.stokFormuToolStripMenuItem.Name = "stokFormuToolStripMenuItem";
            this.stokFormuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F11)));
            this.stokFormuToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.stokFormuToolStripMenuItem.Text = "Stok Formu";
            this.stokFormuToolStripMenuItem.Click += new System.EventHandler(this.stokFormuToolStripMenuItem_Click);
            // 
            // siparisListeFormuToolStripMenuItem
            // 
            this.siparisListeFormuToolStripMenuItem.Name = "siparisListeFormuToolStripMenuItem";
            this.siparisListeFormuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F12)));
            this.siparisListeFormuToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.siparisListeFormuToolStripMenuItem.Text = "Sipariş Liste Formu";
            this.siparisListeFormuToolStripMenuItem.Click += new System.EventHandler(this.siparisListeFormuToolStripMenuItem_Click);
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi.Location = new System.Drawing.Point(12, 40);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(136, 31);
            this.lblBilgi.TabIndex = 0;
            this.lblBilgi.Text = "Hoşgeldin: ";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafe ROBS - Ana Menü";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}