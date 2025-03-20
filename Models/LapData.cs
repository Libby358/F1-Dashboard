namespace F1_Dashboard.Models
{
    public class LapData  // ✅ Ensure it's public
    {
        public string Driver { get; set; }
        public int LapNumber { get; set; }
        public string Sector1 { get; set; }
        public string Sector2 { get; set; }
        public string Sector3 { get; set; }
        public string PitStop { get; set; }
    }
}
