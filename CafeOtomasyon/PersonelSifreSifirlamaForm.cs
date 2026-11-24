using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeOtomasyon
{
    public partial class PersonelSifreSifirlamaForm : Form
    {
        public PersonelSifreSifirlamaForm()
        {
            InitializeComponent();
        }

        private void PersonelSifreSifirlamaForm_Load(object sender, EventArgs e)
        {
            Listele();
            txtID.ReadOnly = true;
            txtAdSoyad.ReadOnly = true;

            // Arama Kutularının Başlangıç Ayarları
            txtBirebirAdSoyad.Enabled = false;
            txtBirebirSifre.Enabled = false;

            cmbHizliAramaTuru.Items.Clear();
            cmbHizliAramaTuru.Items.Add("İçeren");
            cmbHizliAramaTuru.Items.Add("İle Başlayan");
            cmbHizliAramaTuru.Items.Add("İle Biten");
            cmbHizliAramaTuru.SelectedIndex = 0;

            lblHizliAramaDeger.Text = "Ad Soyad:";
        }

        void Listele()
        {
            try
            {
                Form1.BaglantiAc();

                SqlDataAdapter da = new SqlDataAdapter("SELECT ID, AdSoyad, Sifre FROM Kullanicilar", Form1.Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvPersonel.DataSource = dt;

                if (dgvPersonel.Columns.Contains("ID"))
                    dgvPersonel.Columns["ID"].Visible = false;

                dgvPersonel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPersonel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvPersonel.ReadOnly = true;
                dgvPersonel.AllowUserToAddRows = false;

                Form1.Baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme Hatası: " + ex.Message);

                if (Form1.Baglanti.State == ConnectionState.Open)
                    Form1.Baglanti.Close();
            }
        }

        private void dgvPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPersonel.CurrentRow != null)
            {
                txtID.Text = dgvPersonel.CurrentRow.Cells["ID"].Value.ToString();
                txtAdSoyad.Text = dgvPersonel.CurrentRow.Cells["AdSoyad"].Value.ToString();
            }
        }

        private void toolStripButtonSifirla_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Sabit varsayılan parola ile sıfırlama devre dışıdır. Güvenli parola yönetimi tamamlanmalıdır.",
                "İnceleme kopyası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen personel seçiniz");
                return;
            }
            DialogResult sonuc = MessageBox.Show(
                "Bu kaydı güncellemek istiyor musunuz?",
                "Güncelleme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (sonuc == DialogResult.Yes)
            {
                if (txtYeniSifre.Text.Trim() == "")
                {
                    MessageBox.Show("Şifre boş olamaz");
                    return;
                }

                try
                {
                    Form1.BaglantiAc();

                    SqlCommand cmd = new SqlCommand("UPDATE Kullanicilar SET Sifre=@sifre WHERE ID=@id", Form1.Baglanti);
                    cmd.Parameters.AddWithValue("@sifre", txtYeniSifre.Text);
                    cmd.Parameters.AddWithValue("@id", txtID.Text);
                    cmd.ExecuteNonQuery();

                    Form1.Baglanti.Close();

                    MessageBox.Show("Şifre güncellendi");
                    Listele();
                    txtYeniSifre.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Güncelleme Hatası: " + ex.Message);

                    if (Form1.Baglanti.State == ConnectionState.Open)
                        Form1.Baglanti.Close();
                }
            }
        }

        private void toolStripButtonTemizle_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtAdSoyad.Clear();
            txtYeniSifre.Clear();
            dgvPersonel.ClearSelection();
        }

        private void toolStripButtonYenile_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void PersonelSifreSifirlamaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cevap = MessageBox.Show(
                "Çıkmak istiyor musunuz?",
                "Çıkış Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (cevap == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        // =========================================================
        // Birebir Arama Bölümü
        // =========================================================

        private void chkArama_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;

            if (chk == chkAdSoyad)
            {
                txtBirebirAdSoyad.Enabled = chkAdSoyad.Checked;
                if (!chkAdSoyad.Checked) txtBirebirAdSoyad.Clear();
                else txtBirebirAdSoyad.Focus();
            }
            else if (chk == chkSifre)
            {
                txtBirebirSifre.Enabled = chkSifre.Checked;
                if (!chkSifre.Checked) txtBirebirSifre.Clear();
                else txtBirebirSifre.Focus();
            }
        }

        public void KayitAra()
        {
            try
            {
                Form1.BaglantiAc();
                DataTable dt = new DataTable();

                string kosullar = "1=1";

                if (chkAdSoyad.Checked && txtBirebirAdSoyad.Text != "")
                    kosullar += " AND AdSoyad = '" + txtBirebirAdSoyad.Text.Replace("'", "''") + "'";

                if (chkSifre.Checked && txtBirebirSifre.Text != "")
                    kosullar += " AND Sifre = '" + txtBirebirSifre.Text.Replace("'", "''") + "'";

                string sorgu = "SELECT ID, AdSoyad, Sifre FROM Kullanicilar WHERE " + kosullar;

                SqlDataAdapter da = new SqlDataAdapter(sorgu, Form1.Baglanti);
                da.Fill(dt);
                dgvPersonel.DataSource = dt;
                Form1.Baglanti.Close();

                if (dgvPersonel.Columns.Contains("ID")) dgvPersonel.Columns["ID"].Visible = false;
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
            if (rdbAdSoyad.Checked)
                lblHizliAramaDeger.Text = "Ad Soyad:";
            else if (rdbSifre.Checked)
                lblHizliAramaDeger.Text = "Şifre:";

            txtHizliAramaSecim.Text = "";
            txtHizliAramaSecim.Focus();
        }

        public void HizliAra()
        {
            try
            {
                Form1.BaglantiAc();
                DataTable dt = new DataTable();

                string arananAlan = "AdSoyad";
                if (rdbSifre.Checked)
                    arananAlan = "Sifre";

                string arananMetin = txtHizliAramaSecim.Text.Replace("'", "''");

                string SorguTum = "SELECT ID, AdSoyad, Sifre FROM Kullanicilar";
                string SorguIleBaslayan = SorguTum + " WHERE CAST(" + arananAlan + " AS NVARCHAR(MAX)) LIKE '" + arananMetin + "%' ";
                string SorguIleBiten = SorguTum + " WHERE CAST(" + arananAlan + " AS NVARCHAR(MAX)) LIKE '%" + arananMetin + "' ";
                string SorguIceren = SorguTum + " WHERE CAST(" + arananAlan + " AS NVARCHAR(MAX)) LIKE '%" + arananMetin + "%' ";

                string CalisacakSorgu = SorguTum;

                if (txtHizliAramaSecim.Text.Trim() != "")
                {
                    if (cmbHizliAramaTuru.Text == "İle Başlayan")
                        CalisacakSorgu = SorguIleBaslayan;
                    else if (cmbHizliAramaTuru.Text == "İle Biten")
                        CalisacakSorgu = SorguIleBiten;
                    else if (cmbHizliAramaTuru.Text == "İçeren")
                        CalisacakSorgu = SorguIceren;
                }

                SqlDataAdapter da = new SqlDataAdapter(CalisacakSorgu, Form1.Baglanti);
                da.Fill(dt);
                dgvPersonel.DataSource = dt;
                Form1.Baglanti.Close();

                if (dgvPersonel.Columns.Contains("ID")) dgvPersonel.Columns["ID"].Visible = false;
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