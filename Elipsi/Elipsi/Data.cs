using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elipsi
{
    [Serializable]
    public class Data
    {
        List<Ellipse> ellipses;


        public Data()
        {
            ellipses = new List<Ellipse>();
        }


        public void Draw(Graphics g)
        {
            foreach (Ellipse el in ellipses)
            {
                el.Draw(g);
            }
            
        }

        public void ChangeColor()
        {
            foreach (Ellipse el in ellipses)
            {
                el.ChangeColor();
            }
        }

        public void AddEllipse(Ellipse e)
        {
            ellipses.Add(e);
        }

        public int getCount()
        {
            return ellipses.Count;
        }

    }
}
