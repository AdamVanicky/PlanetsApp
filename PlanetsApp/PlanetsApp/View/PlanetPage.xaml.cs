﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PlanetsApp.Models;
using System.ComponentModel;

namespace PlanetsApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public class PageViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public PageViewModel(Planet p)
        {
            Name = p.Name;
            Type = p.Type;
            AverageTemperature = p.AverageTemperature;
        }

        public string _Name;
        public string Name
        {
            get { return _Name; }
            set 
            {
                _Name = value;
                PropertyChanged?.Invoke(this,new PropertyChangedEventArgs("Name"));
            }
        }

        public string _Type;
        public string Type
        {
            get { return _Type; }
            set
            {
                _Type = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Type"));
            }
        }

        public int _AverageTemperature;
        public int AverageTemperature
        {
            get { return _AverageTemperature; }
            set
            {
                _AverageTemperature = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AverageTemperature"));
            }
        }

        public Planet ChangedPlanet()
        {
            Planet p = new Planet
            {
                Name = this.Name,
            Type = this.Type,
            AverageTemperature = this.AverageTemperature
        };
            return p;
        }
    }
    public partial class PlanetPage : ContentPage
    {
        ObservableCollection<Planet> oCollection;
        public PlanetPage()
        {
            InitializeComponent();
        }

        public PlanetPage(Planet p, ObservableCollection<Planet> collection)
        {
            InitializeComponent();
            PageViewModel pvm = new PageViewModel(p);
            BindingContext = pvm;
            oCollection = collection;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            oCollection.Add((BindingContext as PageViewModel).ChangedPlanet());
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}