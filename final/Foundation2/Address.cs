using System.ComponentModel.DataAnnotations;

class Address
{
    private string streetAdd_;
    private string city_;
    private string state_;
    private string country_;
    public Address() { }
    public Address(string streetAdd, string city, string state, string country)
    {
        streetAdd_ = streetAdd;
        city_ = city;
        state_ = state;
        country_ = country;
    }
    public string Display()
    {
        return $"{streetAdd_}\n{city_}, {state_}\n{country_}";
    }
    public bool IsInUSA()
    {
        return country_.Trim().ToUpper() == "USA";
    }

}