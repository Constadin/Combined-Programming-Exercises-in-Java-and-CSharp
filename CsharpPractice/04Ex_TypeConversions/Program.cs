using System;  // Importing the System namespace which contains fundamental classes for basic input/output operations

namespace TypeConversions  // Declaring a namespace called TypeConversions
{
   internal class Program  // Declaring an internal class named Program
   {
      public static void Main(string[] strings)  // Main method, the entry point of the program
      {
         // Integer to long conversion
         long longType = 5235L;  // Declaring a long variable and assigning it a value
         int intType = 50;  // Declaring an int variable and assigning it a value

         longType = intType;  // Implicitly converting int to long

         // Printing the type and value of the long variable after conversion
         Console.Write("Type of :" + longType.GetType());
         Console.WriteLine(" :" + longType);

         // Float to double conversion
         double doubleType = 582.364;  // Declaring a double variable and assigning it a value
         float floatType = 50.25F;  // Declaring a float variable and assigning it a value

         doubleType = floatType;  // Implicitly converting float to double

         // Printing the type and value of the double variable after conversion
         Console.Write("Type of :" + doubleType.GetType());
         Console.WriteLine(" " + doubleType);

         // Explicitly converting double back to float
         floatType = (float)doubleType;
         // Printing the value of the float variable after explicit conversion
         Console.WriteLine("double to float :" + floatType);

         // Byte addition
         // In calculated representations, byte, short, and char are internally converted to int
         byte firstByte = 1;  // Declaring a byte variable and assigning it a value
         byte secondByte = 2;  // Declaring another byte variable and assigning it a value

         // Adding two byte variables and casting the result back to byte
         byte sumByte = (byte)(firstByte + secondByte);
         // Printing the sum of the two byte variables
         Console.WriteLine("Sum of Bytes :" + sumByte);

         // Waiting for user input to keep the console window open
         Console.ReadLine();
      }
   }
}

/*Here's a brief explanation for each part of the code:

The using System; directive includes the System namespace, which is necessary for basic input/output operations.
The namespace TypeConversions declaration creates a namespace named TypeConversions to contain your class.
The internal class Program declaration defines a class named Program with internal accessibility, meaning it is 
accessible only within its containing assembly.
The public static void Main(string[] strings) method is the entry point of the program where execution starts.
Variables of different types are declared and initialized.
Implicit and explicit type conversions are performed:
longType = intType; demonstrates implicit conversion from int to long.
doubleType = floatType; demonstrates implicit conversion from float to double.
floatType = (float)doubleType; demonstrates explicit conversion from double to float.
Byte addition is performed with internal conversion to int and then casting the result back to byte.
The Console.WriteLine and Console.Write methods are used to print the types and values of variables before and after
 conversions.
Console.ReadLine is used to wait for user input before closing the console window.*/