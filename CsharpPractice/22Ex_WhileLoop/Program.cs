/*A loop consists of an expression that determines whether or not the code within the loop should be repeated,
 along with a block containing the source code to be repeated.
 A loop takes the following form.
 The loop can be broken out of with command 'break'. When a computer executes the command 'break',
 the program execution moves onto the next command following the loop block.
 */

//Write a program by using the loop example that asks "Shall we carry on?" until the user inputs the string "no".

using System;
namespace WhileLoop;

internal class Program
{
   public static void Main(string[] args)
   {
      while(true)
      {
         Console.WriteLine("Shall we carry on?");

         string inputChoise = Console.ReadLine();

         if(inputChoise.Equals("no") || inputChoise.Equals("NO"))
         {
            break;
         }
         else
         {
            Console.WriteLine("Ok! Let's carry on!");
         }
      }
      Console.WriteLine("System terminated");
      Environment.Exit(1);

   }
}
