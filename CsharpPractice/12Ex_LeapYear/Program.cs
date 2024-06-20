/*A year is a leap year if it is divisible by 4. However, if the year is divisible by 100, then it is a leap year only when it is also divisible by 400.

Write a program that reads a year from the user, and checks whether or not it is a leap year.*/

using System;  // Importing the System namespace which contains fundamental classes for basic input/output operations

namespace LeapYear  // Declaring a namespace called LeapYear
{
   internal class Program  // Declaring an internal class named Program
   {
      public static void Main(string[] args)  // Main method, the entry point of the program
      {
         // Prompting the user to input a year
         Console.WriteLine("Give a Year");

         // Reading the user input and converting it to an integer
         int inputYear = Convert.ToInt32(Console.ReadLine());

         // Checking if the year is a leap year based on the conditions
         if ((inputYear % 4 == 0 && inputYear % 100 != 0) || inputYear % 400 == 0)
         {
            // If the conditions for a leap year are met, print this message
            Console.WriteLine("The year is a leap year.");
         }
         else
         {
            // If the conditions for a leap year are not met, print this message
            Console.WriteLine("The year is not a leap year.");
         }

         // Waiting for user input to keep the console window open
         Console.ReadLine();
      }
   }
}


/*Explanation:
Namespace and Class Declaration:

namespace LeapYear defines the namespace.
internal class Program declares the class Program.

Main Method:

public static void Main(string[] args) is the entry point of the program.

User Input:

The program prompts the user to input a year with Console.WriteLine("Give a Year");.
Convert.ToInt32(Console.ReadLine()) reads the input string from the console and converts it to an integer, 
storing it in inputYear.

Leap Year Calculation:

The program checks if the inputYear meets the conditions for a leap year:
(inputYear % 4 == 0 && inputYear % 100 != 0): If the year is divisible by 4 but not divisible by 100, it's a 
leap year.
inputYear % 400 == 0: If the year is divisible by 400, it's also a leap year.
If either of these conditions is true, it prints "The year is a leap year.".
Otherwise, it prints "The year is not a leap year."

Pause Execution:

Console.ReadLine(); waits for the user to press Enter before closing the console window. This allows the user 
to see the output before the program terminates.*/
