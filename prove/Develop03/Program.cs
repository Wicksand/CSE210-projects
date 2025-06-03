using System;
using System.Security;

class Program
{
    static void Main(string[] args)
    {
        Passage myPassage = new Passage();

        string userInput = "";
        bool done = false;
        Console.Clear();
        myPassage.Displayscript();

        while (userInput != "q" && !done)
        {
            if (myPassage.AllWordsHidden())
            {
                done = true;
            }
            Console.WriteLine("\nPress enter to continue or 'q' to finish");
            userInput = Console.ReadLine().ToLower();

            myPassage.HideRandomWords(3);
            Console.Clear();
            myPassage.Displayscript();
        }
    }
}