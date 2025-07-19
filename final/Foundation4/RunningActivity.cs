class RunningActivity : Activity
{
    private float distance_;
    public RunningActivity(){}
    public RunningActivity(string date, float time, float  distance) : base(date, time, "Running")
    {
        distance_ = distance;
    }
    
    public override float GetDistance()
    {
        return distance_; 
    }
    public override float GetSpeed()
    {
        return (distance_ / GetTime() )*60f;
    }
    public override float GetPace()
    {
        return GetTime()/distance_;
    } 
}