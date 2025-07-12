using System.ComponentModel.Design;

class Customer
{
    private Address address_;
    private string name_;
    public Customer() { }

    public Customer(string name, string streetAdd, string city, string state, string country)
    {
        Address add = new Address(streetAdd, city, state, country);
        address_ = add;
        name_ = name;
    }
    public bool IsInUSA()
    {
        return address_.IsInUSA();
    }
    public string GetName()
    {
        return name_;
    }
    public string GetAddress()
    {
        return address_.Display();
    }
}