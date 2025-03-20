namespace F1_Dashboard.Models
{
    public class RaceResult
    {
        public string DriverName { get; set; }   // The name of the driver
        public string Team { get; set; }          // The team the driver is part of
        public int GridPosition { get; set; }    // The starting grid position
        public int FinishPosition { get; set; }  // The position the driver finished in the race
        public int Points { get; set; }          // The points awarded for finishing in this position
        public string Status { get; set; }       // Status of the race (e.g., "Finished", "Retired")
        public int Position { get; set; }  // This could be the position at the finish line
        public string Time { get; set; } // This could be the time the driver finished with (e.g., race time)
    }
}
