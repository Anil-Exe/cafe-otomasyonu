using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CafeOtomasyon
{
    public partial class GunSonuForm : Form
    {
        public GunSonuForm()
        {
            InitializeComponent();
        }

        private void GunSonuForm_Load(object sender, EventArgs e)
        {
            Listele();
            lblYildizToplamSiparis.Text = "*";
            lblYildizToplamSiparis.ForeColor = Color.Red;
            lblYildizToplamSiparis.Visible = false;

            // Arama Kutularının Başlangıç Ayarları
            txtBirebirNetCiro.Enabled = false;
            txtBirebirRaporTarihi.Enabled = false;

            cmbHizliAramaTuru.Items.Clear();
            cmbHizliAramaTuru.Items.Add("İçeren");
            cmbHizliAramaTuru.Items.Add("İle Başlayan");
            cmbHizliAramaTuru.Items.Add("İle Biten");
            cmbHizliAramaTuru.SelectedIndex = 0;

            lblHizliAramaDeger.Text = "Net Ciro:";
        }

        void Listele()
        {
            try
            {
                Form1.BaglantiAc();

                SqlDataAdapter da = new SqlDataAdapter("SELECT ID, RaporTarihi, ToplamSiparisTutari, ToplamOdeme, NakitToplam, KartToplam, SahsiKasaToplam, NetCiro, OlusturmaTarihi FROM GunSonuRaporlari ORDER BY RaporTarihi DESC", Form1.Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvGunSonu.DataSource = dt;

                if (dgvGunSonu.Columns.Contains("ID"))
                    dgvGunSonu.Columns["ID"].Visible = false;

                dgvGunSonu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvGunSonu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvGunSonu.ReadOnly = true;
                dgvGunSonu.AllowUserToAddRows = false;

                Form1.Baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme Hatası: " + ex.Message);

                if (Form1.Baglanti.State == ConnectionState.Open)
                    Form1.Baglanti.Close();
            }
        }

        void Temizle()
        {
            txtToplamSiparisTutari.Clear();
            txtToplamOdeme.Clear();
            txtNakitToplam.Clear();
            txtKartToplam.Clear();
            txtSahsiKasaToplam.Clear();
            txtNetCiro.Clear();
            dtpRaporTarihi.Value = DateTime.Now;
        }

        private void toolStripButtonHesapla_Click(object sender, EventArgs e)
        {
            decimal toplamSiparisTutari = 0;
            decimal toplamOdeme = 0;
            decimal nakitToplam = 0;
            decimal kartToplam = 0;
            decimal sahsiKasaToplam = 0;
            decimal netCiro = 0;

            DateTime seciliTarih = dtpRaporTarihi.Value.Date;
            DateTime ertesiGun = seciliTarih.AddDays(1);

            try
            {
                Form1.BaglantiAc();

                SqlCommand cmd1 = new SqlCommand("SELECT ISNULL(SUM(Tutar),0) FROM Odemeler WHERE OdemeTarihi >= @t1 AND OdemeTarihi < @t2", Form1.Baglanti);
                cmd1.Parameters.AddWithValue("@t1", seciliTarih);
                cmd1.Parameters.AddWithValue("@t2", ertesiGun);
                toplamOdeme = Convert.ToDecimal(cmd1.ExecuteScalar());

                SqlCommand cmd2 = new SqlCommand("SELECT ISNULL(SUM(Tutar),0) FROM Odemeler WHERE OdemeTuru='Nakit' AND OdemeTarihi >= @t1 AND OdemeTarihi < @t2", Form1.Baglanti);
                cmd2.Parameters.AddWithValue("@t1", seciliTarih);
                cmd2.Parameters.AddWithValue("@t2", ertesiGun);
                nakitToplam = Convert.ToDecimal(cmd2.ExecuteScalar());

                SqlCommand cmd3 = new SqlCommand("SELECT ISNULL(SUM(Tutar),0) FROM Odemeler WHERE OdemeTuru='Kart' AND OdemeTarihi >= @t1 AND OdemeTarihi < @t2", Form1.Baglanti);
                cmd3.Parameters.AddWithValue("@t1", seciliTarih);
                cmd3.Parameters.AddWithValue("@t2", ertesiGun);
                kartToplam = Convert.ToDecimal(cmd3.ExecuteScalar());

                SqlCommand cmd4 = new SqlCommand("SELECT ISNULL(SUM(Tutar),0) FROM SahsiKasaHareketleri WHERE IslemTarihi >= @t1 AND IslemTarihi < @t2", Form1.Baglanti);
                cmd4.Parameters.AddWithValue("@t1", seciliTarih);
                cmd4.Parameters.AddWithValue("@t2", ertesiGun);
                sahsiKasaToplam = Convert.ToDecimal(cmd4.ExecuteScalar());

                toplamSiparisTutari = toplamOdeme;
                netCiro = toplamOdeme - sahsiKasaToplam;

                Form1.Baglanti.Close();

                txtToplamSiparisTutari.Text = toplamSiparisTutari.ToString("0.00");
                txtToplamOdeme.Text = toplamOdeme.ToString("0.00");
                txtNakitToplam.Text = nakitToplam.ToString("0.00");
                txtKartToplam.Text = kartToplam.ToString("0.00");
                txtSahsiKasaToplam.Text = sahsiKasaToplam.ToString("0.00");
                txtNetCiro.Text = netCiro.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hesaplama Hatası: " + ex.Message);

                if (Form1.Baglanti.State == ConnectionState.Open)
                    Form1.Baglanti.Close();
            }
        }

        public bool BoslukKontrol()
        {
            bool bos = false;

            txtToplamSiparisTutari.BackColor = Color.White;
            txtToplamOdeme.BackColor = Color.White;
            txtNakitToplam.BackColor = Color.White;
            txtKartToplam.BackColor = Color.White;
            txtSahsiKasaToplam.BackColor = Color.White;
            txtNetCiro.BackColor = Color.White;

            if (txtToplamSiparisTutari.Text.Trim() == "")
            {
                txtToplamSiparisTutari.BackColor = Color.LightCoral;
                bos = true;
            }

            if (txtToplamOdeme.Text.Trim() == "")
            {
                txtToplamOdeme.BackColor = Color.LightCoral;
                bos = true;
            }

            if (txtNakitToplam.Text.Trim() == "")
            {
                txtNakitToplam.BackColor = Color.LightCoral;
                bos = true;
            }

            if (txtKartToplam.Text.Trim() == "")
            {
                txtKartToplam.BackColor = Color.LightCoral;
                bos = true;
            }

            if (txtSahsiKasaToplam.Text.Trim() == "")
            {
                txtSahsiKasaToplam.BackColor = Color.LightCoral;
                bos = true;
            }

            if (txtNetCiro.Text.Trim() == "")
            {
                txtNetCiro.BackColor = Color.LightCoral;
                bos = true;
            }

            if (txtToplamSiparisTutari.Text.Trim() == "")
                txtToplamSiparisTutari.Focus();
            else if (txtToplamOdeme.Text.Trim() == "")
                txtToplamOdeme.Focus();
            else if (txtNakitToplam.Text.Trim() == "")
                txtNakitToplam.Focus();
            else if (txtKartToplam.Text.Trim() == "")
                txtKartToplam.Focus();
            else if (txtSahsiKasaToplam.Text.Trim() == "")
                txtSahsiKasaToplam.Focus();
            else if (txtNetCiro.Text.Trim() == "")
                txtNetCiro.Focus();

            return bos;
        }

        private void toolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            decimal toplamSiparisTutari, toplamOdeme, nakitToplam, kartToplam, sahsiKasaToplam, netCiro;
            if (BoslukKontrol())
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtToplamSiparisTutari.Text, out toplamSiparisTutari))
            {
                MessageBox.Show("Toplam sipariş tutarı hatalı");
                return;
            }

            if (!decimal.TryParse(txtToplamOdeme.Text, out toplamOdeme))
            {
                MessageBox.Show("Toplam ödeme hatalı");
                return;
            }

            if (!decimal.TryParse(txtNakitToplam.Text, out nakitToplam))
            {
                MessageBox.Show("Nakit toplam hatalı");
                return;
            }

            if (!decimal.TryParse(txtKartToplam.Text, out kartToplam))
            {
                MessageBox.Show("Kart toplam hatalı");
                return;
            }

            if (!decimal.TryParse(txtSahsiKasaToplam.Text, out sahsiKasaToplam))
            {
                MessageBox.Show("Şahsi kasa toplamı hatalı");
                return;
            }

            if (!decimal.TryParse(txtNetCiro.Text, out netCiro))
            {
                MessageBox.Show("Net ciro hatalı");
                return;
            }

            DialogResult cevap = MessageBox.Show("Gün sonu raporu kaydedilsin mi?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap != DialogResult.Yes) return;

            try
            {
                Form1.BaglantiAc();

                SqlCommand cmd = new SqlCommand("INSERT INTO GunSonuRaporlari (RaporTarihi, ToplamSiparisTutari, ToplamOdeme, NakitToplam, KartToplam, SahsiKasaToplam, NetCiro, OlusturmaTarihi) VALUES (@tarih,@siparis,@odeme,@nakit,@kart,@sahsi,@net,GETDATE())", Form1.Baglanti);
                cmd.Parameters.AddWithValue("@tarih", dtpRaporTarihi.Value.Date);
                cmd.Parameters.AddWithValue("@siparis", toplamSiparisTutari);
                cmd.Parameters.AddWithValue("@odeme", toplamOdeme);
                cmd.Parameters.AddWithValue("@nakit", nakitToplam);
                cmd.Parameters.AddWithValue("@kart", kartToplam);
                cmd.Parameters.AddWithValue("@sahsi", sahsiKasaToplam);
                cmd.Parameters.AddWithValue("@net", netCiro);
                cmd.ExecuteNonQuery();

                Form1.Baglanti.Close();

                MessageBox.Show("Gün sonu raporu kaydedildi");
                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme Hatası: " + ex.Message);

                if (Form1.Baglanti.State == ConnectionState.Open)
                    Form1.Baglanti.Close();
            }
        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            if (dgvGunSonu.CurrentRow == null)
            {
                MessageBox.Show("Lütfen kayıt seçiniz");
                return;
            }

            int id = Convert.ToInt32(dgvGunSonu.CurrentRow.Cells["ID"].Value);

            GunSonuSilForm frm = new GunSonuSilForm();
            frm.BilgiGetir(
                dgvGunSonu.CurrentRow.Cells["ID"].Value.ToString(),
                dgvGunSonu.CurrentRow.Cells["RaporTarihi"].Value.ToString(),
                dgvGunSonu.CurrentRow.Cells["ToplamSiparisTutari"].Value.ToString(),
                dgvGunSonu.CurrentRow.Cells["ToplamOdeme"].Value.ToString(),
                dgvGunSonu.CurrentRow.Cells["NetCiro"].Value.ToString()
            );

            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Form1.BaglantiAc();

                    SqlCommand cmd = new SqlCommand("DELETE FROM GunSonuRaporlari WHERE ID=@id", Form1.Baglanti);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                    Form1.Baglanti.Close();

                    MessageBox.Show("Kayıt silindi");
                    Listele();
                    Temizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme Hatası: " + ex.Message);

                    if (Form1.Baglanti.State == ConnectionState.Open)
                        Form1.Baglanti.Close();
                }
            }
        }

        private void toolStripButtonYenile_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void dgvGunSonu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGunSonu.CurrentRow != null)
            {
                DateTime tarih;
                if (DateTime.TryParse(dgvGunSonu.CurrentRow.Cells["RaporTarihi"].Value.ToString(), out tarih))
                    dtpRaporTarihi.Value = tarih;

                txtToplamSiparisTutari.Text = dgvGunSonu.CurrentRow.Cells["ToplamSiparisTutari"].Value.ToString();
                txtToplamOdeme.Text = dgvGunSonu.CurrentRow.Cells["ToplamOdeme"].Value.ToString();
                txtNakitToplam.Text = dgvGunSonu.CurrentRow.Cells["NakitToplam"].Value.ToString();
                txtKartToplam.Text = dgvGunSonu.CurrentRow.Cells["KartToplam"].Value.ToString();
                txtSahsiKasaToplam.Text = dgvGunSonu.CurrentRow.Cells["SahsiKasaToplam"].Value.ToString();
                txtNetCiro.Text = dgvGunSonu.CurrentRow.Cells["NetCiro"].Value.ToString();
            }
        }

        private void GunSonuForm_FormClosing(object sender, FormClosingEventArgs e)
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

            if (chk == chkNetCiro)
            {
                txtBirebirNetCiro.Enabled = chkNetCiro.Checked;
                if (!chkNetCiro.Checked) txtBirebirNetCiro.Clear();
                else txtBirebirNetCiro.Focus();
            }
            else if (chk == chkRaporTarihi)
            {
                txtBirebirRaporTarihi.Enabled = chkRaporTarihi.Checked;
                if (!chkRaporTarihi.Checked) txtBirebirRaporTarihi.Clear();
                else txtBirebirRaporTarihi.Focus();
            }
        }

        public void KayitAra()
        {
            try
            {
                Form1.BaglantiAc();
                DataTable dt = new DataTable();

                string kosullar = "1=1";

                if (chkNetCiro.Checked && txtBirebirNetCiro.Text != "")
                    kosullar += " AND CAST(NetCiro AS NVARCHAR(MAX)) = '" + txtBirebirNetCiro.Text.Replace("'", "''") + "'";

                if (chkRaporTarihi.Checked && txtBirebirRaporTarihi.Text != "")
                    kosullar += " AND CAST(RaporTarihi AS NVARCHAR(MAX)) LIKE '%" + txtBirebirRaporTarihi.Text.Replace("'", "''") + "%'";

                string sorgu = "SELECT ID, RaporTarihi, ToplamSiparisTutari, ToplamOdeme, NakitToplam, KartToplam, SahsiKasaToplam, NetCiro, OlusturmaTarihi FROM GunSonuRaporlari WHERE " + kosullar + " ORDER BY RaporTarihi DESC";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, Form1.Baglanti);
                da.Fill(dt);
                dgvGunSonu.DataSource = dt;
                Form1.Baglanti.Close();

                if (dgvGunSonu.Columns.Contains("ID")) dgvGunSonu.Columns["ID"].Visible = false;
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
            if (rdbNetCiro.Checked)
                lblHizliAramaDeger.Text = "Net Ciro:";
            else if (rdbRaporTarihi.Checked)
                lblHizliAramaDeger.Text = "Rapor Tarihi:";

            txtHizliAramaSecim.Text = "";
            txtHizliAramaSecim.Focus();
        }

        public void HizliAra()
        {
            try
            {
                Form1.BaglantiAc();
                DataTable dt = new DataTable();

                string arananAlan = "NetCiro";
                if (rdbRaporTarihi.Checked)
                    arananAlan = "RaporTarihi";

                string arananMetin = txtHizliAramaSecim.Text.Replace("'", "''");

                // NetCiro Decimal, RaporTarihi Date olabileceği için CAST kullanarak arama yapıyoruz.
                string SorguTum = "SELECT ID, RaporTarihi, ToplamSiparisTutari, ToplamOdeme, NakitToplam, KartToplam, SahsiKasaToplam, NetCiro, OlusturmaTarihi FROM GunSonuRaporlari";
                string SorguIleBaslayan = SorguTum + " WHERE CAST(" + arananAlan + " AS NVARCHAR(MAX)) LIKE '" + arananMetin + "%' ORDER BY RaporTarihi DESC";
                string SorguIleBiten = SorguTum + " WHERE CAST(" + arananAlan + " AS NVARCHAR(MAX)) LIKE '%" + arananMetin + "' ORDER BY RaporTarihi DESC";
                string SorguIceren = SorguTum + " WHERE CAST(" + arananAlan + " AS NVARCHAR(MAX)) LIKE '%" + arananMetin + "%' ORDER BY RaporTarihi DESC";

                string CalisacakSorgu = SorguTum + " ORDER BY RaporTarihi DESC";

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
                dgvGunSonu.DataSource = dt;
                Form1.Baglanti.Close();

                if (dgvGunSonu.Columns.Contains("ID")) dgvGunSonu.Columns["ID"].Visible = false;
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