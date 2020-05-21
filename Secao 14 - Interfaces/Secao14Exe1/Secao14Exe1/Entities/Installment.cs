using System;
using System.Collections.Generic;
using System.Text;

namespace Secao14Exe1.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment() 
        {
        }
        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

    }
}
