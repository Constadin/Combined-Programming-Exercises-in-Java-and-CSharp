using System;  // Importing the System namespace which contains fundamental classes for basic input/output operations

namespace Password  // Declaring a namespace called Password
{
   internal class Program  // Declaring an internal class named Program
   {
      public static void Main(string[] args)  // Main method, the entry point of the program
      {
         // Prompting the user to input a password
         Console.WriteLine("Give a Password");

         // Reading the user input and storing it in the inputPassword variable
         string inputPassword = Console.ReadLine();

         // Checking if the entered password matches the correct password "Caput Draconis"
         if (inputPassword.Equals("Caput Draconis"))
         {
            // If the password is correct, display a welcome message
            Console.WriteLine("Welcome!");
         }
         else
         {
            // If the password is incorrect, display an off with you message
            Console.WriteLine("Off with you");
         }

         // Waiting for user input to keep the console window open
         Console.ReadLine();
      }
   }
}

/*Explanation:
Namespace and Class Declaration:
namespace Password defines the namespace.
internal class Program declares the class Program.
Main Method:
public static void Main(string[] args) is the entry point of the program.
User Input:
The program prompts the user to input a password with Console.WriteLine("Give a Password");.
Console.ReadLine() reads the input string from the console and stores it in the inputPassword variable.
Password Check:
The program checks if the entered password matches the correct password "Caput Draconis"
using the inputPassword.Equals
("Caput Draconis") method.
If the condition is true, the program prints "Welcome!".
If the condition is false, the program prints "Off with you".
Pause Execution:
Console.ReadLine() waits for the user to press Enter before closing the console window. This allows
the user to see the output before the program terminates.*/