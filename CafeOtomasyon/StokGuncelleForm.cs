using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeOtomasyon
{
    public partial class StokGuncelleForm : Form
    {
        public int SeciliID;
        public StokForm stokForm;

        public StokGuncelleForm()
        {
            InitializeComponent();
        }

        private void StokGuncelleForm_Load(object sender, EventArgs e)
        {
            txtID.ReadOnly = true;

            cmbBirim.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;

            TanimlamaYardimci.ComboDoldur(cmbBirim, "BirimTanimlari", "BirimAdi");
            TanimlamaYardimci.ComboDoldur(cmbKategori, "KategoriTanimlari", "KategoriAdi");
        }

        public bool BoslukKontrol()
        {
            bool bos = false;

            txtUrunAd.BackColor = Color.White;
            cmbBirim.BackColor = Color.White;
            txtFiyat.BackColor = Color.White;
            txtStok.BackColor = Color.White;
            cmbKategori.BackColor = Color.White;

            if (txtUrunAd.Text.Trim() == "")
            {
                txtUrunAd.BackColor = Color.Red;
                bos = true;
            }

            if (cmbBirim.Text.Trim() == "")
            {
                cmbBirim.BackColor = Color.Red;
                bos = true;
            }

            if (txtFiyat.Text.Trim() == "")
            {
                txtFiyat.BackColor = Color.Red;
                bos = true;
            }

            if (txtStok.Text.Trim() == "")
            {
                txtStok.BackColor = Color.Red;
                bos = true;
            }

            if (cmbKategori.Text.Trim() == "")
            {
                cmbKategori.BackColor = Color.Red;
                bos = true;
            }

            return bos;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol())
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.");
                return;
            }

            try
            {
                Form1.BaglantiAc();

                decimal satisFiyat;
                int stokMiktari;

                if (!decimal.TryParse(txtFiyat.Text.Trim(), out satisFiyat))
                {
                    MessageBox.Show("Satış fiyatı sayısal olmalıdır.");
                    txtFiyat.Focus();
                    return;
                }

                if (!int.TryParse(txtStok.Text.Trim(), out stokMiktari))
                {
                    MessageBox.Show("Stok miktarı sayısal olmalıdır.");
                    txtStok.Focus();
                    return;
                }

                string sorgu = "UPDATE Urunler SET UrunAd=@UrunAd, Birim=@Birim, SatisFiyat=@SatisFiyat, StokMiktari=@StokMiktari, Kategori=@Kategori WHERE ID=@ID";
                SqlCommand komut = new SqlCommand(sorgu, Form1.Baglanti);

                komut.Parameters.AddWithValue("@UrunAd", txtUrunAd.Text.Trim());
                komut.Parameters.AddWithValue("@Birim", cmbBirim.Text.Trim());
                komut.Parameters.AddWithValue("@SatisFiyat", satisFiyat);
                komut.Parameters.AddWithValue("@StokMiktari", stokMiktari);
                komut.Parameters.AddWithValue("@Kategori", cmbKategori.Text.Trim());
                komut.Parameters.AddWithValue("@ID", SeciliID);

                if (komut.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kayıt güncellendi.");

                    if (stokForm != null)
                        stokForm.KayitListele();

                    this.Close();
                }

                Form1.Baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme Hatası : " + ex.Message);

                if (Form1.Baglanti.State == ConnectionState.Open)
                    Form1.Baglanti.Close();
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUrunAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ' '))
                e.Handled = true;
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ','))
                e.Handled = true;

            if (e.KeyChar == ',' && txtFiyat.Text.Contains(","))
                e.Handled = true;
        }

        private void txtStok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }
    }
}