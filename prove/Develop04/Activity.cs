using System.ComponentModel;
using System.Data;

class Activity
{
    private string _name;
    private string _description;
    private int _timeLen;

    public Activity()
    {

    }
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;

    }
    public void SetTime()
    {
        int timeLen;

        Console.WriteLine("How long, in seconds, would you like for your session?");

        while (!int.TryParse(Console.ReadLine(), out timeLen))//keeps checking until valid input
        {
            Console.WriteLine("\n--------------------------------------------------------------------\nInvalid input, Please enter a number of seconds\n--------------------------------------------------------------------\n");
        }
        _timeLen = timeLen;
    }

    protected void DisplayWelcome()
    {
        Console.WriteLine($"Welcome to the {_name} Activity\n\n{_description}\n");
    }

    protected void DisplayGoodbye()
    {
        Console.WriteLine("\nWell Done!!");
        Console.WriteLine($"\nYou have completed another {_timeLen} seconds of the {_name} Activity.");

    }
}