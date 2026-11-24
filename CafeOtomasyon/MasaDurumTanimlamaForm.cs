using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CafeOtomasyon
{
    public partial class MasaDurumTanimlamaForm : Form
    {
        int seciliID = 0;

        public MasaDurumTanimlamaForm()
        {
            InitializeComponent();
        }

        public void KayitListele()
        {
            try
            {
                TanimlamaYardimci.TablolariKontrolEt();
                Form1.BaglantiAc();
                DataSet ds = new DataSet();
                string sorgu = "SELECT ID, DurumAdi FROM MasaDurumTanimlari";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, Form1.Baglanti);
                da.Fill(ds, "MasaDurumTanimlari");
                dataGridView1.DataSource = ds.Tables["MasaDurumTanimlari"];

                if (dataGridView1.Columns["ID"] != null)
                    dataGridView1.Columns["ID"].Visible = false;
                if (dataGridView1.Columns["DurumAdi"] != null)
                    dataGridView1.Columns["DurumAdi"].HeaderText = "Durum Adı";

                Form1.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
                if (Form1.Baglanti.State == ConnectionState.Open)
                    Form1.Baglanti.Close();
            }
        }

        public void KayitEkle()
        {
            try
            {
                Form1.BaglantiAc();
                string sorgu = "INSERT INTO MasaDurumTanimlari(DurumAdi) VALUES(@ad)";
                SqlCommand komut = new SqlCommand(sorgu, Form1.Baglanti);
                komut.Parameters.AddWithValue("@ad", txtAd.Text.Trim());

                if (komut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Eklendi", "Veri Girişi");

                Form1.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Ekle Hata Penceresi");
                if (Form1.Baglanti.State == ConnectionState.Open)
                    Form1.Baglanti.Close();
            }
        }

        public void KayitSil()
        {
            try
            {
                Form1.BaglantiAc();
                string sorgu = "DELETE FROM MasaDurumTanimlari WHERE ID=@id";
                SqlCommand komut = new SqlCommand(sorgu, Form1.Baglanti);
                komut.Parameters.AddWithValue("@id", seciliID);

                if (komut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Silindi");

                Form1.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Sil Hata Penceresi");
                if (Form1.Baglanti.State == ConnectionState.Open)
                    Form1.Baglanti.Close();
            }
        }

        public void KayitGuncelle()
        {
            try
            {
                Form1.BaglantiAc();
                string sorgu = "UPDATE MasaDurumTanimlari SET DurumAdi=@ad WHERE ID=@id";
                SqlCommand komut = new SqlCommand(sorgu, Form1.Baglanti);
                komut.Parameters.AddWithValue("@ad", txtAd.Text.Trim());
                komut.Parameters.AddWithValue("@id", seciliID);

                if (komut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Güncellendi", "Veri Güncelleme");

                Form1.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Güncelle Hata Penceresi");
                if (Form1.Baglanti.State == ConnectionState.Open)
                    Form1.Baglanti.Close();
            }
        }

        public void Temizle()
        {
            txtAd.Clear();
            seciliID = 0;
            txtAd.Focus();
        }

        private void MasaDurumTanimlamaForm_Load(object sender, EventArgs e)
        {
            KayitListele();
        }

        private void MasaDurumTanimlamaForm_Activated(object sender, EventArgs e)
        {
            KayitListele();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells["ID"].Value != null)
            {
                seciliID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                txtAd.Text = dataGridView1.CurrentRow.Cells["DurumAdi"].Value.ToString();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Trim() == "")
                MessageBox.Show("Durum Adı boş geçilemez");
            else
            {
                KayitEkle();
                KayitListele();
                Temizle();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliID == 0)
                MessageBox.Show("Silinecek kaydı seçiniz");
            else
            {
                KayitSil();
                KayitListele();
                Temizle();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliID == 0)
                MessageBox.Show("Güncellenecek kaydı seçiniz");
            else if (txtAd.Text.Trim() == "")
                MessageBox.Show("Durum Adı boş geçilemez");
            else
            {
                KayitGuncelle();
                KayitListele();
                Temizle();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
