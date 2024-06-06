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

namespace Polygons
{
    public partial class Form1 : Form
    {

        Data data;
        Polygon tmpPoly = null;
        Color color = Color.FromArgb(0,0,255);
        private string FileName;
		Point mousePos = Point.Empty;


        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            newFile();
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

                    Invalidate(true);
                    return;
                }


                if (tmpPoly.isNearStart(e.Location) && tmpPoly.points.Count > 2)
                {
                    tmpPoly.isClosed = true;
                    tmpPoly.showStart = false;
                    data.addPoligone(tmpPoly);
                    tmpPoly = null;
                }else
                    tmpPoly.addPoint(e.Location);

                setTitle();

                Invalidate(true);

            }

           
        }


        private void newFile()
        {
            askToSave();
            data = new Data();
            FileName = "Untitled";
            setTitle();
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(tmpPoly != null)
            {
                if (tmpPoly.isNearStart(e.Location))
                {
                    tmpPoly.showStart = true;
                   
                }
                else
                {

                    if (tmpPoly.showStart)
                    {
                        tmpPoly.showStart = false;
                        
                    }
                }
            }
            Invalidate(true);
            mousePos = e.Location;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveFile();
        }

        private void setTitle()
        {
            this.Text = string.Format("Draw Polygons - {0}{1}", FileName, data.IsChanged ? "*" : "");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            askToSave();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Polygons doc file (*.pgn)|*.pgn";
            openFileDialog.Title = "Open polygons doc file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        data = (Data)formater.Deserialize(fileStream);
                    }
                    setTitle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file: " + FileName);
                    FileName = null;
                    return;
                }
                Invalidate(true);
            }
        }

        private void askToSave()
        {
            if (data != null && data.IsChanged)
            {
                DialogResult result = MessageBox.Show("Save document changes?", "Save document?", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    saveFile();
                }
            }
        }

        private void saveFile()
        {

            if (FileName == "Untitled")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Polygons doc file (*.pgn)|*.pgn";
                saveFileDialog.Title = "Save polygons doc";
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
                data.IsChanged = false;
                setTitle();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                data.Move(0, -5);
            }
            if (e.KeyCode == Keys.Down)
            {
                data.Move(0, 5);
            }
            if (e.KeyCode == Keys.Left)
            {
                data.Move(-5, 0);
            }
            if (e.KeyCode == Keys.Right)
            {
                data.Move(5, 0);
            }
            Invalidate(true);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            askToSave();
        }


        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            PolygonsCountTxt.Text = String.Format("# Polygons {0}", data.polygons.Count);
            mousePosTxt.Text = String.Format("{0}, {1}", mousePos.X, mousePos.Y);
        }
    }
}
