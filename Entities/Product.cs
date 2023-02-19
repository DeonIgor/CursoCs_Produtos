using System.Globalization;

namespace Entities;

public class Product
{
    public String Name { get; set; }
    public Double Price { get; set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public virtual String PriceTag() {
        return Name + " $" + Price.ToString("F2", CultureInfo.InvariantCulture);
    }  
}