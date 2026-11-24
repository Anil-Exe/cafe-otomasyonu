using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeOtomasyon
{
    public partial class UrunRaporForm : Form
    {
        public UrunRaporForm()
        {
            InitializeComponent();
        }

        private void UrunRaporForm_Load(object sender, EventArgs e)
        {
            dtpBaslangic.Value = DateTime.Today.AddDays(-7);
            dtpBitis.Value = DateTime.Today;

            // Arama Kutularının Başlangıç Ayarları
            txtBirebirUrunAdi.Enabled = false;
            txtBirebirToplamGelir.Enabled = false;

            cmbHizliAramaTuru.Items.Clear();
            cmbHizliAramaTuru.Items.Add("İçeren");
            cmbHizliAramaTuru.Items.Add("İle Başlayan");
            cmbHizliAramaTuru.Items.Add("İle Biten");
            cmbHizliAramaTuru.SelectedIndex = 0;

            lblHizliAramaDeger.Text = "Ürün Adı:";

            RaporGetir();
        }

        private void AltToplamlariHesapla(DataTable dt)
        {
            decimal toplamGenelGelir = 0;
            decimal toplamGenelAdet = 0;

            foreach (DataRow row in dt.Rows)
            {
                if (row["ToplamGelir"] != DBNull.Value)
                    toplamGenelGelir += Convert.ToDecimal(row["ToplamGelir"]);

                if (row["ToplamAdet"] != DBNull.Value)
                    toplamGenelAdet += Convert.ToDecimal(row["ToplamAdet"]);
            }

            lblToplamAdet.Text = "Toplam Adet: " + toplamGenelAdet.ToString();
            lblToplamGelir.Text = "Toplam Gelir: " + toplamGenelGelir.ToString("N2") + " TL";
        }

        private void RaporGetir()
        {
            try
            {
                Form1.BaglantiAc();

                string sorgu = @"
                SELECT 
                    u.ID,
                    u.UrunAd,
                    SUM(sd.Adet) AS ToplamAdet,
                    SUM(sd.SatirToplami) AS ToplamGelir
                FROM SiparisDetay sd
                INNER JOIN Urunler u ON sd.UrunID = u.ID
                INNER JOIN Siparisler s ON sd.SiparisID = s.ID
                WHERE s.Tarih >= @baslangic AND s.Tarih < @bitis
                GROUP BY u.ID, u.UrunAd
                ORDER BY ToplamGelir DESC";

                SqlCommand cmd = new SqlCommand(sorgu, Form1.Baglanti);
                cmd.Parameters.AddWithValue("@baslangic", dtpBaslangic.Value.Date);
                cmd.Parameters.AddWithValue("@bitis", dtpBitis.Value.Date.AddDays(1));

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvUrunRapor.DataSource = dt;
                dgvUrunRapor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvUrunRapor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvUrunRapor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvUrunRapor.ReadOnly = true;
                dgvUrunRapor.AllowUserToAddRows = false;

                if (dgvUrunRapor.Columns.Contains("ID"))
                    dgvUrunRapor.Columns["ID"].Visible = false;

                if (dgvUrunRapor.Columns.Contains("UrunAd"))
                    dgvUrunRapor.Columns["UrunAd"].HeaderText = "Ürün Adı";

                if (dgvUrunRapor.Columns.Contains("ToplamAdet"))
                    dgvUrunRapor.Columns["ToplamAdet"].HeaderText = "Toplam Satış Adedi";

                if (dgvUrunRapor.Columns.Contains("ToplamGelir"))
                {
                    dgvUrunRapor.Columns["ToplamGelir"].HeaderText = "Toplam Gelir";
                    dgvUrunRapor.Columns["ToplamGelir"].DefaultCellStyle.Format = "N2";
                }

                AltToplamlariHesapla(dt);

                Form1.Baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün raporu alınırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (Form1.Baglanti.State == ConnectionState.Open)
                    Form1.Baglanti.Close();
            }
        }

        private void toolStripButtonRaporGetir_Click(object sender, EventArgs e)
        {
            RaporGetir();
        }

        private void toolStripButtonYenile_Click(object sender, EventArgs e)
        {
            dtpBaslangic.Value = DateTime.Today.AddDays(-7);
            dtpBitis.Value = DateTime.Today;

            txtBirebirUrunAdi.Clear();
            txtBirebirToplamGelir.Clear();
            txtHizliAramaSecim.Clear();

            RaporGetir();
        }

        private void UrunRaporForm_FormClosing(object sender, FormClosingEventArgs e)
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

            if (chk == chkUrunAdi)
            {
                txtBirebirUrunAdi.Enabled = chkUrunAdi.Checked;
                if (!chkUrunAdi.Checked) txtBirebirUrunAdi.Clear();
                else txtBirebirUrunAdi.Focus();
            }
            else if (chk == chkToplamGelir)
            {
                txtBirebirToplamGelir.Enabled = chkToplamGelir.Checked;
                if (!chkToplamGelir.Checked) txtBirebirToplamGelir.Clear();
                else txtBirebirToplamGelir.Focus();
            }
        }

        public void KayitAra()
        {
            try
            {
                Form1.BaglantiAc();
                DataTable dt = new DataTable();

                string kosullar = "";

                if (chkUrunAdi.Checked && txtBirebirUrunAdi.Text != "")
                    kosullar += " AND UrunAd = '" + txtBirebirUrunAdi.Text.Replace("'", "''") + "'";

                if (chkToplamGelir.Checked && txtBirebirToplamGelir.Text != "")
                    kosullar += " AND CAST(ToplamGelir AS NVARCHAR(MAX)) = '" + txtBirebirToplamGelir.Text.Replace("'", "''") + "'";

                // Karmaşık sorgu için alt sorgu kullanıyoruz (Tarih bazlı SUM hesabı olduğu için)
                string sorgu = @"
                SELECT * FROM (
                    SELECT 
                        u.ID,
                        u.UrunAd,
                        SUM(sd.Adet) AS ToplamAdet,
                        SUM(sd.SatirToplami) AS ToplamGelir
                    FROM SiparisDetay sd
                    INNER JOIN Urunler u ON sd.UrunID = u.ID
                    INNER JOIN Siparisler s ON sd.SiparisID = s.ID
                    WHERE s.Tarih >= @baslangic AND s.Tarih < @bitis
                    GROUP BY u.ID, u.UrunAd
                ) AS RaporTablosu
                WHERE 1=1 " + kosullar + " ORDER BY ToplamGelir DESC";

                SqlCommand cmd = new SqlCommand(sorgu, Form1.Baglanti);
                cmd.Parameters.AddWithValue("@baslangic", dtpBaslangic.Value.Date);
                cmd.Parameters.AddWithValue("@bitis", dtpBitis.Value.Date.AddDays(1));

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvUrunRapor.DataSource = dt;

                AltToplamlariHesapla(dt);

                Form1.Baglanti.Close();

                if (dgvUrunRapor.Columns.Contains("ID")) dgvUrunRapor.Columns["ID"].Visible = false;
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
            if (rdbUrunAdi.Checked)
                lblHizliAramaDeger.Text = "Ürün Adı:";
            else if (rdbToplamGelir.Checked)
                lblHizliAramaDeger.Text = "Toplam Gelir:";

            txtHizliAramaSecim.Text = "";
            txtHizliAramaSecim.Focus();
        }

        public void HizliAra()
        {
            try
            {
                Form1.BaglantiAc();
                DataTable dt = new DataTable();

                string arananAlan = "UrunAd";
                if (rdbToplamGelir.Checked)
                    arananAlan = "ToplamGelir";

                string arananMetin = txtHizliAramaSecim.Text.Replace("'", "''");
                string ekKosul = "";

                if (txtHizliAramaSecim.Text.Trim() != "")
                {
                    if (cmbHizliAramaTuru.Text == "İle Başlayan")
                        ekKosul = " AND CAST(" + arananAlan + " AS NVARCHAR(MAX)) LIKE '" + arananMetin + "%' ";
                    else if (cmbHizliAramaTuru.Text == "İle Biten")
                        ekKosul = " AND CAST(" + arananAlan + " AS NVARCHAR(MAX)) LIKE '%" + arananMetin + "' ";
                    else if (cmbHizliAramaTuru.Text == "İçeren")
                        ekKosul = " AND CAST(" + arananAlan + " AS NVARCHAR(MAX)) LIKE '%" + arananMetin + "%' ";
                }

                // Alt sorgu ile filtreleme
                string sorgu = @"
                SELECT * FROM (
                    SELECT 
                        u.ID,
                        u.UrunAd,
                        SUM(sd.Adet) AS ToplamAdet,
                        SUM(sd.SatirToplami) AS ToplamGelir
                    FROM SiparisDetay sd
                    INNER JOIN Urunler u ON sd.UrunID = u.ID
                    INNER JOIN Siparisler s ON sd.SiparisID = s.ID
                    WHERE s.Tarih >= @baslangic AND s.Tarih < @bitis
                    GROUP BY u.ID, u.UrunAd
                ) AS RaporTablosu
                WHERE 1=1 " + ekKosul + " ORDER BY ToplamGelir DESC";

                SqlCommand cmd = new SqlCommand(sorgu, Form1.Baglanti);
                cmd.Parameters.AddWithValue("@baslangic", dtpBaslangic.Value.Date);
                cmd.Parameters.AddWithValue("@bitis", dtpBitis.Value.Date.AddDays(1));

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvUrunRapor.DataSource = dt;

                AltToplamlariHesapla(dt);

                Form1.Baglanti.Close();

                if (dgvUrunRapor.Columns.Contains("ID")) dgvUrunRapor.Columns["ID"].Visible = false;
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