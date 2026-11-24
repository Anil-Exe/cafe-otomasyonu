using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeOtomasyon
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.FormClosing += LoginForm_FormClosing;
        }

        // Rakam butonlarının tamamını tasarım ekranından bu metoda bağlamayı unutma
        private void NumPad_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = (Button)sender;
                txtSifre.Text += btn.Text;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtSifre.Focus();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtSifre.Clear();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Lütfen şifrenizi giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Form1.BaglantiAc();

                string sorgu = "SELECT ID, AdSoyad, Rol FROM Kullanicilar WHERE Sifre = @sifre AND AktifMi = 1";

                using (SqlCommand komut = new SqlCommand(sorgu, Form1.Baglanti))
                {
                    komut.Parameters.AddWithValue("@sifre", txtSifre.Text);

                    using (SqlDataReader dr = komut.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            Oturum.KullaniciID = Convert.ToInt32(dr["ID"]);
                            Oturum.AdSoyad = dr["AdSoyad"].ToString();
                            Oturum.Rol = Convert.ToInt32(dr["Rol"]);

                            dr.Close();
                            Form1.Baglanti.Close();

                            MenuForm menu = new MenuForm();
                            menu.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Hatalı Şifre veya Pasif Kullanıcı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtSifre.Clear();
                            dr.Close();
                            Form1.Baglanti.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem Hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                if (Form1.Baglanti.State == ConnectionState.Open)
                    Form1.Baglanti.Close();
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_FormClosing_1(object sender, FormClosingEventArgs e)
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