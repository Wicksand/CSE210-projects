using System.Reflection.Metadata;

class Program
{
    public static void Main(string[] args)
    {
        // Person myPerson = new Person("Bob", "Bubba", 53);// this no longer works due to the abstract class
        // Console.WriteLine(myPerson.GetPersonInformation());

        PoliceMan myPoliceman = new PoliceMan("Cooper", "Silver", 34, "club", 30, 25);
        // Console.WriteLine(myPoliceman.GetPersonInformation());
        // Console.WriteLine(myPoliceman.GetPoliceManInformation());

        Doctor myDoctor = new Doctor("Bob", "Payne", 56, "Hammer", 450000);
        // Console.WriteLine(myDoctor.GetDoctorInformation());

        List<Person> myPeople = new List<Person>();
        // myPeople.Add(myPerson); // this no longer works due to the abstract class
        myPeople.Add(myDoctor);
        myPeople.Add(myPoliceman);

        foreach (Person person in myPeople)
        {
            DisplayPersonInformation(person);
        }

    }

    private static void DisplayPersonInformation(Person person)
    {
        Console.WriteLine(person.GetPersonInformation());
        Console.WriteLine($"Salary: {person.GetSalary()}");
    }
}

