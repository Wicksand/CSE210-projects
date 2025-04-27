using System;

class Program
{
    static void Main(string[] args)
    {
        //request a letter grade and store in "grade"
        Console.Write("What is your grade percentage: ");
        string grade = Console.ReadLine();

        //convert string  to int and store in "NumGrade"
        int NumGrade = int.Parse(grade);

        //declare variable
        string letter = "";

        //determine letter grade
        if(NumGrade >= 90)
        {
            letter = "A";
        }
        else if(NumGrade >= 80)
        {
            letter = "B";
        }
        else if(NumGrade >= 70)
        {
            letter = "C";
        }
        else if(NumGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // determine if the user passed and retrun message
        if(NumGrade >= 70)
        {
            Console.WriteLine("Congratulations you passed!");
        }
        else
        {
            Console.WriteLine("It looks like you didn't quite pass. keep trying!");
        }

        //return letter grade
        Console.WriteLine($"Your letter grade is: {letter}");

    }
}