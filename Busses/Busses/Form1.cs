using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Busses
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }



        private void addBusBtn_Click(object sender, EventArgs e)
        {
            NewBus dialog = new NewBus();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                bussesLB.Items.Add(dialog.bus);
                UpdateList();
            }
        }



        private void deleteBusBtn_Click(object sender, EventArgs e)
        {
            if (bussesLB.SelectedItem == null)
                return;

            if (MessageBox.Show("Дали сте сигурни дека сакате да го избришите автобусот", "Избриши абтобус", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bussesLB.Items.Remove(bussesLB.SelectedItem);
                UpdateList();

            }
            
            
        }

        private void addLineBtn_Click(object sender, EventArgs e)
        {
            Bus bus = bussesLB.SelectedItem as Bus;

            if (bus == null)
                return;

            NewLine dialog = new NewLine();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                bus.addLine(dialog.line);
                UpdateList();
            }
        }

        private void UpdateList()
        {
            linesLB.Items.Clear();
            Bus bus = bussesLB.SelectedItem as Bus;

           

            if (bus == null || bus.lines.Count == 0)
                return;


            int sum = 0;
            Line expLine = null;
            
            bus.lines.ForEach(line => { 
                
                linesLB.Items.Add(line);
                sum += line.price;
                if (expLine == null) 
                {
                    expLine = line;
                    return;
                }
                if (expLine.price < line.price)
                    expLine = line;


            });


            float avrg = sum / bus.lines.Count;

            if (expLine != null)
                expLineTxt.Text = expLine.ToString();
;            avrgPriceTxt.Text = avrg + "";
        }

        private void bussesLB_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateList();
        }
    }
}
