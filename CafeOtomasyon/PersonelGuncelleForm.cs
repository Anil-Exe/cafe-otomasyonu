using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeOtomasyon
{
    public partial class PersonelGuncelleForm : Form
    {
        public int SeciliID;
        public PersonelListeForm personelListeForm;

        public PersonelGuncelleForm()
        {
            InitializeComponent();

            txtID.ReadOnly = true;
            txtAdSoyad.KeyPress += txtAdSoyad_KeyPress;
            txtMaas.KeyPress += txtMaas_KeyPress;
            txtTcNo.KeyPress += txtTcNo_KeyPress;
            txtTelefon.KeyPress += txtTelefon_KeyPress;
        }

        private void YildizlariGizle()
        {
            lblYildizAdSoyad.Visible = false;
            lblYildizSifre.Visible = false;
            lblYildizRol.Visible = false;
            lblYildizTcNo.Visible = false;
            lblYildizTelefon.Visible = false;
            lblYildizAdres.Visible = false;
            lblYildizMaas.Visible = false;
        }

        private void PersonelGuncelleForm_Load(object sender, EventArgs e)
        {
            string seciliRol = cmbRol.Text;
            TanimlamaYardimci.ComboDoldur(cmbRol, "PersonelRolTanimlari", "RolAdi");
            cmbRol.Text = seciliRol;
            YildizlariGizle();
        }

        private bool BoslukKontrol()
        {
            bool bos = false;

            txtAdSoyad.BackColor = Color.White;
            txtSifre.BackColor = Color.White;
            cmbRol.BackColor = Color.White;
            txtTcNo.BackColor = Color.White;
            txtTelefon.BackColor = Color.White;
            txtAdres.BackColor = Color.White;
            txtMaas.BackColor = Color.White;

            YildizlariGizle();

            if (txtAdSoyad.Text.Trim() == "")
            {
                txtAdSoyad.BackColor = Color.Red;
                lblYildizAdSoyad.Visible = true;
                bos = true;
            }

            if (txtSifre.Text.Trim() == "")
            {
                txtSifre.BackColor = Color.Red;
                lblYildizSifre.Visible = true;
                bos = true;
            }

            if (cmbRol.Text.Trim() == "")
            {
                cmbRol.BackColor = Color.Red;
                lblYildizRol.Visible = true;
                bos = true;
            }

            if (txtTcNo.Text.Trim() == "")
            {
                txtTcNo.BackColor = Color.Red;
                lblYildizTcNo.Visible = true;
                bos = true;
            }

            if (txtTelefon.Text.Trim() == "")
            {
                txtTelefon.BackColor = Color.Red;
                lblYildizTelefon.Visible = true;
                bos = true;
            }

            if (txtAdres.Text.Trim() == "")
            {
                txtAdres.BackColor = Color.Red;
                lblYildizAdres.Visible = true;
                bos = true;
            }

            if (txtMaas.Text.Trim() == "")
            {
                txtMaas.BackColor = Color.Red;
                lblYildizMaas.Visible = true;
                bos = true;
            }

            return bos;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol())
            {
                MessageBox.Show("Lütfen kırmızı alanları doldurunuz!");
                return;
            }

            try
            {
                Form1.BaglantiAc();

                int rol;
                decimal maas;

                if (!int.TryParse(cmbRol.Text.Trim(), out rol))
                {
                    MessageBox.Show("Rol sayısal olmalıdır.");
                    cmbRol.Focus();
                    Form1.Baglanti.Close();
                    return;
                }

                if (!decimal.TryParse(txtMaas.Text.Trim(), out maas))
                {
                    MessageBox.Show("Maaş sayısal olmalıdır.");
                    txtMaas.Focus();
                    Form1.Baglanti.Close();
                    return;
                }

                string sorgu = "UPDATE Kullanicilar SET AdSoyad=@adsoyad, Sifre=@sifre, Rol=@rol, TcNo=@tcno, Telefon=@telefon, Adres=@adres, Maas=@maas, IseGirisTarihi=@isegiristarihi, AktifMi=@aktifmi WHERE ID=@id";

                SqlCommand cmd = new SqlCommand(sorgu, Form1.Baglanti);
                cmd.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text.Trim());
                cmd.Parameters.AddWithValue("@sifre", txtSifre.Text.Trim());
                cmd.Parameters.AddWithValue("@rol", rol);
                cmd.Parameters.AddWithValue("@tcno", txtTcNo.Text.Trim());
                cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text.Trim());
                cmd.Parameters.AddWithValue("@adres", txtAdres.Text.Trim());
                cmd.Parameters.AddWithValue("@maas", maas);
                cmd.Parameters.AddWithValue("@isegiristarihi", dtpIseGirisTarihi.Value);
                cmd.Parameters.AddWithValue("@aktifmi", chkAktifMi.Checked);
                cmd.Parameters.AddWithValue("@id", SeciliID);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Personel bilgileri güncellendi.");

                    if (personelListeForm != null)
                        personelListeForm.PersonelListele();

                    this.Close();
                }

                Form1.Baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme Hatası: " + ex.Message);

                if (Form1.Baglanti.State == ConnectionState.Open)
                    Form1.Baglanti.Close();
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ' '))
                e.Handled = true;
        }

        private void cmbRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void txtMaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '.'))
                e.Handled = true;
        }

        private void txtTcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }
    }
}