using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Race
{
    public class Driver
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public bool isFirstDriver { get; set; }
        public List<Lap> laps;

        public Driver(string name, int age, bool isFirst)
        {
            Name = name;
            Age = age;
            isFirstDriver = isFirst;
            laps = new List<Lap>();
        }

        public void AddLap(Lap lap) 
        {
            laps.Add(lap);
        }

        public override string ToString()
        {
            return string.Format("{0}({1}) - {2}", Name, Age, isFirstDriver?"F":"S");
        }
    }
}
