# Cafe Otomasyonu

**Masa, sipariş ve işletme yönetimi**

| Alan | Ayrıntı |
| --- | --- |
| Proje türü | Akademik masaüstü uygulaması |
| Teknolojiler | C# · Windows Forms · SQL Server |
| Geliştirici | Anıl Polat |

---

C# Windows Forms ve SQL Server ile geliştirilmiş akademik masa/sipariş yönetimi uygulaması.

## Proje bağlamı

Üniversite eğitimi sırasında geliştirilen bir masaüstü uygulaması prototipidir. Windows Forms, ilişkisel veritabanı işlemleri ve temel işletme akışlarını birlikte uygulamaya odaklanır. Canlı bir işletme ürünü olarak sunulmaz.

## Kaynakta bulunan ekranlar

- Masa, sipariş ve ödeme yönetimi
- Personel ve rol yönetimi
- Rezervasyon, gün sonu ve raporlama
- Kategori, ödeme türü ve diğer tanım ekranları

## Teknolojiler

C#, Windows Forms, .NET Framework 4.7.2, SQL Server. Visual Studio çözümü ve C# proje dosyası kaynaklara dâhildir.

## Yerel kurulum

1. Windows üzerinde Visual Studio ve .NET Framework 4.7.2 geliştirme araçlarını kurun.
2. `CafeOtomasyon.sln` çözümünü açıp NuGet bağımlılıklarını geri yükleyin. packages.config, eski arşivde bulunan ReportViewer 150.1652.0 ve SQL Server Types 14.0.314.76 sürümlerini belirtir; özel DLL kopyaları pakete alınmadı. Bu sürümler için kapsamlı bağımlılık güvenlik denetimi yapılmadı.
3. Kendi yerel SQL Server ortamınızı kurun. Gerçek MDF/LDF yedekleri bu kopyaya eklenmemiştir.
4. `CAFE_DB_CONNECTION_STRING` ortam değişkenini kendi bağlantınızla ayarlayın. Yerel sunucu/kullanıcı/bağlantı değerlerini kaynak koduna eklemeyin.

## Teknik durum ve geliştirme alanları

Eğitim prototipindeki aşağıdaki alanlar, gerçek personel verileriyle veya canlı işletme ortamında kullanım öncesinde geliştirilmelidir:

- Özgün uygulama parolaları doğrudan SQL sorgularında kullanır. Güvenli hashleme, kullanıcı seçimi/doğrulaması ve rol kontrolleri bütün akışlar için düzenlenmelidir.
- Personel ekranlarında parola sütununun sorgulandığı/gösterilebildiği eski akışlar vardır; bunlar kaldırılmalıdır.
- Sabit varsayılan parolaya sıfırlama işlemi bu inceleme kopyasında devre dışı bırakıldı.
- Mevcut SQL dosyası yalnızca tanım tabloları içindir; sıfırdan kurulum için tam, kişisel veri içermeyen veritabanı şeması ayrıca gereklidir.
- Bu ortamda Windows/.NET Framework olmadığı için derleme ve SQL Server entegrasyon testi yapılmadı.

Bu depo, akademik projenin kaynaklarını ve geliştirme yaklaşımını portföy kapsamında sunar. Gerçek kullanıcı/personel verileri içermez.
