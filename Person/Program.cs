class Program
{
    public static void Main(string[] args)
    {
        Person myPerson = new Person("Bob", "Bubba", 53);
        Console.WriteLine(myPerson.GetPersonInformation());

        PoliceMan myPoliceman = new PoliceMan("Cooper", "Silver", 34, "club");
        Console.WriteLine(myPoliceman.GetPersonInformation());
    }  
}

