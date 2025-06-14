class Breathing : Activity
{

    public Breathing() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        DisplayWelcome();
        SetTime();
        RunBreath();
        DisplayGoodbye();
    }
    public void RunBreath()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(5);
    }
}