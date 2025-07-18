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
        return $"{date_} {type_} ({time_} min)- Distance: {GetDistance()}miles, Speed: {GetSpeed()}mph, Pace: {GetPace()}min per mile.";
    }

    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace(); 
}