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

- **C#** - Backend geliştirme için kullanılan programlama dili.
- **N Katmanlı Mimari ile oluşturuldu.
- **MSSQL** - Veritabanı yönetim sistemi olarak Microsoft SQL Server kullanıldı.
- **Entity Framework** - Veritabanı işlemleri ve ORM (Object-Relational Mapping) için kullanıldı.
- **Swagger, Postman** - API'lerin test edilmesi için kullanılan araçlar.
- **MailKit** - E-posta gönderimi için kullanılan kütüphane.
- **RapidAPI** - Dış API'lerle entegrasyon sağlamak için sosyal medya takipçi verisi ve döviz kuru gibi veriler alındı.
- **Identity** - Kullanıcı kimlik doğrulama ve yetkilendirme işlemleri için kullanıldı.
- **JWT** - JSON Web Token ile kullanıcı oturumu yönetimi sağlandı.
- **AutoMapper** - DTO (Data Transfer Object) ile verilerin dönüşümünü gerçekleştirdi.
- **Fluent Validation** - Kullanıcı giriş doğrulama işlemleri için kullanıldı.
- **CodeFirst Yaklaşımı** - Veritabanı tasarımında CodeFirst yöntemi kullanılarak Entity Framework ile modelleme yapıldı.
- **Repository Design Pattern** - Katmanlar arası bağımsızlık sağlanarak iş mantığı daha modüler ve yeniden kullanılabilir hale getirildi.
- **RapidAPI** - Dış servislerden dinamik verilerin çekilmesi sağlandı (Örneğin: Döviz Kurları, Sosyal Medya Takipçi Sayıları).


  
## Admin

![Image](https://github.com/user-attachments/assets/e41a0ba4-7218-4967-9f33-a9bd5355041d)
![Image](https://github.com/user-attachments/assets/554ede68-c16f-42df-9077-d649c30d7919)
![Image](https://github.com/user-attachments/assets/e9f008b7-0bf3-439e-934c-e2fda4abc6d0)
![Image](https://github.com/user-attachments/assets/341c8492-30af-4120-ac84-9ae6a8cd0db1)
![Image](https://github.com/user-attachments/assets/0769ebf6-fc6a-4aa6-9b87-0cd3d673a47b)
![Image](https://github.com/user-attachments/assets/0cc8ceb6-3991-4f49-897f-681f78336ef1)

![Image](https://github.com/user-attachments/assets/14be73af-7f23-4535-967f-14fa86a14110)

![Image](https://github.com/user-attachments/assets/15029a0e-bd7d-44ff-9c63-327698fb5f17)

![Image](https://github.com/user-attachments/assets/59fd9abb-14d6-4be4-b404-fb434e79a502)



## Web Site

![Image](https://github.com/user-attachments/assets/5638bb6f-17dd-419e-abb1-b86fabd0918a)

![Image](https://github.com/user-attachments/assets/c9dedfe9-75e3-463d-8056-882c8e742cb7)

![Image](https://github.com/user-attachments/assets/d50a54f0-5003-40c0-8d00-95d4166321ec)

![Image](https://github.com/user-attachments/assets/56f8ef95-1ab9-4329-ae2d-e73c8ed3fdbe)

![Image](https://github.com/user-attachments/assets/e5f3f15e-d2d8-48d9-9c0f-efc8daf99578)

![Image](https://github.com/user-attachments/assets/a6c1fbf5-e34f-4a2d-b243-e772b93dd84f)

![Image](https://github.com/user-attachments/assets/3df4f1d7-8dc4-4b61-8826-803665ebf7a2)

![Image](https://github.com/user-attachments/assets/1f84466d-eb32-4fed-8632-04f6f4f5c765)

![Image](https://github.com/user-attachments/assets/ccfe3d2b-ebd9-42d6-a649-c882709e795b)
