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
    public partial class NewBus : Form
    {
        public Bus bus { get; set; }

        public NewBus()
        {
            InitializeComponent();
        }
       

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text.Trim().Equals("") || registarationTxt.Text.Trim().Equals(""))
                return;
            

            bus = new Bus(registarationTxt.Text, nameTxt.Text, isLocalCB.Checked);
            DialogResult = System.Windows.Forms.DialogResult.OK;

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void nameTxt_Validating(object sender, CancelEventArgs e)
        {
            if (nameTxt.Text.Length == 0)
            {
                errorProvider1.SetError(nameTxt, "Името не смее да биде празно");
                e.Cancel = true;
                return;
            }

            errorProvider1.SetError(nameTxt, null);
            e.Cancel = false;
        }

        private void registarationTxt_Validating(object sender, CancelEventArgs e)
        {
            if (!registarationTxt.Text.Any(char.IsDigit))
            {
                errorProvider1.SetError(registarationTxt, "Дозволено е само цифри");
                e.Cancel = true;
                return;
            }

            if (registarationTxt.Text.Length != 4)
            {
                errorProvider1.SetError(registarationTxt, "Дезболено е само 4 цифри");
                e.Cancel = true;
                return;
            }

            errorProvider1.SetError(registarationTxt, null);
            e.Cancel = false;
        }


    }
}
