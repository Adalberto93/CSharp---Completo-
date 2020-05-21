namespace Secao10Exe2.Entities
{
    class Individual : Person
    {
        public double HealthExpenditure { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditure) : base(name, anualIncome)
        {
            HealthExpenditure = healthExpenditure;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000)
            {
                return (AnualIncome * 0.15) - (HealthExpenditure * 0.5);
            }
            else
            {
                return (AnualIncome * 0.25) - (HealthExpenditure * 0.5);
            }
        }
    }
}
