using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CafeOtomasyon
{
    public partial class RezervasyonForm : Form
    {
        public RezervasyonForm()
        {
            InitializeComponent();
        }

        private void RezervasyonForm_Load(object sender, EventArgs e)
        {
            cmbDurum.Items.Clear();
            cmbDurum.Items.Add("Aktif");
            cmbDurum.Items.Add("Geldi");
            cmbDurum.Items.Add("İptal");
            cmbDurum.Items.Add("Tamamlandı");
            cmbDurum.DropDownStyle = ComboBoxStyle.DropDownList;

            // Arama Kutularının Başlangıç Ayarları
            txtBirebirMusteriAdi.Enabled = false;
            txtBirebirTelefon.Enabled = false;
            txtBirebirDurum.Enabled = false;
            txtBirebirTarih.Enabled = false;

            cmbHizliAramaTuru.Items.Clear();
            cmbHizliAramaTuru.Items.Add("İçeren");
            cmbHizliAramaTuru.Items.Add("İle Başlayan");
            cmbHizliAramaTuru.Items.Add("İle Biten");
            cmbHizliAramaTuru.SelectedIndex = 0;

            lblHizliAramaDeger.Text = "Müşteri Adı:";

            Listele();
        }

        void Listele()
        {
            try
            {
                Form1.BaglantiAc();

                SqlDataAdapter da = new SqlDataAdapter("SELECT ID, MusteriAdi, Telefon, MasaID, KisiSayisi, RezervasyonTarihi, Aciklama, Durum FROM Rezervasyonlar", Form1.Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRezervasyon.DataSource = dt;

                if (dgvRezervasyon.Columns.Contains("ID"))
                    dgvRezervasyon.Columns["ID"].Visible = false;

                dgvRezervasyon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvRezervasyon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvRezervasyon.ReadOnly = true;
                dgvRezervasyon.AllowUserToAddRows = false;

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
            txtMusteriAdi.Clear();
            txtTelefon.Clear();
            txtMasaID.Clear();
            txtKisiSayisi.Clear();
            txtAciklama.Clear();
            cmbDurum.SelectedIndex = -1;
            dtpRezervasyonTarihi.Value = DateTime.Now;
        }

        private void toolStripButtonEkle_Click(object sender, EventArgs e)
        {
            int masaId, kisiSayisi;
            if (BoslukKontrol())
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtMusteriAdi.Text.Trim() == "")
            {
                MessageBox.Show("Müşteri adı boş olamaz");
                return;
            }

            if (txtTelefon.Text.Trim() == "")
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

            if (cmbDurum.Text.Trim() == "")
            {
                MessageBox.Show("Durum seçiniz");
                return;
            }

            DialogResult cevap = MessageBox.Show("Rezervasyon eklensin mi?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap != DialogResult.Yes) return;

            try
            {
                Form1.BaglantiAc();

                SqlCommand cmd = new SqlCommand("INSERT INTO Rezervasyonlar (MusteriAdi, Telefon, MasaID, KisiSayisi, RezervasyonTarihi, Aciklama, Durum) VALUES (@ad,@telefon,@masa,@kisi,@tarih,@aciklama,@durum)", Form1.Baglanti);
                cmd.Parameters.AddWithValue("@ad", txtMusteriAdi.Text);
                cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                cmd.Parameters.AddWithValue("@masa", masaId);
                cmd.Parameters.AddWithValue("@kisi", kisiSayisi);
                cmd.Parameters.AddWithValue("@tarih", dtpRezervasyonTarihi.Value);
                cmd.Parameters.AddWithValue("@aciklama", txtAciklama.Text);
                cmd.Parameters.AddWithValue("@durum", cmbDurum.Text);
                cmd.ExecuteNonQuery();

                Form1.Baglanti.Close();

                MessageBox.Show("Rezervasyon eklendi");
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

        private void ComboBoxGorunumAyarla(ComboBox cmb, Color renk)
        {
            cmb.BackColor = renk;
        }

        public bool BoslukKontrol()
        {
            bool bos = false;

            txtMusteriAdi.BackColor = Color.White;
            txtTelefon.BackColor = Color.White;
            txtMasaID.BackColor = Color.White;
            txtKisiSayisi.BackColor = Color.White;
            ComboBoxGorunumAyarla(cmbDurum, Color.White);

            if (txtMusteriAdi.Text.Trim() == "")
            {
                txtMusteriAdi.BackColor = Color.LightCoral;
                bos = true;
            }

            if (txtTelefon.Text.Trim() == "")
            {
                txtTelefon.BackColor = Color.LightCoral;
                bos = true;
            }

            if (txtMasaID.Text.Trim() == "")
            {
                txtMasaID.BackColor = Color.LightCoral;
                bos = true;
            }

            if (txtKisiSayisi.Text.Trim() == "")
            {
                txtKisiSayisi.BackColor = Color.LightCoral;
                bos = true;
            }

            if (cmbDurum.SelectedIndex == -1 || cmbDurum.Text.Trim() == "")
            {
                ComboBoxGorunumAyarla(cmbDurum, Color.LightCoral);
                bos = true;
            }

            if (txtMusteriAdi.Text.Trim() == "")
                txtMusteriAdi.Focus();
            else if (txtTelefon.Text.Trim() == "")
                txtTelefon.Focus();
            else if (txtMasaID.Text.Trim() == "")
                txtMasaID.Focus();
            else if (txtKisiSayisi.Text.Trim() == "")
                txtKisiSayisi.Focus();
            else if (cmbDurum.SelectedIndex == -1 || cmbDurum.Text.Trim() == "")
                cmbDurum.Focus();

            return bos;
        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            if (dgvRezervasyon.CurrentRow == null)
            {
                MessageBox.Show("Lütfen kayıt seçiniz");
                return;
            }

            int id = Convert.ToInt32(dgvRezervasyon.CurrentRow.Cells["ID"].Value);

            RezervasyonSilForm frm = new RezervasyonSilForm();
            frm.BilgiGetir(
                dgvRezervasyon.CurrentRow.Cells["ID"].Value.ToString(),
                dgvRezervasyon.CurrentRow.Cells["MusteriAdi"].Value.ToString(),
                dgvRezervasyon.CurrentRow.Cells["Telefon"].Value.ToString(),
                dgvRezervasyon.CurrentRow.Cells["MasaID"].Value.ToString(),
                dgvRezervasyon.CurrentRow.Cells["KisiSayisi"].Value.ToString(),
                dgvRezervasyon.CurrentRow.Cells["Durum"].Value.ToString()
            );

            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Form1.BaglantiAc();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Rezervasyonlar WHERE ID=@id", Form1.Baglanti);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                    Form1.Baglanti.Close();

                    MessageBox.Show("Rezervasyon silindi");
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
            if (dgvRezervasyon.CurrentRow == null)
            {
                MessageBox.Show("Lütfen kayıt seçiniz");
                return;
            }

            RezervasyonGuncelleForm frm = new RezervasyonGuncelleForm();
            frm.rezervasyonForm = this;
            frm.SeciliID = Convert.ToInt32(dgvRezervasyon.CurrentRow.Cells["ID"].Value);

            frm.txtID.Text = dgvRezervasyon.CurrentRow.Cells["ID"].Value.ToString();
            frm.txtMusteriAdi.Text = dgvRezervasyon.CurrentRow.Cells["MusteriAdi"].Value.ToString();
            frm.txtTelefon.Text = dgvRezervasyon.CurrentRow.Cells["Telefon"].Value.ToString();
            frm.txtMasaID.Text = dgvRezervasyon.CurrentRow.Cells["MasaID"].Value.ToString();
            frm.txtKisiSayisi.Text = dgvRezervasyon.CurrentRow.Cells["KisiSayisi"].Value.ToString();
            frm.txtAciklama.Text = dgvRezervasyon.CurrentRow.Cells["Aciklama"].Value.ToString();
            frm.cmbDurum.Text = dgvRezervasyon.CurrentRow.Cells["Durum"].Value.ToString();

            DateTime tarih;
            if (DateTime.TryParse(dgvRezervasyon.CurrentRow.Cells["RezervasyonTarihi"].Value.ToString(), out tarih))
                frm.dtpRezervasyonTarihi.Value = tarih;

            frm.ShowDialog();
        }

        private void toolStripButtonTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dgvRezervasyon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRezervasyon.CurrentRow != null)
            {
                txtMusteriAdi.Text = dgvRezervasyon.CurrentRow.Cells["MusteriAdi"].Value.ToString();
                txtTelefon.Text = dgvRezervasyon.CurrentRow.Cells["Telefon"].Value.ToString();
                txtMasaID.Text = dgvRezervasyon.CurrentRow.Cells["MasaID"].Value.ToString();
                txtKisiSayisi.Text = dgvRezervasyon.CurrentRow.Cells["KisiSayisi"].Value.ToString();
                txtAciklama.Text = dgvRezervasyon.CurrentRow.Cells["Aciklama"].Value.ToString();
                cmbDurum.Text = dgvRezervasyon.CurrentRow.Cells["Durum"].Value.ToString();

                DateTime tarih;
                if (DateTime.TryParse(dgvRezervasyon.CurrentRow.Cells["RezervasyonTarihi"].Value.ToString(), out tarih))
                    dtpRezervasyonTarihi.Value = tarih;
            }
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

        private void RezervasyonForm_FormClosing(object sender, FormClosingEventArgs e)
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

            if (chk == chkMusteriAdi)
            {
                txtBirebirMusteriAdi.Enabled = chkMusteriAdi.Checked;
                if (!chkMusteriAdi.Checked) txtBirebirMusteriAdi.Clear();
                else txtBirebirMusteriAdi.Focus();
            }
            else if (chk == chkTelefon)
            {
                txtBirebirTelefon.Enabled = chkTelefon.Checked;
                if (!chkTelefon.Checked) txtBirebirTelefon.Clear();
                else txtBirebirTelefon.Focus();
            }
            else if (chk == chkDurum)
            {
                txtBirebirDurum.Enabled = chkDurum.Checked;
                if (!chkDurum.Checked) txtBirebirDurum.Clear();
                else txtBirebirDurum.Focus();
            }
            else if (chk == chkTarih)
            {
                txtBirebirTarih.Enabled = chkTarih.Checked;
                if (!chkTarih.Checked) txtBirebirTarih.Clear();
                else txtBirebirTarih.Focus();
            }
        }

        public void KayitAra()
        {
            try
            {
                Form1.BaglantiAc();
                DataTable dt = new DataTable();

                string kosullar = "1=1";

                if (chkMusteriAdi.Checked && txtBirebirMusteriAdi.Text != "")
                    kosullar += " AND MusteriAdi = '" + txtBirebirMusteriAdi.Text.Replace("'", "''") + "'";

                if (chkTelefon.Checked && txtBirebirTelefon.Text != "")
                    kosullar += " AND Telefon = '" + txtBirebirTelefon.Text.Replace("'", "''") + "'";

                if (chkDurum.Checked && txtBirebirDurum.Text != "")
                    kosullar += " AND Durum = '" + txtBirebirDurum.Text.Replace("'", "''") + "'";

                // Tarih için LIKE kullanıldı (Sadece yıl veya ay yazılarak aranabilmesi için)
                if (chkTarih.Checked && txtBirebirTarih.Text != "")
                    kosullar += " AND CAST(RezervasyonTarihi AS NVARCHAR(MAX)) LIKE '%" + txtBirebirTarih.Text.Replace("'", "''") + "%'";

                string sorgu = "SELECT ID, MusteriAdi, Telefon, MasaID, KisiSayisi, RezervasyonTarihi, Aciklama, Durum FROM Rezervasyonlar WHERE " + kosullar;

                SqlDataAdapter da = new SqlDataAdapter(sorgu, Form1.Baglanti);
                da.Fill(dt);
                dgvRezervasyon.DataSource = dt;
                Form1.Baglanti.Close();

                if (dgvRezervasyon.Columns.Contains("ID")) dgvRezervasyon.Columns["ID"].Visible = false;
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
            if (rdbMusteriAdi.Checked)
                lblHizliAramaDeger.Text = "Müşteri Adı:";
            else if (rdbTelefon.Checked)
                lblHizliAramaDeger.Text = "Telefon:";
            else if (rdbDurum.Checked)
                lblHizliAramaDeger.Text = "Durum:";
            else if (rdbTarih.Checked)
                lblHizliAramaDeger.Text = "Tarih:";

            txtHizliAramaSecim.Text = "";
            txtHizliAramaSecim.Focus();
        }

        public void HizliAra()
        {
            try
            {
                Form1.BaglantiAc();
                DataTable dt = new DataTable();

                string arananAlan = "MusteriAdi";
                if (rdbTelefon.Checked)
                    arananAlan = "Telefon";
                else if (rdbDurum.Checked)
                    arananAlan = "Durum";
                else if (rdbTarih.Checked)
                    arananAlan = "RezervasyonTarihi";

                string arananMetin = txtHizliAramaSecim.Text.Replace("'", "''");

                string SorguTum = "SELECT ID, MusteriAdi, Telefon, MasaID, KisiSayisi, RezervasyonTarihi, Aciklama, Durum FROM Rezervasyonlar";
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
                dgvRezervasyon.DataSource = dt;
                Form1.Baglanti.Close();

                if (dgvRezervasyon.Columns.Contains("ID")) dgvRezervasyon.Columns["ID"].Visible = false;
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