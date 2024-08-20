
# IT Inventory Management System

Bu proje, bir envanter yönetim sistemi geliştirmeyi amaçlayan bir .NET Core uygulamasıdır. Proje, envanter öğelerini yönetme, raporlama ve bildirim sistemleri gibi işlevselliği içerir. Proje, iş mülakatı için geliştirilmiş olup, profesyonel yazılım geliştirme süreçlerine uygun olarak tasarlanmıştır.

## Özellikler

1.  **Envanter Yönetimi**
    
    -   Envanter öğelerinin eklenmesi, düzenlenmesi ve silinmesi.
    -   Kategorilere göre sınıflandırma ve arama fonksiyonları.
2.  **Raporlama**
    
    -   Mevcut envanter durumu raporu.
    -   Atanmış öğelerin listesi.
    -   Yaklaşan garanti süresi sonu olan öğelerin listesi.
3.  **Bildirimler**
    
    -   Düşük stok, yaklaşan garanti süresi sonu gibi durumlar için e-posta bildirimleri.
    -   E-posta gönderme işlemleri SMTP üzerinden gerçekleştirilir.

## Teknolojiler

-   **.NET Core 8.0**: Uygulama geliştirme ve web sunucusu için.
-   **Entity Framework Core**: Veri erişimi ve ORM işlemleri için.
-   **ASP.NET Core MVC**: Web uygulaması geliştirme ve kullanıcı arayüzü için.
-   **SQL Server**: Veritabanı yönetimi için.
-   **SMTP**: E-posta bildirimleri için.

## Kurulum

1.  **Projeyi Klonlayın**
    
    bash
    
    Kodu kopyala
    
    `git clone https://github.com/kullanici-adiniz/it-inventory-management-system.git` 

2. Yapılandırma

-   **`appsettings.json`**: SMTP sunucu ayarlarını ve diğer yapılandırma ayarlarını içeren dosyadır. SMTP ayarlarını doğru bir şekilde yapılandırdığınızdan emin olun.
    
    json
    
    Kodu kopyala
    
    ```"SmtpSettings": {
      "Host": "smtp.example.com",
      "Port": 587,
      "Username": "your-email@example.com",
      "Password": "your-email-password"
    },
  ``"ConnectionStrings": {
    "DefaultConnection": "Server=BURHAN\\SQLEXPRESS;Database=ITInventoryManagementDataBase;Trusted_Connection=True;TrustServerCertificate=True;"
  }``
    
    
3.  **Bağımlılıkları Yükleyin**
    
    Proje klasörüne gidin ve bağımlılıkları yükleyin:
    
    bash
    
    Kodu kopyala
    
    `cd it-inventory-management-system
    dotnet restore` 
    
4.  **Veritabanını Oluşturun ve Güncelleyin**
    
    Veritabanını oluşturmak ve güncellemeleri uygulamak için:
    
    bash
    
    Kodu kopyala
    
    `dotnet ef database update` 
    
5.  **Uygulamayı Çalıştırın**
    
    Uygulamayı geliştirme modunda başlatın:
    
    bash
    
    Kodu kopyala
    
    `dotnet run` 
    
6.  **Web Tarayıcısında Test Edin**
    
    Tarayıcınızı açın
    

## Kullanım

-   **Envanter Yönetimi**: Envanter öğelerini ekleyin, düzenleyin ve silin. Kategorilere göre filtreleme ve arama yapabilirsiniz.
-   **Raporlama**: Envanter durumunu, atanmış öğeleri ve yaklaşan garanti süresi sonu olan öğeleri görüntüleyin.
-   **Bildirimler**: Düşük stok ve yaklaşan garanti süresi sonu hakkında e-posta bildirimleri alın.
