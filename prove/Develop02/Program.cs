using System;

class Program
{
    static int DisplayMenu()
    {
        int responce = 0;
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("ParallelLoopState select one of the following choicde");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What Would you like to do? ");
        responce = int.Parse(Console.ReadLine());
        return responce;
    }
    static void Main(string[] args)
    {
        int input = 0;

        while (input != 5)
        {
            input = DisplayMenu();
            Console.WriteLine(input);
            
        }

    }
}