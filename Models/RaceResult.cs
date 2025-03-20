namespace F1_Dashboard.Models
{
    public class RaceResult
    {
        public string DriverName { get; set; }
        public string Team { get; set; }
        public int GridPosition { get; set; }
        public int FinishPosition { get; set; }
        public int Points { get; set; }
        public string Status { get; set; }
    }
}
