using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeOtomasyon
{
    public partial class MasaDurumTakipForm : Form
    {
        public MasaDurumTakipForm()
        {
            InitializeComponent();
        }

        private void MasaDurumTakipForm_Load(object sender, EventArgs e)
        {
            Listele();

            // Arama Kutularının Başlangıç Ayarları
            txtBirebirMasaNo.Enabled = false;
            txtBirebirKapasite.Enabled = false;
            txtBirebirKonum.Enabled = false;

            cmbHizliAramaTuru.Items.Clear();
            cmbHizliAramaTuru.Items.Add("İçeren");
            cmbHizliAramaTuru.Items.Add("İle Başlayan");
            cmbHizliAramaTuru.Items.Add("İle Biten");
            cmbHizliAramaTuru.SelectedIndex = 0;

            lblHizliAramaDeger.Text = "Masa No:";
        }

        void Listele()
        {
            try
            {
                Form1.BaglantiAc();

                string sorgu = "SELECT ID, MasaNo, Kapasite, Konum, Durum, AcilisZamani, SonIslemTarihi FROM Masalar";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, Form1.Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvMasalar.DataSource = dt;
                dgvMasalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMasalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvMasalar.ReadOnly = true;
                dgvMasalar.AllowUserToAddRows = false;

                if (dgvMasalar.Columns.Contains("ID"))
                    dgvMasalar.Columns["ID"].Visible = false;

                if (dgvMasalar.Columns.Contains("MasaNo"))
                    dgvMasalar.Columns["MasaNo"].HeaderText = "Masa No";

                if (dgvMasalar.Columns.Contains("Kapasite"))
                    dgvMasalar.Columns["Kapasite"].HeaderText = "Kapasite";

                if (dgvMasalar.Columns.Contains("Konum"))
                    dgvMasalar.Columns["Konum"].HeaderText = "Konum";

                if (dgvMasalar.Columns.Contains("Durum"))
                    dgvMasalar.Columns["Durum"].HeaderText = "Durum";

                if (dgvMasalar.Columns.Contains("AcilisZamani"))
                    dgvMasalar.Columns["AcilisZamani"].HeaderText = "Açılış Zamanı";

                if (dgvMasalar.Columns.Contains("SonIslemTarihi"))
                    dgvMasalar.Columns["SonIslemTarihi"].HeaderText = "Son İşlem Tarihi";

                Form1.Baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme Hatası: " + ex.Message);

                if (Form1.Baglanti.State == ConnectionState.Open)
                    Form1.Baglanti.Close();
            }
        }

        private void toolStripButtonYenile_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void MasaDurumTakipForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cevap = MessageBox.Show(
                "Çıkmak istiyor musunuz?",
                "Çıkış Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (cevap == DialogResult.No)
                e.Cancel = true;
        }

        // =========================================================
        // Birebir Arama Bölümü
        // =========================================================

        private void chkArama_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;

            if (chk == chkMasaNo)
            {
                txtBirebirMasaNo.Enabled = chkMasaNo.Checked;
                if (!chkMasaNo.Checked) txtBirebirMasaNo.Clear();
                else txtBirebirMasaNo.Focus();
            }
            else if (chk == chkKapasite)
            {
                txtBirebirKapasite.Enabled = chkKapasite.Checked;
                if (!chkKapasite.Checked) txtBirebirKapasite.Clear();
                else txtBirebirKapasite.Focus();
            }
            else if (chk == chkKonum)
            {
                txtBirebirKonum.Enabled = chkKonum.Checked;
                if (!chkKonum.Checked) txtBirebirKonum.Clear();
                else txtBirebirKonum.Focus();
            }
        }

        public void KayitAra()
        {
            try
            {
                Form1.BaglantiAc();
                DataTable dt = new DataTable();

                string kosullar = "1=1";

                if (chkMasaNo.Checked && txtBirebirMasaNo.Text != "")
                    kosullar += " AND MasaNo = '" + txtBirebirMasaNo.Text.Replace("'", "''") + "'";

                if (chkKapasite.Checked && txtBirebirKapasite.Text != "")
                    kosullar += " AND Kapasite = '" + txtBirebirKapasite.Text.Replace("'", "''") + "'";

                if (chkKonum.Checked && txtBirebirKonum.Text != "")
                    kosullar += " AND Konum = '" + txtBirebirKonum.Text.Replace("'", "''") + "'";

                string sorgu = "SELECT ID, MasaNo, Kapasite, Konum, Durum, AcilisZamani, SonIslemTarihi FROM Masalar WHERE " + kosullar;

                SqlDataAdapter da = new SqlDataAdapter(sorgu, Form1.Baglanti);
                da.Fill(dt);
                dgvMasalar.DataSource = dt;
                Form1.Baglanti.Close();

                if (dgvMasalar.Columns.Contains("ID")) dgvMasalar.Columns["ID"].Visible = false;
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }

        private void btnBirebirAra_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        // =========================================================
        // Hızlı Arama Bölümü
        // =========================================================

        private void HizliAramaRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMasaNo.Checked)
                lblHizliAramaDeger.Text = "Masa No:";
            else if (rdbKapasite.Checked)
                lblHizliAramaDeger.Text = "Kapasite:";
            else if (rdbKonum.Checked)
                lblHizliAramaDeger.Text = "Konum:";

            txtHizliAramaSecim.Text = "";
            txtHizliAramaSecim.Focus();
        }

        public void HizliAra()
        {
            try
            {
                Form1.BaglantiAc();
                DataTable dt = new DataTable();

                string arananAlan = "MasaNo";
                if (rdbKapasite.Checked)
                    arananAlan = "Kapasite";
                else if (rdbKonum.Checked)
                    arananAlan = "Konum";

                string arananMetin = txtHizliAramaSecim.Text.Replace("'", "''");

                // Kapasite int, MasaNo varchar/int olabilir, CAST ile standartlaştırıyoruz.
                string SorguTum = "SELECT ID, MasaNo, Kapasite, Konum, Durum, AcilisZamani, SonIslemTarihi FROM Masalar";
                string SorguIleBaslayan = SorguTum + " WHERE CAST(" + arananAlan + " AS NVARCHAR(MAX)) LIKE '" + arananMetin + "%' ";
                string SorguIleBiten = SorguTum + " WHERE CAST(" + arananAlan + " AS NVARCHAR(MAX)) LIKE '%" + arananMetin + "' ";
                string SorguIceren = SorguTum + " WHERE CAST(" + arananAlan + " AS NVARCHAR(MAX)) LIKE '%" + arananMetin + "%' ";

                string CalisacakSorgu = SorguTum;

                if (txtHizliAramaSecim.Text.Trim() != "")
                {
                    if (cmbHizliAramaTuru.Text == "İle Başlayan")
                        CalisacakSorgu = SorguIleBaslayan;
                    else if (cmbHizliAramaTuru.Text == "İle Biten")
                        CalisacakSorgu = SorguIleBiten;
                    else if (cmbHizliAramaTuru.Text == "İçeren")
                        CalisacakSorgu = SorguIceren;
                }

                SqlDataAdapter da = new SqlDataAdapter(CalisacakSorgu, Form1.Baglanti);
                da.Fill(dt);
                dgvMasalar.DataSource = dt;
                Form1.Baglanti.Close();

                if (dgvMasalar.Columns.Contains("ID")) dgvMasalar.Columns["ID"].Visible = false;
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }

        private void txtHizliAramaSecim_TextChanged(object sender, EventArgs e)
        {
            HizliAra();
        }
    }
}