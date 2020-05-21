
using System;
using System.Globalization;

namespace Secao14Exe1.Services
{
    class PayPalTaxService 
    {
        public double AmountBase { get; set; }
        public int NumberInstallment { get; set; }

        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public PayPalTaxService(double amountBase, int numberInstallment)
        {
            AmountBase = amountBase;
            NumberInstallment = numberInstallment;
        }

        public double AmountFinish()
        {
            // Juros Simples da Parcela --> 1% a cada parcela
            double amountPartial;
            amountPartial = AmountBase + (AmountBase * MonthlyInterest * NumberInstallment);

            // Taxa de Pagamento --> 2 % na parcela 
            return  amountPartial += amountPartial * FeePercentage;
        }
    }
}

