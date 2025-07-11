using System;
using System.Diagnostics.Tracing;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;

class Program
{

    static void TestByRef(int x, string name) {
        x++;
        name += " This is a string addition.";
        Console.WriteLine($"in Testbyref: {x}, {name}");
    }
    static void Main(string[] args)
    {
        // Console.WriteLine("yo bob");

        // DateTime currentTime = DateTime.Now;
        // DateTime endTime = currentTime.AddSeconds(20);

        // string animation = ":D:(";
        // string animationString2 = "|/-|-\\";
        // int index = 0;

        // while (DateTime.Now < endTime)
        // {
        //     Console.Write(animationString2[index++ % animationString2.Length]);
        //     Thread.Sleep(500);
        //     Console.Write("\b");
        // }

        // while (DateTime.Now < endTime)
        // {
        //     Console.Write(animation[0..2]);
        //     Thread.Sleep(500);
        //     Console.Write("\b\b");
        //     Console.Write(animation[2..]);
        //     Thread.Sleep(500);
        //     Console.Write("\b\b");}

        int x = 10;
        string name = "bob";
        TestByRef(x, name);
        Console.WriteLine($"In Main:{x}, {name}");
    }
}


// class Program
// {
//     static void Main(string[] args)
//     {
//         Circle myCircle = new Circle();
//         // myCircle.SetRadius(10);
//         // Console.WriteLine($"{myCircle.GetRadius()}");
//         // Circle myCircle2 = new Circle();
//         // myCircle2.SetRadius(20);
//         Console.WriteLine($"{myCircle2.GetRadius()}");

//         Console.WriteLine($"{myCircle.GetArea()}");
//         Console.WriteLine($"{myCircle2.GetArea()}");

//         Cylinder myCylinder = new Cylinder();
//         myCylinder.SetHeight(10);
//         myCylinder.SetCircle(myCircle);
//         Console.WriteLine($"{myCylinder.GetVolume()}");
//     }
// }
