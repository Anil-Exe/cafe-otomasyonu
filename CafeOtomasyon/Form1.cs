using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CafeOtomasyon
{
    public partial class Form1 : Form
    {
        // Yerel bağlantı ortam değişkeninden alınır; depoya eklenmez.
        public static SqlConnection Baglanti = new SqlConnection(
            Environment.GetEnvironmentVariable("CAFE_DB_CONNECTION_STRING") ?? string.Empty);

        // Bağlantıyı açan metot
        public static void BaglantiAc()
        {
            try
            {
                if (Baglanti.State == ConnectionState.Closed)
                    Baglanti.Open();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Bağlantı Hatası");
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // İlk açılışta Login formunu göster
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}