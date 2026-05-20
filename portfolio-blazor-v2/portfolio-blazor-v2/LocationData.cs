namespace portfolio_blazor_v2
{
    public class LocationData
    {
        public double Latitiude { get; set; }
        public double Longitude { get; set; }
        public double Accuracy { get; set; }
        public double? Altitude { get; set; }
        public string Timestamp { get; set; } = string.Empty;
    }
}
