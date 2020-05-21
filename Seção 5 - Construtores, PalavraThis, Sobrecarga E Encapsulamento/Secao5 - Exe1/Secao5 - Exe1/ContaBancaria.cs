using System.Globalization;

namespace Secao5___Exe1
{
    class ContaBancaria
    {
        static double taxa = 5.00;
        public string Nome { get; set; }
        public int Conta { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string nome, int conta)
        {
            Nome = nome;
            Conta = conta;
        }

        public ContaBancaria(string nome, int conta, double saldo) : this(nome, conta)
        {
            Deposito (saldo);
        }

        public void Deposito (double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo = Saldo - valor - taxa;
        }


        public override string ToString()
        {
            return "Conta: " 
                 + Conta 
                 + ", Titular: " 
                 + Nome 
                 + ", Saldo: $ " 
                 + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
