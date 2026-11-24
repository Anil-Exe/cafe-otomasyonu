using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeOtomasyon
{
    public partial class PersonelListeForm : Form
    {
        public PersonelListeForm()
        {
            InitializeComponent();
            RaporlarButonunuGarantiEt();

            txtAdSoyad.KeyPress += txtAdSoyad_KeyPress;
            txtMaas.KeyPress += txtMaas_KeyPress;
            txtTcNo.KeyPress += txtTcNo_KeyPress;
            txtTelefon.KeyPress += txtTelefon_KeyPress;
            dgvPersonel.CellClick += dgvPersonel_CellClick;
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

            if (personelRaporuToolStripMenuItem == null)
                personelRaporuToolStripMenuItem = new ToolStripMenuItem();

            personelRaporuToolStripMenuItem.Name = "personelRaporuToolStripMenuItem";
            personelRaporuToolStripMenuItem.Text = "Personel Listesi";
            personelRaporuToolStripMenuItem.Click -= personelRaporuToolStripMenuItem_Click;
            personelRaporuToolStripMenuItem.Click += personelRaporuToolStripMenuItem_Click;

            toolStripDropDownButtonRaporlar.DropDownItems.Add(personelRaporuToolStripMenuItem);

            if (!toolStrip1.Items.Contains(toolStripDropDownButtonRaporlar))
            {
                int tanimIndex = toolStrip1.Items.IndexOf(toolStripDropDownButtonTanimlamalar);
                if (tanimIndex >= 0 && tanimIndex < toolStrip1.Items.Count - 1)
                    toolStrip1.Items.Insert(tanimIndex + 1, toolStripDropDownButtonRaporlar);
                else
                    toolStrip1.Items.Add(toolStripDropDownButtonRaporlar);
            }
        }

        private void PersonelListeForm_Load(object sender, EventArgs e)
        {
            YildizlariGizle();
            TanimlamaYardimci.ComboDoldur(cmbRol, "PersonelRolTanimlari", "RolAdi");
            PersonelListele();

            // Arama Kutularının Başlangıç Ayarları
            txtBirebirAdSoyad.Enabled = false;
            txtBirebirMaas.Enabled = false;
            txtBirebirTcNo.Enabled = false;

            cmbHizliAramaTuru.Items.Clear();
            cmbHizliAramaTuru.Items.Add("İçeren");
            cmbHizliAramaTuru.Items.Add("İle Başlayan");
            cmbHizliAramaTuru.Items.Add("İle Biten");
            cmbHizliAramaTuru.SelectedIndex = 0;

            lblHizliAramaDeger.Text = "Ad Soyad:";
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

        public bool BoslukKontrol()
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
                txtAdSoyad.BackColor = Color.LightCoral;
                lblYildizAdSoyad.Visible = true;
                bos = true;
            }

            if (txtSifre.Text.Trim() == "")
            {
                txtSifre.BackColor = Color.LightCoral;
                lblYildizSifre.Visible = true;
                bos = true;
            }

            if (cmbRol.Text.Trim() == "")
            {
                cmbRol.BackColor = Color.LightCoral;
                lblYildizRol.Visible = true;
                bos = true;
            }

            if (txtTcNo.Text.Trim() == "")
            {
                txtTcNo.BackColor = Color.LightCoral;
                lblYildizTcNo.Visible = true;
                bos = true;
            }

            if (txtTelefon.Text.Trim() == "")
            {
                txtTelefon.BackColor = Color.LightCoral;
                lblYildizTelefon.Visible = true;
                bos = true;
            }

            if (txtAdres.Text.Trim() == "")
            {
                txtAdres.BackColor = Color.LightCoral;
                lblYildizAdres.Visible = true;
                bos = true;
            }

            if (txtMaas.Text.Trim() == "")
            {
                txtMaas.BackColor = Color.LightCoral;
                lblYildizMaas.Visible = true;
                bos = true;
            }

            if (txtAdSoyad.Text.Trim() == "")
                txtAdSoyad.Focus();
            else if (txtSifre.Text.Trim() == "")
                txtSifre.Focus();
            else if (cmbRol.Text.Trim() == "")
                cmbRol.Focus();
            else if (txtTcNo.Text.Trim() == "")
                txtTcNo.Focus();
            else if (txtTelefon.Text.Trim() == "")
                txtTelefon.Focus();
            else if (txtAdres.Text.Trim() == "")
                txtAdres.Focus();
            else if (txtMaas.Text.Trim() == "")
                txtMaas.Focus();

            return bos;
        }

        public void PersonelListele()
        {
            try
            {
                Form1.BaglantiAc();

                string sorgu = "SELECT ID, AdSoyad, Sifre, Rol, TcNo, Telefon, Adres, Maas, IseGirisTarihi, AktifMi FROM Kullanicilar";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, Form1.Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvPersonel.DataSource = dt;
                dgvPersonel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPersonel.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvPersonel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvPersonel.AllowUserToAddRows = false;
                dgvPersonel.ReadOnly = true;

                if (dgvPersonel.Columns.Contains("ID"))
                    dgvPersonel.Columns["ID"].Visible = false;

                dgvPersonel.Columns["AdSoyad"].HeaderText = "Ad Soyad";
                dgvPersonel.Columns["Sifre"].HeaderText = "Şifre";
                dgvPersonel.Columns["Rol"].HeaderText = "Rol";
                dgvPersonel.Columns["TcNo"].HeaderText = "TC No";
                dgvPersonel.Columns["Telefon"].HeaderText = "Telefon";
                dgvPersonel.Columns["Adres"].HeaderText = "Adres";
                dgvPersonel.Columns["Maas"].HeaderText = "Maaş";
                dgvPersonel.Columns["IseGirisTarihi"].HeaderText = "İşe Giriş Tarihi";
                dgvPersonel.Columns["AktifMi"].HeaderText = "Aktif Mi";

                Form1.Baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personel listesi yüklenemedi: " + ex.Message);

                if (Form1.Baglanti.State == ConnectionState.Open)
                    Form1.Baglanti.Close();
            }
        }

        public void KayitEkle()
        {
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

                string sorgu = "INSERT INTO Kullanicilar (AdSoyad, Sifre, Rol, TcNo, Telefon, Adres, Maas, IseGirisTarihi, AktifMi) " +
                               "VALUES (@adsoyad, @sifre, @rol, @tcno, @telefon, @adres, @maas, @isegiristarihi, @aktifmi)";

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

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Personel başarıyla eklendi.");
                    PersonelListele();
                    Temizle();
                }

                Form1.Baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme Hatası: " + ex.Message);

                if (Form1.Baglanti.State == ConnectionState.Open)
                    Form1.Baglanti.Close();
            }
        }

        public void Temizle()
        {
            txtAdSoyad.Clear();
            txtSifre.Clear();
            cmbRol.SelectedIndex = -1;
            txtTcNo.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            txtMaas.Clear();
            dtpIseGirisTarihi.Value = DateTime.Now;
            chkAktifMi.Checked = false;

            txtAdSoyad.BackColor = Color.White;
            txtSifre.BackColor = Color.White;
            cmbRol.BackColor = Color.White;
            txtTcNo.BackColor = Color.White;
            txtTelefon.BackColor = Color.White;
            txtAdres.BackColor = Color.White;
            txtMaas.BackColor = Color.White;

            YildizlariGizle();
        }

        private void toolStripButtonEkle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol())
                MessageBox.Show("Lütfen kırmızı alanları doldurunuz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                KayitEkle();
        }

        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            if (dgvPersonel.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silinecek personeli seçiniz!");
                return;
            }

            int seciliId = Convert.ToInt32(dgvPersonel.CurrentRow.Cells["ID"].Value);
            string adSoyad = dgvPersonel.CurrentRow.Cells["AdSoyad"].Value.ToString();
            string rol = dgvPersonel.CurrentRow.Cells["Rol"].Value.ToString();
            string tcNo = dgvPersonel.CurrentRow.Cells["TcNo"].Value.ToString();
            string telefon = dgvPersonel.CurrentRow.Cells["Telefon"].Value.ToString();

            PersonelSilOnayForm frm = new PersonelSilOnayForm();
            frm.BilgiGetir(seciliId.ToString(), adSoyad, rol, tcNo, telefon);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Form1.BaglantiAc();

                    string kontrolSorgu = "SELECT COUNT(*) FROM Masalar WHERE GarsonID = @id";
                    SqlCommand kontrolKomut = new SqlCommand(kontrolSorgu, Form1.Baglanti);
                    kontrolKomut.Parameters.AddWithValue("@id", seciliId);

                    int kayitSayisi = Convert.ToInt32(kontrolKomut.ExecuteScalar());

                    if (kayitSayisi > 0)
                    {
                        MessageBox.Show("Bu personel bir veya daha fazla masaya atanmış olduğu için silinemez! Önce masalardaki garson atamasını değiştiriniz.");
                        Form1.Baglanti.Close();
                        return;
                    }

                    string sorgu = "DELETE FROM Kullanicilar WHERE ID = @id";
                    SqlCommand cmd = new SqlCommand(sorgu, Form1.Baglanti);
                    cmd.Parameters.AddWithValue("@id", seciliId);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Personel veritabanından silindi.");
                        PersonelListele();
                        Temizle();
                    }

                    Form1.Baglanti.Close();
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
            if (dgvPersonel.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek personeli seçiniz!");
                return;
            }

            PersonelGuncelleForm frm = new PersonelGuncelleForm();
            frm.personelListeForm = this;
            frm.SeciliID = Convert.ToInt32(dgvPersonel.CurrentRow.Cells["ID"].Value);

            frm.txtID.Text = dgvPersonel.CurrentRow.Cells["ID"].Value.ToString();
            frm.txtAdSoyad.Text = dgvPersonel.CurrentRow.Cells["AdSoyad"].Value.ToString();
            frm.txtSifre.Text = dgvPersonel.CurrentRow.Cells["Sifre"].Value.ToString();
            frm.cmbRol.Text = dgvPersonel.CurrentRow.Cells["Rol"].Value.ToString();
            frm.txtTcNo.Text = dgvPersonel.CurrentRow.Cells["TcNo"].Value.ToString();
            frm.txtTelefon.Text = dgvPersonel.CurrentRow.Cells["Telefon"].Value.ToString();
            frm.txtAdres.Text = dgvPersonel.CurrentRow.Cells["Adres"].Value.ToString();
            frm.txtMaas.Text = dgvPersonel.CurrentRow.Cells["Maas"].Value.ToString();

            DateTime tarih;
            if (DateTime.TryParse(dgvPersonel.CurrentRow.Cells["IseGirisTarihi"].Value.ToString(), out tarih))
                frm.dtpIseGirisTarihi.Value = tarih;

            bool aktif = false;
            bool.TryParse(dgvPersonel.CurrentRow.Cells["AktifMi"].Value.ToString(), out aktif);
            frm.chkAktifMi.Checked = aktif;

            frm.ShowDialog();
        }

        private void toolStripButtonTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dgvPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPersonel.CurrentRow != null)
            {
                txtAdSoyad.Text = dgvPersonel.CurrentRow.Cells["AdSoyad"].Value.ToString();
                txtSifre.Text = dgvPersonel.CurrentRow.Cells["Sifre"].Value.ToString();
                cmbRol.Text = dgvPersonel.CurrentRow.Cells["Rol"].Value.ToString();
                txtTcNo.Text = dgvPersonel.CurrentRow.Cells["TcNo"].Value.ToString();
                txtTelefon.Text = dgvPersonel.CurrentRow.Cells["Telefon"].Value.ToString();
                txtAdres.Text = dgvPersonel.CurrentRow.Cells["Adres"].Value.ToString();
                txtMaas.Text = dgvPersonel.CurrentRow.Cells["Maas"].Value.ToString();

                DateTime tarih;
                if (DateTime.TryParse(dgvPersonel.CurrentRow.Cells["IseGirisTarihi"].Value.ToString(), out tarih))
                    dtpIseGirisTarihi.Value = tarih;

                bool aktif = false;
                bool.TryParse(dgvPersonel.CurrentRow.Cells["AktifMi"].Value.ToString(), out aktif);
                chkAktifMi.Checked = aktif;
            }
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

        private void personelRolTanimlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelRolTanimlamaForm frm = new PersonelRolTanimlamaForm();
            frm.ShowDialog();
            TanimlamaYardimci.ComboDoldur(cmbRol, "PersonelRolTanimlari", "RolAdi");
        }

        private void personelRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelRaporForm frm = new PersonelRaporForm();
            frm.ShowDialog();
        }

        private void PersonelListeForm_FormClosing(object sender, FormClosingEventArgs e)
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

            if (chk == chkAdSoyad)
            {
                txtBirebirAdSoyad.Enabled = chkAdSoyad.Checked;
                if (!chkAdSoyad.Checked) txtBirebirAdSoyad.Clear();
                else txtBirebirAdSoyad.Focus();
            }
            else if (chk == chkMaas)
            {
                txtBirebirMaas.Enabled = chkMaas.Checked;
                if (!chkMaas.Checked) txtBirebirMaas.Clear();
                else txtBirebirMaas.Focus();
            }
            else if (chk == chkTcNo)
            {
                txtBirebirTcNo.Enabled = chkTcNo.Checked;
                if (!chkTcNo.Checked) txtBirebirTcNo.Clear();
                else txtBirebirTcNo.Focus();
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

                if (chkMaas.Checked && txtBirebirMaas.Text != "")
                    kosullar += " AND CAST(Maas AS NVARCHAR(MAX)) = '" + txtBirebirMaas.Text.Replace("'", "''") + "'";

                if (chkTcNo.Checked && txtBirebirTcNo.Text != "")
                    kosullar += " AND TcNo = '" + txtBirebirTcNo.Text.Replace("'", "''") + "'";

                string sorgu = "SELECT ID, AdSoyad, Sifre, Rol, TcNo, Telefon, Adres, Maas, IseGirisTarihi, AktifMi FROM Kullanicilar WHERE " + kosullar;

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
            else if (rdbMaas.Checked)
                lblHizliAramaDeger.Text = "Maaş:";
            else if (rdbTcNo.Checked)
                lblHizliAramaDeger.Text = "TC No:";

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
                if (rdbMaas.Checked)
                    arananAlan = "Maas";
                else if (rdbTcNo.Checked)
                    arananAlan = "TcNo";

                string arananMetin = txtHizliAramaSecim.Text.Replace("'", "''");

                string SorguTum = "SELECT ID, AdSoyad, Sifre, Rol, TcNo, Telefon, Adres, Maas, IseGirisTarihi, AktifMi FROM Kullanicilar";
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