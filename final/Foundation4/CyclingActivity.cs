class CyclingActivity : Activity
{
    private float speed_;
    public CyclingActivity() { }
    public CyclingActivity(string date, float time, float speed): base(date, time, "Cycling")
    {
        speed_ = speed;
    }
    public override float GetDistance()
    {
        return (speed_ * GetTime())/60f; 
    }
    public override float GetSpeed()
    {
        return speed_;
    }
    public override float GetPace()
    {
        return GetTime()/GetDistance();
    } 
}