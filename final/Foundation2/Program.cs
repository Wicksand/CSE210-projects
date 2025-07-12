using System;

class Program
{
    static void Main(string[] args)
    {
        //-----------------------------Example orders ---------------------------------
        Customer cust1 = new Customer("John Wane", "123 Main St", "Springfield", "IL", "USA");
        List<Product> products1 = new List<Product>()
        {
            new Product("Can of Spam", "A123", 5.00f, 2),
            new Product("Can-o Cupcake", "B456", 10.00f, 1)
        };
        Order order1 = new Order(cust1, products1);

        Customer cust2 = new Customer("Timmy Bob", "345 Normal Blv", "East Vally", "Vancuvor", "Canada");
        List<Product> products2 = new List<Product>()
        {
            new Product("2 Left Shoes", "C123", 15.00f, 6),
            new Product("Watch", "D456", 10.00f, 4)
        };
        Order order2 = new Order(cust2, products2);



        //----------------------------------------------------------------------------

        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine($"Shipping Label:\n{order1.ShippingLabel()}");
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");

        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine($"Shipping Label:\n{order2.ShippingLabel()}");
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}