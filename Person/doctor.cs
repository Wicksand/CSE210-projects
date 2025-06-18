class Doctor : Person
{
    private string _tools;
    private double _salary;
    public Doctor(string firstName, string lastName, int age, string tools, double salary)
    : base(firstName, lastName, age)
    {

        _tools = tools;
        _salary = salary;
    }

    // public string GetDoctorInformation()
    // {
    //     return $"tools:{_tools} :: {GetPersonInformation()}";
    // }
    public override string GetPersonInformation()
    {
        return $"tools:{_tools} :: {base.GetPersonInformation()}";
    }
    public override double GetSalary()
    {
        return _salary;
    }
}