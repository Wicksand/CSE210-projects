using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        // difine while loop
        int num = 1;
        while (num != 0){
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            num = int.Parse(input); // change to an int
            if(num != 0){ //check that it doesn't add 0
                numbers.Add(num);//append list
            }
        }
        
        //add up list
        int sum = 0;
        foreach(int number in numbers){
            sum +=number;
        }
        Console.WriteLine($"The sum is: {sum}");
        
        //find average of list
        float numbersLength = numbers.Count; 
        float average = sum/numbersLength;
        Console.WriteLine($"The average is: {average}");
        
        //find max
        int big = 0;
        foreach(int number in numbers){
            if (number > big){
                big = number;
            }
        }
        Console.WriteLine($" The largest number is: {big}");
    }
}