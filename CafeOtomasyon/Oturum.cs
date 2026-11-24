using System;

namespace CafeOtomasyon
{
    // Başına "public static" ekliyoruz ki projendeki her Formdan 
    // "Oturum.AdSoyad" diyerek bu bilgilere ulaşabilesin.
    public static class Oturum
    {
        // Bunlar bizim hafıza kutucuklarımız
        public static int KullaniciID;   // Veritabanındaki ID (Örn: 1)
        public static string AdSoyad;    // Personel İsmi (Örn: Anıl Polat)
        public static int Rol;           // Yetki (1: Müdür, 2: Muhasebe, 3: Garson)
    }
}