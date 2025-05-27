class Program
{
    public static void Main(string[] arg)
    {
        Console.WriteLine("Hello, World!");

        WordCounter wordCounter = new WordCounter("My name is joe");
        wordCounter.DisplayWords();
    }
}

