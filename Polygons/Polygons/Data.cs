using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    public class Data
    {
        List<Polygon> polygons { get; set; }

        public Data()
        {
            polygons = new List<Polygon>();

        }

        public void Draw(Graphics g)
        {
            foreach (var polygon in polygons) 
            {
                polygon.Draw(g);
            }
        }

        public void addPoligone(Polygon p)
        {
            polygons.Add(p);
        }



    }
}
