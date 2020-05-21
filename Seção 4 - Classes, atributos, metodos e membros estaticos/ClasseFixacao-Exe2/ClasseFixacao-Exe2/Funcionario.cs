using System.Globalization;

namespace ClasseFixacao_Exe2
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public void AumentarSalario(double Porcentagem)
        {
            SalarioBruto += (SalarioBruto * Porcentagem) / 100.00;

        }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

            
        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
