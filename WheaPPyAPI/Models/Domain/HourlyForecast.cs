namespace WheaPPyAPI.Models.Domain
{
    public class HourlyForecast
    {
        public Guid Id { get; set; }
        public Guid LocationId { get; set; }
        public Guid WeatherDataId { get; set; }
        public TimeOnly ForecastTime { get; set; }
        public float Temperature { get; set; }
        public string Condition { get; set; }

        // Navigation Property
        public Location Location { get; set; }
    }
}
