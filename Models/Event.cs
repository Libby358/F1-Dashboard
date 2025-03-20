using System;

namespace F1_Dashboard.Models
{
    public class Event
    {
        public int RoundNumber { get; set; } // This holds the round number (e.g., 1, 2, 3, etc.)
        public string Country { get; set; }
        public string Location { get; set; }
        public string OfficialEventName { get; set; }
        public DateTime EventDate { get; set; }
        public string EventName { get; set; }
        public string Session1 { get; set; }
        public DateTime Session1Date { get; set; }
        public string Session2 { get; set; }
        public DateTime Session2Date { get; set; }
        public string Session3 { get; set; }
        public DateTime Session3Date { get; set; }
        public string Session4 { get; set; }
        public DateTime Session4Date { get; set; }
        public string Session5 { get; set; }
        public DateTime Session5Date { get; set; }
    }
}

