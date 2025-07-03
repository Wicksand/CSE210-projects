using System.Runtime.CompilerServices;

abstract class BaseGoal
{
    private string _goal;
    private int _points;
    private string _goalTitle;

    public abstract void RecordEvent();

    public abstract string SetGoal();

    public abstract void GetGoal();

    public virtual string ConvertToTextScreen()
    {
        return "";
    }

    public virtual string ConvertToTextFile()
    {
        return "";
    }
}