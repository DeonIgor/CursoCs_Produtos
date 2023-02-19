using Entities;
internal class Program
{
    public static void Main(String[] args) 
    {
        List<Product> Products = new List<Product>();

        Products.Add(new Product("Notebook", 1100));
        Products.Add(new ImportedProduct("Tablet", 260, 20));
        Products.Add(new UsedProduct("Iphone", 400, DateTime.Parse("15/03/2017")));

        System.Console.WriteLine("PRICE TAGS:");
        foreach(Product prod in Products){
            System.Console.WriteLine(prod.PriceTag());
        }
    }
}