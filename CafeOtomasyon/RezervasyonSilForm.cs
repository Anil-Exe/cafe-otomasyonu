using System;
using System.Windows.Forms;

namespace CafeOtomasyon
{
    public partial class RezervasyonSilForm : Form
    {
        public RezervasyonSilForm()
        {
            InitializeComponent();
        }

        public void BilgiGetir(string id, string musteriAdi, string telefon, string masaId, string kisiSayisi, string durum)
        {
            txtID.Text = id;
            txtMusteriAdi.Text = musteriAdi;
            txtTelefon.Text = telefon;
            txtMasaID.Text = masaId;
            txtKisiSayisi.Text = kisiSayisi;
            txtDurum.Text = durum;
        }

        private void RezervasyonSilForm_Load(object sender, EventArgs e)
        {
            txtID.ReadOnly = true;
            txtMusteriAdi.ReadOnly = true;
            txtTelefon.ReadOnly = true;
            txtMasaID.ReadOnly = true;
            txtKisiSayisi.ReadOnly = true;
            txtDurum.ReadOnly = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Bu rezervasyon silinsin mi?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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