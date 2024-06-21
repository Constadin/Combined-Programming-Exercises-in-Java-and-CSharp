using System;
using System.IO;
using System.Reflection;

namespace SwitchCase;

internal class Program
{
   public static void Main(string[] args)
   {
      Console.WriteLine("Give a Character A, B, C, D");

      char inputChar = Console.ReadLine()[0]; // This line uses Console.ReadLine() to read the entire line of
                                              // input as a string.
      //It then directly accesses the first character of that string with the[0] index.

      // Switch statement to handle different cases based on input character.
      switch (inputChar)
      {
         case 'A':
            Console.WriteLine("inside case A"); // Executes if inputChar is 'A'.
            break; // Exits the switch statement.

         case 'B':
            Console.WriteLine("inside case B"); // Executes if inputChar is 'B'.
            break; // Exits the switch statement.

         case 'C':
            Console.WriteLine("inside case C"); // Executes if inputChar is 'C'.
            break; // Exits the switch statement.

         case 'D':
            Console.WriteLine("inside case D"); // Executes if inputChar is 'D'.
            break; // Exits the switch statement.

         default:
            Console.WriteLine("default case"); // Executes if inputChar is not 'A', 'B', 'C', or 'D'.
            break; // Exits the switch statement.
      }

      Console.ReadLine(); // Wait for user input before closing the console.
   }
}

/*Explanation 
User Input Conversion:
char inputChar = Console.ReadLine()[0]; // This line uses Console.ReadLine() to read the entire line of
                                        input as a string.It then directly accesses the first character of that 
                                        string with the[0] index.

Switch Statement:
Evaluates inputChar and executes the corresponding case block.
Each case corresponds to a specific character ('A', 'B', 'C', 'D').
The default case handles any input that doesn't match the specified cases.

Break Statement:
break;: Exits the switch statement to prevent fall-through to subsequent cases.*/