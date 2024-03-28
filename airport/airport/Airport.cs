using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airport
{
    public class Airport
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string ShortName { get; set; }
        public List<Destination> destinations;

        public Airport(String name, String city, string shortNmae) 
        {
            Name = name;
            City = city;
            ShortName = shortNmae;
            destinations = new List<Destination>();
        }

        public void addDestionatio(Destination destination) 
        {
            
            destinations.Add(destination);
        }

        public override string ToString()
        {
            return $"{ShortName} - {Name} - {City}";
        }

    }
}
