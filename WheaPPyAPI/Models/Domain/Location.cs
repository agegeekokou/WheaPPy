namespace WheaPPyAPI.Models.Domain
{
    public class Location
    {
        public Guid Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }

        //Navigation Property
        public ICollection<WeatherData> WeatherData { get; set; }
        public ICollection<HourlyForecast> HourlyForecasts { get; set; }
    }
}
