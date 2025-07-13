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

<img width="1760" height="965" alt="1" src="https://github.com/user-attachments/assets/2448e57e-dcaa-4676-84f1-c9b4400660ca" />

<img width="2027" height="879" alt="2" src="https://github.com/user-attachments/assets/be62bfea-8352-4983-aaa9-98714b4f09f2" />

<img width="1371" height="1183" alt="3" src="https://github.com/user-attachments/assets/7289e065-a6c3-49c6-8ebd-370760d58c39" />

<img width="1393" height="697" alt="4" src="https://github.com/user-attachments/assets/1cb5adc2-2a97-4a14-b222-d1aec9c86a80" />
<img width="2489" height="802" alt="5" src="https://github.com/user-attachments/assets/26fdf5fe-9a0f-4b20-ac93-e8b6992c0ab5" />
<img width="2540" height="752" alt="6" src="https://github.com/user-attachments/assets/62c94c8a-ecc7-4687-af6d-61a22965b18b" />
<img width="2532" height="1257" alt="7" src="https://github.com/user-attachments/assets/35c569ec-156b-4ef0-a44f-4c9e3a361a25" />
<img width="2542" height="1271" alt="8" src="https://github.com/user-attachments/assets/13d37a76-aaaa-4b0a-ac00-fcc33ffc3634" />
<img width="2539" height="1264" alt="9" src="https://github.com/user-attachments/assets/20951b01-1673-41b9-b95a-213144e17acb" />
<img width="2540" height="1271" alt="10" src="https://github.com/user-attachments/assets/bd227420-1305-4b71-a838-f5b52df1f43c" />
<img width="2539" height="1264" alt="11" src="https://github.com/user-attachments/assets/52390df3-0bb6-44ea-8fec-3fa1940cca03" />
<img width="766" height="583" alt="Ekran görüntüsü 2025-07-13 201548" src="https://github.com/user-attachments/assets/6824b9cf-78f6-444c-a20e-950d48aebd72" />
