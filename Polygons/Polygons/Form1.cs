using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polygons
{
    public partial class Form1 : Form
    {

        Data data;
        Polygon tmpPoly = null;
        Color color = Color.FromArgb(0,0,255);

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            data = new Data();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            data.Draw(g);
            if(tmpPoly != null)
            {
                tmpPoly.Draw(g);
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            if(e.Button == MouseButtons.Left)
            {
                if(tmpPoly == null)
                {
                    tmpPoly = new Polygon(color);
                    tmpPoly.addPoint(e.Location);

                    Invalidate();
                    return;
                }


                if (tmpPoly.isNearStart(e.Location))
                {
                    tmpPoly.isClosed = true;
                    data.addPoligone(tmpPoly);
                    tmpPoly = null;
                }else
                    tmpPoly.addPoint(e.Location);
                
                Invalidate();

            }

           
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(tmpPoly != null)
            {
                if (tmpPoly.isNearStart(e.Location))
                {
                    tmpPoly.showStart = true;
                    Invalidate();
                }
                else
                {

                    if (tmpPoly.showStart)
                    {
                        tmpPoly.showStart = false;
                        Invalidate();
                    }
                }
            }
        }
    }
}
