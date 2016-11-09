namespace Linq.Models
{

    public class CityDistance
    {
        public string Country { get; set; }
        public string Name { get; set; }
        public int DistanceInKm { get; set; }

        public override string ToString()
        {
            return string.Format("{0} in {1} at {2} km distance", Name, Country, DistanceInKm);
        }
    }
}