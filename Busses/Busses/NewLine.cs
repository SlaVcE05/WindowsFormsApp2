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
    public partial class NewLine : Form
    {

        public Line line { get; set; }

        public NewLine()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (destinationTxt.Text.Trim().Length == 0)
                return;

            line = new Line(destinationTxt.Text, (int) hourNum.Value, (int) minNum.Value, (int) priceNum.Value);
            DialogResult = System.Windows.Forms.DialogResult.OK;

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void destinationTxt_Validating(object sender, CancelEventArgs e)
        {
            if (destinationTxt.Text.Length == 0)
            {
                errorProvider1.SetError(destinationTxt, "Дестинацијата не смее да биде празна");
                e.Cancel = true;
                return;
            }

            errorProvider1.SetError(destinationTxt, null);
            e.Cancel = false;
        }
    }
}
