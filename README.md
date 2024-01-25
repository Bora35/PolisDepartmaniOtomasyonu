# Polis Departmanı Otomasyonu

Bu proje, bir polis departmanı otomasyonunu simüle eden bir C# Windows Forms uygulamasıdır. 
Aşağıda, projenin genel yapısı, kullanılan teknolojiler ve projenin nasıl çalıştırılacağı gibi önemli bilgileri bulabilirsiniz.

## Kullanılan Teknolojiler

- **C# Programlama Dili**
- **Windows Forms Uygulama Geliştirme Aracı**
- **SQL Server Veritabanı**

## Proje Açıklaması

Bu uygulama, mahkum kayıtlarını ve görevli bilgilerini takip etmek, kaydetmek, güncellemek, silmek ve aramak için kullanılır. 
Yetkili kullanıcı girişi ile sisteme erişim sağlanır ve ardından mahkumların ve görevlilerin bilgilerini yönetmek mümkündür.

## Uygulama Ekranları

1. **Ana Ekran (FrmAnaEkran):** Uygulamanın ana ekranıdır. Yetkili kullanıcı girişi yapılabilir.

2. **Login Ekranı (FrmLogin):** Yetkili kullanıcı girişi ekranıdır. Kullanıcı adı ve şifre ile giriş yapılabilir.

3. **Bilgi Düzenle Ekranı (FrmBilgiDuzenle):** Bu ekran, kullanıcı bilgilerini güncellemek için kullanılır.

4. **Mahkum Ekranı (FrmSuclu):** Bu ekran, mahkum bilgilerini işleyen formu içerir.

5. **Görevli Ekranı (FrmGorevli):** Bu ekran, görevli bilgilerini işleyen formu içerir.

## Proje Yapısının Anlaşılması

- **FrmAnaEkran.cs:** Uygulamanın ana ekran formunu içerir.
- **FrmLogin.cs:** Yetkili kullanıcı girişi ekranını içerir.
- **FrmBilgiDuzenle.cs:** Kullanıcı bilgilerini güncellemek için formu içerir.
- **FrmSuclu.cs:** Mahkum bilgilerini işleyen formu içerir.
- **FrmGorevli.cs:** Görevli bilgilerini işleyen formu içerir.
- **Veritabani.cs:** SQL Server veritabanı işlemlerini gerçekleştiren sınıfı içerir.

## Nasıl Çalıştırılır?

1. Projeyi bilgisayarınıza klonlayın.
2. SQL Server üzerinde gerekli  `polisdepartman.sql` ile veritabanı ve tabloları oluşturun.
3. Visual Studio veya benzer bir C# geliştirme ortamını açın.
4. Proje dosyasını yükleyin ve gerekli bağımlılıkları çözün.
5. Veritabanı bağlantı bilgilerinizi `Veritabani.cs` ve `App.config` içerisinde güncelleyin.
6. Projeyi derleyin ve çalıştırın.

