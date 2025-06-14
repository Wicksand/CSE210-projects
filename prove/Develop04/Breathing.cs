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
        GetReady();

        DateTime endTime = DateTime.Now.AddSeconds(GetTime());

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            Timer(4);
            Console.Write("\nNow breathe out...");
            Timer(4);
            Console.WriteLine();
        }
    }
}