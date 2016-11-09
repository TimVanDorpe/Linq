namespace Linq.Models
{

    public class Location
    {
        public string Country { get; set; }
        public string City { get; set; }
        public int Distance { get; set; }
        public override string ToString()
        {
            return string.Format("{0} in {1} at {2} miles distance", City, Country, Distance);
        }
    }
}
