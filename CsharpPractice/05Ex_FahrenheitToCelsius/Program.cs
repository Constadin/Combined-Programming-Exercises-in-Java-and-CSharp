using System;  // Importing the System namespace which contains fundamental classes for basic input/output operations

namespace FahrenheitToCelsius  // Declaring a namespace called FahrenheitToCelsius
{
   internal class Program  // Declaring an internal class named Program
   {
      public static void Main(string[] args)  // Main method, the entry point of the program
      {
         int fahrenheit = 94;  // Declaring an int variable to hold the Fahrenheit temperature and assigning it a value

         // Calculating the Celsius equivalent of the Fahrenheit temperature
         // The formula is: (Fahrenheit - 32) * 5/9
         // Using decimal for more precise calculation
         decimal celsius = ((fahrenheit - 32) * (5M / 9M));

         // Printing the converted temperature in Celsius
         Console.WriteLine("Temp Celsius :" + celsius);
      }
   }
}

/*Here's a brief explanation for each part of the code:

The using System; directive includes the System namespace, which is necessary for basic input/output operations.
The namespace FahrenheitToCelsius declaration creates a namespace named FahrenheitToCelsius to contain your class.
The internal class Program declaration defines a class named Program with internal accessibility, meaning it is 
accessible only within its containing assembly.
The public static void Main(string[] args) method is the entry point of the program where execution starts.
An integer variable fahrenheit is declared and initialized with a value of 94.
The formula (fahrenheit - 32) * (5M / 9M) is used to convert the Fahrenheit temperature to Celsius. The M suffix 
indicates that the numbers are of type decimal to ensure precise calculation.
The result is stored in a decimal variable celsius.
The Console.WriteLine method is used to print the converted temperature in Celsius to the console.*/