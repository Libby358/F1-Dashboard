using F1_Dashboard.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace F1_Dashboard.Services
{
    public class ApiService
    {
        // Ensure HttpClient is initialized and used correctly
        private static readonly HttpClient client = new HttpClient { BaseAddress = new Uri("http://127.0.0.1:5000") };

        // Flag to switch between placeholder data and actual API calls
        private static bool usePlaceholder = true; // Set this to false when API is up

        // This method will fetch the event schedule
        public static async Task<List<Event>> GetEventSchedule()
        {
            if (usePlaceholder)
            {
                return GetPlaceholderEventSchedule();
            }
            else
            {
                try
                {
                    var response = await client.GetStringAsync("/events");
                    return JsonConvert.DeserializeObject<List<Event>>(response);
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception("Error while connecting to the API: " + ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("An unexpected error occurred: " + ex.Message);
                }
            }
        }

        // This method will fetch the race results
        public static async Task<List<RaceResult>> GetRaceResults(int year, int round)
        {
            if (usePlaceholder)
            {
                return GetPlaceholderRaceResults();
            }
            else
            {
                try
                {
                    var response = await client.GetStringAsync($"/results/{year}/{round}");
                    return JsonConvert.DeserializeObject<List<RaceResult>>(response);
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception("Error while connecting to the API: " + ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("An unexpected error occurred: " + ex.Message);
                }
            }
        }

        // This method will fetch the timing data
        public static async Task<List<LapData>> GetTimingData(int year, int round)
        {
            if (usePlaceholder)
            {
                return GetPlaceholderTimingData();
            }
            else
            {
                try
                {
                    var response = await client.GetStringAsync($"/timing-data/{year}/{round}");
                    return JsonConvert.DeserializeObject<List<LapData>>(response);
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception("Error while connecting to the API: " + ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("An unexpected error occurred: " + ex.Message);
                }
            }
        }

        public static async Task<List<RaceControlMessage>> GetRaceControlMessages()
        {
            if (usePlaceholder)
            {
                return GetPlaceholderRaceControlMessages(); // Return placeholder data if usePlaceholder is true
            }
            else
            {
                try
                {
                    var response = await client.GetStringAsync("/race-control-messages");
                    return JsonConvert.DeserializeObject<List<RaceControlMessage>>(response);
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception("Error while connecting to the API: " + ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("An unexpected error occurred: " + ex.Message);
                }
            }
        }

        public static async Task<List<SessionStatus>> GetSessionStatuses()
        {
            if (usePlaceholder)
            {
                return GetPlaceholderSessionStatuses(); // Return placeholder data if usePlaceholder is true
            }
            else
            {
                try
                {
                    var response = await client.GetStringAsync("/session-status");
                    return JsonConvert.DeserializeObject<List<SessionStatus>>(response);
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception("Error while connecting to the API: " + ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("An unexpected error occurred: " + ex.Message);
                }
            }
        }


        // Placeholder data for Track Status
        private static TrackStatus GetPlaceholderTrackStatus()
        {
            return new TrackStatus
            {
                TrackCondition = "Dry",
                Temperature = "25°C",
                WindSpeed = "15 km/h",
                SafetyCarStatus = "None",
                LapTimeDelays = "None",
                IncidentReports = new List<string> { "No incidents reported" },
                FlagStatus = "Green"
            };
        }

        // Placeholder data for Session Status
        // Placeholder data for Session Status
        private static List<SessionStatus> GetPlaceholderSessionStatuses()
        {
            return new List<SessionStatus>
            {
                new SessionStatus
                {
                    SessionType = "Qualifying",
                    TimeRemaining = "10:00",
                    SessionStatusActive = "Active",
                    FlagStatus = "Green",
                    SafetyCarStatus = "None",
                    PitLaneStatus = "Open"
                },
                new SessionStatus
                {
                    SessionType = "Race",
                    TimeRemaining = "50:00",
                    SessionStatusActive = "Active",
                    FlagStatus = "Green",
                    SafetyCarStatus = "Deployed",
                    PitLaneStatus = "Closed"
                }
            };
        }

        // Placeholder data for Race Control Messages
        private static List<RaceControlMessage> GetPlaceholderRaceControlMessages()
        {
            return new List<RaceControlMessage>
            {
                new RaceControlMessage
                {
                    MessageType = "Safety Car",
                    Message = "Safety car deployed due to incident at Turn 5.",
                    ActionRequired = "Reduce speed",
                    TimeOfMessage = DateTime.Now,
                    AffectedArea = "Turn 5"
                },
                new RaceControlMessage
                {
                    MessageType = "Yellow Flag",
                    Message = "Yellow flag in Sector 2 due to debris.",
                    ActionRequired = "Caution",
                    TimeOfMessage = DateTime.Now,
                    AffectedArea = "Sector 2"
                }
            };
        }

         public static async Task<TelemetryData> GetTelemetryData(int year, int round)
        {
            if (usePlaceholder)
            {
                return GetPlaceholderTelemetry(); // Return placeholder data if usePlaceholder is true
            }
            else
            {
                try
                {
                    var response = await client.GetStringAsync($"/telemetry/{year}/{round}");
                    return JsonConvert.DeserializeObject<TelemetryData>(response);
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception("Error while connecting to the API: " + ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("An unexpected error occurred: " + ex.Message);
                }
            }
        }

        private static TelemetryData GetPlaceholderTelemetry()
        {
            return new TelemetryData
            {
                Speed = "305 km/h",
                ThrottlePosition = "85%",
                BrakePressure = "20%",
                Gear = "7",
                EngineRPM = "13,500",
                TireTemperatures = new Dictionary<string, string>
                {
                    { "Front Left", "75°C" },
                    { "Front Right", "78°C" },
                    { "Rear Left", "70°C" },
                    { "Rear Right", "72°C" }
                },
                FuelRemaining = "35%",
                GForce = new Dictionary<string, string>
                {
                    { "Lateral", "2.5G" },
                    { "Longitudinal", "1.2G" }
                },
                LapTimeComparison = "0.3s faster than previous lap"
            };
        }

        // Method to fetch track markers data
        public static async Task<List<TrackMarkers>> GetTrackMarkers(int year, int round)
        {
            if (usePlaceholder)
            {
                return GetPlaceholderTrackMarkers();
            }
            else
            {
                try
                {
                    var response = await client.GetStringAsync($"/track-markers/{year}/{round}");
                    return JsonConvert.DeserializeObject<List<TrackMarkers>>(response);
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception("Error while connecting to the API: " + ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("An unexpected error occurred: " + ex.Message);
                }
            }
        }

        public static async Task<TrackStatus> GetTrackStatus(int year, int round)
        {
            if (usePlaceholder)
            {
                return GetPlaceholderTrackStatus();
            }
            else
            {
                try
                {
                    var response = await client.GetStringAsync($"/track-status/{year}/{round}");
                    return JsonConvert.DeserializeObject<TrackStatus>(response);
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception("Error while connecting to the API: " + ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("An unexpected error occurred: " + ex.Message);
                }
            }
        }

        // Placeholder data for Track Markers
        private static List<TrackMarkers> GetPlaceholderTrackMarkers()
        {
            return new List<TrackMarkers>
            {
                new TrackMarkers
                {
                    Name = "Turn 1",
                    Type = "Corner",
                    Coordinates = new { X = 50, Y = 100 },
                    ImportantFor = "High-speed braking zone"
                },
                new TrackMarkers
                {
                    Name = "DRS Zone 1",
                    Type = "Overtaking Zone",
                    Coordinates = new { X = 200, Y = 300 },
                    ImportantFor = "DRS activation zone for overtaking"
                },
                new TrackMarkers
                {
                    Name = "Pit Entry",
                    Type = "Pit Lane",
                    Coordinates = new { X = 450, Y = 200 },
                    ImportantFor = "Pit stop entry"
                }
            };
        }

        #region Placeholder Data Methods

        // Placeholder data for Event Schedule
        private static List<Event> GetPlaceholderEventSchedule()
        {
            return new List<Event>
            {
                new Event
                {
                    RoundNumber = 1,
                    Country = "Bahrain",
                    Location = "Sakhir",
                    OfficialEventName = "FORMULA 1 GULF AIR BAHRAIN GRAND PRIX 2025",
                    EventDate = DateTime.Parse("2025-03-28T15:00:00"),
                    EventName = "Bahrain Grand Prix",
                    Session1 = "Practice 1",
                    Session1Date = DateTime.Parse("2025-03-26T11:30:00"),
                    Session2 = "Practice 2",
                    Session2Date = DateTime.Parse("2025-03-26T15:00:00"),
                    Session3 = "Practice 3",
                    Session3Date = DateTime.Parse("2025-03-27T12:00:00"),
                    Session4 = "Qualifying",
                    Session4Date = DateTime.Parse("2025-03-27T15:00:00"),
                    Session5 = "Race",
                    Session5Date = DateTime.Parse("2025-03-28T15:00:00")
                }
            };
        }

        // Placeholder data for Race Results
        private static List<RaceResult> GetPlaceholderRaceResults()
        {
            return new List<RaceResult>
            {
                new RaceResult
                {
                    DriverName = "Lewis Hamilton",
                    Team = "Mercedes",
                    Position = 1,
                    Time = "1:31:55.556"
                },
                new RaceResult
                {
                    DriverName = "Max Verstappen",
                    Team = "Red Bull Racing",
                    Position = 2,
                    Time = "1:32:01.123"
                }
            };
        }

        // Placeholder data for Timing Data
        private static List<LapData> GetPlaceholderTimingData()
        {
            return new List<LapData>
            {
                new LapData
                {
                    DriverName = "Lewis Hamilton",
                    LapTime = "1:31.234",
                    LapNumber = 10
                },
                new LapData
                {
                    DriverName = "Max Verstappen",
                    LapTime = "1:32.345",
                    LapNumber = 10
                }
            };
        }

        #endregion
    }
}


