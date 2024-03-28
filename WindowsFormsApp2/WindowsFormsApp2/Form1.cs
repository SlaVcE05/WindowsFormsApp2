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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudent AddStudent = new AddStudent();
            if (AddStudent.ShowDialog() == DialogResult.OK)
            {
                lbStudents.Items.Add(AddStudent.student);
            }
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            if (lbStudents.SelectedItems.Count > 0)
            {
                Student student = lbStudents.SelectedItem as Student;
                student.addPayment(new Payment(nudValue.Value));
                UpdateLabel();
                UpdateStudentWithMaxPayment();
                nudValue.Value = 0;
            }
        }

        private void lbStudents_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateLabel();
            nudValue.Value = 0;
        }

        private void UpdateLabel()
        {
            if (lbStudents.SelectedItems.Count > 0)
            {
                Student student = lbStudents.SelectedItem as Student;
                lblSelectedStudent.Text = student.Details();
            }
        }

        private void UpdateStudentWithMaxPayment()
        {
            Student max = lbStudents.Items[0] as Student;
            foreach (var item in lbStudents.Items)
            {
                Student student = item as Student;
                if (student.TotalAmount() > max.TotalAmount())
                {
                    max = student;
                }
            }
            tbMax.Text = max.ToString();
        }

        private void btnRemovePayments_Click(object sender, EventArgs e)
        {
            if (lbStudents.SelectedItems.Count > 0)
            {
                MessageBox.Show("Дали сте сигурни дека сакате да ги избришете уплатите ?", "Бришење уплати", MessageBoxButtons.YesNo);
                Student selectedStudent = lbStudents.SelectedItem as Student;
                selectedStudent.Payments = new List<Payment>();
                UpdateLabel();
                UpdateStudentWithMaxPayment();
            }
        }
    }
}
