using System;  // Importing the System namespace which contains fundamental classes for basic input/output operations

namespace Ex_Hello  // Declaring a namespace called Ex_Hello
{
   internal class Program  // Declaring an internal class named Program
   {
      static void Main(string[] args)  // Main method, the entry point of the program
      {
         // Prints "Hello Csharp!" followed by a newline
         Console.WriteLine("Hello Csharp!");

         // Prints "I am developer" followed by a tab space but does not move to a new line
         Console.Write("I am developer\t");

         // Prints "Write (no break line)" without moving to a new line
         Console.Write("Write (no break line)");

         // Waits for the user to press Enter before closing the console window
         Console.ReadLine();
      }
   }
}

/*Here's a brief explanation for each part of the code:

The using System; directive includes the System namespace, which is necessary for basic input/output operations.
The namespace Ex_Hello declaration creates a namespace named Ex_Hello to contain your class.
The internal class Program declaration defines a class named Program with internal accessibility, meaning it is 
accessible only within its containing assembly.
The static void Main(string[] args) method is the entry point of the program where execution starts.
The Console.WriteLine method writes a line of text to the console and moves the cursor to the next line.
The Console.Write method writes text to the console without moving to the next line.
The Console.ReadLine method waits for the user to press Enter, preventing the console window from closing 
immediately.*/