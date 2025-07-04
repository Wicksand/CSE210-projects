class EternalGoal : BaseGoal
{
    public EternalGoal()
    {
        SetType("eternal");
        SetName();
        SetDescription();
        setPoints();
    }
    public EternalGoal(string name, string desc, int point, bool status)
    {
        SetGoal(name, desc, point, status);
        SetType("eternal");

    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points.");
        return GetPoints();
        
    }
}