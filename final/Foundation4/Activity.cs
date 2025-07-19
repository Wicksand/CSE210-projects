using System.Dynamic;

abstract class Activity
{
    private string date_;
    private float time_;
    private string type_;
    public Activity() { }
    public Activity(string date, float time, string type)
    {
        date_ = date;
        time_ = time;
        type_ = type;
    }

    public virtual string GetSummary()
    {
        return $"{date_} {type_} ({time_} min)- Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile.";
    }
    public float GetTime()
    {
        return time_;
    }

    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace(); 
}