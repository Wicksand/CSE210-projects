using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Reflection;
using Microsoft.VisualBasic;

class Menu
{
    private int _input = 0;
    new Goals myGoals = new Goals();

    public Menu()
    {
        while (_input != 6)
        {
            _input = DisplayMenu();
        }
    }
    private int DisplayMenu()
    {
        Console.WriteLine($"\n\nYou have {myGoals.GetPointsTotal()} points\n");
        Console.WriteLine("Menu Options:\n  1.  Create New Goal\n  2.  List Goals\n  3.  Save Goals\n  4.  Load Goals\n  5.  Record Event\n  6.  Quit");
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
            case 1: // make a goal
                DisplayGoalMenu();
                break;
            case 2: // list goals
                myGoals.DisplayGoals();
                break;
            case 3:// save goals
                Console.WriteLine("It worked");
                break;
            case 4: // load goals
                Console.WriteLine("It worked");

                break;
            case 5: // record event
                myGoals.RecordGoalEvent();

                break;
            case 6: //quit

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
        bool waiting = true;
        while (waiting)
        {
            Console.WriteLine("\nThe types of Goals are:\n  1.  Simple Goal\n  2.  Eternal Goal\n  3.  Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");

            string read = Console.ReadLine();
            if (!int.TryParse(read, out int goalType))
            {
                Console.WriteLine("\n--------------------------------------------------------------------\nInvalid input, Please enter a number 1-3\n--------------------------------------------------------------------\n");
            }
            else
            {
                switch (goalType)
                {

                    case 1: // simple
                        SimpleGoal mySimple = new SimpleGoal();
                        myGoals.AddGoal(mySimple);
                        waiting = false;
                        break;
                    case 2: // eternal
                        EternalGoal myEternal = new EternalGoal();
                        myGoals.AddGoal(myEternal);
                        waiting = false;
                        break;
                    case 3: // checklist
                        Checklist myChecklist = new Checklist();
                        myGoals.AddGoal(myChecklist);
                        waiting = false;
                        break;
                    default:
                        Console.WriteLine("\n--------------------------------------------------------------------\nInvalid input, Please enter a number 1-3\n--------------------------------------------------------------------\n");
                        break;
                }
            }

        }
    }
}