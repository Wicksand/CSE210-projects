using System.Reflection;

class Reflection : Activity
{
    public Reflection() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        DisplayWelcome();
        SetTime();
        GetReady();
        Console.WriteLine("\nConsider the following prompt:\n");
        DisplayRandomPrompt();
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        RunReflection();
        DisplayGoodbye();
    }
    private void DisplayRandomPrompt()
    {
         List<string> prompts = new List<string>();
        prompts.Add("--- Think of a time when you stood up for someone else. ---");
        prompts.Add("--- Think of a time when you did something really difficult. ---");
        prompts.Add("--- Think of a time when you helped someone in need. ---");
        prompts.Add("--- Think of a time when you did something truly selfless. ---");
        
        Random rand = new Random();
        int _randNum = rand.Next(prompts.Count);
        Console.WriteLine(prompts[_randNum]);
    }
    private void DisplayRandomFollowQuestion()
    {
         List<string> followQuestions = new List<string>();
        followQuestions.Add("> Why was this experience meaningful to you?");
        followQuestions.Add("> Have you ever done anything like this before?");
        followQuestions.Add("> How did you get started?");
        followQuestions.Add("> What made this time different than other times when you were not as successful?");
        followQuestions.Add("> What is your favorite thing about this experience?");
        followQuestions.Add("> What could you learn from this experience that applies to other situations?");
        followQuestions.Add("> What did you learn about yourself through this experience?");
        followQuestions.Add("> How can you keep this experience in mind in the future?");

        Random rand = new Random();
        int _randNum = rand.Next(followQuestions.Count);
        Console.WriteLine(followQuestions[_randNum]);
    }
    private void RunReflection()
    {
        Console.WriteLine("Now ponder on each of the following questionsas they related to this experience.");
        Console.Write("You may begin in:");
        Timer(5);
        DateTime endTime = DateTime.Now.AddSeconds(GetTime());
        Console.Clear();
        while (DateTime.Now < endTime)
        {
            DisplayRandomFollowQuestion();
            Spinner(6);
        }
    }
}