using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddAirport airportForm = new AddAirport();
            if (airportForm.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                airportsLB.Items.Add(airportForm.airport);
                updateDestinations();
            }
        }

        private void addDestinationBtn_Click(object sender, EventArgs e)
        {
            if (airportsLB.SelectedIndex == -1)
                return;

            AddDestination destinationForm = new AddDestination();
            if (destinationForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                (airportsLB.SelectedItem as Airport).addDestionatio(destinationForm.destination);
                updateDestinations();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (airportsLB.SelectedIndex == -1)
                return;

            if(MessageBox.Show("Дали сте сигурни?", "Избриши аеродром", MessageBoxButtons.YesNo) == DialogResult.Yes)
            { 
                airportsLB.Items.Remove(airportsLB.SelectedItem);
            }
        }


        private void airportsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDestinations();
        }



        private void updateDestinations()
        {
            destinationLB.Items.Clear();
            mostExpTxt.Clear();
            avrgDistanceTxt.Clear();

            Airport selected = airportsLB.SelectedItem as Airport;
            if (selected == null || selected.destinations.Count == 0) 
            {
                return;
                
            }

            int sum = 0;
            Destination mostExp = null;

            foreach (Destination destination in selected.destinations)
            {
                sum += destination.Distance;

                if (mostExp == null) 
                {
                    mostExp = destination;
                }else if(destination.Price > mostExp.Price)
                    mostExp = destination;

                destinationLB.Items.Add(destination);
            }

            avrgDistanceTxt.Text = ((Double) sum / selected.destinations.Count).ToString();

            mostExpTxt.Text = mostExp.ToString();

        }
    }
}
