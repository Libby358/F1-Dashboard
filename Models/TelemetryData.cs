using System.Collections.Generic;

namespace F1_Dashboard.Models
{
    public class TelemetryData
    {
        public string Speed { get; set; }
        public string ThrottlePosition { get; set; }
        public string BrakePressure { get; set; }
        public string Gear { get; set; }
        public string EngineRPM { get; set; }
        public Dictionary<string, string> TireTemperatures { get; set; }
        public string FuelRemaining { get; set; }
        public Dictionary<string, string> GForce { get; set; }
        public string LapTimeComparison { get; set; }
    }
}
