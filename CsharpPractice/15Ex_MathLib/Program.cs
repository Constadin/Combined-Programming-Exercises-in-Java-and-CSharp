/*Write a program that reads two integers from the user and prints the square root of the
sum of these integers. The program does not need to work with negative values.
You can calculate the square root of an integer with the command Math.sqrt*/

using System;

namespace MathLib
{
   internal class Program
   {
      public static void Main(string[] args)
      {

         Console.WriteLine("Give First number");
         int number1 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Give Second number");
         int number2 = Convert.ToInt32(Console.ReadLine());

         int sumNumber = number1 + number2;
         double squareRoot = Math.Sqrt(sumNumber);

         Console.WriteLine(squareRoot);

         Console.ReadLine();
      }

      
   }
}
