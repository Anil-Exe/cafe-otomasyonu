using System;
using System.Windows.Forms;

namespace CafeOtomasyon
{
    public partial class PersonelSilOnayForm : Form
    {
        public PersonelSilOnayForm()
        {
            InitializeComponent();
        }

        public void BilgiGetir(string id, string adSoyad, string rol, string tcNo, string telefon)
        {
            txtID.Text = id;
            txtAdSoyad.Text = adSoyad;
            txtRol.Text = rol;
            txtTcNo.Text = tcNo;
            txtTelefon.Text = telefon;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Bu personeli silmek istediğinize emin misiniz?", "Son Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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