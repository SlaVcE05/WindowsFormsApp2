using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AddStudent : Form
    {
        public Student student { get; set; }
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            student = new Student(tbIndex.Text,tbName.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }

        private void tbIndex_Validating(object sender, CancelEventArgs e)
        {
            if (tbIndex.Text.Length == 6)
            {
                errorProvider1.SetError(tbIndex, null);
                e.Cancel = false;
            }else
            {
                errorProvider1.SetError(tbIndex, "Индексот треба да содржи 6 знаци!");
                e.Cancel = true;
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text.Length > 0)
            {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;
            }
            else
            {
                errorProvider1.SetError(tbName, "Името не треба да е празно!");
                e.Cancel = true;
            }
        }
    }
}
