namespace Secao10Exe2.Entities
{
    class Company : Person
    {
        public int QtdEmployees { get; set; }

        public Company(string name, double anualIncome, int qtdEmployees) : base(name, anualIncome)
        {
            QtdEmployees = qtdEmployees;
        }

        public override double Tax()
        {
            if (QtdEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }




}
