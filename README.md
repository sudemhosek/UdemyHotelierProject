# HotelierProject
Bu proje, bir otelin online rezervasyon sistemini ve admin panelini içeren dinamik bir web uygulamasıdır. Kullanıcılar otel hakkında bilgi alabilir, rezervasyon yapabilir ve yönetim tarafı otel operasyonlarını verimli bir şekilde gerçekleştirebilir.

---

## Proje Özellikleri

### 🌍 Web Sitesi

Web sitesi, kullanıcıların otel hakkında bilgi edinmesini ve rezervasyon yapabilmesini sağlayan kullanıcı dostu özellikler sunmaktadır:

- 🛏️ **Oda ve Hizmet Bilgileri:** Kullanıcılar, otelin sunduğu oda seçeneklerini, hizmet detaylarını ve kullanıcı yorumlarını inceleyebilir.
- 📧 **Mail Bülteni Kaydı:** Kullanıcılar, otelin güncel bülteni için abone olabilir ve düzenli bilgi alabilir.
- 📅 **Rezervasyon İşlemleri:** Kullanıcılar, belirledikleri tarihlerde otel odalarını rezerve edebilirler.
- ✉️ **İletişim:** Kullanıcılar, iletişim formu ile otel yönetimiyle iletişime geçebilirler.

### 🖥️ Admin Paneli

Admin paneli, otelin tüm yönetimsel işlevlerini kolayca yöneten güçlü bir arayüz sunar. Adminler aşağıdaki işlemleri gerçekleştirebilirler:

- 📊 **Dashboard:** Veriler görselleştirilerek sunulur, sosyal medya takipçi sayıları gibi veriler RapidAPI entegrasyonu ile dinamik olarak çekilir.
- 📅 **Rezervasyonlar:** Yapılan tüm rezervasyonlar görüntülenebilir, güncellenebilir ve durumları değiştirilebilir.
- 👨‍💼 **Personeller:** Otel çalışanlarının detaylı bilgileri listelenebilir.
- 📝 **Referanslar:** Otel hakkındaki referanslar eklenebilir, düzenlenebilir.
- 🛎️ **Hizmetler:** Otelin sunduğu hizmetler güncellenebilir ve yeni hizmetler eklenebilir.
- 🏨 **Hakkımızda:** Otelin "Hakkımızda" kısmı düzenlenebilir.
- 🛌 **Odalar:** Oda bilgileri listelenebilir, güncellenebilir ve yeni odalar eklenebilir.
- 👥 **Misafirler:** Misafir bilgileri görüntülenebilir ve yönetilebilir.
- 📩 **Mesajlar:** Kullanıcıların gönderdiği mesajlar listelenebilir ve admin cevap verebilir.
- ✉️ **E-posta Gönderimi:** MailKit ile e-posta gönderimi yapılabilir.
- 📂 **Dosya Yükleme:** Admin, görsel ve dosya yükleme işlemleri gerçekleştirebilir.

### 🔒 Güvenlik ve Rol Yönetimi

**Identity Framework** kullanılarak uygulamanın güvenliği sağlanmıştır. Kullanıcılara belirli roller atanabilir ve her rol için farklı yetkilendirme yapılabilir.

---

## Kullanılan Teknolojiler

- **C#** - Backend dili
- **ASP.NET Core** - Web çatısı
- **MSSQL** - Veritabanı
- **Entity Framework** - Veritabanı işlemleri
- **Swagger, Postman** - API testi
- **MailKit** - E-posta gönderimi
- **RapidAPI** - Sosyal medya ve döviz API entegrasyonu


