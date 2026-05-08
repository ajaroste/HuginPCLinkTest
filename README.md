# Hugin PC Link Test

Bu depo, **Windows Forms (C#)** ile hazırlanmış örnek bir masaüstü uygulamasıdır.  
Amaç: temel form akışını ve proje yapısını hızlıca test etmektir.

## Bu proje ne yapıyor?
- `Form1` üzerinden basit bir kullanıcı arayüzü sunar.
- .NET/Windows Forms çözüm yapısını örnekler.
- Geliştirme ve test ortamında hızlıca açılıp çalıştırılabilir.

## Proje yapısı
- `HuginTest.sln` → Visual Studio çözümü
- `HuginTest.csproj` → C# proje dosyası
- `Program.cs` → uygulama başlangıç noktası
- `Form1.cs` ve `Form1.Designer.cs` → ana form kodu ve tasarım bileşenleri
- `Properties/` → assembly, ayar ve kaynak dosyaları

## Nasıl çalıştırılır?
1. **Visual Studio** ile `HuginTest.sln` dosyasını açın.
2. Gerekirse NuGet geri yüklemesini tamamlayın.
3. `Start` / `F5` ile uygulamayı başlatın.

## AI'ye sorarken bu depoya yönlendirme
AI asistanına soru sorarken aşağıdaki metni kullanabilirsiniz:

```text
Lütfen cevaplarını bu depodaki dosyalara göre ver:
Repository: HuginPCLinkTest
Önce README.md ve Form1.cs dosyalarını referans al.
Eğer kod öneriyorsan mevcut Windows Forms yapısını bozma.
```

## Katkı notu
- Değişiklik yapmadan önce kısa bir plan çıkarın.
- UI değişikliklerinde `Form1.cs` ile `Form1.Designer.cs` uyumunu koruyun.
- Anlaşılır commit mesajları kullanın.
