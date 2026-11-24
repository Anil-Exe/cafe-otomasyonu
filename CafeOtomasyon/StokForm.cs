using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeOtomasyon
{
    public partial class StokForm : Form
    {
        public StokForm()
        {
            InitializeComponent();
            TanimlamalarButonunuGarantiEt();
            RaporlarButonunuGarantiEt();

            this.FormClosing += StokForm_FormClosing;

            cmbBirim.SelectedIndexChanged += ComboBoxTemizle_SelectedIndexChanged;
            cmbKategori.SelectedIndexChanged += ComboBoxTemizle_SelectedIndexChanged;
            txtUrunAd.TextChanged += TextBoxTemizle_TextChanged;
            txtFiyat.TextChanged += TextBoxTemizle_TextChanged;
            txtStok.TextChanged += TextBoxTemizle_TextChanged;

            // Checkbox'ların tıklanma olaylarını bağladık
            chkUrunAdi.CheckedChanged += chkUrunAdi_CheckedChanged;
            chkKategori.CheckedChanged += chkKategori_CheckedChanged;

        }


        private void TanimlamalarButonunuGarantiEt()
        {
            if (toolStrip1 == null) return;

            if (toolStripDropDownButtonTanimlamalar == null)
                toolStripDropDownButtonTanimlamalar = new ToolStripDropDownButton();

            toolStripDropDownButtonTanimlamalar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButtonTanimlamalar.Text = "Tanımlamalar";
            toolStripDropDownButtonTanimlamalar.Name = "toolStripDropDownButtonTanimlamalar";

            toolStripDropDownButtonTanimlamalar.DropDownItems.Clear();

            if (birimTanimlamaToolStripMenuItem == null)
                birimTanimlamaToolStripMenuItem = new ToolStripMenuItem();
            birimTanimlamaToolStripMenuItem.Name = "birimTanimlamaToolStripMenuItem";
            birimTanimlamaToolStripMenuItem.Text = "Birim Tanımlama";
            birimTanimlamaToolStripMenuItem.Click -= birimTanimlama_Click;
            birimTanimlamaToolStripMenuItem.Click += birimTanimlama_Click;

            if (kategoriTanimlamaToolStripMenuItem == null)
                kategoriTanimlamaToolStripMenuItem = new ToolStripMenuItem();
            kategoriTanimlamaToolStripMenuItem.Name = "kategoriTanimlamaToolStripMenuItem";
            kategoriTanimlamaToolStripMenuItem.Text = "Kategori Tanımlama";
            kategoriTanimlamaToolStripMenuItem.Click -= kategoriTanimlama_Click;
            kategoriTanimlamaToolStripMenuItem.Click += kategoriTanimlama_Click;

            toolStripDropDownButtonTanimlamalar.DropDownItems.Add(birimTanimlamaToolStripMenuItem);
            toolStripDropDownButtonTanimlamalar.DropDownItems.Add(kategoriTanimlamaToolStripMenuItem);

            if (!toolStrip1.Items.Contains(toolStripDropDownButtonTanimlamalar))
            {
                int temizleIndex = toolStrip1.Items.IndexOf(toolStripButtonTemizle);
                if (temizleIndex >= 0 && temizleIndex < toolStrip1.Items.Count - 1)
                    toolStrip1.Items.Insert(temizleIndex + 1, toolStripDropDownButtonTanimlamalar);
                else
                    toolStrip1.Items.Add(toolStripDropDownButtonTanimlamalar);
            }
        }

        private void RaporlarButonunuGarantiEt()
        {
            if (toolStrip1 == null) return;

            if (toolStripDropDownButtonRaporlar == null)
                toolStripDropDownButtonRaporlar = new ToolStripDropDownButton();

            toolStripDropDownButtonRaporlar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButtonRaporlar.Text = "Raporlar";
            toolStripDropDownButtonRaporlar.Name = "toolStripDropDownButtonRaporlar";
            toolStripDropDownButtonRaporlar.DropDownItems.Clear();

            if (stokRaporuToolStripMenuItem == null)
                stokRaporuToolStripMenuItem = new ToolStripMenuItem();

            stokRaporuToolStripMenuItem.Name = "stokRaporuToolStripMenuItem";
            stokRaporuToolStripMenuItem.Text = "Stok Listesi";
            stokRaporuToolStripMenuItem.Click -= stokRaporuToolStripMenuItem_Click;
            stokRaporuToolStripMenuItem.Click += stokRaporuToolStripMenuItem_Click;

            toolStripDropDownButtonRaporlar.DropDownItems.Add(stokRaporuToolStripMenuItem);

            if (!toolStrip1.Items.Contains(toolStripDropDownButtonRaporlar))
            {
                int tanimIndex = toolStrip1.Items.IndexOf(toolStripDropDownButtonTanimlamalar);
                if (tanimIndex >= 0 && tanimIndex < toolStrip1.Items.Count - 1)
                    toolStrip1.Items.Insert(tanimIndex + 1, toolStripDropDownButtonRaporlar);
                else
                    toolStrip1.Items.Add(toolStripDropDownButtonRaporlar);
            }
        }

        private void YildizlariGizle()
        {
            lblYildizUrunAd.Visible = false;
            lblYildizBirim.Visible = false;
            lblYildizFiyat.Visible = false;
            lblYildizStok.Visible = false;
            lblYildizKategori.Visible = false;
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

            if (txt == txtUrunAd)
                lblYildizUrunAd.Visible = false;
            else if (txt == txtFiyat)
                lblYildizFiyat.Visible = false;
            else if (txt == txtStok)
                lblYildizStok.Visible = false;
        }

        private void ComboBoxTemizle_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            ComboBoxGorunumAyarla(cmb, Color.White);

            if (cmb == cmbBirim)
                lblYildizBirim.Visible = false;
            else if (cmb == cmbKategori)
                lblYildizKategori.Visible = false;
        }

        private void StokForm_Load(object sender, EventArgs e)
        {
            cmbBirim.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;

            ComboBoxlariDoldur();

            ComboBoxGorunumAyarla(cmbBirim, Color.White);
            ComboBoxGorunumAyarla(cmbKategori, Color.White);

            YildizlariGizle();

            // Arama Kutularının Başlangıç Ayarları
            txtBirebirUrunAdi.Enabled = false;
            txtBirebirKategori.Enabled = false;

            cmbHizliAramaTuru.Items.Clear();
            cmbHizliAramaTuru.Items.Add("İçeren");
            cmbHizliAramaTuru.Items.Add("İle Başlayan");
            cmbHizliAramaTuru.Items.Add("İle Biten");
            cmbHizliAramaTuru.SelectedIndex = 0;

            lblHizliAramaDeger.Text = "Ürün Adı:";

            KayitListele();
        }

        public void ComboBoxlariDoldur()
        {
            TanimlamaYardimci.ComboDoldur(cmbBirim, "BirimTanimlari", "BirimAdi");
            TanimlamaYardimci.ComboDoldur(cmbKategori, "KategoriTanimlari", "KategoriAdi");
        }

        private void birimTanimlama_Click(object sender, EventArgs e)
        {
            BirimTanimlamaForm frm = new BirimTanimlamaForm();
            frm.ShowDialog();
            ComboBoxlariDoldur();
        }

        private void kategoriTanimlama_Click(object sender, EventArgs e)
        {
            KategoriTanimlamaForm frm = new KategoriTanimlamaForm();
            frm.ShowDialog();
            ComboBoxlariDoldur();
        }

        public void KayitListele()
        {
            try
            {
                Form1.BaglantiAc();
                string sorgu = "SELECT ID, UrunAd, Birim, SatisFiyat, StokMiktari, Kategori FROM Urunler";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, Form1.Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvUrunler.DataSource = dt;

                // Senin ilk şablonundaki tablo düzenleme kodları
                if (dgvUrunler.Columns["ID"] != null) dgvUrunler.Columns["ID"].Visible = false;
                if (dgvUrunler.Columns["UrunAd"] != null) dgvUrunler.Columns["UrunAd"].HeaderText = "Ürün Adı";
                if (dgvUrunler.Columns["Birim"] != null) dgvUrunler.Columns["Birim"].HeaderText = "Birim";
                if (dgvUrunler.Columns["SatisFiyat"] != null) dgvUrunler.Columns["SatisFiyat"].HeaderText = "Satış Fiyatı";
                if (dgvUrunler.Columns["StokMiktari"] != null) dgvUrunler.Columns["StokMiktari"].HeaderText = "Stok Miktarı";
                if (dgvUrunler.Columns["Kategori"] != null) dgvUrunler.Columns["Kategori"].HeaderText = "Kategori";

                dgvUrunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvUrunler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvUrunler.AllowUserToAddRows = false;
                dgvUrunler.ReadOnly = true;

                Form1.Baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme Hatası : " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Form1.Baglanti.State == ConnectionState.Open)
                    Form1.Baglanti.Close();
            }
        }

        public bool BoslukKontrol()
        {
            bool bos = false;

            txtUrunAd.BackColor = Color.White;
            ComboBoxGorunumAyarla(cmbBirim, Color.White);
            txtFiyat.BackColor = Color.White;
            txtStok.BackColor = Color.White;
            ComboBoxGorunumAyarla(cmbKategori, Color.White);

            YildizlariGizle();

            if (txtUrunAd.Text.Trim() == "")
            {
                txtUrunAd.BackColor = Color.LightCoral;
                lblYildizUrunAd.Visible = true;
                bos = true;
            }

            if (cmbBirim.SelectedIndex == -1 || cmbBirim.Text.Trim() == "")
            {
                ComboBoxGorunumAyarla(cmbBirim, Color.LightCoral);
                lblYildizBirim.Visible = true;
                bos = true;
            }

            if (txtFiyat.Text.Trim() == "")
            {
                txtFiyat.BackColor = Color.LightCoral;
                lblYildizFiyat.Visible = true;
                bos = true;
            }

            if (txtStok.Text.Trim() == "")
            {
                txtStok.BackColor = Color.LightCoral;
                lblYildizStok.Visible = true;
                bos = true;
            }

            if (cmbKategori.SelectedIndex == -1 || cmbKategori.Text.Trim() == "")
            {
                ComboBoxGorunumAyarla(cmbKategori, Color.LightCoral);
                lblYildizKategori.Visible = true;
                bos = true;
            }

            if (txtUrunAd.Text.Trim() == "")
                txtUrunAd.Focus();
            else if (cmbBirim.SelectedIndex == -1 || cmbBirim.Text.Trim() == "")
                cmbBirim.Focus();
            else if (txtFiyat.Text.Trim() == "")
                txtFiyat.Focus();
            else if (txtStok.Text.Trim() == "")
                txtStok.Focus();
            else if (cmbKategori.SelectedIndex == -1 || cmbKategori.Text.Trim() == "")
                cmbKategori.Focus();

            return bos;
        }

        public void Temizle()
        {
            txtUrunAd.Clear();
            cmbBirim.SelectedIndex = -1;
            txtFiyat.Clear();
            txtStok.Clear();
            cmbKategori.SelectedIndex = -1;

            txtUrunAd.BackColor = Color.White;
            ComboBoxGorunumAyarla(cmbBirim, Color.White);
            txtFiyat.BackColor = Color.White;
            txtStok.BackColor = Color.White;
            ComboBoxGorunumAyarla(cmbKategori, Color.White);

            YildizlariGizle();
        }

        public void KayitEkle()
        {
            try
            {
                Form1.BaglantiAc();

                decimal satisFiyat;
                int stokMiktari;

                if (!decimal.TryParse(txtFiyat.Text.Trim(), out satisFiyat))
                {
                    MessageBox.Show("Satış fiyatı sayısal olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFiyat.Focus();
                    Form1.Baglanti.Close();
                    return;
                }

                if (!int.TryParse(txtStok.Text.Trim(), out stokMiktari))
                {
                    MessageBox.Show("Stok miktarı sayısal olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtStok.Focus();
                    Form1.Baglanti.Close();
                    return;
                }

                string sorgu = "INSERT INTO Urunler (UrunAd, Birim, SatisFiyat, StokMiktari, Kategori) VALUES (@UrunAd, @Birim, @SatisFiyat, @StokMiktari, @Kategori)";
                SqlCommand komut = new SqlCommand(sorgu, Form1.Baglanti);

                komut.Parameters.AddWithValue("@UrunAd", txtUrunAd.Text.Trim());
                komut.Parameters.AddWithValue("@Birim", cmbBirim.Text.Trim());
                komut.Parameters.AddWithValue("@SatisFiyat", satisFiyat);
                komut.Parameters.AddWithValue("@StokMiktari", stokMiktari);
                komut.Parameters.AddWithValue("@Kategori", cmbKategori.Text.Trim());

                if (komut.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kayıt eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KayitListele();
                    Temizle();
                }

                Form1.Baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme Hatası : " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (Form1.Baglanti.State == ConnectionState.Open)
                    Form1.Baglanti.Close();
            }
        }

        private void toolStripButtonEkle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol())
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult cevap = MessageBox.Show("Yeni ürün kaydı eklensin mi?", "Ekleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
                KayitEkle();
        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silinecek kaydı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult cevap = MessageBox.Show("Seçili ürün için silme ekranı açılsın mı?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.No)
                return;

            StokSilOnayForm frm = new StokSilOnayForm();
            frm.stokForm = this;
            frm.SeciliID = Convert.ToInt32(dgvUrunler.CurrentRow.Cells["ID"].Value);

            frm.txtID.Text = dgvUrunler.CurrentRow.Cells["ID"].Value.ToString();
            frm.txtUrunAd.Text = dgvUrunler.CurrentRow.Cells["UrunAd"].Value.ToString();
            frm.txtBirim.Text = dgvUrunler.CurrentRow.Cells["Birim"].Value.ToString();
            frm.txtFiyat.Text = dgvUrunler.CurrentRow.Cells["SatisFiyat"].Value.ToString();
            frm.txtStok.Text = dgvUrunler.CurrentRow.Cells["StokMiktari"].Value.ToString();
            frm.txtKategori.Text = dgvUrunler.CurrentRow.Cells["Kategori"].Value.ToString();

            frm.ShowDialog();
        }

        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek kaydı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult cevap = MessageBox.Show("Seçili ürün için güncelleme ekranı açılsın mı?", "Güncelleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.No)
                return;

            StokGuncelleForm frm = new StokGuncelleForm();
            frm.stokForm = this;
            frm.SeciliID = Convert.ToInt32(dgvUrunler.CurrentRow.Cells["ID"].Value);

            frm.txtID.Text = dgvUrunler.CurrentRow.Cells["ID"].Value.ToString();
            frm.txtUrunAd.Text = dgvUrunler.CurrentRow.Cells["UrunAd"].Value.ToString();
            frm.cmbBirim.Text = dgvUrunler.CurrentRow.Cells["Birim"].Value.ToString();
            frm.txtFiyat.Text = dgvUrunler.CurrentRow.Cells["SatisFiyat"].Value.ToString();
            frm.txtStok.Text = dgvUrunler.CurrentRow.Cells["StokMiktari"].Value.ToString();
            frm.cmbKategori.Text = dgvUrunler.CurrentRow.Cells["Kategori"].Value.ToString();

            frm.ShowDialog();
        }

        private void toolStripButtonTemizle_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Alanlar temizlensin mi?", "Temizleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
                Temizle();
        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUrunler.CurrentRow != null)
            {
                txtUrunAd.Text = dgvUrunler.CurrentRow.Cells["UrunAd"].Value.ToString();
                cmbBirim.Text = dgvUrunler.CurrentRow.Cells["Birim"].Value.ToString();
                txtFiyat.Text = dgvUrunler.CurrentRow.Cells["SatisFiyat"].Value.ToString();
                txtStok.Text = dgvUrunler.CurrentRow.Cells["StokMiktari"].Value.ToString();
                cmbKategori.Text = dgvUrunler.CurrentRow.Cells["Kategori"].Value.ToString();
            }
        }

        private void txtFiyat_TextChanged(object sender, EventArgs e) { }

        private void txtUrunAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ' '))
                e.Handled = true;
        }

        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == ','))
                e.Handled = true;

            if (e.KeyChar == ',' && txtFiyat.Text.Contains(","))
                e.Handled = true;
        }

        private void txtStok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void StokForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Formu kapatmak istediğinize emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.No)
                e.Cancel = true;
        }

        // =========================================================
        // Checkbox Aktif/Pasif Mantığı
        // =========================================================
        private void chkUrunAdi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUrunAdi.Checked == true)
            {
                txtBirebirUrunAdi.Enabled = true;
                txtBirebirUrunAdi.Focus();
            }
            else
            {
                txtBirebirUrunAdi.Enabled = false;
                txtBirebirUrunAdi.Clear();
            }
        }

        private void chkKategori_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKategori.Checked == true)
            {
                txtBirebirKategori.Enabled = true;
                txtBirebirKategori.Focus();
            }
            else
            {
                txtBirebirKategori.Enabled = false;
                txtBirebirKategori.Clear();
            }
        }

        // =========================================================
        // Birebir Arama Metodu (Şablonuna Birebir Uygun)
        // =========================================================
        public void KayitAra()
        {
            try
            {
                Form1.BaglantiAc();
                DataTable dt = new DataTable();

                string SorguTum = "SELECT ID, UrunAd, Birim, SatisFiyat, StokMiktari, Kategori FROM Urunler";
                string SorguUrunAd = "SELECT ID, UrunAd, Birim, SatisFiyat, StokMiktari, Kategori FROM Urunler WHERE UrunAd='" + txtBirebirUrunAdi.Text + "' ";
                string SorguKategori = "SELECT ID, UrunAd, Birim, SatisFiyat, StokMiktari, Kategori FROM Urunler WHERE Kategori='" + txtBirebirKategori.Text + "' ";
                string SorguAdKategori = "SELECT ID, UrunAd, Birim, SatisFiyat, StokMiktari, Kategori FROM Urunler WHERE UrunAd='" + txtBirebirUrunAdi.Text + "' AND Kategori='" + txtBirebirKategori.Text + "' ";

                if (chkUrunAdi.Checked == true && chkKategori.Checked == true)
                    SorguTum = SorguAdKategori;
                else if (chkUrunAdi.Checked == true)
                    SorguTum = SorguUrunAd;
                else if (chkKategori.Checked == true)
                    SorguTum = SorguKategori;

                SqlDataAdapter da = new SqlDataAdapter(SorguTum, Form1.Baglanti);
                da.Fill(dt);
                dgvUrunler.DataSource = dt;
                Form1.Baglanti.Close();

                if (dgvUrunler.Columns["ID"] != null) dgvUrunler.Columns["ID"].Visible = false;
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
        // Hızlı Arama Bölümü (Şablonuna Birebir Uygun)
        // =========================================================
        private void HizliAramaRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbUrunAd.Checked == true)
            {
                lblHizliAramaDeger.Text = "Ürün Adı:";
                txtHizliAramaSecim.Text = "";
                txtHizliAramaSecim.Focus();
            }
            else if (rdbKategori.Checked == true)
            {
                lblHizliAramaDeger.Text = "Kategori:";
                txtHizliAramaSecim.Text = "";
                txtHizliAramaSecim.Focus();
            }
        }

        public void HizliAra()
        {
            try
            {
                Form1.BaglantiAc();
                DataTable dt = new DataTable();

                string arananAlan = "UrunAd";
                if (rdbKategori.Checked == true)
                    arananAlan = "Kategori";

                string arananMetin = txtHizliAramaSecim.Text;

                string SorguTum = "SELECT ID, UrunAd, Birim, SatisFiyat, StokMiktari, Kategori FROM Urunler";
                string SorguIleBaslayan = "SELECT ID, UrunAd, Birim, SatisFiyat, StokMiktari, Kategori FROM Urunler WHERE " + arananAlan + " LIKE '" + arananMetin + "%' ";
                string SorguIleBiten = "SELECT ID, UrunAd, Birim, SatisFiyat, StokMiktari, Kategori FROM Urunler WHERE " + arananAlan + " LIKE '%" + arananMetin + "' ";
                string SorguIceren = "SELECT ID, UrunAd, Birim, SatisFiyat, StokMiktari, Kategori FROM Urunler WHERE " + arananAlan + " LIKE '%" + arananMetin + "%' ";

                if (cmbHizliAramaTuru.Text == "İle Başlayan")
                    SorguTum = SorguIleBaslayan;
                else if (cmbHizliAramaTuru.Text == "İle Biten")
                    SorguTum = SorguIleBiten;
                else if (cmbHizliAramaTuru.Text == "İçeren")
                    SorguTum = SorguIceren;

                SqlDataAdapter da = new SqlDataAdapter(SorguTum, Form1.Baglanti);
                da.Fill(dt);
                dgvUrunler.DataSource = dt;
                Form1.Baglanti.Close();

                if (dgvUrunler.Columns["ID"] != null) dgvUrunler.Columns["ID"].Visible = false;
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
        private void stokRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokRaporForm frm = new StokRaporForm();
            frm.ShowDialog();
        }
    }
}