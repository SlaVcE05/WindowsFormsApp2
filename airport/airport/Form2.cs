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
    public partial class AddAirport : Form
    {
        public Airport airport { get; set; }


        public AddAirport()
        {
            InitializeComponent();
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            airport = new Airport(nameTxt.Text.Trim(), cityTxt.Text.Trim(), shortNameTxt.Text.Trim());
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

        private void cityTxt_Validating(object sender, CancelEventArgs e)
        {
            if (cityTxt.Text.Length > 0)
            {
                errorProvider.SetError(cityTxt, null);
                e.Cancel = false;
            }
            else
            {
                errorProvider.SetError(cityTxt, "Името не смее да биде празно");
                e.Cancel = true;
            }
        }

        private void shortNameTxt_Validating(object sender, CancelEventArgs e)
        {
            if (shortNameTxt.Text.Length != 3)
            {
                errorProvider.SetError(shortNameTxt, "Големината треба да биде 3 букви");
                e.Cancel = true;
            }
            else
            {
                foreach (char c in shortNameTxt.Text) 
                {
                    if (Char.IsDigit(c))
                    {
                        errorProvider.SetError(shortNameTxt, "Број не е дозволн");
                        e.Cancel = true;
                        return;
                    }

                    if (Char.IsLower(c) || Char.IsDigit(c)) 
                    {
                        errorProvider.SetError(shortNameTxt, "Сите букви треба да се големи");
                        e.Cancel = true;
                        return;
                    }
                }
                
                errorProvider.SetError(cityTxt, null);
                e.Cancel = false;
            }
        }
    }
}
