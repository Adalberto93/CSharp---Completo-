
namespace MembrosEstaticos_Exe1
{
    class ConversorDeMoeda
    {
        // IOF 6% = 0,06 --> 1,06;
        public static double Iof = 1.06;
        public static double DolarParaReal(double cotacao, double quantidade)
        {
            return (quantidade * cotacao) *  Iof;
        }
    }
}
