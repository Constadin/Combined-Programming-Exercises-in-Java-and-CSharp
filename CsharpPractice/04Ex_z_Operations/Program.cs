/*Addition (+): Adds num1 and num2.
Subtraction (-): Subtracts num2 from num1.
Multiplication (*): Multiplies num1 by num2.
Division (/): Divides num1 by num2, checking first to ensure num2 is not zero to avoid division
 by zero.
Modulus (%): Computes the remainder of num1 divided by num2, again checking to ensure num2 is
not zero.*/

/*Logical AND (&&): True if both bool1 and bool2 are true.
Logical OR (||): True if either bool1 or bool2 is true.
Logical NOT (!): Negates the boolean value.
Combined Logical Operation: Demonstrates a more complex boolean expression.*/


/*Greater than (>): Checks if compNum1 is greater than compNum2.
Less than (<): Checks if compNum1 is less than compNum2.
Greater than or equal to (>=): Checks if compNum1 is greater than or equal to compNum2.
Less than or equal to (<=): Checks if compNum1 is less than or equal to compNum2.
Equal to (==): Checks if compNum1 is equal to compNum2.
Not equal to (!=): Checks if compNum1 is not equal to compNum2.*/
using System;

namespace ComprehensiveDemo
{
   class Program
   {
      static void Main(string[] args)
      {
         // Basic Arithmetic Operations
         Console.WriteLine("Arithmetic Operations:");
         Console.Write("Enter the first number: ");
         double num1 = Convert.ToDouble(Console.ReadLine());

         Console.Write("Enter the second number: ");
         double num2 = Convert.ToDouble(Console.ReadLine());

         // Addition
         double addition = num1 + num2;
         Console.WriteLine($"{num1} + {num2} = {addition}");

         // Subtraction
         double subtraction = num1 - num2;
         Console.WriteLine($"{num1} - {num2} = {subtraction}");

         // Multiplication
         double multiplication = num1 * num2;
         Console.WriteLine($"{num1} * {num2} = {multiplication}");

         // Division
         if (num2 != 0)
         {
            double division = num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {division}");
         }
         else
         {
            Console.WriteLine("Division by zero is not allowed.");
         }

         // Modulus
         if (num2 != 0)
         {
            double remainder = num1 % num2;
            Console.WriteLine($"{num1} % {num2} = {remainder}");
         }
         else
         {
            Console.WriteLine("Modulus by zero is not allowed.");
         }

         // Boolean Operations
         Console.WriteLine("\nBoolean Operations:");
         Console.Write("Enter the first boolean (true/false): ");
         bool bool1 = Convert.ToBoolean(Console.ReadLine());

         Console.Write("Enter the second boolean (true/false): ");
         bool bool2 = Convert.ToBoolean(Console.ReadLine());

         // Logical AND
         bool andResult = bool1 && bool2;
         Console.WriteLine($"{bool1} AND {bool2} = {andResult}");

         // Logical OR
         bool orResult = bool1 || bool2;
         Console.WriteLine($"{bool1} OR {bool2} = {orResult}");

         // Logical NOT
         bool notBool1 = !bool1;
         bool notBool2 = !bool2;
         Console.WriteLine($"NOT {bool1} = {notBool1}");
         Console.WriteLine($"NOT {bool2} = {notBool2}");

         // Combined logical operations
         bool combinedResult = (bool1 && bool2) || (!bool1 && !bool2);
         Console.WriteLine($"({bool1} AND {bool2}) OR (NOT {bool1} AND NOT {bool2}) = {combinedResult}");

         // Comparison Operations
         Console.WriteLine("\nComparison Operations:");
         Console.Write("Enter the first number: ");
         int compNum1 = Convert.ToInt32(Console.ReadLine());

         Console.Write("Enter the second number: ");
         int compNum2 = Convert.ToInt32(Console.ReadLine());

         // Greater than
         Console.WriteLine($"{compNum1} > {compNum2} : {compNum1 > compNum2}");

         // Less than
         Console.WriteLine($"{compNum1} < {compNum2} : {compNum1 < compNum2}");

         // Greater than or equal to
         Console.WriteLine($"{compNum1} >= {compNum2} : {compNum1 >= compNum2}");

         // Less than or equal to
         Console.WriteLine($"{compNum1} <= {compNum2} : {compNum1 <= compNum2}");

         // Equal to
         Console.WriteLine($"{compNum1} == {compNum2} : {compNum1 == compNum2}");

         // Not equal to
         Console.WriteLine($"{compNum1} != {compNum2} : {compNum1 != compNum2}");
      }
   }
}

