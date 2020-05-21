using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace ClasseFixacao_Exe3
{
    class Aluno
    {
        public string Nome;
        public double N1, N2, N3;

        public double CalcularNota()
        {
            return N1 + N2 + N3;
        }

        public void AvaliarNota(double Nota) 
        {
            double faltaram = 0.00;

            if (Nota >= 60.00)
            {
                Console.WriteLine("APROVADO");
            }
            else 
            {
                faltaram = 60.00 - Nota;
                Console.WriteLine("REPROVADO");
                Console.WriteLine("Faltaram {0} pontos", faltaram);
            }
        }
    }
}
