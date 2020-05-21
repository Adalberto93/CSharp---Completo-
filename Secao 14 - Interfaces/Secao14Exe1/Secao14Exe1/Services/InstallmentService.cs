using System;
using Secao14Exe1.Entities;
using Secao14Exe1.Services;

namespace Secao14Exe1.Services
{
    class InstallmentService
    {
        public DateTime DateContract { get; set; }

        public double AmountBase { get; set; }
        public int NumberInstallment { get; set; }

        public InstallmentService(DateTime dateContract, double amountBase, int numberInstallment)
        {
            DateContract = dateContract;
            AmountBase = amountBase;
            NumberInstallment = numberInstallment;
        }

        public DateTime CalculateDue()
        {
            return DateContract.AddMonths(NumberInstallment);
        }

        public double CalculateAmount()
        {
            PayPalTaxService payPal = new PayPalTaxService(AmountBase, NumberInstallment);
            return payPal.AmountFinish();
        }
    }
}
