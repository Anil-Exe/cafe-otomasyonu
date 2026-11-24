using System;
using System.Windows.Forms;

namespace CafeOtomasyon
{
    public partial class GunSonuSilForm : Form
    {
        public GunSonuSilForm()
        {
            InitializeComponent();
        }

        public void BilgiGetir(string id, string raporTarihi, string toplamSiparis, string toplamOdeme, string netCiro)
        {
            txtID.Text = id;
            txtRaporTarihi.Text = raporTarihi;
            txtToplamSiparis.Text = toplamSiparis;
            txtToplamOdeme.Text = toplamOdeme;
            txtNetCiro.Text = netCiro;
        }

        private void GunSonuSilForm_Load(object sender, EventArgs e)
        {
            txtID.ReadOnly = true;
            txtRaporTarihi.ReadOnly = true;
            txtToplamSiparis.ReadOnly = true;
            txtToplamOdeme.ReadOnly = true;
            txtNetCiro.ReadOnly = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Bu gün sonu kaydı silinsin mi?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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