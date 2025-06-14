using System.ComponentModel;

class Activity
{
    private string _name;
    private string _description;
    private int _timeLen;

    public Activity()
    {

    }
    public Activity(string name, string description, int timeLen)
    {
        _name = name;
        _description = description;
        _timeLen = timeLen;
    }

    protected void DisplayWelcome()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
    }
}