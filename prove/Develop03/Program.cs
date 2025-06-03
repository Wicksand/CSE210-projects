using System;
using System.Security;

class Program
{
    static void Main(string[] args)
    {
        Passage myPassage = new Passage("");
        string scriptureChoice = myPassage.PickRandom();

        myPassage = new Passage(scriptureChoice);

        Reference reference;
        if (myPassage.VerseEnd == "")
        {
            reference = new Reference(myPassage.Book, myPassage.Chapter, myPassage.VerseStart, myPassage);
        }
        else
        {
            reference =new Reference(myPassage.Book, myPassage.Chapter, myPassage.VerseStart, myPassage.VerseEnd, myPassage);
        }
        string userInput = "";

        while (userInput != "q")
        {
            Console.Clear();
            reference.Display();

            if (myPassage.AllWordsHidden())
            {
                break;
            }

            Console.WriteLine("press enter to continue or 'q' to finish");
            userInput = Console.ReadLine().ToLower();

            if (userInput == "q")
            {
                break;
            }
            myPassage.HideRandomWords(3);
        }
    }
}