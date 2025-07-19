class CyclingActivity : Activity
{
    private float speed_;
    public CyclingActivity() { }
    public CyclingActivity(string date, int time, float Speed): base(date, time, "Cycling")
    {
        speed_ = Speed;
    }
    public override float GetDistance()
    {
        return speed_ * GetTime(); 
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