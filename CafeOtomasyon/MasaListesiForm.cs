using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeOtomasyon
{
    public partial class MasaListesiForm : Form
    {
        public MasaListesiForm()
        {
            InitializeComponent();

            txtKapasite.KeyPress += txtKapasite_KeyPress;
            txtMasaNo.KeyPress += txtMasaNo_KeyPress;
            dgvMasalar.CellClick += dgvMasalar_CellClick;

            // Eski hatalı eklemeleri sildim, Designer'da tek bir FormClosing (MasaListesiForm_FormClosing) bağlandı.

            cmbKonum.SelectedIndexChanged += ComboBoxTemizle_SelectedIndexChanged;
            cmbDurum.SelectedIndexChanged += ComboBoxTemizle_SelectedIndexChanged;
            txtMasaNo.TextChanged += TextBoxTemizle_TextChanged;
            txtKapasite.TextChanged += TextBoxTemizle_TextChanged;
        }

        private void YildizlariGizle()
        {
            lblYildizMasaNo.Visible = false;
            lblYildizKapasite.Visible = false;
            lblYildizKonum.Visible = false;
            lblYildizDurum.Visible = false;
        }

        private void ComboBoxGorunumAyarla(ComboBox cmb, Color renk)
        {
            cmb.FlatStyle = FlatStyle.Flat;
            cmb.BackColor = renk;
        }

        private void TextBoxTemizle_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.BackColor = Color.White;

            if (txt == txtMasaNo)
                lblYildizMasaNo.Visible = false;
            else if (txt == txtKapasite)
                lblYildizKapasite.Visible = false;
        }

        private void ComboBoxTemizle_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            ComboBoxGorunumAyarla(cmb, Color.White);

            if (cmb == cmbKonum)
                lblYildizKonum.Visible = false;
            else if (cmb == cmbDurum)
                lblYildizDurum.Visible = false;
        }

        public bool BoslukKontrol()
        {
            bool bos = false;

            txtMasaNo.BackColor = Color.White;
            txtKapasite.BackColor = Color.White;
            ComboBoxGorunumAyarla(cmbKonum, Color.White);
            ComboBoxGorunumAyarla(cmbDurum, Color.White);

            YildizlariGizle();

            if (txtMasaNo.Text.Trim() == "")
            {
                txtMasaNo.BackColor = Color.LightCoral;
                lblYildizMasaNo.Visible = true;
                bos = true;
            }

            if (txtKapasite.Text.Trim() == "")
            {
                txtKapasite.BackColor = Color.LightCoral;
                lblYildizKapasite.Visible = true;
                bos = true;
            }

            if (cmbKonum.SelectedIndex == -1 || cmbKonum.Text.Trim() == "")
            {
                ComboBoxGorunumAyarla(cmbKonum, Color.LightCoral);
                lblYildizKonum.Visible = true;
                bos = true;
            }

            if (cmbDurum.SelectedIndex == -1 || cmbDurum.Text.Trim() == "")
            {
                ComboBoxGorunumAyarla(cmbDurum, Color.LightCoral);
                lblYildizDurum.Visible = true;
                bos = true;
            }

            if (txtMasaNo.Text.Trim() == "")
                txtMasaNo.Focus();
            else if (txtKapasite.Text.Trim() == "")
                txtKapasite.Focus();
            else if (cmbKonum.SelectedIndex == -1 || cmbKonum.Text.Trim() == "")
                cmbKonum.Focus();
            else if (cmbDurum.SelectedIndex == -1 || cmbDurum.Text.Trim() == "")
                cmbDurum.Focus();

            return bos;
        }

        public void MasaListele()
        {
            try
            {
                Form1.BaglantiAc();

                string sorgu = "SELECT ID, MasaNo, Kapasite, Konum, Durum, AcilisZamani, SonIslemTarihi FROM Masalar";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, Form1.Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvMasalar.DataSource = dt;
                dgvMasalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMasalar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvMasalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvMasalar.AllowUserToAddRows = false;
                dgvMasalar.ReadOnly = true;

                if (dgvMasalar.Columns.Contains("ID"))
                    dgvMasalar.Columns["ID"].Visible = false;

                if (dgvMasalar.Columns.Contains("MasaNo"))
                    dgvMasalar.Columns["MasaNo"].HeaderText = "Masa Numarası";

                if (dgvMasalar.Columns.Contains("Kapasite"))
                    dgvMasalar.Columns["Kapasite"].HeaderText = "Kapasite";

                if (dgvMasalar.Columns.Contains("Konum"))
                    dgvMasalar.Columns["Konum"].HeaderText = "Konum";

                if (dgvMasalar.Columns.Contains("Durum"))
                    dgvMasalar.Columns["Durum"].HeaderText = "Durum";

                if (dgvMasalar.Columns.Contains("AcilisZamani"))
                {
                    dgvMasalar.Columns["AcilisZamani"].HeaderText = "Açılış Zamanı";
                    dgvMasalar.Columns["AcilisZamani"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
                }

                if (dgvMasalar.Columns.Contains("SonIslemTarihi"))
                {
                    dgvMasalar.Columns["SonIslemTarihi"].HeaderText = "Son İşlem Tarihi";
                    dgvMasalar.Columns["SonIslemTarihi"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
                }

                Form1.Baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri çekme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (Form1.Baglanti.State == ConnectionState.Open)
                    Form1.Baglanti.Close();
            }
        }

        public void KayitEkle()
        {
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

                string sorgu = "INSERT INTO Masalar (MasaNo, Kapasite, Konum, Durum, AcilisZamani, SonIslemTarihi) " +
                               "VALUES (@masano, @kapasite, @konum, @durum, @aciliszamani, GETDATE())";

                SqlCommand cmd = new SqlCommand(sorgu, Form1.Baglanti);
                cmd.Parameters.AddWithValue("@masano", txtMasaNo.Text.Trim());
                cmd.Parameters.AddWithValue("@kapasite", kapasite);
                cmd.Parameters.AddWithValue("@konum", cmbKonum.Text.Trim());
                cmd.Parameters.AddWithValue("@durum", durumDegeri);

                if (durumDegeri == 1)
                    cmd.Parameters.AddWithValue("@aciliszamani", DateTime.Now);
                else
                    cmd.Parameters.AddWithValue("@aciliszamani", DBNull.Value);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Masa başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MasaListele();
                    Temizle();
                }

                Form1.Baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme Hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (Form1.Baglanti.State == ConnectionState.Open)
                    Form1.Baglanti.Close();
            }
        }

        public void Temizle()
        {
            txtMasaNo.Clear();
            txtKapasite.Clear();
            cmbKonum.SelectedIndex = -1;
            cmbDurum.SelectedIndex = -1;

            txtMasaNo.BackColor = Color.White;
            txtKapasite.BackColor = Color.White;
            ComboBoxGorunumAyarla(cmbKonum, Color.White);
            ComboBoxGorunumAyarla(cmbDurum, Color.White);

            YildizlariGizle();
        }

        private void MasaListesiForm_Load(object sender, EventArgs e)
        {
            cmbDurum.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKonum.DropDownStyle = ComboBoxStyle.DropDownList;

            TanimlamaYardimci.ComboDoldur(cmbDurum, "MasaDurumTanimlari", "DurumAdi");
            TanimlamaYardimci.ComboDoldur(cmbKonum, "MasaKonumTanimlari", "KonumAdi");

            ComboBoxGorunumAyarla(cmbKonum, Color.White);
            ComboBoxGorunumAyarla(cmbDurum, Color.White);

            YildizlariGizle();
            MasaListele();

            // Arama Kutularının Başlangıç Ayarları
            txtBirebirKapasite.Enabled = false;
            txtBirebirKonum.Enabled = false;

            cmbHizliAramaTuru.Items.Clear();
            cmbHizliAramaTuru.Items.Add("İçeren");
            cmbHizliAramaTuru.Items.Add("İle Başlayan");
            cmbHizliAramaTuru.Items.Add("İle Biten");
            cmbHizliAramaTuru.SelectedIndex = 0;

            lblHizliAramaDeger.Text = "Kapasite:";
        }

        private void toolStripButtonEkle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol())
            {
                MessageBox.Show("Lütfen kırmızı alanları doldurunuz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult cevap = MessageBox.Show("Yeni masa kaydı eklensin mi?", "Ekleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
                KayitEkle();
        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            if (dgvMasalar.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silinecek masayı seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int seciliId = Convert.ToInt32(dgvMasalar.CurrentRow.Cells["ID"].Value);
            string masaNo = dgvMasalar.CurrentRow.Cells["MasaNo"].Value.ToString();
            string kapasite = dgvMasalar.CurrentRow.Cells["Kapasite"].Value.ToString();
            string konum = dgvMasalar.CurrentRow.Cells["Konum"].Value.ToString();
            string durum = dgvMasalar.CurrentRow.Cells["Durum"].Value.ToString();

            string durumYazi = (durum == "1" || durum == "True") ? "Dolu" : "Boş";

            MasaSilOnayForm frm = new MasaSilOnayForm();
            frm.BilgiGetir(seciliId.ToString(), masaNo, kapasite, konum, durumYazi);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Form1.BaglantiAc();

                    string sorgu = "DELETE FROM Masalar WHERE ID = @id";
                    SqlCommand cmd = new SqlCommand(sorgu, Form1.Baglanti);
                    cmd.Parameters.AddWithValue("@id", seciliId);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Masa veritabanından silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MasaListele();
                        Temizle();
                    }

                    Form1.Baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme Hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (Form1.Baglanti.State == ConnectionState.Open)
                        Form1.Baglanti.Close();
                }
            }
        }

        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvMasalar.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek masayı seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MasaGuncelleForm frm = new MasaGuncelleForm();
            frm.masaListesiForm = this;
            frm.SeciliID = Convert.ToInt32(dgvMasalar.CurrentRow.Cells["ID"].Value);

            frm.txtID.Text = dgvMasalar.CurrentRow.Cells["ID"].Value.ToString();
            frm.txtMasaNo.Text = dgvMasalar.CurrentRow.Cells["MasaNo"].Value.ToString();
            frm.txtKapasite.Text = dgvMasalar.CurrentRow.Cells["Kapasite"].Value.ToString();
            frm.cmbKonum.Text = dgvMasalar.CurrentRow.Cells["Konum"].Value.ToString();

            object durumDegeri = dgvMasalar.CurrentRow.Cells["Durum"].Value;
            if (durumDegeri != null && (durumDegeri.ToString() == "1" || durumDegeri.ToString() == "True"))
                frm.cmbDurum.Text = "Dolu";
            else
                frm.cmbDurum.Text = "Boş";

            frm.ShowDialog();
        }

        private void toolStripButtonTemizle_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Alanlar temizlensin mi?", "Temizleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
                Temizle();
        }

        private void dgvMasalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMasalar.CurrentRow != null)
            {
                txtMasaNo.Text = dgvMasalar.CurrentRow.Cells["MasaNo"].Value.ToString();
                txtKapasite.Text = dgvMasalar.CurrentRow.Cells["Kapasite"].Value.ToString();
                cmbKonum.Text = dgvMasalar.CurrentRow.Cells["Konum"].Value.ToString();

                object durumDegeri = dgvMasalar.CurrentRow.Cells["Durum"].Value;
                if (durumDegeri != null && (durumDegeri.ToString() == "1" || durumDegeri.ToString() == "True"))
                    cmbDurum.Text = "Dolu";
                else
                    cmbDurum.Text = "Boş";
            }
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

        private void masaKonumTanimlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasaKonumTanimlamaForm frm = new MasaKonumTanimlamaForm();
            frm.ShowDialog();
            TanimlamaYardimci.ComboDoldur(cmbKonum, "MasaKonumTanimlari", "KonumAdi");
        }

        private void masaDurumTanimlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasaDurumTanimlamaForm frm = new MasaDurumTanimlamaForm();
            frm.ShowDialog();
            TanimlamaYardimci.ComboDoldur(cmbDurum, "MasaDurumTanimlari", "DurumAdi");
        }

        private void MasaListesiForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Çıkmak istiyor musunuz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.No)
                e.Cancel = true;
        }

        // =========================================================
        // Birebir Arama Bölümü
        // =========================================================

        private void chkArama_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;

            if (chk == chkKapasite)
            {
                txtBirebirKapasite.Enabled = chkKapasite.Checked;
                if (!chkKapasite.Checked) txtBirebirKapasite.Clear();
                else txtBirebirKapasite.Focus();
            }
            else if (chk == chkKonum)
            {
                txtBirebirKonum.Enabled = chkKonum.Checked;
                if (!chkKonum.Checked) txtBirebirKonum.Clear();
                else txtBirebirKonum.Focus();
            }
        }

        public void KayitAra()
        {
            try
            {
                Form1.BaglantiAc();
                DataTable dt = new DataTable();

                string kosullar = "1=1";

                if (chkKapasite.Checked && txtBirebirKapasite.Text != "")
                    kosullar += " AND Kapasite = '" + txtBirebirKapasite.Text.Replace("'", "''") + "'";

                if (chkKonum.Checked && txtBirebirKonum.Text != "")
                    kosullar += " AND Konum = '" + txtBirebirKonum.Text.Replace("'", "''") + "'";

                string sorgu = "SELECT ID, MasaNo, Kapasite, Konum, Durum, AcilisZamani, SonIslemTarihi FROM Masalar WHERE " + kosullar;

                SqlDataAdapter da = new SqlDataAdapter(sorgu, Form1.Baglanti);
                da.Fill(dt);
                dgvMasalar.DataSource = dt;
                Form1.Baglanti.Close();

                if (dgvMasalar.Columns.Contains("ID")) dgvMasalar.Columns["ID"].Visible = false;
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
            if (rdbKapasite.Checked)
                lblHizliAramaDeger.Text = "Kapasite:";
            else if (rdbKonum.Checked)
                lblHizliAramaDeger.Text = "Konum:";

            txtHizliAramaSecim.Text = "";
            txtHizliAramaSecim.Focus();
        }

        public void HizliAra()
        {
            try
            {
                Form1.BaglantiAc();
                DataTable dt = new DataTable();

                string arananAlan = "Kapasite";
                if (rdbKonum.Checked)
                    arananAlan = "Konum";

                string arananMetin = txtHizliAramaSecim.Text.Replace("'", "''");

                string SorguTum = "SELECT ID, MasaNo, Kapasite, Konum, Durum, AcilisZamani, SonIslemTarihi FROM Masalar";
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
                dgvMasalar.DataSource = dt;
                Form1.Baglanti.Close();

                if (dgvMasalar.Columns.Contains("ID")) dgvMasalar.Columns["ID"].Visible = false;
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