using System;
using System.Windows.Forms;

namespace CafeOtomasyon
{
    public partial class OdemeSilForm : Form
    {
        public OdemeSilForm()
        {
            InitializeComponent();
        }

        public void BilgiGetir(string id, string masaId, string siparisId, string tutar, string odemeTuru, string aciklama)
        {
            txtID.Text = id;
            txtMasaID.Text = masaId;
            txtSiparisID.Text = siparisId;
            txtTutar.Text = tutar;
            txtOdemeTuru.Text = odemeTuru;
            txtAciklama.Text = aciklama;
        }

        private void OdemeSilForm_Load(object sender, EventArgs e)
        {
            txtID.ReadOnly = true;
            txtMasaID.ReadOnly = true;
            txtSiparisID.ReadOnly = true;
            txtTutar.ReadOnly = true;
            txtOdemeTuru.ReadOnly = true;
            txtAciklama.ReadOnly = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Bu ödeme kaydı silinsin mi?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMasaID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSiparisID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}