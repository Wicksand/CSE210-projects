using System.ComponentModel;

class SimpleGoal : BaseGoal
{
    public SimpleGoal()
    {
        SetType("simple");
        SetStatus(false);
        SetName();
        SetDescription();
        setPoints();
    }
    public SimpleGoal(string name, string desc, int point, bool status)
    {
        SetGoal(name, desc, point, status);
        SetType("simple");
    }
    public override int RecordEvent()
    {
        if (!GetStatus())
        {
            SetStatus(true);
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points.");
            return GetPoints();
        }
        else
        {
            Console.WriteLine($"That goal has already been compleated.");
            return 0;
        }
    }
}