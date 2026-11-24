using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeOtomasyon
{
    public partial class GarsonSiparisIslemForm : Form
    {
        public GarsonSiparisIslemForm()
        {
            InitializeComponent();
        }

        private void GarsonSiparisIslemForm_Load(object sender, EventArgs e)
        {
            cmbDurum.Items.Clear();
            cmbDurum.Items.Add("Hazırlanıyor");
            cmbDurum.Items.Add("Teslim Edildi");
            cmbDurum.Items.Add("İptal Edildi");
            cmbDurum.DropDownStyle = ComboBoxStyle.DropDownList;

            // Arama Kutularının Başlangıç Ayarları
            txtBirebirOdemeTipi.Enabled = false;
            txtBirebirToplamTutar.Enabled = false;
            txtBirebirDurum.Enabled = false;

            cmbHizliAramaTuru.Items.Clear();
            cmbHizliAramaTuru.Items.Add("İçeren");
            cmbHizliAramaTuru.Items.Add("İle Başlayan");
            cmbHizliAramaTuru.Items.Add("İle Biten");
            cmbHizliAramaTuru.SelectedIndex = 0;

            lblHizliAramaDeger.Text = "Ödeme Tipi:";

            Listele();
        }

        void Listele()
        {
            try
            {
                Form1.BaglantiAc();

                string sorgu = "SELECT ID, MasaID, KullaniciID, Tarih, AraToplam, KdvOrani, ToplamTutar, OdendiMi, OdemeTipi, Durum FROM Siparisler";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, Form1.Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvSiparisler.DataSource = dt;
                dgvSiparisler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvSiparisler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvSiparisler.ReadOnly = true;
                dgvSiparisler.AllowUserToAddRows = false;

                if (dgvSiparisler.Columns.Contains("ID"))
                    dgvSiparisler.Columns["ID"].Visible = false;

                if (dgvSiparisler.Columns.Contains("MasaID"))
                    dgvSiparisler.Columns["MasaID"].HeaderText = "Masa ID";

                if (dgvSiparisler.Columns.Contains("KullaniciID"))
                    dgvSiparisler.Columns["KullaniciID"].HeaderText = "Kullanıcı ID";

                if (dgvSiparisler.Columns.Contains("Tarih"))
                    dgvSiparisler.Columns["Tarih"].HeaderText = "Tarih";

                if (dgvSiparisler.Columns.Contains("AraToplam"))
                    dgvSiparisler.Columns["AraToplam"].HeaderText = "Ara Toplam";

                if (dgvSiparisler.Columns.Contains("KdvOrani"))
                    dgvSiparisler.Columns["KdvOrani"].HeaderText = "KDV Oranı";

                if (dgvSiparisler.Columns.Contains("ToplamTutar"))
                    dgvSiparisler.Columns["ToplamTutar"].HeaderText = "Toplam Tutar";

                if (dgvSiparisler.Columns.Contains("OdendiMi"))
                    dgvSiparisler.Columns["OdendiMi"].HeaderText = "Ödendi Mi";

                if (dgvSiparisler.Columns.Contains("OdemeTipi"))
                    dgvSiparisler.Columns["OdemeTipi"].HeaderText = "Ödeme Tipi";

                if (dgvSiparisler.Columns.Contains("Durum"))
                    dgvSiparisler.Columns["Durum"].HeaderText = "Durum";

                Form1.Baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme Hatası: " + ex.Message);

                if (Form1.Baglanti.State == ConnectionState.Open)
                    Form1.Baglanti.Close();
            }
        }

        private void dgvSiparisler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSiparisler.CurrentRow != null)
            {
                txtSiparisID.Text = dgvSiparisler.CurrentRow.Cells["ID"].Value.ToString();
                cmbDurum.Text = dgvSiparisler.CurrentRow.Cells["Durum"].Value.ToString();
            }
        }

        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            if (txtSiparisID.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen sipariş seçiniz.");
                return;
            }

            if (cmbDurum.Text.Trim() == "")
            {
                MessageBox.Show("Durum seçiniz.");
                return;
            }

            DialogResult cevap = MessageBox.Show("Sipariş durumu güncellensin mi?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap != DialogResult.Yes) return;

            try
            {
                Form1.BaglantiAc();

                string sorgu = "UPDATE Siparisler SET Durum=@durum WHERE ID=@id";
                SqlCommand cmd = new SqlCommand(sorgu, Form1.Baglanti);
                cmd.Parameters.AddWithValue("@durum", cmbDurum.Text);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtSiparisID.Text));

                cmd.ExecuteNonQuery();
                Form1.Baglanti.Close();

                MessageBox.Show("Sipariş güncellendi.");
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme Hatası: " + ex.Message);

                if (Form1.Baglanti.State == ConnectionState.Open)
                    Form1.Baglanti.Close();
            }
        }

        private void toolStripButtonIptalEt_Click(object sender, EventArgs e)
        {
            if (txtSiparisID.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen sipariş seçiniz.");
                return;
            }

            DialogResult cevap = MessageBox.Show("Sipariş iptal edilsin mi?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap != DialogResult.Yes) return;

            try
            {
                Form1.BaglantiAc();

                string sorgu = "UPDATE Siparisler SET Durum='İptal Edildi' WHERE ID=@id";
                SqlCommand cmd = new SqlCommand(sorgu, Form1.Baglanti);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtSiparisID.Text));

                cmd.ExecuteNonQuery();
                Form1.Baglanti.Close();

                MessageBox.Show("Sipariş iptal edildi.");
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İptal Hatası: " + ex.Message);

                if (Form1.Baglanti.State == ConnectionState.Open)
                    Form1.Baglanti.Close();
            }
        }

        private void toolStripButtonYenile_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void GarsonSiparisIslemForm_FormClosing(object sender, FormClosingEventArgs e)
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

            if (chk == chkOdemeTipi)
            {
                txtBirebirOdemeTipi.Enabled = chkOdemeTipi.Checked;
                if (!chkOdemeTipi.Checked) txtBirebirOdemeTipi.Clear();
                else txtBirebirOdemeTipi.Focus();
            }
            else if (chk == chkToplamTutar)
            {
                txtBirebirToplamTutar.Enabled = chkToplamTutar.Checked;
                if (!chkToplamTutar.Checked) txtBirebirToplamTutar.Clear();
                else txtBirebirToplamTutar.Focus();
            }
            else if (chk == chkDurum)
            {
                txtBirebirDurum.Enabled = chkDurum.Checked;
                if (!chkDurum.Checked) txtBirebirDurum.Clear();
                else txtBirebirDurum.Focus();
            }
        }

        public void KayitAra()
        {
            try
            {
                Form1.BaglantiAc();
                DataTable dt = new DataTable();

                string kosullar = "1=1"; // Her zaman doğru olan temel koşul

                if (chkOdemeTipi.Checked && txtBirebirOdemeTipi.Text != "")
                    kosullar += " AND OdemeTipi = '" + txtBirebirOdemeTipi.Text.Replace("'", "''") + "'";

                if (chkToplamTutar.Checked && txtBirebirToplamTutar.Text != "")
                    kosullar += " AND ToplamTutar = '" + txtBirebirToplamTutar.Text.Replace("'", "''") + "'";

                if (chkDurum.Checked && txtBirebirDurum.Text != "")
                    kosullar += " AND Durum = '" + txtBirebirDurum.Text.Replace("'", "''") + "'";

                string sorgu = "SELECT ID, MasaID, KullaniciID, Tarih, AraToplam, KdvOrani, ToplamTutar, OdendiMi, OdemeTipi, Durum FROM Siparisler WHERE " + kosullar;

                SqlDataAdapter da = new SqlDataAdapter(sorgu, Form1.Baglanti);
                da.Fill(dt);
                dgvSiparisler.DataSource = dt;
                Form1.Baglanti.Close();

                if (dgvSiparisler.Columns.Contains("ID")) dgvSiparisler.Columns["ID"].Visible = false;
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
            if (rdbOdemeTipi.Checked)
            {
                lblHizliAramaDeger.Text = "Ödeme Tipi:";
            }
            else if (rdbToplamTutar.Checked)
            {
                lblHizliAramaDeger.Text = "Toplam Tutar:";
            }
            else if (rdbDurum.Checked)
            {
                lblHizliAramaDeger.Text = "Durum:";
            }

            txtHizliAramaSecim.Text = "";
            txtHizliAramaSecim.Focus();
        }

        public void HizliAra()
        {
            try
            {
                Form1.BaglantiAc();
                DataTable dt = new DataTable();

                string arananAlan = "OdemeTipi";
                if (rdbToplamTutar.Checked)
                    arananAlan = "ToplamTutar";
                else if (rdbDurum.Checked)
                    arananAlan = "Durum";

                string arananMetin = txtHizliAramaSecim.Text.Replace("'", "''");

                // CAST() kullanıyoruz çünkü ToplamTutar sayısal bir veri tipi olabilir ve LIKE sayısal tiplerde hata verebilir.
                string SorguTum = "SELECT ID, MasaID, KullaniciID, Tarih, AraToplam, KdvOrani, ToplamTutar, OdendiMi, OdemeTipi, Durum FROM Siparisler";
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
                dgvSiparisler.DataSource = dt;
                Form1.Baglanti.Close();

                if (dgvSiparisler.Columns.Contains("ID")) dgvSiparisler.Columns["ID"].Visible = false;
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