using System;  // Importing the System namespace which contains fundamental classes for basic input/output operations

namespace LargerThanOrEqualTo  // Declaring a namespace called LargerThanOrEqualTo
{
   internal class Program  // Declaring an internal class named Program
   {
      public static void Main(string[] args)  // Main method, the entry point of the program
      {
         // Prompting the user to input the first number
         Console.WriteLine("Give the first number");
         double firstNum = Convert.ToDouble(Console.ReadLine());  // Reading and converting the input to a double

         // Prompting the user to input the second number
         Console.WriteLine("Give the second number");
         double secondNum = Convert.ToDouble(Console.ReadLine());  // Reading and converting the input to a double

         // Comparing the two numbers
         if (firstNum > secondNum)
         {
            // If the first number is greater than the second number
            Console.WriteLine("Greater number is: " + firstNum);
         }
         else if (firstNum < secondNum)
         {
            // If the first number is less than the second number
            Console.WriteLine("Greater number is: " + secondNum);
         }
         else
         {
            // If the numbers are equal
            Console.WriteLine("The numbers are equal!");
         }

         // Waiting for user input to keep the console window open
         Console.ReadLine();
      }
   }
}

/*Explanation:
Namespace and Class Declaration:

namespace LargerThanOrEqualTo defines the namespace.
internal class Program declares the class Program.
Main Method:

public static void Main(string[] args) is the entry point of the program.
User Input:

The program prompts the user to input the first number with Console.WriteLine("Give the first number");.
Convert.ToDouble(Console.ReadLine()) reads the input string from the console and converts it to a double,
storing it in firstNum.
The program prompts the user to input the second number with Console.WriteLine("Give the second number");.
Convert.ToDouble(Console.ReadLine()) reads the input string from the console and converts it to a double,
storing it in secondNum.
Conditional Check:

The program checks if firstNum is greater than secondNum using an if statement. If true, it prints "Greater
number is: " followed by firstNum.
If the condition firstNum > secondNum is false, it checks if firstNum is less than secondNum using an else if statement. If true, it prints "Greater number is: " followed by secondNum.
If neither condition is true, it means the numbers are equal, so it prints "The numbers are equal!".
Pause Execution:

Console.ReadLine() waits for the user to press Enter before closing the console window. This allows the user
to see the output before the program terminates.*/