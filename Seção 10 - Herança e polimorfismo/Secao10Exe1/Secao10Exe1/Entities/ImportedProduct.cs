using System.Globalization;

namespace Secao10Exe1.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        double totalPrice = 0.0;
        public ImportedProduct() 
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice() 
        {
            return totalPrice = Price + CustomsFee;
        }

        public override string PriceTag()
        {
            totalPrice = TotalPrice();
            string msg = Name + " $ " + totalPrice.ToString("F2", CultureInfo.InvariantCulture)
                     + $" (Customs fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";  
            return msg;
        }
    }
}
