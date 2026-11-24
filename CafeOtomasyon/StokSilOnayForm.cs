using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeOtomasyon
{
    public partial class StokSilOnayForm : Form
    {
        public int SeciliID;
        public StokForm stokForm;

        public StokSilOnayForm()
        {
            InitializeComponent();
        }

        private void StokSilOnayForm_Load(object sender, EventArgs e)
        {
            txtID.ReadOnly = true;
            txtUrunAd.ReadOnly = true;
            txtBirim.ReadOnly = true;
            txtFiyat.ReadOnly = true;
            txtStok.ReadOnly = true;
            txtKategori.ReadOnly = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.BaglantiAc();

                string kontrolSorgu = "SELECT COUNT(*) FROM SiparisDetay WHERE UrunID=@ID";
                SqlCommand kontrolKomut = new SqlCommand(kontrolSorgu, Form1.Baglanti);
                kontrolKomut.Parameters.AddWithValue("@ID", SeciliID);

                int kayitSayisi = Convert.ToInt32(kontrolKomut.ExecuteScalar());

                if (kayitSayisi > 0)
                {
                    MessageBox.Show("Bu ürün sipariş detaylarında kullanıldığı için silinemez.");
                    Form1.Baglanti.Close();
                    return;
                }

                string sorgu = "DELETE FROM Urunler WHERE ID=@ID";
                SqlCommand komut = new SqlCommand(sorgu, Form1.Baglanti);
                komut.Parameters.AddWithValue("@ID", SeciliID);

                if (komut.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kayıt silindi.");

                    if (stokForm != null)
                    {
                        stokForm.KayitListele();
                        stokForm.Temizle();
                    }

                    this.Close();
                }

                Form1.Baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme Hatası : " + ex.Message);

                if (Form1.Baglanti.State == ConnectionState.Open)
                    Form1.Baglanti.Close();
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}