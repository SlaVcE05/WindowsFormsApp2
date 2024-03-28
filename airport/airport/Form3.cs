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
    public partial class AddDestination : Form
    {
        public Destination destination { get; set; }

        public AddDestination()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            destination = new Destination(nameTxt.Text.Trim(), ((int)distanceNum.Value), ((int)priceNum.Value));
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void nameTxt_Validating(object sender, CancelEventArgs e)
        {
            if (nameTxt.Text.Length == 0)
            {
                errorProvider.SetError(nameTxt, "Името не смее да биде празно");
                e.Cancel = true;
                return;
            }

            errorProvider.SetError(nameTxt, null);
            e.Cancel = false;
        }
    }
}
