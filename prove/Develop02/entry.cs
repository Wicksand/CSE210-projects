using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

public class Entry
{
    private string dateText;
    private string _entry;
    private string _prompt;
    public string GetRandomPrompt()
    {
        List<string> prompts = new List<string>();
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");
        prompts.Add("If I could tell someone from three hundred years in the future three facts about yourself what would they be?");
        prompts.Add("Why did you eat what you ate today?");
        prompts.Add("What was the coolest thing you learned today?");


        // get a random prompt
        Random rand = new Random();
        int _randNum = rand.Next(prompts.Count);
        return prompts[_randNum];

    }
    public string logformat()
    {
        return $"{dateText}#{_prompt}#{_entry}";
    }
    public void CreateEntry(string prompt)
    {
        //get date and set it = to dateText
        DateTime theCurrentTime = DateTime.Now;
        dateText = theCurrentTime.ToShortDateString();

        _prompt = prompt;

        //give user prompt and request input then 
        Console.WriteLine(prompt);
        Console.Write(">");
        _entry = Console.ReadLine();

    }
    public string Display()
    {
        //show entry in console
        string OutputString = ($"{dateText} - Prompt: {_prompt} {_entry}");
        return OutputString;

    }
    public void CreateEntryWithData(string date, string prompt, string response)
    {
        dateText = date;
        _prompt = prompt;
        _entry = response;
    }
}