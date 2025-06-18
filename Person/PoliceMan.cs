using System.Dynamic;

class PoliceMan : Person
{
    private string _weapons;
    private int _hoursWorked;
    private double _hourlyWage;
    public PoliceMan(string firstName, string lastName, int age, string weapons, int hoursWorked, double hourlyWage)
    : base(firstName, lastName, age)
    {
        _hourlyWage = hourlyWage;
        _weapons = weapons;
        _hoursWorked = hoursWorked;
    }

    // public string GetPoliceManInformation()
    // {
    //     return $"WEapons:{_weapons} :: {GetPersonInformation()}";
    // }
    public override string GetPersonInformation()
    {
        return $"Weapons:{_weapons} :: {base.GetPersonInformation()}";
    }
    public override double GetSalary()
    {
        double pay = _hoursWorked * _hourlyWage;
        if (_hoursWorked > 40)
        {
            pay += (_hoursWorked - 40) * _hourlyWage * 2;
        }

        return pay;
    }
}