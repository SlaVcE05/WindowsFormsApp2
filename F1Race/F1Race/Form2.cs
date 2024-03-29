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
    public partial class AddDriver : Form
    {
        public Driver driver { get; set; }

        public AddDriver()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (nameTxt.Text.Length == 0)
            {
                errorProvider.SetError(nameTxt, "Името не смее да биде празно!!");
                e.Cancel = true;
                return;
            }

            errorProvider.SetError(nameTxt, null);
            e.Cancel = false;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            driver = new Driver(nameTxt.Text.Trim(), ((int)ageNum.Value), firstCB.Checked);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

    }
}
