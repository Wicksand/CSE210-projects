class Checklist : BaseGoal
{

    private int _taskCount;
    private int _TaskGoal;
    public Checklist()
    {
        SetType("checklist");
    }
    public void SetTaskCount(int num)
    {
        _taskCount = num;
    }
    public int GetTaskCount()
    {
        return _taskCount;
    }
    public void SetTaskGoal(int num)
    {
        _TaskGoal = num;
    }
    public int GetTaskGoal()
    {
        return _TaskGoal;
    }
    public override int RecordEvent()
    {
        return 0;
    }
    public override string SetGoal(){
        return"";
    }

    public override void GetGoal()
    {
        
    }
}