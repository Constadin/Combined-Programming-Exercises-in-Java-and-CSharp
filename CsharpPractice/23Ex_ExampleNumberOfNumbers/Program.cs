/* Write a program that reads values from the user until they input a 0. 
 * After this, the program prints the total number of inputted values. 
 * The zero that's used to exit the loop should not be included in the total number count.
 */

using System;

namespace NumberOfNumbers
{
   internal class Program
   {
      public static void Main(string[] args)
      {
         int count = 0;

         // Infinite loop to continuously prompt the user for input
         while (true)
         {
            Console.WriteLine("Give a number:"); // Prompt the user to input a number

            int inputNumber = Convert.ToInt32(Console.ReadLine()); // Read and convert the input to an integer

            if (inputNumber == 0)
            {
               // If the input is 0, break the loop
               break;
            }

            // Increment the count for each valid input (non-zero)
            count++;
         }

         // Print the total count of numbers entered, excluding the terminating zero
         Console.WriteLine($"Number of numbers: {count}");
         Console.ReadLine(); // Keep the console open to view the result
      }
   }
}

/*Infinite Loop:

A while (true) loop is used to continuously prompt the user for input.

User Prompt:
Console.WriteLine("Give a number:"); prompts the user to input a number.

Input Reading and Conversion:
int inputNumber = Convert.ToInt32(Console.ReadLine()); reads the input from the user and 
converts it to an integer.

Break Condition:
The loop checks if the input number is 0. If it is, the loop breaks, terminating the input 
process.

Count Increment:
For each valid (non-zero) input, the count variable is incremented to keep track of the total
number of inputs.
Output the Result:

After the loop terminates, the program prints the total count of numbers entered using 
Console.WriteLine($"Number of numbers: {count}");.

Keep Console Open:
Console.ReadLine(); is used at the end to keep the console window open to view the result 
before the program exits.*/
