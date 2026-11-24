using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeOtomasyon
{
    public partial class SahsiKasaGuncelleForm : Form
    {
        public int SeciliID;
        public SahsiKasaForm sahsiKasaForm;

        public SahsiKasaGuncelleForm()
        {
            InitializeComponent();
        }

        private void SahsiKasaGuncelleForm_Load(object sender, EventArgs e)
        {
            txtID.ReadOnly = true;

            cmbIslemTuru.Items.Add("Kasa Girişi");
            cmbIslemTuru.Items.Add("Kasa Çıkışı");
            cmbIslemTuru.Items.Add("Şahsi Harcama");
            cmbIslemTuru.Items.Add("Şahsi Ekleme");
            cmbIslemTuru.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            decimal tutar;
            int kullaniciId;

            if (cmbIslemTuru.Text == "")
            {
                MessageBox.Show("İşlem türü seçiniz");
                return;
            }

            if (!decimal.TryParse(txtTutar.Text, out tutar))
            {
                MessageBox.Show("Tutar sayısal olmalıdır");
                return;
            }

            if (!int.TryParse(txtKullaniciID.Text, out kullaniciId))
            {
                MessageBox.Show("Kullanıcı ID sayısal olmalıdır");
                return;
            }

            DialogResult cevap = MessageBox.Show("Kasa kaydı güncellensin mi?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap != DialogResult.Yes) return;

            Form1.BaglantiAc();
            SqlCommand cmd = new SqlCommand("UPDATE SahsiKasaHareketleri SET IslemTuru=@tur, Tutar=@tutar, Aciklama=@aciklama, KullaniciID=@kullanici WHERE ID=@id", Form1.Baglanti);
            cmd.Parameters.AddWithValue("@tur", cmbIslemTuru.Text);
            cmd.Parameters.AddWithValue("@tutar", tutar);
            cmd.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
            cmd.Parameters.AddWithValue("@kullanici", kullaniciId);
            cmd.Parameters.AddWithValue("@id", SeciliID);
            cmd.ExecuteNonQuery();
            Form1.Baglanti.Close();

            MessageBox.Show("Kasa kaydı güncellendi");

            if (sahsiKasaForm != null)
                sahsiKasaForm.GetType().GetMethod("Listele", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?.Invoke(sahsiKasaForm, null);

            this.Close();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '.'))
                e.Handled = true;
        }

        private void txtKullaniciID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }
    }
}