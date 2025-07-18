class ReceptionEvent : Event
{
    public ReceptionEvent()
    {

    }

private string email_;

    public ReceptionEvent(string title, string description, string date, string time, Address address,string email) : base(title, description, date, time, address,"Reception") {
        email_ = email;
    }
    public string fullOutdoor() {
        return Full($"   To RSVP please send a message to:{email_}");
    }
}