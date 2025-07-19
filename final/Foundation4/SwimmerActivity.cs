class SwimmingActivity : Activity
{
    private int laps_;
    public SwimmingActivity() {}
    public SwimmingActivity(string date, float time,int laps) : base(date, time, "Swimming")
    {
        laps_ = laps;
    }
    

    public override float GetDistance()
    {
        return (laps_ *50) /1000f * 0.62f; 
    }
    public override float GetSpeed()
    {
        return GetDistance() / GetTime() *60f;
    }
    public override float GetPace()
    {
        return GetTime() / GetDistance();
    } 
}