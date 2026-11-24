using System;
using System.Windows.Forms;

namespace CafeOtomasyon
{
    public partial class MasaSilOnayForm : Form
    {
        public MasaSilOnayForm()
        {
            InitializeComponent();
        }

        public void BilgiGetir(string id, string masaNo, string kapasite, string konum, string durum)
        {
            txtID.Text = id;
            txtMasaNo.Text = masaNo;
            txtKapasite.Text = kapasite;
            txtKonum.Text = konum;
            txtDurum.Text = durum;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Bu masayı silmek istediğinize emin misiniz?", "Son Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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