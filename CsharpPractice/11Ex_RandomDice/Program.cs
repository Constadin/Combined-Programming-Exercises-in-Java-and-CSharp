using System;  // Importing the System namespace which contains fundamental classes for basic input/output operations

namespace RandomDice  // Declaring a namespace called RandomDice
{
   internal class Program  // Declaring an internal class named Program
   {
      public static void Main(string[] args)  // Main method, the entry point of the program
      {
         Random diceNum = new Random();  // Creating a new instance of the Random class to generate random numbers

         // Rolling three dice and storing the results in variables
         int roll1 = diceNum.Next(1, 7);  // Generates a random integer between 1 and 6 (inclusive)
         int roll2 = diceNum.Next(1, 7);  // Generates a random integer between 1 and 6 (inclusive)
         int roll3 = diceNum.Next(1, 7);  // Generates a random integer between 1 and 6 (inclusive)

         // Calculating the total score of the dice rolls
         int totalDice = roll1 + roll2 + roll3;

         // Displaying the total score to the user
         Console.WriteLine("Your Score: " + totalDice);

         // Checking if the total score meets or exceeds 14
         if (totalDice >= 14)
         {
            // If the total score is 14 or higher, the player wins
            Console.WriteLine("You win!");
         }
         else
         {
            // If the total score is less than 14, the player loses
            Console.WriteLine("Sorry, you lose.");
         }

         // Waiting for user input to keep the console window open
         Console.ReadLine();
      }
   }
}

/*Explanation:
Namespace and Class Declaration:

namespace RandomDice defines the namespace.
internal class Program declares the class Program.

Main Method:

public static void Main(string[] args) is the entry point of the program.

Random Number Generation:

Random diceNum = new Random(); creates a new instance of the Random class, which will be used to generate 
random numbers.

Dice Rolls:

diceNum.Next(1, 7); is used three times to simulate rolling a six-sided die (1 is inclusive and 7 is 
exclusive), storing the results in roll1, roll2, and roll3.
Total Score Calculation:

int totalDice = roll1 + roll2 + roll3; calculates the total score by summing up the results of the three dice 
rolls.

Output:

Console.WriteLine("Your Score: " + totalDice); displays the total score to the user.

Win/Lose Condition:

if (totalDice >= 14) checks if the total score is 14 or higher. If true, it prints "You win!".
If the total score is less than 14 (else case), it prints "Sorry, you lose.".

Pause Execution:

Console.ReadLine(); waits for the user to press Enter before closing the console window. This allows the user 
to see the output before the program terminates.*/