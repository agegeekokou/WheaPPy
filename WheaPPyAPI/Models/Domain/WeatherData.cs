namespace WheaPPyAPI.Models.Domain
{
    public class WeatherData
    {
        public Guid Id { get; set; }
        public Guid LocationId { get; set; }
        public DateTime Date { get; set; }
        public float Temperature { get; set; }
        public string Condition { get; set; }
        public TimeOnly Sunrise { get; set; }
        public TimeOnly Sunset { get; set; }
        public int Humidity { get; set; }
        public DateTime RecordedAt { get; set; }

        // Navigation Property
        public Location Location { get; set; }
    }
}
