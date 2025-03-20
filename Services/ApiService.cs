using F1_Dashboard.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace F1_Dashboard.Services
{
    public class ApiService
    {
        private static readonly HttpClient client = new HttpClient { BaseAddress = new System.Uri("http://127.0.0.1:5000") };

        public static async Task<List<Event>> GetEventSchedule()
        {
            var response = await client.GetStringAsync("/events");
            return JsonConvert.DeserializeObject<List<Event>>(response);
        }

        public static async Task<List<RaceResult>> GetRaceResults(int year, int round)
        {
            var response = await client.GetStringAsync($"/results/{year}/{round}");
            return JsonConvert.DeserializeObject<List<RaceResult>>(response);
        }

        public static async Task<List<LapData>> GetTimingData(int year, int round)
        {
            var response = await client.GetStringAsync($"/timing-data/{year}/{round}");
            return JsonConvert.DeserializeObject<List<LapData>>(response);
        }
    }
}
