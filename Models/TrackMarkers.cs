namespace F1_Dashboard.Models
{
    public class TrackMarkers
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public object Coordinates { get; set; }  // Coordinates could be an object like { X, Y }
        public string ImportantFor { get; set; }
    }
}
