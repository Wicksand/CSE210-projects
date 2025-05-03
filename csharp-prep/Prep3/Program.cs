using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        // generate random number
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);

        bool running = true;

        // game loop
        while (running == true){
            Console.Write("What is your guess? ");
        string roughGuess = Console.ReadLine();
        int guess = int.Parse(roughGuess);

        //core logic responces
        if (number < guess){
            Console.WriteLine("Lower");
        }
        else if(number > guess){
            Console.WriteLine("Higher");
        }
        else{
            Console.WriteLine("You guessed it!");
            running = false;
        }
        }

        // //initial prompt
        // Console.Write("What is the magic number? ");
        // string input = Console.ReadLine();
        // int numbeer = int.Parse(input);
        

    }
}