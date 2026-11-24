using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CafeOtomasyon
{
    public partial class OdemeAlmaForm : Form
    {
        public OdemeAlmaForm()
        {
            InitializeComponent();
        }

        public void OdemeTuruComboDoldur()
        {
            TanimlamaYardimci.ComboDoldur(cmbOdemeTuru, "OdemeTuruTanimlari", "OdemeTuruAdi");
        }

        private void odemeTuruTanimlama_Click(object sender, EventArgs e)
        {
            OdemeTuruTanimlamaForm frm = new OdemeTuruTanimlamaForm();
            frm.ShowDialog();
            OdemeTuruComboDoldur();
        }

        private void OdemeAlmaForm_Load(object sender, EventArgs e)
        {
            cmbOdemeTuru.DropDownStyle = ComboBoxStyle.DropDownList;
            OdemeTuruComboDoldur();

            // Arama Kutularının Başlangıç Ayarları
            txtBirebirTutar.Enabled = false;
            txtBirebirOdemeTuru.Enabled = false;
            txtBirebirMasaID.Enabled = false;

            cmbHizliAramaTuru.Items.Clear();
            cmbHizliAramaTuru.Items.Add("İçeren");
            cmbHizliAramaTuru.Items.Add("İle Başlayan");
            cmbHizliAramaTuru.Items.Add("İle Biten");
            cmbHizliAramaTuru.SelectedIndex = 0;

            lblHizliAramaDeger.Text = "Tutar:";

            Listele();
        }

        void Listele()
        {
            try
            {
                Form1.BaglantiAc();

                SqlDataAdapter da = new SqlDataAdapter("SELECT ID, MasaID, SiparisID, Tutar, OdemeTuru, Aciklama, OdemeTarihi FROM Odemeler", Form1.Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOdemeler.DataSource = dt;

                if (dgvOdemeler.Columns.Contains("ID"))
                    dgvOdemeler.Columns["ID"].Visible = false;

                dgvOdemeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvOdemeler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvOdemeler.ReadOnly = true;
                dgvOdemeler.AllowUserToAddRows = false;

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
            txtMasaID.Clear();
            txtSiparisID.Clear();
            txtTutar.Clear();
            cmbOdemeTuru.SelectedIndex = -1;
            txtAciklama.Clear();
        }

        private void ComboBoxGorunumAyarla(ComboBox cmb, Color renk)
        {
            cmb.BackColor = renk;
        }

        public bool BoslukKontrol()
        {
            bool bos = false;

            txtMasaID.BackColor = Color.White;
            txtSiparisID.BackColor = Color.White;
            txtTutar.BackColor = Color.White;
            ComboBoxGorunumAyarla(cmbOdemeTuru, Color.White);

            if (txtMasaID.Text.Trim() == "")
            {
                txtMasaID.BackColor = Color.LightCoral;
                bos = true;
            }

            if (txtSiparisID.Text.Trim() == "")
            {
                txtSiparisID.BackColor = Color.LightCoral;
                bos = true;
            }

            if (txtTutar.Text.Trim() == "")
            {
                txtTutar.BackColor = Color.LightCoral;
                bos = true;
            }

            if (cmbOdemeTuru.SelectedIndex == -1 || cmbOdemeTuru.Text.Trim() == "")
            {
                ComboBoxGorunumAyarla(cmbOdemeTuru, Color.LightCoral);
                bos = true;
            }

            if (txtMasaID.Text.Trim() == "")
                txtMasaID.Focus();
            else if (txtSiparisID.Text.Trim() == "")
                txtSiparisID.Focus();
            else if (txtTutar.Text.Trim() == "")
                txtTutar.Focus();
            else if (cmbOdemeTuru.SelectedIndex == -1 || cmbOdemeTuru.Text.Trim() == "")
                cmbOdemeTuru.Focus();

            return bos;
        }

        private void toolStripButtonEkle_Click(object sender, EventArgs e)
        {
            decimal tutar;
            int masaId, siparisId;
            if (BoslukKontrol())
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

            DialogResult cevap = MessageBox.Show("Ödeme eklensin mi?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap != DialogResult.Yes) return;

            try
            {
                Form1.BaglantiAc();

                SqlCommand cmd = new SqlCommand("INSERT INTO Odemeler (MasaID, SiparisID, Tutar, OdemeTuru, Aciklama, OdemeTarihi) VALUES (@masa,@siparis,@tutar,@tur,@aciklama,GETDATE())", Form1.Baglanti);
                cmd.Parameters.AddWithValue("@masa", masaId);
                cmd.Parameters.AddWithValue("@siparis", siparisId);
                cmd.Parameters.AddWithValue("@tutar", tutar);
                cmd.Parameters.AddWithValue("@tur", cmbOdemeTuru.Text);
                cmd.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
                cmd.ExecuteNonQuery();

                Form1.Baglanti.Close();

                MessageBox.Show("Ödeme eklendi");
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
            if (dgvOdemeler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen kayıt seçiniz");
                return;
            }

            int id = Convert.ToInt32(dgvOdemeler.CurrentRow.Cells["ID"].Value);

            OdemeSilForm frm = new OdemeSilForm();
            frm.BilgiGetir(
                dgvOdemeler.CurrentRow.Cells["ID"].Value.ToString(),
                dgvOdemeler.CurrentRow.Cells["MasaID"].Value.ToString(),
                dgvOdemeler.CurrentRow.Cells["SiparisID"].Value.ToString(),
                dgvOdemeler.CurrentRow.Cells["Tutar"].Value.ToString(),
                dgvOdemeler.CurrentRow.Cells["OdemeTuru"].Value.ToString(),
                dgvOdemeler.CurrentRow.Cells["Aciklama"].Value.ToString()
            );

            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Form1.BaglantiAc();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Odemeler WHERE ID=@id", Form1.Baglanti);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                    Form1.Baglanti.Close();

                    MessageBox.Show("Ödeme silindi");
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
            if (dgvOdemeler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen kayıt seçiniz");
                return;
            }

            OdemeGuncelleForm frm = new OdemeGuncelleForm();
            frm.odemeAlmaForm = this;
            frm.SeciliID = Convert.ToInt32(dgvOdemeler.CurrentRow.Cells["ID"].Value);

            frm.txtID.Text = dgvOdemeler.CurrentRow.Cells["ID"].Value.ToString();
            frm.txtMasaID.Text = dgvOdemeler.CurrentRow.Cells["MasaID"].Value.ToString();
            frm.txtSiparisID.Text = dgvOdemeler.CurrentRow.Cells["SiparisID"].Value.ToString();
            frm.txtTutar.Text = dgvOdemeler.CurrentRow.Cells["Tutar"].Value.ToString();
            frm.cmbOdemeTuru.Text = dgvOdemeler.CurrentRow.Cells["OdemeTuru"].Value.ToString();
            frm.txtAciklama.Text = dgvOdemeler.CurrentRow.Cells["Aciklama"].Value.ToString();

            frm.ShowDialog();
        }

        private void toolStripButtonTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dgvOdemeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOdemeler.CurrentRow != null)
            {
                txtMasaID.Text = dgvOdemeler.CurrentRow.Cells["MasaID"].Value.ToString();
                txtSiparisID.Text = dgvOdemeler.CurrentRow.Cells["SiparisID"].Value.ToString();
                txtTutar.Text = dgvOdemeler.CurrentRow.Cells["Tutar"].Value.ToString();
                cmbOdemeTuru.Text = dgvOdemeler.CurrentRow.Cells["OdemeTuru"].Value.ToString();
                txtAciklama.Text = dgvOdemeler.CurrentRow.Cells["Aciklama"].Value.ToString();
            }
        }

        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '.'))
                e.Handled = true;
        }

        private void txtMasaID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void txtSiparisID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void OdemeAlmaForm_FormClosing(object sender, FormClosingEventArgs e)
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

            if (chk == chkTutar)
            {
                txtBirebirTutar.Enabled = chkTutar.Checked;
                if (!chkTutar.Checked) txtBirebirTutar.Clear();
                else txtBirebirTutar.Focus();
            }
            else if (chk == chkOdemeTuru)
            {
                txtBirebirOdemeTuru.Enabled = chkOdemeTuru.Checked;
                if (!chkOdemeTuru.Checked) txtBirebirOdemeTuru.Clear();
                else txtBirebirOdemeTuru.Focus();
            }
            else if (chk == chkMasaID)
            {
                txtBirebirMasaID.Enabled = chkMasaID.Checked;
                if (!chkMasaID.Checked) txtBirebirMasaID.Clear();
                else txtBirebirMasaID.Focus();
            }
        }

        public void KayitAra()
        {
            try
            {
                Form1.BaglantiAc();
                DataTable dt = new DataTable();

                string kosullar = "1=1";

                if (chkTutar.Checked && txtBirebirTutar.Text != "")
                    kosullar += " AND CAST(Tutar AS NVARCHAR(MAX)) = '" + txtBirebirTutar.Text.Replace("'", "''") + "'";

                if (chkOdemeTuru.Checked && txtBirebirOdemeTuru.Text != "")
                    kosullar += " AND OdemeTuru = '" + txtBirebirOdemeTuru.Text.Replace("'", "''") + "'";

                if (chkMasaID.Checked && txtBirebirMasaID.Text != "")
                    kosullar += " AND MasaID = '" + txtBirebirMasaID.Text.Replace("'", "''") + "'";

                string sorgu = "SELECT ID, MasaID, SiparisID, Tutar, OdemeTuru, Aciklama, OdemeTarihi FROM Odemeler WHERE " + kosullar;

                SqlDataAdapter da = new SqlDataAdapter(sorgu, Form1.Baglanti);
                da.Fill(dt);
                dgvOdemeler.DataSource = dt;
                Form1.Baglanti.Close();

                if (dgvOdemeler.Columns.Contains("ID")) dgvOdemeler.Columns["ID"].Visible = false;
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
            if (rdbTutar.Checked)
                lblHizliAramaDeger.Text = "Tutar:";
            else if (rdbOdemeTuru.Checked)
                lblHizliAramaDeger.Text = "Ödeme Türü:";
            else if (rdbMasaID.Checked)
                lblHizliAramaDeger.Text = "Masa ID:";

            txtHizliAramaSecim.Text = "";
            txtHizliAramaSecim.Focus();
        }

        public void HizliAra()
        {
            try
            {
                Form1.BaglantiAc();
                DataTable dt = new DataTable();

                string arananAlan = "Tutar";
                if (rdbOdemeTuru.Checked)
                    arananAlan = "OdemeTuru";
                else if (rdbMasaID.Checked)
                    arananAlan = "MasaID";

                string arananMetin = txtHizliAramaSecim.Text.Replace("'", "''");

                // Veri tipleri farklı (Decimal, Int, Varchar) olabileceği için CAST kullanarak arama yapıyoruz.
                string SorguTum = "SELECT ID, MasaID, SiparisID, Tutar, OdemeTuru, Aciklama, OdemeTarihi FROM Odemeler";
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
                dgvOdemeler.DataSource = dt;
                Form1.Baglanti.Close();

                if (dgvOdemeler.Columns.Contains("ID")) dgvOdemeler.Columns["ID"].Visible = false;
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