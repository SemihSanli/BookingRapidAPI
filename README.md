# 🏨 Booking.com API Entegrasyon Projesi - ASP.NET 8.0 🌐

---

## 🚀 Projenin Amacı

Bu proje, RapidAPI üzerinden sunulan **Booking.com API** ile doğrudan iletişim kurarak, kullanıcıya **gerçek zamanlı otel rezervasyon bilgileri** sunmayı amaçlamaktadır. 🧳  
📌 Veritabanı kullanılmaz; tüm veriler API üzerinden dinamik olarak elde edilir ve kullanıcıya sunulur.

---

## 🛠️ Kullanılan Teknolojiler

| Teknoloji         | Açıklama                                           |
|------------------|---------------------------------------------------|
| ⚙️ ASP.NET 8.0     | Projenin backend çatısı                            |
| 🧱 Tek Katman       | Katmanlı mimari yerine sade yapı                  |
| 🧠 ViewModel       | UI ve API verisi arasında köprü görevi görür      |
| 🌐 RapidAPI        | Booking.com API sağlayıcısı                       |
| 🏨 Booking API     | Otel, şehir, detay, fotoğraf bilgisi çekimi       |

---

## 📡 Kullanılan Booking API Endpoint'leri

| Endpoint               | Açıklama                                                                              |
|------------------------|--------------------------------------------------------------------------------------|
| 🔍 `/stays/auto-complete` | Şehir adı ile yapılan aramayı şehir ID’sine dönüştürür                               |
| 🔎 `/stays/search`        | Şehir ID, tarih ve kişi bilgilerine göre uygun otelleri listeler                    |
| 🖼️ `/hotels/photos`       | Otel ID’sine ait yüksek çözünürlüklü görselleri getirir                              |
| 🧾 `/stays/detail`        | Her bir otelin detaylı bilgilerini (puan, yorum sayısı, açıklama vb.) getirir        |

---

## 🧑‍💻 Kullanıcı Akışı

### 🏠 Ana Sayfa Üzerinden Rezervasyon Bilgileri Girişi

Kullanıcı aşağıdaki bilgileri girer:

- 📍 **Şehir Adı** (Autocomplete ile ID’ye dönüştürülür)  
- 📅 **Giriş Tarihi**  
- 📅 **Çıkış Tarihi**  
- 👤 **Yetişkin Sayısı**  
- 👶 **Çocuk Sayısı**  

---

### 🔄 API Akışı

1. 🎯 **AutoComplete Endpoint:**  
   Kullanıcının yazdığı şehir adı, şehir ID’sine dönüştürülür.

2. 🔍 **Search Endpoint:**  
   Şehir ID, tarih ve kişi bilgilerine göre uygun oteller çekilir.

3. 🧾 **Stays Detail Endpoint:**  
   Her otel için detay bilgiler alınır (puan, yorum sayısı, seviye vs.).

4. 🖼️ **Get Hotel Photos Endpoint:**  
   Otel ID’si ile otelin yüksek çözünürlüklü görselleri elde edilir.

---

## 🏨 Kullanıcıya Gösterilen Otel Bilgileri

| Bilgi                  | Açıklama                                                                 |
|------------------------|--------------------------------------------------------------------------|
| 🖼️ Otel Fotoğrafı        | API’den dönen fotoğraflar arasından en yüksek çözünürlüklü olan seçilir |
| 🏨 Otel Adı              | Otelin Booking.com üzerindeki adı                                       |
| ⭐ Puan                 | Kullanıcıların verdiği ortalama puan                                    |
| 🎖️ Seviye Title'ı       | Puan değerine karşılık gelen Booking yorum seviyesi                    |
| 📝 Değerlendirme Sayısı | Otel için yapılan toplam yorum sayısı                                   |

> 🔁 Tüm bu veriler **her arama sorgusunda canlı olarak API üzerinden çekilir**.  
> 💾 **Veritabanı kesinlikle kullanılmaz**, sistem %100 API tabanlı çalışır.

---




