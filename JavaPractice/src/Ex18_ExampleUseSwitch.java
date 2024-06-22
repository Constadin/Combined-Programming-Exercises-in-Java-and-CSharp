
import java.util.Random;
import java.util.Scanner;

public class Ex18_ExampleUseSwitch  {
    public static void main(String[] args) {
        // Create an instance of the Random class to generate random numbers
        Random dice = new Random();
        Scanner scanner = new Scanner(System.in);

        // Define a string for the "draw" condition
        String draw = "draw";

        // Define player names
        String playerA = "PlayerA";
        String playerB = "PlayerB";

        // Define hero names
        String heroA = "Superman";
        String heroB = "Batman";
        String heroC = "Captain_America";
        String heroD = "Wonder_Woman";

        // Prompt Player One to roll the dice
        System.out.println("Player One roll a dice (press enter)");
        scanner.nextLine(); // Wait for the player to press enter
        int rollePlayerA = dice.nextInt(6) + 1; // Generate a random number between 1 and 6
        System.out.println("Player One dice: " + rollePlayerA);

        // Prompt Player Two to roll the dice
        System.out.println("Player Two roll a dice (press enter)");
        scanner.nextLine(); // Wait for the player to press enter
        int rollePlayerB = dice.nextInt(6) + 1; // Generate a random number between 1 and 6
        System.out.println("Player Two dice: " + rollePlayerB);

        // Determine the winner or if it's a draw
        String winnerPlayer = (rollePlayerA > rollePlayerB) ? playerA : (rollePlayerA < rollePlayerB) ? playerB : draw;

        // Check for a draw condition
        if (winnerPlayer.equals("draw")) {
            System.out.println("There is a tie, the program is terminated");
            scanner.close();
            System.exit(0); // Exit the program
        }

        // Announce the winner and prompt to choose a hero
        System.out.println("Winner is: " + winnerPlayer + ". Choose your hero (1-4)");

        // Read the hero choice from the winner player
        int choiceWinnerPlayer = scanner.nextInt();

        // Assign the selected hero to the winning player using a switch statement
        switch (choiceWinnerPlayer) {
            case 1:
                if (winnerPlayer.equals("PlayerA")) {
                    playerA = heroA;
                    System.out.println("Your hero Name is " + playerA);
                } else if (winnerPlayer.equals("PlayerB")) {
                    playerB = heroA;
                    System.out.println("Your hero Name is " + playerB);
                }
                break;
            case 2:
                if (winnerPlayer.equals("PlayerA")) {
                    playerA = heroB;
                    System.out.println("Your hero Name is " + playerA);
                } else if (winnerPlayer.equals("PlayerB")) {
                    playerB = heroB;
                    System.out.println("Your hero Name is " + playerB);
                }
                break;
            case 3:
                if (winnerPlayer.equals("PlayerA")) {
                    playerA = heroC;
                    System.out.println("Your hero Name is " + playerA);
                } else if (winnerPlayer.equals("PlayerB")) {
                    playerB = heroC;
                    System.out.println("Your hero Name is " + playerB);
                }
                break;
            case 4:
                if (winnerPlayer.equals("PlayerA")) {
                    playerA = heroD;
                    System.out.println("Your hero Name is " + playerA);
                } else if (winnerPlayer.equals("PlayerB")) {
                    playerB = heroD;
                    System.out.println("Your hero Name is " + playerB);
                }
                break;
            default:
                // Handle invalid input
                System.out.println("Invalid value, the program is terminated");
                scanner.close();
                System.exit(0); // Exit the program
                break;
        }
        scanner.close(); // Close the scanner
    }
}
/*Explanations:
Import Statements:
The program imports java.util.Random for random number generation and java.util.Scanner for reading user input.

Main Method:
The main method is the entry point of the program. It is where the program starts execution.

Random Number Generation:
A Random object (dice) is created to generate random numbers, simulating dice rolls for the players.

Player and Hero Names:
Strings are defined for player names and hero names. These will be used later in the program.

User Interaction:
The program prompts the user (Player One and Player Two) to roll the dice by pressing enter.
The scanner.nextLine() method is used to pause until the user presses enter.

Dice Rolling:
The dice.nextInt(6) + 1 method generates a random number between 1 and 6 for each player.

Determine Winner:
A ternary operator is used to determine the winner based on the dice rolls. If the dice rolls are equal, it is a draw.

Draw Condition:
If it is a draw, the program prints a message and terminates using System.exit(0);

Hero Selection:
The winning player is prompted to choose a hero. The choice is read using scanner.nextInt().

Switch Statement:
A switch statement is used to assign the chosen hero to the winning player based on the player's input.
The switch statement is efficient for handling multiple possible input values.

Invalid Input:
The default case in the switch statement handles invalid inputs by printing a message and terminating the program.

Program Termination:
The program uses System.exit(0); to terminate under specific conditions, such as a draw or invalid hero selection.*/