using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busses
{
    public class Line
    {
        String destination { get; set; }
        public int hour { get; set; }
        public int minute { get; set; }
        public int price { get; set; }

        public Line(string destination, int h, int min, int price) 
        {
            this.destination = destination;
            this.hour = h;
            this.minute = min;
            this.price = price;
        }


        public override string ToString()
        {
            return $"{hour}:{minute} - {destination} - {price} Ден.";
        }

    }
}
