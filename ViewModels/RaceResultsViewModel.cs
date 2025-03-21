﻿using F1_Dashboard.Models;
using System.Collections.ObjectModel;

namespace F1_Dashboard.ViewModels
{
    public class RaceResultsViewModel : ViewModelBase
    {
        private ObservableCollection<RaceResult> _raceResults;
        public ObservableCollection<RaceResult> RaceResults
        {
            get { return _raceResults; }
            set { _raceResults = value; OnPropertyChanged(nameof(RaceResults)); }
        }

        public RaceResultsViewModel()
        {
            RaceResults = new ObservableCollection<RaceResult>
            {
                new RaceResult { DriverName = "Max Verstappen", Team = "Red Bull", GridPosition = 1, FinishPosition = 1, Points = 25, Status = "Finished" },
                new RaceResult { DriverName = "Lewis Hamilton", Team = "Mercedes", GridPosition = 2, FinishPosition = 3, Points = 15, Status = "Finished" }
            };
        }
    }
}
