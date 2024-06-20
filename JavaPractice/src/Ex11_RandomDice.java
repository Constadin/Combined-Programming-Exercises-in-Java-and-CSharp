import java.util.Random;

public class Ex11_RandomDice {
    public static void main(String[] args){

        Random diceNum = new Random();  // Random object for generating random numbers
        int max = 7;  // Upper bound for dice roll (exclusive)
        int min = 1;  // Lower bound for dice roll (inclusive)

        // Rolling three dice and calculating the total score
        int roll1 = diceNum.nextInt((max - min ) + 1) + min;
        int roll2 = diceNum.nextInt((max - min ) + 1) + min;
        int roll3 = diceNum.nextInt((max - min ) + 1) + min;
        int totalDice = roll1 + roll2 + roll3;

        System.out.println("Your Score: " + totalDice);  // Outputting the total score

        // Determining the game outcome based on the total score
        if(totalDice >= 14)
        {
            System.out.println("You win!");  // Output if the total score is 14 or more
        }
        else if(totalDice < 14)
        {
            System.out.println("Sorry, you lose.");  // Output if the total score is less than 14
        }
    }
}
/*Important Comments and Explanation:
Random diceNum = new Random();: Creates a Random object named diceNum for generating random numbers.
int max = 7;: Defines the maximum value (exclusive) that can be rolled on the dice (from 1 to 6).
int min = 1;: Defines the minimum value (inclusive) that can be rolled on the dice.
int roll1 = diceNum.nextInt((max - min ) + 1) + min;: Generates a random integer between min and max (inclusive)
for the first dice roll.
int roll2 = diceNum.nextInt((max - min ) + 1) + min;: Generates a random integer between min and max (inclusive)
for the second dice roll.
int roll3 = diceNum.nextInt((max - min ) + 1) + min;: Generates a random integer between min and max (inclusive)
for the third dice roll.
int totalDice = roll1 + roll2 + roll3;: Calculates the total score by summing the results of the three dice rolls.
System.out.println("Your Score: " + totalDice);: Prints the total score obtained from rolling three dice.
if(totalDice >= 14): Checks if the total score is 14 or more.
Explanation: If totalDice is 14 or greater, the program prints "You win!" indicating a winning outcome.
else if(totalDice < 14): Checks if the total score is less than 14.
Explanation: If totalDice is less than 14, the program prints "Sorry, you lose." indicating a losing outcome.
Explanation:
This Java program simulates a dice game where three dice are rolled randomly, and the total score is calculated.
It then determines the game outcome based on the total score:
If the total score is 14 or more, it prints "You win!".
If the total score is less than 14, it prints "Sorry, you lose.".*/
