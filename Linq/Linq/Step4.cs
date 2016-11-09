using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;
using Extensions;

namespace Linq
{
    public class Step4
    {
        public void Execute()
        {
            Console.WriteLine("\nStep 4: Linq Select, var en anonieme types\n");

            IEnumerable<Location> cities = TravelOrganizer.PlacesVisited;
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // simpele transaformatie van collectie van int-s
            IEnumerable<int> newNumbers = numbers.Select(g => g + 1);
            PrintCollection("De gewijzigde lijst van getallen:", newNumbers);

            // transformatie van Location-s naar int-s
            IEnumerable<int> cityLengths = cities.Select(c => c.City.Length);
            PrintCollection("Lengte van de namen van de steden:", cityLengths);

            // transformatie naar een ander type, object initializer
            IEnumerable<CityDistance> cityDistances = cities.Select(
                c => new CityDistance
                {
                    Name = c.City,
                    Country = c.Country,
                    DistanceInKm = (int)(c.Distance * 1.61)
                });
            PrintCollection("Afstanden in km:", cityDistances);
            Console.WriteLine();

            // transformatie naar een anoniem type
            var anonymousCities = cities.Select(c => new
            {
                Name = c.City,
                c.Country,
                DistanceInKm = c.Distance * 1.61
            });
            PrintCollection("Anonieme types:", anonymousCities);
            Console.WriteLine();

            Console.WriteLine("Druk op enter om verder te gaan...");
            Console.ReadLine();
        }

        // generische methode PrintCities<T>
        public static void PrintCollection<T>(string title, IEnumerable<T> sequence)
        {
            Console.WriteLine();
            Console.WriteLine("----- {0} -----", title);
            if (!sequence.Any())
                Console.WriteLine("geen resultaten...");
            else
                foreach (var l in sequence)
                    Console.WriteLine(l);
            Console.WriteLine();
        }
    }
}
