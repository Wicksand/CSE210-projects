using System.ComponentModel.Design;

class Event
{
    private string title_;
    private string description_;
    private string date_;
    private string time_;
    private Address address_;
    public Event() { }
    public Event(string title, string description, string date, string time, Address address)
    {
        title_ = title;
        description_ = description;
        date_ = date;
        time_ = time;
        address_ = address;
    }
    protected void standard()
    {
        Console.WriteLine($"Standard Details:\nTitle: {title_}\nDescription: {description_}\nDate: {date_}\nStart Time: {time_} \nLocation: {address_}");
    }
    protected void Full(string eventType, string specification)
    {
        Console.WriteLine($"Full Details:\nEvent Type: {eventType}\nTitle: {title_}\nDescription: {description_}\nDate: {date_}\nStart Time: {time_} \nLocation: {address_}\n{specification}");
    }
}