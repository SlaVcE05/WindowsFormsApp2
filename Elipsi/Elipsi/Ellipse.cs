using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elipsi
{
    [Serializable]
    public class Ellipse
    {
        public Point pos { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public Color color { get; set; }
        public bool inFinished { get; set; }

        public Ellipse(Point pos, int width, int height)
        {
            this.pos = pos;
            this.width = width;
            this.height = height;
            Random r = new Random();
            this.color = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
        }


        public void Draw(Graphics g)
        {

            if (!inFinished)
            {
                Pen pen = new Pen(Color.Black,3);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                g.DrawEllipse(pen, pos.X, pos.Y, width, height);
                return;
            }
            

            Brush brush = new SolidBrush(color);
            g.FillEllipse(brush, pos.X, pos.Y, width, height);
        }

        public void ChangeColor()
        {
            int R = color.R;
            int G = color.G;
            int B = color.B;

            R += 5;
            G += 10;
            B += 15;    
            R = R % 256;
            G = G % 256;
            B = B % 256;

            color = Color.FromArgb(R,G,B);
        }

    }

}
