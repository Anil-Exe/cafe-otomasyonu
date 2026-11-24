using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CafeOtomasyon
{
    public class TanimlamaYardimci
    {
        public static void TablolariKontrolEt()
        {
            try
            {
                Form1.BaglantiAc();

                string sorgu = @"
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name='BirimTanimlari')
BEGIN
    CREATE TABLE BirimTanimlari(
        ID int IDENTITY(1,1) PRIMARY KEY,
        BirimAdi nvarchar(50) NOT NULL UNIQUE
    )
END

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name='KategoriTanimlari')
BEGIN
    CREATE TABLE KategoriTanimlari(
        ID int IDENTITY(1,1) PRIMARY KEY,
        KategoriAdi nvarchar(50) NOT NULL UNIQUE
    )
END

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name='OdemeTuruTanimlari')
BEGIN
    CREATE TABLE OdemeTuruTanimlari(
        ID int IDENTITY(1,1) PRIMARY KEY,
        OdemeTuruAdi nvarchar(50) NOT NULL UNIQUE
    )
END

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name='MasaKonumTanimlari')
BEGIN
    CREATE TABLE MasaKonumTanimlari(
        ID int IDENTITY(1,1) PRIMARY KEY,
        KonumAdi nvarchar(50) NOT NULL UNIQUE
    )
END

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name='MasaDurumTanimlari')
BEGIN
    CREATE TABLE MasaDurumTanimlari(
        ID int IDENTITY(1,1) PRIMARY KEY,
        DurumAdi nvarchar(50) NOT NULL UNIQUE
    )
END

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name='PersonelRolTanimlari')
BEGIN
    CREATE TABLE PersonelRolTanimlari(
        ID int IDENTITY(1,1) PRIMARY KEY,
        RolAdi nvarchar(50) NOT NULL UNIQUE
    )
END

IF NOT EXISTS (SELECT * FROM BirimTanimlari)
BEGIN
    INSERT INTO BirimTanimlari(BirimAdi) VALUES('Adet'),('Kg'),('Lt'),('Paket'),('Koli')
END

IF NOT EXISTS (SELECT * FROM KategoriTanimlari)
BEGIN
    INSERT INTO KategoriTanimlari(KategoriAdi) VALUES(N'İçecek'),(N'Yiyecek'),(N'Temizlik'),(N'Tatlı'),(N'Diğer')
END

IF NOT EXISTS (SELECT * FROM OdemeTuruTanimlari)
BEGIN
    INSERT INTO OdemeTuruTanimlari(OdemeTuruAdi) VALUES(N'Nakit'),(N'Kart'),(N'Yemek Kartı'),(N'Diğer')
END

IF NOT EXISTS (SELECT * FROM MasaKonumTanimlari)
BEGIN
    INSERT INTO MasaKonumTanimlari(KonumAdi) VALUES(N'Salon'),(N'Bahçe'),(N'VIP'),(N'Cam Kenarı'),(N'Üst Kat')
END

IF NOT EXISTS (SELECT * FROM MasaDurumTanimlari)
BEGIN
    INSERT INTO MasaDurumTanimlari(DurumAdi) VALUES(N'Boş'),(N'Dolu')
END

IF NOT EXISTS (SELECT * FROM PersonelRolTanimlari)
BEGIN
    INSERT INTO PersonelRolTanimlari(RolAdi) VALUES(N'1'),(N'2'),(N'3')
END";

                SqlCommand komut = new SqlCommand(sorgu, Form1.Baglanti);
                komut.ExecuteNonQuery();
                Form1.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Tanımlama Tablo Kontrol Hatası");
                if (Form1.Baglanti.State == ConnectionState.Open)
                    Form1.Baglanti.Close();
            }
        }

        public static void ComboDoldur(ComboBox cmb, string tabloAdi, string alanAdi)
        {
            try
            {
                TablolariKontrolEt();
                Form1.BaglantiAc();

                cmb.Items.Clear();
                string sorgu = "SELECT " + alanAdi + " FROM " + tabloAdi + " ORDER BY " + alanAdi;
                SqlCommand komut = new SqlCommand(sorgu, Form1.Baglanti);
                SqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    cmb.Items.Add(dr[alanAdi].ToString());
                }

                dr.Close();
                Form1.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Combobox Veri Çekme Hatası");
                if (Form1.Baglanti.State == ConnectionState.Open)
                    Form1.Baglanti.Close();
            }
        }
    }
}
