using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeOtomasyon
{
    public partial class RezervasyonGuncelleForm : Form
    {
        public int SeciliID;
        public RezervasyonForm rezervasyonForm;

        public RezervasyonGuncelleForm()
        {
            InitializeComponent();
        }

        private void RezervasyonGuncelleForm_Load(object sender, EventArgs e)
        {
            txtID.ReadOnly = true;

            cmbDurum.Items.Add("Aktif");
            cmbDurum.Items.Add("Geldi");
            cmbDurum.Items.Add("İptal");
            cmbDurum.Items.Add("Tamamlandı");
            cmbDurum.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int masaId, kisiSayisi;

            if (txtMusteriAdi.Text == "")
            {
                MessageBox.Show("Müşteri adı boş olamaz");
                return;
            }

            if (txtTelefon.Text == "")
            {
                MessageBox.Show("Telefon boş olamaz");
                return;
            }

            if (!int.TryParse(txtMasaID.Text, out masaId))
            {
                MessageBox.Show("Masa ID sayısal olmalıdır");
                return;
            }

            if (!int.TryParse(txtKisiSayisi.Text, out kisiSayisi))
            {
                MessageBox.Show("Kişi sayısı sayısal olmalıdır");
                return;
            }

            if (cmbDurum.Text == "")
            {
                MessageBox.Show("Durum seçiniz");
                return;
            }

            DialogResult cevap = MessageBox.Show("Rezervasyon güncellensin mi?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap != DialogResult.Yes) return;

            Form1.BaglantiAc();
            SqlCommand cmd = new SqlCommand("UPDATE Rezervasyonlar SET MusteriAdi=@ad, Telefon=@telefon, MasaID=@masa, KisiSayisi=@kisi, RezervasyonTarihi=@tarih, Aciklama=@aciklama, Durum=@durum WHERE ID=@id", Form1.Baglanti);
            cmd.Parameters.AddWithValue("@ad", txtMusteriAdi.Text);
            cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@masa", masaId);
            cmd.Parameters.AddWithValue("@kisi", kisiSayisi);
            cmd.Parameters.AddWithValue("@tarih", dtpRezervasyonTarihi.Value);
            cmd.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
            cmd.Parameters.AddWithValue("@durum", cmbDurum.Text);
            cmd.Parameters.AddWithValue("@id", SeciliID);
            cmd.ExecuteNonQuery();
            Form1.Baglanti.Close();

            MessageBox.Show("Rezervasyon güncellendi");

            if (rezervasyonForm != null)
                rezervasyonForm.GetType().GetMethod("Listele", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?.Invoke(rezervasyonForm, null);

            this.Close();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMasaID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void txtKisiSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }
    }
}