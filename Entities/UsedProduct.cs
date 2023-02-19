using System.Globalization;

namespace Entities;

public class UsedProduct : Product
{
    public DateTime ManufectureDate { get; set; }

    public UsedProduct(string name, double price, DateTime manufectureDate) : base(name, price)
    {
        ManufectureDate = manufectureDate;
    }
    public override string PriceTag()
    {
        return Name + " (Used) $" + Price.ToString("F2", CultureInfo.InvariantCulture)
            + " (Manufecture Date: " + ManufectureDate.ToString("dd/MM/yyyy") + ')';
    }
}