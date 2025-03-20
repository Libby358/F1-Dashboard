﻿using F1_Dashboard.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;

namespace F1_Dashboard.Views
{
    public partial class RaceResults : UserControl
    {
        public RaceResults()
        {
            InitializeComponent(); // Initializes the page components
            DataContext = new RaceResultsViewModel(); // Bind the view model to the page
        }
    }
}

