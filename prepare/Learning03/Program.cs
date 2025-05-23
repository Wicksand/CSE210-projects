using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction myFraction1 = new Fraction();
        Console.WriteLine(myFraction1.GetFractionString());
        Console.WriteLine(myFraction1.GetFractionValue());

        Fraction myFraction2 = new Fraction(5);
        Console.WriteLine(myFraction2.GetFractionString());
        Console.WriteLine(myFraction2.GetFractionValue());

        Fraction myFraction3 = new Fraction(3, 4);
        Console.WriteLine(myFraction3.GetFractionString());
        Console.WriteLine(myFraction3.GetFractionValue());

        Fraction myFraction4 = new Fraction(1, 3);
        Console.WriteLine(myFraction4.GetFractionString());
        Console.WriteLine(myFraction4.GetFractionValue());
    }
}