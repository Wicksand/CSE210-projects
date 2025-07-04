class SimpleGoal : BaseGoal
{
    public SimpleGoal()
    {
        SetName();
        SetDescription();
        setPoints();
    }
    public SimpleGoal(string name, int points, bool status)
    {
        
    }
    public override void RecordEvent()
    {

    }
    public override string SetGoal()
    {
        return "";
    }
    public override void GetGoal()
    {
        
    }
}