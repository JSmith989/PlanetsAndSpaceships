using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastTwoPlanets = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(lastTwoPlanets);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            planetList.Add("Pluto");
            planetList.Remove("Pluto");

            var rockyPlanets = new List<string>();
            var terestrials = planetList.GetRange(0, 4);
            rockyPlanets.AddRange(terestrials);

            foreach (var planet in planetList)
            {
                Console.WriteLine($"{planet}");
            }
            Console.WriteLine("=========");
            foreach (var planet in rockyPlanets)
            {
                Console.WriteLine($"{planet}");
            }
            Console.WriteLine("=========");
            var satelliteDictionary = new Dictionary<string, List<string>>
            {
                { "Echo", new List<string>{"Neptune", "Mars", "Earth"} },
                { "Kepler", new List<string>{"Venus", "Mars", "Uranus", "Mercury"} },
                { "Suzaku", new List<string>{"Saturn", "Jupiter", "Uranus"} }
            };

            foreach (var planet in planetList)
            {
                var satellites = new List<string>();
                foreach (var (satellite, destination) in satelliteDictionary)
                {
                    if(destination.Contains(planet))
                    {
                        satellites.Add(satellite);
                    }
                }
                
                Console.WriteLine($"{planet}: {String.Join(",", satellites)}");
            }


        }
    }
}
