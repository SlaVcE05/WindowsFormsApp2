using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{

    [Serializable]
    public class Data
    {
        public List<Polygon> polygons { get; set; }
        public bool IsChanged { get; set; }

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
            IsChanged = true;
        }

        public void Move(int x, int y)
        {
            foreach(var polygon in polygons)
            {
                polygon.Move(x, y);
            }
        }



    }
}
