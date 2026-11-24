using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeOtomasyon
{
    public partial class RaporlamaForm : Form
    {
        public RaporlamaForm()
        {
            InitializeComponent();
        }

        private void RaporlamaForm_Load(object sender, EventArgs e)
        {
            RaporlariGetir();
        }

        void RaporlariGetir()
        {
            try
            {
                Form1.BaglantiAc();

                string sorgu = @"
                SELECT 
                    (SELECT COUNT(*) FROM Masalar) AS ToplamMasa,
                    (SELECT COUNT(*) FROM Kullanicilar) AS ToplamPersonel,
                    (SELECT COUNT(*) FROM Urunler) AS ToplamUrun,
                    (SELECT ISNULL(SUM(Tutar),0) FROM Odemeler) AS ToplamOdeme,
                    (SELECT ISNULL(SUM(NetCiro),0) FROM GunSonuRaporlari) AS ToplamNetCiro";

                SqlCommand cmd = new SqlCommand(sorgu, Form1.Baglanti);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    lblToplamMasa.Text = dr["ToplamMasa"].ToString();
                    lblToplamPersonel.Text = dr["ToplamPersonel"].ToString();
                    lblToplamUrun.Text = dr["ToplamUrun"].ToString();
                    lblToplamOdeme.Text = dr["ToplamOdeme"].ToString() + " TL";
                    lblToplamNetCiro.Text = dr["ToplamNetCiro"].ToString() + " TL";
                }

                dr.Close();
                Form1.Baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Raporlama Hatası: " + ex.Message);

                if (Form1.Baglanti.State == ConnectionState.Open)
                    Form1.Baglanti.Close();
            }
        }

        private void RaporlamaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cevap = MessageBox.Show(
        "Çıkmak istiyor musunuz?",
        "Çıkış Onayı",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (cevap == DialogResult.No)
                e.Cancel = true;
        }
    }
}