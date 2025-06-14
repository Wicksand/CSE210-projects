using System.ComponentModel;

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

    protected void DisplayWelcome()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
    }
}