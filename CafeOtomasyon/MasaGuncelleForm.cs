using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeOtomasyon
{
    public partial class MasaGuncelleForm : Form
    {
        public int SeciliID;
        public MasaListesiForm masaListesiForm;

        public MasaGuncelleForm()
        {
            InitializeComponent();

            txtID.ReadOnly = true;
            txtMasaNo.KeyPress += txtMasaNo_KeyPress;
            txtKapasite.KeyPress += txtKapasite_KeyPress;
        }

        private void YildizlariGizle()
        {
            lblYildizMasaNo.Visible = false;
            lblYildizKapasite.Visible = false;
            lblYildizKonum.Visible = false;
            lblYildizDurum.Visible = false;
        }

        private void MasaGuncelleForm_Load(object sender, EventArgs e)
        {
            string seciliKonum = cmbKonum.Text;
            string seciliDurum = cmbDurum.Text;

            cmbDurum.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKonum.DropDownStyle = ComboBoxStyle.DropDownList;

            TanimlamaYardimci.ComboDoldur(cmbDurum, "MasaDurumTanimlari", "DurumAdi");
            TanimlamaYardimci.ComboDoldur(cmbKonum, "MasaKonumTanimlari", "KonumAdi");

            cmbKonum.Text = seciliKonum;
            cmbDurum.Text = seciliDurum;

            YildizlariGizle();
        }

        private bool BoslukKontrol()
        {
            bool bos = false;

            txtMasaNo.BackColor = Color.White;
            txtKapasite.BackColor = Color.White;
            cmbKonum.BackColor = Color.White;
            cmbDurum.BackColor = Color.White;

            YildizlariGizle();

            if (txtMasaNo.Text.Trim() == "")
            {
                txtMasaNo.BackColor = Color.Red;
                lblYildizMasaNo.Visible = true;
                bos = true;
            }

            if (txtKapasite.Text.Trim() == "")
            {
                txtKapasite.BackColor = Color.Red;
                lblYildizKapasite.Visible = true;
                bos = true;
            }

            if (cmbKonum.Text.Trim() == "")
            {
                cmbKonum.BackColor = Color.Red;
                lblYildizKonum.Visible = true;
                bos = true;
            }

            if (cmbDurum.Text.Trim() == "")
            {
                cmbDurum.BackColor = Color.Red;
                lblYildizDurum.Visible = true;
                bos = true;
            }

            if (txtMasaNo.Text.Trim() == "")
                txtMasaNo.Focus();
            else if (txtKapasite.Text.Trim() == "")
                txtKapasite.Focus();
            else if (cmbKonum.Text.Trim() == "")
                cmbKonum.Focus();
            else if (cmbDurum.Text.Trim() == "")
                cmbDurum.Focus();

            return bos;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol())
            {
                MessageBox.Show("Lütfen kırmızı alanları doldurunuz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult cevap = MessageBox.Show("Masa bilgileri güncellensin mi?", "Güncelleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.No)
                return;

            try
            {
                Form1.BaglantiAc();

                int kapasite;
                if (!int.TryParse(txtKapasite.Text.Trim(), out kapasite))
                {
                    MessageBox.Show("Kapasite sayısal olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtKapasite.Focus();
                    Form1.Baglanti.Close();
                    return;
                }

                int durumDegeri = cmbDurum.Text == "Dolu" ? 1 : 0;

                string sorgu = "UPDATE Masalar SET MasaNo=@masano, Kapasite=@kapasite, Konum=@konum, Durum=@durum, SonIslemTarihi=GETDATE(), AcilisZamani=@aciliszamani WHERE ID=@id";

                SqlCommand cmd = new SqlCommand(sorgu, Form1.Baglanti);
                cmd.Parameters.AddWithValue("@masano", txtMasaNo.Text.Trim());
                cmd.Parameters.AddWithValue("@kapasite", kapasite);
                cmd.Parameters.AddWithValue("@konum", cmbKonum.Text.Trim());
                cmd.Parameters.AddWithValue("@durum", durumDegeri);
                cmd.Parameters.AddWithValue("@id", SeciliID);

                if (durumDegeri == 1)
                    cmd.Parameters.AddWithValue("@aciliszamani", DateTime.Now);
                else
                    cmd.Parameters.AddWithValue("@aciliszamani", DBNull.Value);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Masa bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (masaListesiForm != null)
                        masaListesiForm.MasaListele();

                    this.Close();
                }

                Form1.Baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme Hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (Form1.Baglanti.State == ConnectionState.Open)
                    Form1.Baglanti.Close();
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Güncelleme formu kapatılsın mı?", "Kapatma Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
                this.Close();
        }

        private void txtMasaNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void txtKapasite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }
    }
}