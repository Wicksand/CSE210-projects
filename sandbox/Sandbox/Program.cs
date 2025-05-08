using System;
using System.Security.Cryptography;

class Circle
{
    private double _radius;

    public void SetRadius(double radius){
        if(radius < 0){
           Console.WriteLine("Error");
           return;
        }
            double _radius = radius;

    }
    public double GetRadius(){
        return _radius;
    }
    public double GetArea(){
        return Math.PI * _radius *_radius;
    }

}

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
        Circle myCircle = new Circle();
        myCircle.SetRadius(10);
        Console.WriteLine($"{myCircle.GetRadius()}");
        Console.WriteLine($"{myCircle.GetArea()}");

        Circle myCircle2 = new circle();
        myCircle2.SetRadius(20);
        Console.WriteLine($"{myCircle.GetRadius()}");
        Console.WriteLine($"{myCircle.GetArea()}");
    }
}