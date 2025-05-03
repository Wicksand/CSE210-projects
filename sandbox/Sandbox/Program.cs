using System;
using System.Security.Cryptography;

class Program
{
    static double AddNumbers(double a, double b)
    {
        return a + b;
    }

    static void DisplayGreeting()
    {
        Console.WriteLine("hi tim");
    }
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Sandbox World!");
        // Console.Write("Please input your name:");
        // string firstName = Console.ReadLine();
        // Console.WriteLine($"Your first name is: {firstName}");

        // Random randomGenerator = new Random();
        // int randomNumber = new RandomNumberGenerator(1,100);

        // List<int> myNumbers = new List<int>();
        // myNumbers.Add(50);
        // myNumbers.Add(51);
        // myNumbers.Add(52);

        // foreach(int i in myNumbers)
        // {
        //     Console.WriteLine(i);
        // }
        double total = AddNumbers(50,45);
        Console.WriteLine($"The total is:{total}");

        // bool done = false;
        // do{
        //     Console.WriteLine("");
        // }while(!done);


    }
}