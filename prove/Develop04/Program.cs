using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        int running = 0;
        while (running != 4)
        {
            running = DisplayMenu();
        }
    }
    private static int DisplayMenu()
    {
        Console.WriteLine("Menu Options:\n  1. Breathing Activity\n  2. Reflection Activity\n  3. Listing Activity\n  44. Quit");
        Console.WriteLine("Pick your activity.");
        string read = Console.ReadLine();
        if (!int.TryParse(read, out int input))
        {
            Console.Clear();
            Console.WriteLine("\n--------------------------------------------------------------------\nInvalid input, Please enter a number 1-4\n--------------------------------------------------------------------\n");
            return 0;
        }
        // int input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("case1");

                break;
            case 2:
                Console.Clear();

                break;
            case 3:
                Console.Clear();

                break;
            case 4:
                Console.Clear();

                break;
            default:
                Console.Clear();
                Console.WriteLine("\n--------------------------------------------------------------------\nInvalid input, Please enter a number 1-4\n--------------------------------------------------------------------\n");
                break;
        }
        return input;
    }
}