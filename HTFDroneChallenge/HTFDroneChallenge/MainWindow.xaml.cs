﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Wpf;

namespace HTFDroneChallenge
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }


        private void cmbDetails_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            switch(cmbDetails.SelectedIndex)
            {
                case 0:
                SeriesCollection = new SeriesCollection
            {

                new LineSeries
                {
                    Title = "Temperature",
                    Values = new ChartValues<double> { 4, 6, 5, 2 ,4 }
                },
};
                    break;
                case 1:
                    SeriesCollection = new SeriesCollection
            {

                new LineSeries
                {
                    Title = "Wind Speed",
                    Values = new ChartValues<double> { 1,2,4,3,5 }
                },
};
                    break;
                case 2:
                    SeriesCollection = new SeriesCollection
            {

                new LineSeries
                {
                    Title = "Wind oriantation",
                    Values = new ChartValues<double> { 5,3,1,5,6 }
                },
};
                    break;
                case 3:
                    SeriesCollection = new SeriesCollection
            {

                new LineSeries
                {
                    Title = "Particle Size",
                    Values = new ChartValues<double> { 3,3,3,4,1}
                },
};
                    break;

            };
        
            YFormatter = value => value.ToString("C");



            DataContext = this;
        }
        public SeriesCollection SeriesCollection { get; set; }
        public Func<double, string> YFormatter { get; set; }
    }
    }


