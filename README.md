# Hugin PC Link Test Uygulaması

![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?style=for-the-badge&logo=dotnet)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-Test%20Araci-0078D4?style=for-the-badge&logo=windows)
![CSharp](https://img.shields.io/badge/C%23-Desktop-239120?style=for-the-badge&logo=csharp)

Hugin PC Link Test Uygulaması, Hugin PC Link API destekleyen Hugin cihazları ile entegrasyon geliştiren ekipler için hazırlanmış pratik bir Windows Forms test aracıdır. Uygulama; bağlantı kontrolü, belge başlatma, satış JSON'u oluşturma/gönderme, satış iptali, cihaz ayarları ve X/Z rapor işlemlerini tek ekrandan denemeyi kolaylaştırır.

Bu proje, entegrasyon sürecinde "API çalışıyor mu?", "documentId geldi mi?", "satış gönderimi hangi cevapla döndü?" gibi kritik soruları hızlı yanıtlamak için tasarlanmıştır.

## Kapsam ve Feragat

Bu uygulama, Hugin PC Link API ile haberleşebilen Hugin cihazlarında test ve geliştirme amacıyla kullanılmak üzere hazırlanmıştır. Proje, Hugin firması tarafından geliştirilmemiştir; Hugin firmasıyla resmi, ticari veya kurumsal bir bağı yoktur.

Uygulama yalnızca entegrasyon denemeleri, API akışlarını doğrulama ve örnek satış senaryolarını test etme amacı taşır. Canlı ortamda kullanmadan önce cihaz, servis ve mali süreçlerin ilgili teknik dokümanlara göre ayrıca doğrulanması gerekir.

## Öne Çıkan Özellikler

- Hugin PC Link API için tek ekrandan test akışı
- Base URL, SoftwareId, HardwareId ve SerialNo bilgilerini arayüzden düzenleme
- `/v1/status` ile cihaz ve aktif belge durumunu kontrol etme
- `/v1/documents` ile satış belgesi başlatma
- Otomatik veya manuel satış JSON'u hazırlama
- Satış kalemi, KDV, indirim, birim, kısım ve ödeme bilgilerini arayüzden ekleme
- TRY ve dövizli ödeme senaryoları için tutar/kur alanları
- `/v1/settings` ile cihaz ayarlarını ve kısım listesini okuma
- Satış iptali, X raporu ve Z raporu işlemleri
- İstek ve cevapları takip etmek için dahili log alanı

## Teknoloji

- C#
- Windows Forms
- .NET Framework 4.7.2
- `System.Net.Http` tabanlı HTTP istemcisi

## Gereksinimler

- Windows
- Visual Studio 2019 veya daha yeni bir sürüm
- .NET Framework 4.7.2 Developer Pack
- Hugin PC Link API erişimi olan cihaz veya test ortamı

## Kurulum

Projeyi klonlayın:

```bash
git clone <repository-url>
cd HuginTest
```

Visual Studio ile `HuginTest.sln` dosyasını açın.

Ardından projeyi `Debug` veya `Release` konfigürasyonunda derleyip çalıştırın.

## Hızlı Kullanım

1. Uygulamayı çalıştırın.
2. `Base URL`, `SoftwareId`, `HardwareId` ve `SerialNo` alanlarını kendi cihaz/test ortamınıza göre güncelleyin.
3. `Durum Test` ile cihaza erişimi kontrol edin.
4. `Belge Başlat` ile yeni bir satış belgesi açın.
5. Satış kalemi ve ödeme bilgilerini düzenleyin ya da `Örnek Fiş Yükle` ile hazır senaryoyu kullanın.
6. `JSON Gönder` ile satış belgesini cihaza iletin.
7. Gerekirse `Satış İptal`, `X Yazdır`, `Z Yazdır` ve `Ayarlar` işlemlerini test edin.

## Desteklenen API İşlemleri

| İşlem | Metot | Endpoint |
| --- | --- | --- |
| Durum kontrolü | `GET` | `/v1/status` |
| Belge başlatma | `POST` | `/v1/documents` |
| Satış gönderme | `PUT` | `/v1/documents/{documentId}` |
| Satış iptali | `POST` | `/v1/documents/{documentId}/cancel` |
| Ayarları okuma | `GET` | `/v1/settings` |
| X raporu yazdırma | `GET` | `/v1/reports/X/print` |
| Z raporu yazdırma | `POST` | `/v1/reports/Z/print` |

## Varsayılan Test Bilgileri

Uygulama açılışında geliştirme/test kolaylığı için örnek cihaz bilgileri ve örnek satış kalemi yüklenir. Gerçek bir kurulumda bu alanları kendi Hugin cihazınızın bilgileriyle değiştirmelisiniz.

> Not: Depoya canlı ortam bilgileri, müşteriye ait cihaz kimlikleri veya gizli entegrasyon verileri eklemeyin.


## Geliştirme Notları

- Uygulama TLS 1.2 kullanır.
- Test ortamları için sertifika doğrulaması esnek bırakılmıştır.
- HTTP istemcisi zaman aşımı olmadan çalışır; cihazdan cevap bekleyen işlemlerde arayüz butonları geçici olarak devre dışı kalır.
- Satış başarılı tamamlandığında aktif `documentId` otomatik temizlenir.

## Lisans

Bu depoda lisans dosyası bulunmuyorsa, kullanım ve dağıtım koşullarını proje sahibiyle netleştirin.
