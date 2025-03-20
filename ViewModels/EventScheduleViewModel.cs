using System.Collections.ObjectModel;

namespace F1_Dashboard.ViewModels
{
    public class EventScheduleViewModel
    {
        public ObservableCollection<EventModel> Events { get; set; }

        public EventScheduleViewModel()
        {
            Events = new ObservableCollection<EventModel>
            {
                new EventModel { Name = "Monaco GP", Country = "Monaco", Location = "Monte Carlo", Date = "26 May 2024", StartTime = "14:00" },
                new EventModel { Name = "British GP", Country = "UK", Location = "Silverstone", Date = "7 July 2024", StartTime = "15:00" }
            };
        }
    }

    public class EventModel
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Location { get; set; }
        public string Date { get; set; }
        public string StartTime { get; set; }
    }
}


