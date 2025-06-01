class Program
{
    public static void Main(string[] arg)
    {
        Console.WriteLine("Hello, World!");

        WordCounter wordCounter = new WordCounter("My name is joe joe the purple octopus.");
        wordCounter.DisplayWords();

        int count = wordCounter.CountSingleWord("text");
        Console.WriteLine(count);
    }
}

