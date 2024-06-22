using System;

namespace ExampleUseSwitch
{
   internal class Program
   {
      public static void Main(string[] args)
      {
         // Create an instance of the Random class to generate random numbers
         Random dice = new Random();

         // Define a string for the "draw" condition
         string draw = "draw";

         // Define player names
         string playerA = "PlayerA";
         string playerB = "PlayerB";

         // Define hero names
         string heroA = "Superman";
         string heroB = "Batman";
         string heroC = "Captain_America";
         string heroD = "Wonder_Woman";

         // Prompt Player One to roll the dice
         Console.WriteLine("Player One roll a dice (press enter)");
         Console.ReadLine(); // Wait for the player to press enter
         int rollePlayerA = dice.Next(1, 7); // Generate a random number between 1 and 5
         Console.WriteLine("Player One dice :" + rollePlayerA);

         // Prompt Player Two to roll the dice
         Console.WriteLine("Player Two roll a dice (press enter)");
         Console.ReadLine(); // Wait for the player to press enter
         int rollePlayerB = dice.Next(1, 7); // Generate a random number between 1 and 5
         Console.WriteLine("Player Two dice :" + rollePlayerB);

         // Determine the winner or if it's a draw
         string winnerPlayer = (rollePlayerA > rollePlayerB) ? playerA : (rollePlayerA < rollePlayerB) ? playerB : draw;

         // Check for a draw condition
         if (winnerPlayer.Equals("draw"))
         {
            Console.WriteLine("There is a tie, the program is terminated");
            Environment.Exit(0); // Exit the program
         }

         // Announce the winner and prompt to choose a hero
         Console.WriteLine("Winner is :" + winnerPlayer + ". Choose your hero (1-4)");

         // Read the hero choice from the winner player
         int choiseWinnerPlayer = Convert.ToInt16(Console.ReadLine());

         // Assign the selected hero to the winning player using a switch statement
         switch (choiseWinnerPlayer)
         {
            case 1:
               if (winnerPlayer == "PlayerA")
               {
                  playerA = heroA;
                  Console.WriteLine("Your hero Name is " + playerA);
               }
               else if (winnerPlayer == "PlayerB")
               {
                  playerB = heroA;
                  Console.WriteLine("Your hero Name is " + playerB);
               }
               break;
            case 2:
               if (winnerPlayer.Equals("PlayerA"))
               {
                  playerA = heroB;
                  Console.WriteLine("Your hero Name is " + playerA);
               }
               else if (winnerPlayer.Equals("PlayerB")) //like  winnerPlayer == "PlayerA"
               {
                  playerB = heroB;
                  Console.WriteLine("Your hero Name is " + playerB);
               }
               break;
            case 3:
               if (winnerPlayer == "PlayerA")
               {
                  playerA = heroC;
                  Console.WriteLine("Your hero Name is " + playerA);
               }
               else if (winnerPlayer == "PlayerB")
               {
                  playerB = heroC;
                  Console.WriteLine("Your hero Name is " + playerB);
               }
               break;
            case 4:
               if (winnerPlayer == "PlayerA")
               {
                  playerA = heroD;
                  Console.WriteLine("Your hero Name is " + playerA);
               }
               else if (winnerPlayer == "PlayerB")
               {
                  playerB = heroD;
                  Console.WriteLine("Your hero Name is " + playerB);
               }
               break;
            default:
               // Handle invalid input
               Console.WriteLine("Invalid value, the program is terminated");
               Environment.Exit(0); // Exit the program
               break;
         }
         // Keep the console window open until the user presses enter
         Console.ReadLine();
      }
   }
}

/*Explanations:
Namespace and Class:
The code is contained within a namespace (ExampleUseSwitch) and a class (Program), which is typical for C# applications.

Main Method:

The Main method is the entry point of the program. It is where the program starts execution.
Random Number Generation:
A Random object (dice) is created to generate random numbers, simulating dice rolls for the players.

Player and Hero Names:
Strings are defined for player names and hero names. These will be used later in the program.

User Interaction:
The program prompts the user (Player One and Player Two) to roll the dice by pressing enter. The Console.ReadLine() 
method is used to pause until the user presses enter.

Dice Rolling:
The dice.Next(1, 6) method generates a random number between 1 and 5 for each player.

Determine Winner:
A ternary operator is used to determine the winner based on the dice rolls. If the dice rolls are equal, it is a draw.

Draw Condition:
If it is a draw, the program prints a message and terminates using Environment.Exit(0);

Hero Selection:
The winning player is prompted to choose a hero. The choice is read using Convert.ToInt16(Console.ReadLine()).

Switch Statement:
A switch statement is used to assign the chosen hero to the winning player based on the player's input.
The switch statement is efficient for handling multiple possible input values.

Invalid Input:
The default case in the switch statement handles invalid inputs by printing a message and terminating the program.

Program Termination:
The program uses Environment.Exit(0); to terminate under specific conditions, such as a draw or invalid hero selection.*/