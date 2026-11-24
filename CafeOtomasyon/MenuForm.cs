using System;
using System.Windows.Forms;

namespace CafeOtomasyon
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            this.FormClosing += MenuForm_FormClosing;
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            lblBilgi.Text = "Hoş Geldin: " + Oturum.AdSoyad;

            if (Oturum.Rol == 3 || Oturum.Rol == 2)
            {
                yoneticiPaneliToolStripMenuItem.Enabled = false;
                yoneticiPaneliToolStripMenuItem.Text = "🔒 Yönetici Paneli (Yetkisiz)";
            }
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void sifreSifirlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelSifreSifirlamaForm frm = new PersonelSifreSifirlamaForm();
            frm.Show();
        }

        private void odemeAlmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdemeAlmaForm frm = new OdemeAlmaForm();
            frm.Show();
        }

        private void sahsiKasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SahsiKasaForm frm = new SahsiKasaForm();
            frm.Show();
        }

        private void gunSonuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GunSonuForm frm = new GunSonuForm();
            frm.Show();
        }

        private void raporlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaporlamaForm frm = new RaporlamaForm();
            frm.Show();
        }

        private void personelListeFormuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelListeForm frm = new PersonelListeForm();
            frm.Show();
        }

        private void masaIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasaListesiForm frm = new MasaListesiForm();
            frm.Show();
        }

        private void durumTakibiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasaDurumTakipForm frm = new MasaDurumTakipForm();
            frm.Show();
        }

        private void rezervasyonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RezervasyonForm frm = new RezervasyonForm();
            frm.Show();
        }

        private void yeniSiparisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisForm frm = new SiparisForm();
            frm.Show();
        }

        private void iptalGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GarsonSiparisIslemForm frm = new GarsonSiparisIslemForm();
            frm.Show();
        }

        private void urunRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunRaporForm frm = new UrunRaporForm();
            frm.Show();
        }

        private void stokFormuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokForm frm = new StokForm();
            frm.Show();
        }

        private void siparisListeFormuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisListeForm frm = new SiparisListeForm();
            frm.Show();
        }
    }
}