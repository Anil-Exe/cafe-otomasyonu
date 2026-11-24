using System;
using System.Windows.Forms;

namespace CafeOtomasyon
{
    public partial class SahsiKasaSilForm : Form
    {
        public SahsiKasaSilForm()
        {
            InitializeComponent();
        }

        public void BilgiGetir(string id, string islemTuru, string tutar, string aciklama, string kullaniciId)
        {
            txtID.Text = id;
            txtIslemTuru.Text = islemTuru;
            txtTutar.Text = tutar;
            txtAciklama.Text = aciklama;
            txtKullaniciID.Text = kullaniciId;
        }

        private void SahsiKasaSilForm_Load(object sender, EventArgs e)
        {
            txtID.ReadOnly = true;
            txtIslemTuru.ReadOnly = true;
            txtTutar.ReadOnly = true;
            txtAciklama.ReadOnly = true;
            txtKullaniciID.ReadOnly = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Bu kasa kaydı silinsin mi?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}