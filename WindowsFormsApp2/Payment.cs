using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Payment
    {
        public decimal amount { get; set; }

        public Payment(decimal amount)
        {
            this.amount = amount;
        }

        public override string ToString()
        {
            return $"Уплата: {amount} Провизија: {Fee()} Вкупно: {amount + Fee()}";
        }

        internal decimal Fee()
        {
            return Math.Round(amount * 0.0114m);
        }
        
    }
}
