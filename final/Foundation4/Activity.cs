using System.Dynamic;

abstract class Activity
{
    private string date_;
    private int time_;
    private string type_;
    public Activity() { }
    public Activity(string date, int time, string type)
    {
        date_ = date;
        time_ = time;
        type_ = type;
    }

    public virtual string GetSummary()
    {
        return $"{date_} {type_} ({time_} min)- Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile.";
    }
    public int GetTime()
    {
        return time_;
    }

    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace(); 
}