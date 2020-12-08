using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace PlanetsApp.Models
{
    public class OurPlanets
    {
        public ObservableCollection<Planet> AllObjects { get; set; }

        public OurPlanets()
        {
            AllObjects = new ObservableCollection<Planet>();
            AllObjects.Add(new Planet { Name = "Mercury", Type = "Planeta", AverageTemperature = 440 });
            AllObjects.Add(new Planet { Name = "Venus", Type = "Planeta", AverageTemperature = 737 });
            AllObjects.Add(new Planet { Name = "Earth", Type = "Planeta", AverageTemperature = 287 });
            AllObjects.Add(new Planet { Name = "Mars", Type = "Planeta", AverageTemperature = 210 });
            AllObjects.Add(new Planet { Name = "Jupiter", Type = "Planeta", AverageTemperature = -121 });
            AllObjects.Add(new Planet { Name = "Saturn", Type = "Planeta", AverageTemperature = 0 });
            AllObjects.Add(new Planet { Name = "Uranus", Type = "Planeta", AverageTemperature = 68 });
            AllObjects.Add(new Planet { Name = "Neptune", Type = "Planeta", AverageTemperature = 53 });
            AllObjects.Add(new Planet { Name = "Sun", Type = "Star", AverageTemperature = 1000000 });
            AllObjects.Add(new Planet { Name = "Moon", Type = "Druzice", AverageTemperature = 53 });
        }
    }
}
