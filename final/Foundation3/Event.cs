using System.ComponentModel;
using System.ComponentModel.Design;

class Event
{
    private string title_;
    private string description_;
    private string date_;
    private string time_;
    private Address address_;
    private string typeEvent_;

    public Event() { }
    public Event(string title, string description, string date, string time, Address address, string typeEvent)
    {
        title_ = title;
        description_ = description;
        date_ = date;
        time_ = time;
        address_ = address;
        typeEvent_ = typeEvent;
    }
    public string Standard()
    {
        return $"Standard Details:\n   Title: {title_}\n   Description: {description_}\n   Date: {date_}\n   Start Time: {time_} \n   Location: {address_.Display()}";
    }
    protected string Full(string specification)
    {
        return $"Full Details:\n   Event Type: {typeEvent_}\n   Title: {title_}\n   Description: {description_}\n   Date: {date_}\n   Start Time: {time_} \n   Location: {address_.Display()}\n{specification}";
    }
    public string Short()
    {
        return $"Short Details:\n   Event Type: {typeEvent_}\n   Title: {title_}\n   Date: {date_}";
    }
}