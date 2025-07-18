using System.Runtime.InteropServices;

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
        return $"{streetAdd_}, {city_}, {state_}, {country_}";
    }
}