using System;

namespace F1_Dashboard.Models
{
    public class RaceControlMessage
    {
        public string MessageType { get; set; }
        public string Message { get; set; }
        public string ActionRequired { get; set; }
        public DateTime TimeOfMessage { get; set; }
        public string AffectedArea { get; set; }
    }
}
