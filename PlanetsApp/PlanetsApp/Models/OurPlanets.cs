using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace PlanetsApp.Models
{
    public class OurPlanets
    {
        public ObservableCollection<Planet> AllPlanets { get; set; }

        public OurPlanets()
        {
            AllPlanets = new ObservableCollection<Planet>();
            AllPlanets.Add(new Planet { Name = "Mercury", SolarSystemPosition = 1, AverageTemperature = 440 });
            AllPlanets.Add(new Planet { Name = "Venus", SolarSystemPosition = 2, AverageTemperature = 737 });
            AllPlanets.Add(new Planet { Name = "Earth", SolarSystemPosition = 3, AverageTemperature = 287 });
            AllPlanets.Add(new Planet { Name = "Mars", SolarSystemPosition = 4, AverageTemperature = 210 });
            AllPlanets.Add(new Planet { Name = "Jupiter", SolarSystemPosition = 5, AverageTemperature = -121 });
            AllPlanets.Add(new Planet { Name = "Saturn", SolarSystemPosition = 6, AverageTemperature = 0 });
            AllPlanets.Add(new Planet { Name = "Uranus", SolarSystemPosition = 7, AverageTemperature = 68 });
            AllPlanets.Add(new Planet { Name = "Neptune", SolarSystemPosition = 8, AverageTemperature = 53 });
        }
    }
}
