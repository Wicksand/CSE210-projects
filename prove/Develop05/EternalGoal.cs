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
    }
    public override int RecordEvent()
    {
        return 0;
    }

    public override string SetGoal()
    {
        return "";
    }

    public override void GetGoal()
    {
        
    }
}