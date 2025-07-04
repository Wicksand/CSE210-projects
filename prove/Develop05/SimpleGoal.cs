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
    public override void RecordEvent()
    {
        if (!GetStatus())
        {
            SetStatus(true);
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points.");
        }
        else
        {
            Console.WriteLine($"That goal has already been compleated.");
        }
    }
    public override string SetGoal()
    {
        return $"{GetType()}#{GetName()}#{GetDescription()}#{GetPoints()}#{GetStatus()}";
    }
    public override void GetGoal()
    {
        
    }
}