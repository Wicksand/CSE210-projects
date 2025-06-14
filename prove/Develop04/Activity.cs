using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Globalization;

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
    public int GetTime()
    {
        return _timeLen;
    }

    protected void DisplayWelcome()
    {
        Console.WriteLine($"Welcome to the {_name} Activity\n\n{_description}\n");
    }
    protected void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(3);
    }

    protected void DisplayGoodbye()
    {
        Console.WriteLine("\nWell Done!!");
        Spinner(4);
        Console.WriteLine($"\nYou have completed another {_timeLen} seconds of the {_name} Activity.");
        Spinner(4);
        Console.Clear();

    }

    public void Timer(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            string secondst = seconds.ToString();
            Console.Write(i);
            Thread.Sleep(1000);

            for (int j = 0; j < secondst.Length; j++)
            {
                Console.Write("\b");
            }
        }
        Console.Write(" ");
    }
    public void Spinner(int sec)
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(sec);

        int index = 0;
        string animationString = "|/-|-\\";
        
        while (DateTime.Now < endTime)
        {
            Console.Write(animationString[index++ % animationString.Length]);
            Thread.Sleep(500);
            Console.Write("\b");
        }
        Console.Write(" ");
    }
}