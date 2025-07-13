﻿using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using RapidApiBooking.ConsumeModels;

namespace RapidApiBooking.Controllers
{
    public class ReservationController : Controller
    {
        private const string APIKEY = "6693216b71msha5551e4926298a0p124851jsn4012c7ff4b8f";
        private const string APIHOST = "booking-com18.p.rapidapi.com";
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> SearchReservation(string query, string checkinDate, string checkoutDate, int adults, int children)
        {
            var locationId = await GetLocationById(query);
            if (locationId == null)
            {
                return View("Error", "Şehir Adı Bulunamadı");
            }
            var hotels = await GetAllHotels(locationId, checkinDate, checkoutDate, adults, children);

            ViewBag.CheckinDate = checkinDate;
            ViewBag.CheckoutDate = checkoutDate;
            return View("GetAllHotels", hotels);
        }

        public async Task<IActionResult> HotelDetail(string hotelId, string checkinDate, string checkoutDate)
        {
            var detail = await GetHotelDetail(hotelId, checkinDate, checkoutDate);
            return View("GetHotelDetail",detail);
        }

        public async Task<string> GetLocationById(string query)
        {
            using var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://{APIHOST}/stays/auto-complete?query={query}"),
                Headers =
               {
                { "x-rapidapi-key", APIKEY },
                { "x-rapidapi-host", APIHOST },
               }
            };
            using var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<dynamic>(body);
            return data?.data[0]?.id;
        }
        public async Task<List<HotelsViewModel>> GetAllHotels(string locationId, string checkinDate, string checkoutDate, int adults, int children)
        {
            if (!DateTime.TryParse(checkinDate, out DateTime checkinDateParsed) ||
                !DateTime.TryParse(checkoutDate, out DateTime checkoutDateParsed))
            {

                throw new ArgumentException("Check-in veya check-out tarihi geçerli bir formatta değil.");
            }

            string formattedCheckinDate = checkinDateParsed.ToString("yyyy-MM-dd");
            string formattedCheckoutDate = checkoutDateParsed.ToString("yyyy-MM-dd");

            using var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://{APIHOST}/stays/search?locationId={locationId}&checkinDate={formattedCheckinDate}&checkoutDate={formattedCheckoutDate}&adults={adults}&children={children}&units=metric&temperature=c"),
                Headers =
        {
            { "x-rapidapi-key", APIKEY },
            { "x-rapidapi-host", APIHOST },
        },
            };

            using var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<dynamic>(body);

            var hotels = new List<HotelsViewModel>();
            foreach (var item in data?.data)
            {
                var hotel = new HotelsViewModel
                {
                    HotelId = item.id,
                    HotelName = item.name,
                    ReviewScore = item.reviewScore,
                    ReviewCount = item.reviewCount,
                    ReviewScoreWord = item.reviewScoreWord != null ? (string)item.reviewScoreWord : "Yorum yok"
                };

                // Daha kaliteli fotoğrafı çek
                var photos = await GetHotelPhotos(hotel.HotelId);
                if (photos != null && photos.Count > 0)
                {
                    hotel.CoverImageURL = photos.First().ImageURL;
                }
                else if (item.photoUrls != null && item.photoUrls.Count > 0)
                {
                    hotel.CoverImageURL = item.photoUrls[0]; // yedek: düşük kalite
                }

                hotels.Add(hotel);
            }

            return hotels;
        }

   

        public async Task<List<PhotosByHotelViewModel>> GetHotelPhotos(string hotelId)
        {
            using var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://{APIHOST}/stays/get-photos?hotelId={hotelId}"),
                Headers =
                {
            { "x-rapidapi-key", APIKEY },
            { "x-rapidapi-host", APIHOST },
                },
            };

            using var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            var data = JsonConvert.DeserializeObject<dynamic>(body);

            var photos = new List<PhotosByHotelViewModel>();
            try
            {
                var photoData = data?.data?.data?[hotelId];
                if (photoData != null && photoData.Count > 0)
                {
                    var firstItem = photoData[0];
                    var fourthIndex = firstItem[4];
                    var photoUrl = fourthIndex[31]?.ToString();

                    if (!string.IsNullOrEmpty(photoUrl))
                    {
                        var fullPhotoUrl = $"{data?.data?.url_prefix}{photoUrl}";

                        photos.Add(new PhotosByHotelViewModel
                        {
                            ImageURL = fullPhotoUrl
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fotoğraf alma işlemi sırasında hata oluştu: {ex.Message}");
            }
            return photos;
        }




        public async Task<HotelDetailViewModel> GetHotelDetail(string hotelId, string checkinDate, string checkoutDate)
        {
            if (!DateTime.TryParse(checkinDate, out var checkin) || !DateTime.TryParse(checkoutDate, out var checkout))
            {
                throw new ArgumentException("Geçersiz tarih formatı");
            }

            string formattedCheckin = checkin.ToString("yyyy-MM-dd");
            string formattedCheckout = checkout.ToString("yyyy-MM-dd");

            string city = null;
            string price = null;
            string coverImageUrl = null;

            try
            {
                using var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://{APIHOST}/stays/detail?hotelId={hotelId}&checkinDate={formattedCheckin}&checkoutDate={formattedCheckout}&units=metric"),
                    Headers =
            {
                { "x-rapidapi-key", APIKEY },
                { "x-rapidapi-host", APIHOST },
            },
                };

                using var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<dynamic>(body);

                city = data?.data?.city;

               
                var grossAmount = data?.data?.composite_price_breakdown?.gross_amount;
                if (grossAmount != null)
                {
                    price = $"{grossAmount.amount_rounded} {grossAmount.currency}";
                }

               
                var block = data?.data?.block;
                var photos = block?[0]?.photos;
                if (photos != null && photos.Count > 0)
                {
                    coverImageUrl = photos[0]?.url_max300 ?? photos[0]?.url_original;
                }

                
                if (string.IsNullOrEmpty(coverImageUrl))
                {
                    var fallbackPhotos = await GetHotelPhotos(hotelId);
                    if (fallbackPhotos != null && fallbackPhotos.Count > 0)
                    {
                        coverImageUrl = fallbackPhotos.First().ImageURL;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"HATA - HotelDetail: {ex.Message}");
            }

            return new HotelDetailViewModel
            {
                City = city ?? "Bilinmiyor",
                Price = price ?? "Fiyat bilgisi yok",
                CoverImageURL = coverImageUrl
            };
        }





    }

}

