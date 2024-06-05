using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elipsi
{
    public partial class Form1 : Form
    {

        Data data;
        Ellipse tmpEllipse = null;
        string FileName;


        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            newDoc();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            data.Draw(g);
            if (tmpEllipse != null)
            {
                tmpEllipse.Draw(g);
            }

        }



        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //if (tmpEllipse == null)
            //{
            //    tmpEllipse = new Ellipse(e.Location,0,0);
            //}
            //else
            //{
            //    tmpEllipse.inFinished = true;
            //    ellipses.Add(tmpEllipse);
            //    tmpEllipse = null;
            //    ellipsesCountTxt.Text = ellipses.Count.ToString();
            //}
            //Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (tmpEllipse == null)
                return;

            int width = e.Location.X - tmpEllipse.pos.X;
            int height = e.Location.Y - tmpEllipse.pos.Y;

            tmpEllipse.width = width;
            tmpEllipse.height = height;

            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            data.ChangeColor();
            Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            tmpEllipse = new Ellipse(e.Location, 0, 0);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (tmpEllipse == null)
                return;

            tmpEllipse.inFinished = true;
            data.AddEllipse(tmpEllipse);
            tmpEllipse = null;
            ellipsesCountTxt.Text = String.Format("Elipses: {0} ", data.getCount().ToString());
            Invalidate();
        }


        private void newDoc()
        {
            data = new Data();
            FileName = "Untitled";
        }

        private void saveFile()
        {
            if (FileName == "Untitled")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Ellipse doc file (*.elli)|*.elli";
                saveFileDialog.Title = "Save Ellipse data";
                saveFileDialog.FileName = FileName;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog.FileName;
                }
            }
            if (FileName != null)
            {
                using (FileStream fileStream = new FileStream(FileName, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, data);

                }
            }

        }
        private void openFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Ellipse doc file (*.elli)|*.elli";
            openFileDialog.Title = "Open Ellipse data";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    IFormatter formatter = new BinaryFormatter();
                    data = (Data)formatter.Deserialize(stream);
                }
            }
            ellipsesCountTxt.Text = String.Format("Elipses: {0} ", data.getCount().ToString());
        }




        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newDoc();
			Invalidate();
        }

    }
}