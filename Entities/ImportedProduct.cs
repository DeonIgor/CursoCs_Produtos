using System.Globalization;

namespace Entities;

public class ImportedProduct : Product
{
    public Double CustomFee { get; set; }

    public ImportedProduct(string name, double price, double customFee) : base(name, price)
    {
        CustomFee = customFee;
    }

    public Double TotalPrice() 
    {
        return Price + CustomFee;
    }

    public override string PriceTag()
    {
        return Name + " $" + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
            + " (Custom Fee: $" + CustomFee + ')';
    }
}