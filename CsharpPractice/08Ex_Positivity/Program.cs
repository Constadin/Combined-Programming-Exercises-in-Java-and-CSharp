using System;  // Importing the System namespace which contains fundamental classes for basic input/output operations

namespace Positivity  // Declaring a namespace called Positivity
{
   internal class Program  // Declaring an internal class named Program
   {
      public static void Main(string[] args)  // Main method, the entry point of the program
      {
         // Prompting the user to input a number
         Console.WriteLine("Give a Number");

         // Reading the user input and converting it to a double
         double inputNumber = Convert.ToDouble(Console.ReadLine());

         // Checking if the number is positive
         if (inputNumber > 0)
         {
            // If the number is greater than zero, it is positive
            Console.WriteLine("The number is positive");
         }
         else
         {
            // If the number is not greater than zero, it is not positive
            Console.WriteLine("The number is not positive");
         }

         // Waiting for user input to keep the console window open
         Console.ReadLine();
      }
   }
}

/*Explanation:
Namespace and Class Declaration:

namespace Positivity defines the namespace.
internal class Program declares the class Program.
Main Method:

public static void Main(string[] args) is the entry point of the program.
User Input:

The program prompts the user to input a number with Console.WriteLine("Give a Number");.
Convert.ToDouble(Console.ReadLine()) reads the input string from the console and converts it to a double.
Conditional Check:

The program checks if the inputNumber is greater than 0 using an if statement.
If the condition inputNumber > 0 is true, it prints "The number is positive".
If the condition is false (i.e., the number is zero or negative), it prints "The number is not positive".
Pause Execution:

Console.ReadLine() waits for the user to press Enter before closing the console window. This allows the user to
see the output before the program terminates*/