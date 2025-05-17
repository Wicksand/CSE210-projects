using System;

class Program
{
    static int DisplayMenu()
    {
        int responce = 0;
        Console.WriteLine("Select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What Would you like to do? ");
        responce = int.Parse(Console.ReadLine());
        return responce;
    }
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        int input = 0;
        Console.WriteLine("Welcome to the Journal Program!");

        while (input != 5)
        {
            input = DisplayMenu();
            switch (input)
            {
                case 1: //write
                    Entry myEntry = new Entry();
                    string prompt = myEntry.GetRandomPrompt();
                    myEntry.CreateEntry(prompt);
                    myJournal.AddEntry(myEntry);
                    myEntry.Display();

                    break;
                case 2: //display
                    myJournal.Display();

                    break;
                case 3: //load
                    Console.WriteLine("What is the file name?");
                    string loadName = Console.ReadLine();
                    myJournal.ReadFromFile(loadName);

                    break;
                case 4: //save
                    Console.WriteLine("What is the file name?");
                    string saveFile = Console.ReadLine();
                    myJournal.SaveToFile(saveFile);
                    break;
                case 5://quit

                    break;
                default:
                    Console.WriteLine("Please enter a valid input 1 - 5");
                    break;
            }
        }

    }
}