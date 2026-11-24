using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeOtomasyon
{
    public partial class OdemeGuncelleForm : Form
    {
        public int SeciliID;
        public OdemeAlmaForm odemeAlmaForm;

        public OdemeGuncelleForm()
        {
            InitializeComponent();
        }

        private void OdemeGuncelleForm_Load(object sender, EventArgs e)
        {
            txtID.ReadOnly = true;

            cmbOdemeTuru.DropDownStyle = ComboBoxStyle.DropDownList;
            TanimlamaYardimci.ComboDoldur(cmbOdemeTuru, "OdemeTuruTanimlari", "OdemeTuruAdi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            decimal tutar;
            int masaId, siparisId;

            if (!int.TryParse(txtMasaID.Text, out masaId))
            {
                MessageBox.Show("Masa ID sayısal olmalıdır");
                return;
            }

            if (!int.TryParse(txtSiparisID.Text, out siparisId))
            {
                MessageBox.Show("Sipariş ID sayısal olmalıdır");
                return;
            }

            if (!decimal.TryParse(txtTutar.Text, out tutar))
            {
                MessageBox.Show("Tutar sayısal olmalıdır");
                return;
            }

            if (cmbOdemeTuru.Text == "")
            {
                MessageBox.Show("Ödeme türü seçiniz");
                return;
            }

            DialogResult cevap = MessageBox.Show("Ödeme kaydı güncellensin mi?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap != DialogResult.Yes) return;

            Form1.BaglantiAc();
            SqlCommand cmd = new SqlCommand("UPDATE Odemeler SET MasaID=@masa, SiparisID=@siparis, Tutar=@tutar, OdemeTuru=@tur, Aciklama=@aciklama WHERE ID=@id", Form1.Baglanti);
            cmd.Parameters.AddWithValue("@masa", masaId);
            cmd.Parameters.AddWithValue("@siparis", siparisId);
            cmd.Parameters.AddWithValue("@tutar", tutar);
            cmd.Parameters.AddWithValue("@tur", cmbOdemeTuru.Text);
            cmd.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
            cmd.Parameters.AddWithValue("@id", SeciliID);
            cmd.ExecuteNonQuery();
            Form1.Baglanti.Close();

            MessageBox.Show("Ödeme güncellendi");

            if (odemeAlmaForm != null)
                odemeAlmaForm.GetType().GetMethod("Listele", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)?.Invoke(odemeAlmaForm, null);

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
    }
}