# 🏨 Booking.com API Entegrasyon Projesi - ASP.NET 8.0 🌐

---

## 🚀 Projenin Amacı

Bu proje, **RapidAPI** üzerinden sunulan **Booking.com API** ile doğrudan iletişim kurarak bir otel rezervasyon deneyimi sunmayı amaçlamaktadır. 🧳  
**Veritabanı kullanılmadan**, sadece API ile iletişim kurularak dinamik otel bilgileri kullanıcıya sunulur.  

🔄 **Gerçek zamanlı** olarak rezervasyon bilgileri alınıp listelenir ve kullanıcıya gösterilir.

---

## 🛠️ Kullanılan Teknolojiler

| Teknoloji         | Açıklama                                |
|-------------------|------------------------------------------|
| ⚙️ ASP.NET 8.0     | Projenin backend çatısı                  |
| 🧱 Tek Katman      | Katmanlı mimari yerine sade yapı         |
| 🧠 ViewModel       | UI ve API verisi arasında köprü olarak   |
| 🌐 RapidAPI        | API sağlayıcısı                          |
| 🏨 Booking.com API | Otel, şehir, fotoğraf bilgisi çekimi     |

---

## 📡 Kullanılan Booking API Endpointleri

| Endpoint                     | Açıklama                                                                 |
|-----------------------------|--------------------------------------------------------------------------|
| 🔍 `/stays/auto-complete`   | Şehir adı ile yapılan aramayı şehir ID’sine dönüştürür.                  |
| 🔎 `/stays/search`          | Belirli şehir ID’si ve tarih bilgileri ile otel araması yapar.           |
| 🖼️ `/hotels/photos`         | Otel ID’sine ait yüksek çözünürlüklü fotoğrafları getirir.               |

---

## 🧑‍💻 Kullanıcı Akışı

### 🏠 Ana Sayfa Üzerinden Rezervasyon Bilgileri Girişi

Kullanıcı aşağıdaki bilgileri girer:

- 📍 **Şehir Adı** (Autocomplete ile ID’ye dönüştürülür)
- 📅 **Giriş Tarihi**
- 📅 **Çıkış Tarihi**
- 👤 **Yetişkin Sayısı**
- 👶 **Çocuk Sayısı**

🧭 Bu bilgiler girildikten sonra şu API akışı devreye girer:

1. 🎯 **AutoComplete Endpoint:**  
   Şehir adı → Şehir ID dönüşümü yapılır.
2. 🔍 **Search Endpoint:**  
   Girilen şehir ID, tarih, kişi sayısına göre uygun oteller getirilir.
3. 🖼️ **Get Hotel Photos Endpoint:**  
   Her otelin yüksek çözünürlüklü görselleri alınır.

---

## 🏨 Kullanıcıya Gösterilen Otel Bilgileri

Kullanıcı, listelenen oteller için şu bilgileri görür:

| Bilgi                          | Açıklama                                                             |
|-------------------------------|----------------------------------------------------------------------|
| 🖼️ **Otel Fotoğrafı**          | En yüksek çözünürlüklü görsel seçilerek ekranda gösterilir           |
| 🏨 **Otel Adı**                 | Otelin Booking.com üzerindeki adı                                   |
| ⭐ **Puan**                     | Otelin aldığı kullanıcı puanı                                        |
| 🎖️ **Seviye Title'ı**         | Puan değerine karşılık gelen Booking yorum seviyesi                  |
| 📝 **Değerlendirme Sayısı**    | Otel için kaç adet yorum/değerlendirme yapıldığı bilgisi             |

> 🔁 Tüm bu bilgiler her yeni rezervasyon sorgusunda **gerçek zamanlı** olarak API'den çekilir, herhangi bir `veritabanı` kullanılmaz!

---

## 📷 Otel Kart Örneği


<img width="1760" height="965" alt="1" src="https://github.com/user-attachments/assets/25c068bf-9b11-4123-b885-d0d96b17db6d" />

<img width="2027" height="879" alt="2" src="https://github.com/user-attachments/assets/87bc4e04-a992-48ed-b621-c945155af381" />

<img width="1371" height="1183" alt="3" src="https://github.com/user-attachments/assets/e87b3153-0679-48e0-b864-81fe51075519" />

<img width="1393" height="697" alt="4" src="https://github.com/user-attachments/assets/e86c66d7-3387-41c3-a570-894f6210ed6b" />
<img width="2489" height="802" alt="5" src="https://github.com/user-attachments/assets/cacb0acd-b443-49dc-a6f2-a762d5e6bd31" />

<img width="2540" height="752" alt="6" src="https://github.com/user-attachments/assets/58357647-4802-42c4-94dd-c8695a38648a" />

<img width="2532" height="1257" alt="7" src="https://github.com/user-attachments/assets/80967c11-7fdb-4dbb-b4c9-543a46847913" />

<img width="2542" height="1271" alt="8" src="https://github.com/user-attachments/assets/57096e27-1167-4f48-8109-5c055b0f80b3" />
<img width="2539" height="1264" alt="9" src="https://github.com/user-attachments/assets/ef5d47b8-8535-496a-9596-0713e03a49b5" />
<img width="2540" height="1271" alt="10" src="https://github.com/user-attachments/assets/e6f69ae2-1edf-46b5-9473-031cfb7a844e" />
<img width="2539" height="1264" alt="11" src="https://github.com/user-attachments/assets/3f87f045-5d6c-4b46-a824-55e333fd1b61" />



