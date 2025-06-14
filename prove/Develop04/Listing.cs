class Listing : Activity
{

    private int _count = 0;
    public Listing() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        DisplayWelcome();
        SetTime();
        GetReady();
        DisplayRandomQuestion();
        RunListing();
        DisplayGoodbye();
    }
    private void DisplayRandomQuestion()
    {
        List<string> questions = new List<string>();
        questions.Add("--- Who are people that you appreciate? ---");
        questions.Add("--- What are personal strengths of yours? ---");
        questions.Add("--- Who are people that you have helped this week? ---");
        questions.Add("--- What was the strongest emotion I felt today? ---");
        questions.Add("--- When have you felt the Holy Ghost this month? ---");
        questions.Add("--- Who are some of your personal heroes? ---");

        Random rand = new Random();
        int _randNum = rand.Next(questions.Count);
        Console.WriteLine(questions[_randNum]);
    }
    private void RunListing()
    {
        Console.Write("You may begin in:");
        Timer(3);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(GetTime());

        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            Console.ReadLine();
            _count++;
        }
        Console.WriteLine($"You listed {_count} Items!");
    }
}