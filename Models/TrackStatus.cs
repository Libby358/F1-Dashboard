using System.Collections.Generic;

namespace F1_Dashboard.Models
{
    public class TrackStatus
    {
        public string TrackCondition { get; set; }
        public string Temperature { get; set; }
        public string WindSpeed { get; set; }
        public string SafetyCarStatus { get; set; }
        public string LapTimeDelays { get; set; }
        public string FlagStatus { get; set; }
        public List<string> IncidentReports { get; set; }
    }
}

