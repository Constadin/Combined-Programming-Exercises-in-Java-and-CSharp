import java.util.Scanner;

public class Ex16_TernaryOperator {
    public static void main(String[] args){

        Scanner scan = new Scanner(System.in); // Initialize scanner for user input.

        System.out.println("Give a number");

        int inputNumber = Integer.valueOf(scan.nextLine()); // Read user input and convert to integer.

        // Conditional logic using if-else statements.
        if(inputNumber == 0){
            int bufferNumber = (int)inputNumber; // Cast inputNumber to int.
            System.out.println("Display inside (if): " + bufferNumber); // Display result for input 0.
        } else if(inputNumber > 0){
            int bufferNumber = (int)(inputNumber + 1); // Increment inputNumber by 1 and cast to int.
            System.out.println("Display inside (else if): " + bufferNumber); // Display result for positive input.
        }

        // Using ternary operator for conditional logic in a single line.
        int bufferNum = (inputNumber == 0) ? (int)inputNumber : (int)(inputNumber + 1);
        System.out.println("Display with Ternary Operator: " + bufferNum); // Display result using ternary operator.

        scan.close(); // Close the scanner to free resources.
    }
}

/*Explanation

Scanner Initialization:
Scanner scan = new Scanner(System.in);: Prepares to read user input.

User Input:
int inputNumber = Integer.valueOf(scan.nextLine());: Reads and converts user input to an integer.

If-Else Structure:
Handles different scenarios based on the input number (zero or positive) and prints corresponding results.

Ternary Operator:
int bufferNum = (inputNumber == 0) ? (int)inputNumber : (int)(inputNumber + 1);: Simplifies conditional logic
in a compact form.
 */

