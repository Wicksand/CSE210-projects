using System;

class Program
{
    static void Main(string[] args)
    {
        Address add = new Address("3369 Arlington Ave", "Eugene", "OR", "Cannada");//(name, ID, price, quantity)
        Console.WriteLine(add.Display());
    }
}