class OutdoorEvent : Event
{
    private string weather_;
    public OutdoorEvent() { }

    public OutdoorEvent(string title, string description, string date, string time, Address address,string weather) : base(title, description, date, time, address,"Outdoor gathering") {
        weather_ = weather;
    }
    public string fullOutdoor() {
        return Full($"   Weather Forecast:{weather_}");
    }
    
}