class EternalGoal : BaseGoal
{
    private int _completions;

    public EternalGoal()
    {
        SetType("eternal");
        SetName();
        SetDescription();
        setPoints();
        SetGoal();
        _completions = 0;
    }
    public void AddCompletions()
    {
        
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points.");
        return GetPoints();
        
    }

    public override string SetGoal()
    {
        return "";
    }

    public override void GetGoal()
    {
        
    }
}