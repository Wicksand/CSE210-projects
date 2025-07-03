using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Reflection;

class Menu
{
    private int _score = 0;
    private int _input = 0;

    public Menu()
    {
        while (_input != 6)
        {
            _input = DisplayMenu();
        }
    }
    private int DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine($"You have {_score} points\n");
        Console.WriteLine("Menu Options:\n  1.  Create New Goal\n  2.  List Goals\n  3.  Save Goals\n  4.  Save Goals\n  5.  Record Event\n  6.  Quit");
        Console.Write("Select a choice from the menu: ");


        string read = Console.ReadLine();
        if (!int.TryParse(read, out int menuVal))
        {
            Console.Clear();
            Console.WriteLine("\n--------------------------------------------------------------------\nInvalid input, Please enter a number 1-6\n--------------------------------------------------------------------\n");
            return 0;
        }
        // int input = int.Parse(Console.ReadLine());
        switch (menuVal)
        {
            case 1:
                DisplayGoalMenu();
                break;
            case 2:
                Console.WriteLine("It worked");
                break;
            case 3:
                Console.WriteLine("It worked");
                break;
            case 4:
                Console.WriteLine("It worked");

                break;
            case 5:
                Console.WriteLine("It worked");

                break;
            case 6:

                break;
            default:
                Console.Clear();
                Console.WriteLine("\n--------------------------------------------------------------------\nInvalid input, Please enter a number 1-6\n--------------------------------------------------------------------\n");
                break;
        }
        return menuVal;
    }

    private void DisplayGoalMenu()
    {
        // string read = Console.ReadLine();
        // if (!int.TryParse(read, out int goalType))
        // {
        //     Console.Clear();
        //     Console.WriteLine("\n--------------------------------------------------------------------\nInvalid input, Please enter a number 1-3\n--------------------------------------------------------------------\n");
        //     return 0;
        // }
        Console.WriteLine("The types of Goals are:\n  1.  Simple Goal\n  2.  Eternal Goal\n  3.  Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        Console.ReadLine();
    } 

}