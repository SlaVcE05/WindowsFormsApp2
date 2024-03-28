using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Student
    {
        public string index { get; set; }
        public string name { get; set; }

        public List<Payment> Payments { get; set; }

        public Student (string index, string name)
        {
            this.index = index;
            this.name = name; 
            this.Payments = new List<Payment> ();
        }

        public override string ToString()
        {
            return $"{index} {name}";
        }

        public void addPayment(Payment payment)
        {
            Payments.Add(payment);
        }

        public decimal TotalAmount()
        {
            decimal totalAmount = 0m;
            for (int i = 0; i < Payments.Count; i++)
            {
                totalAmount += Payments[i].amount;
            }
            return totalAmount;
        }

        public decimal TotalFee()
        {
            decimal totalFee = 0m;
            for (int i = 0; i < Payments.Count; i++)
            {
                totalFee += Payments[i].Fee();
            }
            return totalFee;
        }

        public string Details()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString()).Append("\n");
            for (int i = 0; i < Payments.Count; i++) {
                sb.Append(i + 1).Append(". ").Append(Payments[i].ToString()).Append("\n");
            }
            sb.Append("Вкупно уплати: ").Append(TotalAmount()).Append("\n");
            sb.Append("Вкупно провизија: ").Append(TotalFee());
            return sb.ToString();
        }
    }
}
