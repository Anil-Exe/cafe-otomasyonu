using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeOtomasyon
{
    public partial class SiparisForm : Form
    {
        public SiparisForm()
        {
            InitializeComponent();
        }

        private void SiparisForm_Load(object sender, EventArgs e)
        {
            KategorileriGetir();
        }

        // 1. ADIM: Urunler tablosundaki Kategori sütunundan butonları oluşturma
        public void KategorileriGetir()
        {
            try
            {
                pnlKategoriler.Controls.Clear();
                Form1.BaglantiAc();

                // DISTINCT kullanarak ürünler tablosundaki farklı kategori isimlerini alıyoruz
                string sorgu = "SELECT DISTINCT Kategori FROM Urunler WHERE Kategori IS NOT NULL";
                SqlCommand komut = new SqlCommand(sorgu, Form1.Baglanti);
                SqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    Button btn = new Button();
                    string kategoriAdi = dr["Kategori"].ToString();
                    btn.Text = kategoriAdi;
                    btn.Tag = kategoriAdi; // Kategori ismini Tag'de saklıyoruz

                    btn.Size = new Size(180, 50);
                    btn.BackColor = Color.IndianRed;
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                    btn.Click += new EventHandler(KategoriButon_Click);
                    pnlKategoriler.Controls.Add(btn);
                }
                dr.Close();
                Form1.Baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategori Listeleme Hatası: " + ex.Message);
                if (Form1.Baglanti.State == ConnectionState.Open) Form1.Baglanti.Close();
            }
        }

        // 2. ADIM: Tıklanan kategori ismine göre ürünleri listeleme
        private void KategoriButon_Click(object sender, EventArgs e)
        {
            Button basilanButon = (Button)sender;
            string seciliKategori = basilanButon.Tag.ToString();

            pnlUrunler.Controls.Clear();
            Form1.BaglantiAc();

            // Sütun ismin "Kategori" olduğu için filtrelemeyi ona göre yapıyoruz
            string sorgu = "SELECT UrunAd, SatisFiyat FROM Urunler WHERE Kategori = @katAd";
            SqlCommand komut = new SqlCommand(sorgu, Form1.Baglanti);
            komut.Parameters.AddWithValue("@katAd", seciliKategori);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                Button btnUrun = new Button();
                btnUrun.Text = dr["UrunAd"].ToString() + "\n" + dr["SatisFiyat"].ToString() + " TL";
                btnUrun.Tag = dr["SatisFiyat"];

                btnUrun.Size = new Size(120, 80);
                btnUrun.BackColor = Color.LightSteelBlue;
                btnUrun.FlatStyle = FlatStyle.Popup;

                btnUrun.Click += new EventHandler(UrunButon_Click);
                pnlUrunler.Controls.Add(btnUrun);
            }
            dr.Close();
            Form1.Baglanti.Close();
        }

        private void UrunButon_Click(object sender, EventArgs e)
        {
            Button seciliUrun = (Button)sender;
            string urunAd = seciliUrun.Text.Split('\n')[0];
            string fiyat = seciliUrun.Tag.ToString();

            ListViewItem satir = new ListViewItem(urunAd);
            satir.SubItems.Add(fiyat);
            lvSiparisler.Items.Add(satir);

            ToplamGuncelle();
        }

        private void ToplamGuncelle()
        {
            decimal toplam = 0;
            foreach (ListViewItem item in lvSiparisler.Items)
            {
                toplam += Convert.ToDecimal(item.SubItems[1].Text);
            }
            lblToplam.Text = "TOPLAM: " + toplam.ToString("C2");
        }

        private void SiparisForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cevap = MessageBox.Show(
        "Çıkmak istiyor musunuz?",
        "Çıkış Onayı",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (cevap == DialogResult.No)
                e.Cancel = true;
        }
    }
}