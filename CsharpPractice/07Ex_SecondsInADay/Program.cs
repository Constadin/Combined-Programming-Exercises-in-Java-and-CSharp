using System;  // Importing the System namespace which contains fundamental classes for basic input/output operations

namespace SecondsInADay  // Declaring a namespace called SecondsInADay
{
   internal class Program  // Declaring an internal class named Program
   {
      public static void Main(string[] args)  // Main method, the entry point of the program
      {
         // Constants representing the number of hours, minutes, and seconds in a day
         int hoursInADay = 24;
         int minutesInAHour = 60;
         int secondsInAMinute = 60;

         // Asking the user for the number of days they want to convert to seconds
         Console.WriteLine("How many days would you like to Convert to seconds");
         int inputDays = Convert.ToInt32(Console.ReadLine());  // Reading the user input and converting it to an integer

         // Calculating the total number of seconds
         int seconds = inputDays * hoursInADay * minutesInAHour * secondsInAMinute;

         // Displaying the result
         Console.WriteLine($"{inputDays} Days is equal to {seconds} sec.");

         // Waiting for user input to keep the console window open
         Console.ReadLine();
      }
   }
}

/*Explanation:
Namespace and Class Declaration:

namespace SecondsInADay defines the namespace.
internal class Program declares the class Program.
Main Method:

public static void Main(string[] args) is the entry point of the program.
Constants Definition:

hoursInADay, minutesInAHour, and secondsInAMinute are defined as constants to represent the standard units of time.
User Input:

The program prompts the user to input the number of days they wish to convert to seconds.
Convert.ToInt32(Console.ReadLine()) reads and converts the input string to an integer.
Calculation:

The total number of seconds is calculated by multiplying the input days by the number of hours in a day, minutes
in an hour, and seconds in a minute.
Output:

Console.WriteLine outputs the result to the console in a formatted string.
Pause Execution:

Console.ReadLine() waits for the user to press Enter before closing the console window.*/