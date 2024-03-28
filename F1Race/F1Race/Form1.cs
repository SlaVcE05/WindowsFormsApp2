using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1Race
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addDriverBtn_Click(object sender, EventArgs e)
        {
            AddDriver driverForm = new AddDriver();
            if (driverForm.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                driversLB.Items.Add(driverForm.driver);
                UpdateData();
            }
        }

        private void deleteDriver_Click(object sender, EventArgs e)
        {
            if (driversLB.SelectedIndex == -1)
                return;

            if (MessageBox.Show("Дали сте сигурни?", "Избриши возач", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                driversLB.Items.Remove(driversLB.SelectedItem);
                UpdateData();
            }
        }

        private void secNum_ValueChanged(object sender, EventArgs e)
        {
            if (secNum.Value == 60) 
            {
                secNum.Value = 0;
                minNum.Value += 1;
            }

            if (secNum.Value == -1 && minNum.Value > 0)
            {
                secNum.Value = 59;
                minNum.Value -= 1;
            }
        }

        private void addLapBtn_Click(object sender, EventArgs e)
        {
            Driver driver = driversLB.SelectedItem as Driver;
            driver.AddLap(new Lap(((int)minNum.Value), ((int)secNum.Value)));
            UpdateData();
        }

        private void UpdateData()
        {

            lapsLB.Items.Clear();
            bestLapTxt.Clear();

            if (driversLB.SelectedIndex == -1)
                return;

            Driver driver = driversLB.SelectedItem as Driver;

            if (driver.laps.Count == 0)
                return;

            Lap bestLap = null;

            foreach (Lap lap in driver.laps) 
            {
                if (lap.getTimeInSecunds() >= timeNum.Value) 
                {
                    lapsLB.Items.Add(lap);

                    if (bestLap == null) 
                    {
                        bestLap = lap;
                        continue;
                    }
                    if (bestLap.getTimeInSecunds() > lap.getTimeInSecunds())
                        bestLap = lap;

                }
            }

            bestLapTxt.Text = bestLap!= null?bestLap.ToString():"";

        }

        private void driversLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void timeNum_ValueChanged(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}
