using System;  // Importing the System namespace which contains fundamental classes for basic input/output operations

namespace Ex_ReadLine  // Declaring a namespace called Ex_ReadLine
{
   internal class Program  // Declaring an internal class named Program
   {
      public static void Main(string[] args)  // Main method, the entry point of the program
      {
         // Prompts the user to write a message
         Console.WriteLine("Write a message");

         // Reads a line of text from the console input and stores it in the variable msg
         string msg = Console.ReadLine();

         // Prints "Typing :" followed by the message inputted by the user
         Console.WriteLine("Typing :" + msg);
      }
   }
}
/*Here's a brief explanation for each part of the code:

The using System; directive includes the System namespace, which is necessary for basic input/output operations.
The namespace Ex_ReadLine declaration creates a namespace named Ex_ReadLine to contain your class.
The internal class Program declaration defines a class named Program with internal accessibility, meaning it is 
accessible only within its containing assembly.
The public static void Main(string[] args) method is the entry point of the program where execution starts.
The Console.WriteLine method writes a line of text to the console and moves the cursor to the next line, prompting 
the user to write a message.
The Console.ReadLine method reads a line of text inputted by the user from the console and stores it in the msg 
variable.
The Console.WriteLine method writes "Typing :" followed by the user input stored in the msg variable to the 
console.*/