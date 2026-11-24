/* CafeOtomasyon - Tanımlama Tabloları
   Bu script mevcut verileri silmez. Sadece eksik tanımlama tablolarını oluşturur
   ve tablolar boşsa başlangıç verilerini ekler. */

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name='BirimTanimlari')
BEGIN
    CREATE TABLE dbo.BirimTanimlari(
        ID int IDENTITY(1,1) PRIMARY KEY,
        BirimAdi nvarchar(50) NOT NULL UNIQUE
    )
END

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name='KategoriTanimlari')
BEGIN
    CREATE TABLE dbo.KategoriTanimlari(
        ID int IDENTITY(1,1) PRIMARY KEY,
        KategoriAdi nvarchar(50) NOT NULL UNIQUE
    )
END

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name='OdemeTuruTanimlari')
BEGIN
    CREATE TABLE dbo.OdemeTuruTanimlari(
        ID int IDENTITY(1,1) PRIMARY KEY,
        OdemeTuruAdi nvarchar(50) NOT NULL UNIQUE
    )
END

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name='MasaKonumTanimlari')
BEGIN
    CREATE TABLE dbo.MasaKonumTanimlari(
        ID int IDENTITY(1,1) PRIMARY KEY,
        KonumAdi nvarchar(50) NOT NULL UNIQUE
    )
END

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name='MasaDurumTanimlari')
BEGIN
    CREATE TABLE dbo.MasaDurumTanimlari(
        ID int IDENTITY(1,1) PRIMARY KEY,
        DurumAdi nvarchar(50) NOT NULL UNIQUE
    )
END

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name='PersonelRolTanimlari')
BEGIN
    CREATE TABLE dbo.PersonelRolTanimlari(
        ID int IDENTITY(1,1) PRIMARY KEY,
        RolAdi nvarchar(50) NOT NULL UNIQUE
    )
END

IF NOT EXISTS (SELECT * FROM dbo.BirimTanimlari)
BEGIN
    INSERT INTO dbo.BirimTanimlari(BirimAdi) VALUES(N'Adet'),(N'Kg'),(N'Lt'),(N'Paket'),(N'Koli')
END

IF NOT EXISTS (SELECT * FROM dbo.KategoriTanimlari)
BEGIN
    INSERT INTO dbo.KategoriTanimlari(KategoriAdi) VALUES(N'İçecek'),(N'Yiyecek'),(N'Temizlik'),(N'Tatlı'),(N'Diğer')
END

IF NOT EXISTS (SELECT * FROM dbo.OdemeTuruTanimlari)
BEGIN
    INSERT INTO dbo.OdemeTuruTanimlari(OdemeTuruAdi) VALUES(N'Nakit'),(N'Kart'),(N'Yemek Kartı'),(N'Diğer')
END

IF NOT EXISTS (SELECT * FROM dbo.MasaKonumTanimlari)
BEGIN
    INSERT INTO dbo.MasaKonumTanimlari(KonumAdi) VALUES(N'Salon'),(N'Bahçe'),(N'VIP'),(N'Cam Kenarı'),(N'Üst Kat')
END

IF NOT EXISTS (SELECT * FROM dbo.MasaDurumTanimlari)
BEGIN
    INSERT INTO dbo.MasaDurumTanimlari(DurumAdi) VALUES(N'Boş'),(N'Dolu')
END

IF NOT EXISTS (SELECT * FROM dbo.PersonelRolTanimlari)
BEGIN
    INSERT INTO dbo.PersonelRolTanimlari(RolAdi) VALUES(N'1'),(N'2'),(N'3')
END
