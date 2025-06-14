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

        DateTime endTime = DateTime.Now.AddSeconds(GetTime());

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            Timer(6);
            Console.Write("\nNow breathe out...");
            Timer(6);
            Console.WriteLine();
        }
    }
}