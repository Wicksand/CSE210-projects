using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        int running = 0;
        while (running != 4){
            running = DisplayMenu();
        }
    }
    private static int DisplayMenu()
    {
        Console.WriteLine("Pick your activity.");
        // string read = Console.ReadLine();
        // if (read <){

        // }
        int input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.WriteLine("case1");

                break;
            case 2:

                break;
            case 3:
                break;
            case 4:
            
                break;
            default:

                break;
        }
        return input;
    }
}