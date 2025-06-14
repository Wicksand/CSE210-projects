class Listing : Activity
{

    private int _count;
    public Listing() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        DisplayWelcome();
        SetTime();
        GetReady();
        DisplayRandomQuestion();
        DisplayGoodbye();
    }
    private void DisplayRandomQuestion()
    {
        List<string> questions = new List<string>();
        questions.Add("---Who are people that you appreciate?---");
        questions.Add("---What are personal strengths of yours?---");
        questions.Add("---Who are people that you have helped this week?---");
        questions.Add("---What was the strongest emotion I felt today?---");
        questions.Add("---When have you felt the Holy Ghost this month?---");
        questions.Add("---Who are some of your personal heroes?---");

        Random rand = new Random();
        int _randNum = rand.Next(questions.Count);
        Console.WriteLine(questions[_randNum]);
    }
    private void RunListing()
    {
        
    }
}