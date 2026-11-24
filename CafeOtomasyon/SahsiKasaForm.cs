using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CafeOtomasyon
{
    public partial class SahsiKasaForm : Form
    {
        public SahsiKasaForm()
        {
            InitializeComponent();
        }

        private void SahsiKasaForm_Load(object sender, EventArgs e)
        {
            cmbIslemTuru.Items.Clear();
            cmbIslemTuru.Items.Add("Kasa Girişi");
            cmbIslemTuru.Items.Add("Kasa Çıkışı");
            cmbIslemTuru.Items.Add("Şahsi Harcama");
            cmbIslemTuru.Items.Add("Şahsi Ekleme");
            cmbIslemTuru.DropDownStyle = ComboBoxStyle.DropDownList;

            // Arama Kutularının Başlangıç Ayarları
            txtBirebirIslemTuru.Enabled = false;
            txtBirebirTutar.Enabled = false;

            cmbHizliAramaTuru.Items.Clear();
            cmbHizliAramaTuru.Items.Add("İçeren");
            cmbHizliAramaTuru.Items.Add("İle Başlayan");
            cmbHizliAramaTuru.Items.Add("İle Biten");
            cmbHizliAramaTuru.SelectedIndex = 0;

            lblHizliAramaDeger.Text = "İşlem Türü:";

            Listele();
        }

        void Listele()
        {
            try
            {
                Form1.BaglantiAc();
                SqlDataAdapter da = new SqlDataAdapter("SELECT ID, IslemTuru, Tutar, Aciklama, IslemTarihi, KullaniciID FROM SahsiKasaHareketleri", Form1.Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKasa.DataSource = dt;

                if (dgvKasa.Columns.Contains("ID"))
                    dgvKasa.Columns["ID"].Visible = false;

                dgvKasa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvKasa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvKasa.ReadOnly = true;
                dgvKasa.AllowUserToAddRows = false;

                Form1.Baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme Hatası: " + ex.Message);

                if (Form1.Baglanti.State == ConnectionState.Open)
                    Form1.Baglanti.Close();
            }
        }

        void Temizle()
        {
            cmbIslemTuru.SelectedIndex = -1;
            txtTutar.Clear();
            txtAciklama.Clear();
            txtKullaniciID.Clear();
        }

        private void ComboBoxGorunumAyarla(ComboBox cmb, Color renk)
        {
            cmb.BackColor = renk;
        }

        public bool BoslukKontrol()
        {
            bool bos = false;

            ComboBoxGorunumAyarla(cmbIslemTuru, Color.White);
            txtTutar.BackColor = Color.White;
            txtKullaniciID.BackColor = Color.White;

            if (cmbIslemTuru.SelectedIndex == -1 || cmbIslemTuru.Text.Trim() == "")
            {
                ComboBoxGorunumAyarla(cmbIslemTuru, Color.LightCoral);
                bos = true;
            }

            if (txtTutar.Text.Trim() == "")
            {
                txtTutar.BackColor = Color.LightCoral;
                bos = true;
            }

            if (txtKullaniciID.Text.Trim() == "")
            {
                txtKullaniciID.BackColor = Color.LightCoral;
                bos = true;
            }

            if (cmbIslemTuru.SelectedIndex == -1 || cmbIslemTuru.Text.Trim() == "")
                cmbIslemTuru.Focus();
            else if (txtTutar.Text.Trim() == "")
                txtTutar.Focus();
            else if (txtKullaniciID.Text.Trim() == "")
                txtKullaniciID.Focus();

            return bos;
        }

        private void toolStripButtonEkle_Click(object sender, EventArgs e)
        {
            decimal tutar;
            int kullaniciId;
            if (BoslukKontrol())
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

            DialogResult cevap = MessageBox.Show("Kasa kaydı eklensin mi?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap != DialogResult.Yes) return;

            try
            {
                Form1.BaglantiAc();
                SqlCommand cmd = new SqlCommand("INSERT INTO SahsiKasaHareketleri (IslemTuru, Tutar, Aciklama, IslemTarihi, KullaniciID) VALUES (@tur,@tutar,@aciklama,GETDATE(),@kullanici)", Form1.Baglanti);
                cmd.Parameters.AddWithValue("@tur", cmbIslemTuru.Text);
                cmd.Parameters.AddWithValue("@tutar", tutar);
                cmd.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
                cmd.Parameters.AddWithValue("@kullanici", kullaniciId);
                cmd.ExecuteNonQuery();
                Form1.Baglanti.Close();

                MessageBox.Show("Kasa kaydı eklendi");
                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme Hatası: " + ex.Message);

                if (Form1.Baglanti.State == ConnectionState.Open)
                    Form1.Baglanti.Close();
            }
        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            if (dgvKasa.CurrentRow == null)
            {
                MessageBox.Show("Lütfen kayıt seçiniz");
                return;
            }

            int id = Convert.ToInt32(dgvKasa.CurrentRow.Cells["ID"].Value);

            SahsiKasaSilForm frm = new SahsiKasaSilForm();
            frm.BilgiGetir(
                dgvKasa.CurrentRow.Cells["ID"].Value.ToString(),
                dgvKasa.CurrentRow.Cells["IslemTuru"].Value.ToString(),
                dgvKasa.CurrentRow.Cells["Tutar"].Value.ToString(),
                dgvKasa.CurrentRow.Cells["Aciklama"].Value.ToString(),
                dgvKasa.CurrentRow.Cells["KullaniciID"].Value.ToString()
            );

            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Form1.BaglantiAc();
                    SqlCommand cmd = new SqlCommand("DELETE FROM SahsiKasaHareketleri WHERE ID=@id", Form1.Baglanti);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    Form1.Baglanti.Close();

                    MessageBox.Show("Kasa kaydı silindi");
                    Listele();
                    Temizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme Hatası: " + ex.Message);

                    if (Form1.Baglanti.State == ConnectionState.Open)
                        Form1.Baglanti.Close();
                }
            }
        }

        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvKasa.CurrentRow == null)
            {
                MessageBox.Show("Lütfen kayıt seçiniz");
                return;
            }

            SahsiKasaGuncelleForm frm = new SahsiKasaGuncelleForm();
            frm.sahsiKasaForm = this;
            frm.SeciliID = Convert.ToInt32(dgvKasa.CurrentRow.Cells["ID"].Value);

            frm.txtID.Text = dgvKasa.CurrentRow.Cells["ID"].Value.ToString();
            frm.cmbIslemTuru.Text = dgvKasa.CurrentRow.Cells["IslemTuru"].Value.ToString();
            frm.txtTutar.Text = dgvKasa.CurrentRow.Cells["Tutar"].Value.ToString();
            frm.txtAciklama.Text = dgvKasa.CurrentRow.Cells["Aciklama"].Value.ToString();
            frm.txtKullaniciID.Text = dgvKasa.CurrentRow.Cells["KullaniciID"].Value.ToString();

            frm.ShowDialog();
        }

        private void toolStripButtonTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dgvKasa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKasa.CurrentRow != null)
            {
                cmbIslemTuru.Text = dgvKasa.CurrentRow.Cells["IslemTuru"].Value.ToString();
                txtTutar.Text = dgvKasa.CurrentRow.Cells["Tutar"].Value.ToString();
                txtAciklama.Text = dgvKasa.CurrentRow.Cells["Aciklama"].Value.ToString();
                txtKullaniciID.Text = dgvKasa.CurrentRow.Cells["KullaniciID"].Value.ToString();
            }
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

        private void SahsiKasaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cevap = MessageBox.Show(
                "Çıkmak istiyor musunuz?",
                "Çıkış Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (cevap == DialogResult.No)
                e.Cancel = true;
        }

        // =========================================================
        // Birebir Arama Bölümü
        // =========================================================

        private void chkArama_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;

            if (chk == chkIslemTuru)
            {
                txtBirebirIslemTuru.Enabled = chkIslemTuru.Checked;
                if (!chkIslemTuru.Checked) txtBirebirIslemTuru.Clear();
                else txtBirebirIslemTuru.Focus();
            }
            else if (chk == chkTutar)
            {
                txtBirebirTutar.Enabled = chkTutar.Checked;
                if (!chkTutar.Checked) txtBirebirTutar.Clear();
                else txtBirebirTutar.Focus();
            }
        }

        public void KayitAra()
        {
            try
            {
                Form1.BaglantiAc();
                DataTable dt = new DataTable();

                string kosullar = "1=1";

                if (chkIslemTuru.Checked && txtBirebirIslemTuru.Text != "")
                    kosullar += " AND IslemTuru = '" + txtBirebirIslemTuru.Text.Replace("'", "''") + "'";

                if (chkTutar.Checked && txtBirebirTutar.Text != "")
                    kosullar += " AND CAST(Tutar AS NVARCHAR(MAX)) = '" + txtBirebirTutar.Text.Replace("'", "''") + "'";

                string sorgu = "SELECT ID, IslemTuru, Tutar, Aciklama, IslemTarihi, KullaniciID FROM SahsiKasaHareketleri WHERE " + kosullar;

                SqlDataAdapter da = new SqlDataAdapter(sorgu, Form1.Baglanti);
                da.Fill(dt);
                dgvKasa.DataSource = dt;
                Form1.Baglanti.Close();

                if (dgvKasa.Columns.Contains("ID")) dgvKasa.Columns["ID"].Visible = false;
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
            if (rdbIslemTuru.Checked)
                lblHizliAramaDeger.Text = "İşlem Türü:";
            else if (rdbTutar.Checked)
                lblHizliAramaDeger.Text = "Tutar:";

            txtHizliAramaSecim.Text = "";
            txtHizliAramaSecim.Focus();
        }

        public void HizliAra()
        {
            try
            {
                Form1.BaglantiAc();
                DataTable dt = new DataTable();

                string arananAlan = "IslemTuru";
                if (rdbTutar.Checked)
                    arananAlan = "Tutar";

                string arananMetin = txtHizliAramaSecim.Text.Replace("'", "''");

                // Veri tipleri farklı (Decimal, Varchar) olabileceği için CAST kullanarak arama yapıyoruz.
                string SorguTum = "SELECT ID, IslemTuru, Tutar, Aciklama, IslemTarihi, KullaniciID FROM SahsiKasaHareketleri";
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
                dgvKasa.DataSource = dt;
                Form1.Baglanti.Close();

                if (dgvKasa.Columns.Contains("ID")) dgvKasa.Columns["ID"].Visible = false;
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