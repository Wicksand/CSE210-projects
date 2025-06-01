using System;

class Program
{
     private List<Passage> _scriptures = new List<Passage>
     {
        new Passage("Mosiah#2#17#And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God."),
        new Passage("Proverbs#3#5-6#Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
        new Passage("Moroni#7#33-34And Christ hath said: If ye will have faith in me ye shall have power to do whatsoever thing is expedient in me. And he hath said: Repent all ye ends of the earth, and come unto me, and be baptized in my name, and have faith in me, that ye may be saved.")
     };

    static void Main(string[] args)
    {
        string userInput = null;
        while (userInput != "q")
        {
            Console.WriteLine("press enter to continue or 'q' to finish");
            userInput = Console.ReadLine();
        }
    }
}