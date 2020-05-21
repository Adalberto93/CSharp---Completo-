using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Secao14Exe1.Services;

namespace Secao14Exe1.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public int Quantity { get; set; }
        public List<Installment> Installments { get; set; } = new List<Installment>();

        public Contract(int number, DateTime date, double value, int quantity)
        {
            Number = number;
            Date = date;
            Value = value;
            Quantity = quantity;
        }

        public void CalculateInstalment()
        {
            double baseValue = 0.0;
            baseValue = Value / Quantity;

            for (int i = 1; i <= Quantity; i++ )
            {
               InstallmentService installmentService = new InstallmentService(Date, baseValue, i);
               DateTime dateDue = installmentService.CalculateDue();
               double amountInstallment = installmentService.CalculateAmount();

               Installment parcel = new Installment(dateDue, amountInstallment);

               AddInstallment(parcel);
            }
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
        public override string ToString()
        {
            StringBuilder msg = new StringBuilder();
            msg.AppendLine("Installments:");
            foreach (Installment obj in Installments)
            {
                msg.Append(obj.DueDate.ToString("dd/MM/yyyy"));
                msg.Append(" - ");
                msg.AppendLine(obj.Amount.ToString("F2", CultureInfo.InvariantCulture));
            }
            return msg.ToString();
        }

    }
}
