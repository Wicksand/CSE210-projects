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
    public override string SetGoal()
    {
        return $"{GetType()}#{GetName()}#{GetDescription()}#{GetPoints()}#{GetStatus()}";
    }
    public override void GetGoal()
    {
        
    }
}