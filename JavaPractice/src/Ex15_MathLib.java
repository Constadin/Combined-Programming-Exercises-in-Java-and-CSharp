/*You've been asked to add a feature to your company's software. The feature is intended to
 * improve the renewal rate of subscriptions to the software. Your task is to display a
 * renewal message when a user logs into the software system and is notified their
 * subscription will soon end. You'll need to add a couple of decision statements to properly
 * add branching logic to the application to satisfy the requirements.*/

import java.util.Scanner;

public class Ex15_MathLib {
    public static void main(String[] args) {

        // Create a Scanner object for reading input from the console.
        Scanner scan = new Scanner(System.in);

        // Prompt the user to input the first number.
        System.out.println("Give first number");

        // Read the user input, convert it to an integer, and store it in variable number1.
        int number1 = Integer.valueOf(scan.nextLine());

        // Prompt the user to input the second number.
        System.out.println("Give second number");

        // Read the user input, convert it to an integer, and store it in variable number2.
        int number2 = Integer.valueOf(scan.nextLine());

        // Calculate the sum of number1 and number2 and store it in variable sumNumbers.
        int sumNumbers = number1 + number2;

        // Calculate the square root of sumNumbers using the Math.sqrt method and store it in variable squareRoot.
        double squareRoot = Math.sqrt(sumNumbers);

        // Output the square root of the sum of the two numbers to the console.
        System.out.println("The square root of the sum (" + number1 + " + " + number2 + " = " + sumNumbers + ") is: " + squareRoot);

        // Close the Scanner object to prevent resource leaks.
        scan.close();
    }
}

/*Explanation of Key Parts:
Scanner Initialization:

Scanner scan = new Scanner(System.in); initializes a Scanner object to read user input from the console.
User Input:

System.out.println("Give first number"); prompts the user to input the first number.
int number1 = Integer.valueOf(scan.nextLine()); reads the user input from the console, converts it to an integer,
 and stores it in number1.
System.out.println("Give second number"); prompts the user to input the second number.
int number2 = Integer.valueOf(scan.nextLine()); reads the user input from the console, converts it to an integer,
 and stores it in number2.
Sum Calculation:

int sumNumbers = number1 + number2; calculates the sum of number1 and number2, and stores the result in sumNumbers.
Square Root Calculation:

double squareRoot = Math.sqrt(sumNumbers); calculates the square root of sumNumbers using the Math.sqrt method and
stores the result in squareRoot.
Output:

System.out.println("The square root of the sum (" + number1 + " + " + number2 + " = " + sumNumbers + ") is: " + squareRoot);
prints the sum of the two numbers and its square root to the console.
Resource Management:

scan.close(); closes the Scanner object to prevent resource leaks, ensuring proper management of system resources.*/