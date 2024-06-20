using System;  // Importing the System namespace which contains fundamental classes for basic input/output operations

namespace Ex_Variables  // Declaring a namespace called Ex_Variables
{
   internal class Program  // Declaring an internal class named Program
   {
      public static void Main(string[] args)  // Main method, the entry point of the program
      {
         // Declaring an integer variable with a value of 5
         int integerNum = 5;
         // Printing the value of the integer variable
         Console.WriteLine(integerNum);

         // Declaring a float variable with a value of 52.2
         float floatNum = 52.2F;
         // Printing the value of the float variable
         Console.WriteLine(floatNum);

         // Declaring a double variable with a value of 5.2365
         double doubleNum = 5.2365;
         // Printing the value of the double variable
         Console.WriteLine(doubleNum);

         // Declaring a decimal variable with a value of 25.56
         decimal DecimalNum = 25.56M;
         // Printing the value of the decimal variable
         Console.WriteLine(DecimalNum);

         // Declaring a boolean variable with a value of false
         bool boolNum = false;
         // Printing the value of the boolean variable
         Console.WriteLine(boolNum);
      }
   }
}

/*Here's a brief explanation for each part of the code:

The using System; directive includes the System namespace, which is necessary for basic input/output operations.
The namespace Ex_Variables declaration creates a namespace named Ex_Variables to contain your class.
The internal class Program declaration defines a class named Program with internal accessibility, meaning it is 
accessible only within its containing assembly.
The public static void Main(string[] args) method is the entry point of the program where execution starts.
Various variables are declared with different data types:
int integerNum = 5; declares an integer variable and assigns it a value of 5.
float floatNum = 52.2F; declares a float variable and assigns it a value of 52.2.
double doubleNum = 5.2365; declares a double variable and assigns it a value of 5.2365.
decimal DecimalNum = 25.56M; declares a decimal variable and assigns it a value of 25.56.
bool boolNum = false; declares a boolean variable and assigns it a value of false.
Each variable is then printed to the console using the Console.WriteLine method, which outputs the value of the
variable followed by a newline.*/