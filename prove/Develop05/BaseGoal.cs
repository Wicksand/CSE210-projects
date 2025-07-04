using System.Dynamic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;

abstract class BaseGoal
{
    private int _points;
    private string _name;
    private string _description;
    private bool _status;
    private string _type;


    public BaseGoal()
    {

    }

    //--------------------------------------Getters + setters----------------------------------
    public void setPoints()
    {
        bool numCheck = true;
        int points = 0;
        while (numCheck)
        {
            Console.Write("What is the amount of points associated with this goal? ");
            string testpoint = Console.ReadLine();

            if (!int.TryParse(testpoint, out points))
            {
                Console.WriteLine("\n--------------------------------------------------------------------\nInvalid input, Please enter a number\n--------------------------------------------------------------------\n");
                numCheck = true;
            }
            else
            {
                numCheck = false;
            }
        }
        _points = points;
    }
    public void LoadPoints(int points)
    {
        _points = points;
    }
    public int GetPoints()
    {
        return _points;
    }
    public void SetDescription()
    {
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
    }
     public void LoadDescription(string input)
    {
        _description = input;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetName()
    {
        Console.Write("What is the name of your Goal? ");
        _name = Console.ReadLine();
    }
    public void LoadName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetStatus(bool status)
    {
        _status = status;
    }
    public bool GetStatus()
    {
        return _status;
    }
    public void SetType(string type)
    {
        _type = type;
    }
    public string GetType()
    {
        return _type;
    }
    //------------------------------------------------------------------------------------------------------------
    public virtual string ConvertToTextFile()
    {
        return $"{GetType()}#{GetName()}#{GetDescription()}#{GetPoints()}#{GetStatus()}";
    }
    public abstract int RecordEvent();

    public void SetGoal(string name, string desc, int point, bool status)
    {
        SetStatus(status);
        LoadName(name);
        LoadDescription(desc);
        LoadPoints(point);
    }
}