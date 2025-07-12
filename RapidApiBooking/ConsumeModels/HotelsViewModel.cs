namespace RapidApiBooking.ConsumeModels
{
    public class HotelsViewModel
    {
        public string HotelId { get; set; }
        public string HotelName { get; set; }
        public string CoverImageURL { get; set; }
        public string ReviewScoreWord { get; set; }
        public decimal ReviewScore { get; set; }
        public string ReviewCount { get; set; }
        public List<PhotosByHotelViewModel> Photos { get; set; }
    }
}
