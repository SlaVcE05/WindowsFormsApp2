﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    [Serializable]
    public class Polygon
    {
        public List<Point> points { get; set; }
        Color color;
        public bool isClosed { get; set; }
        public bool showStart { get; set; }

        public Polygon(Color c) { 
            points = new List<Point>();

            color = c;
        }

        public void addPoint(Point p) 
        {
            points.Add(p);
        }

        public void Draw(Graphics g)
        {
            if (points.Count < 2)
                return;

            Brush brush = new SolidBrush(color);
            Pen pen = new Pen(brush);

            if (isClosed)
                g.FillPolygon(brush, points.ToArray());
            else
                g.DrawLines(pen, points.ToArray());

            if (showStart && points.Count > 2)
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawRectangle(pen, points[0].X - 5, points[0].Y - 5, 10, 10);
            }

            brush.Dispose();
            pen.Dispose();

        }

        public bool isNearStart(Point p)
        {
            return Math.Sqrt(Math.Pow(p.X - points[0].X, 2) + Math.Pow(p.Y - points[0].Y, 2)) < 5; 

        }

        public void Move(int x, int y)
        {
            for (int i = 0; i < points.Count; i++)
            {
                points[i] = new Point(points[i].X + x, points[i].Y + y);
            }
        }


    }
}
