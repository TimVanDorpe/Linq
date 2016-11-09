using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Models;

namespace Linq
{
    public class Step6
    {
        public void Execute()
        {
            Console.WriteLine("\nStep 6 : Exercises\n");
            IEnumerable<Location> placesVisited = TravelOrganizer.PlacesVisited;

            // De gemiddelde afstand van de steden
            Console.WriteLine("Gemiddelde afstand van de steden is {0:0} miles", placesVisited.Average(p => p.Distance));

            // De afstand van de verste stad
            Console.WriteLine("De verste stad ligt op {0:0} miles", placesVisited.Max(p => p.Distance));

            // De verste stad in de USA
            Console.WriteLine("De verste stad in de USA is {0}", placesVisited.OrderByDescending(p => p.Distance).FirstOrDefault(p => p.Country == "USA"));

            // Geef de namen van de landen met steden die niet in de USA liggen en op minder dan 4600 miles afstand liggen
            IEnumerable<string> nearbyNonUSACities =
                placesVisited.Where(p => p.Country != "USA" && p.Distance < 4600).Select(p => p.City).Distinct();
            Step4.PrintCollection("Dichte steden buiten de USA", nearbyNonUSACities);

            // Een gesorteerde lijst van alle landen (elk land komt slechts 1 keer voor in de lijst)
            IEnumerable<string> countries = placesVisited.Select(p => p.Country).Distinct().OrderBy(c => c);
            Step4.PrintCollection("Alle landen:", countries);

            // Maak een lijst van anonieme objecten die de properties City en InUSA hebben.
            // InUSA staat op true voor een city binnen de USA, anders op false
            var cityInfo = placesVisited.Select(p => new
            {
                p.City,
                InUSA = p.Country == "USA"
            });
            Console.WriteLine("Welke steden liggen in de USA?");
            Step4.PrintCollection("Alle landen in de lijst:", cityInfo);

            // Maak een array van CityDistance objecten voor alle Locations die in de USA liggen
            CityDistance[] cityDistances = placesVisited.Where(p => p.Country == "USA").
                Select(p => new CityDistance
                {
                    Name = p.City,
                    Country = p.Country,
                    DistanceInKm = (int)(p.Distance * 1.6)
                }).ToArray();
            Step4.PrintCollection("CityDistances voor steden in USA:", cityDistances);

            Console.WriteLine("Druk op enter om verder te gaan...");
            Console.ReadLine();

        }
    }
}
