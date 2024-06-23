/* Write a program that reads values from the user until they input a 0.
 * After this, the program prints the total number of inputted values.
 * The zero that's used to exit the loop should not be included in the total number count.
 */

import java.util.Scanner;

public class Ex23_NumberOfNumbers {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int count = 0;

        // Infinite loop to continuously prompt the user for input
        while (true) {
            System.out.println("Give a number:"); // Prompt the user to input a number

            int inputNum = Integer.parseInt(scanner.nextLine()); // Read and convert the input to an integer

            if (inputNum == 0) {
                // If the input is 0, break the loop
                break;
            } else {
                // Increment the count for each valid input (non-zero)
                count++;
            }
        }

        // Print the total count of numbers entered, excluding the terminating zero
        System.out.println("Number of numbers: " + count);
        scanner.close(); // Close the scanner to free up resources
    }
}

/*Import Statement:

The Scanner class from java.util is imported to read user input.

Class Declaration:
The program is contained within the Ex23_NumberOfNumbers class.

Main Method:
The main method is the entry point of the program.

Scanner Initialization:
A Scanner object is created to read input from the console.

Infinite Loop:
A while (true) loop is used to continuously prompt the user for input.

User Prompt:
System.out.println("Give a number:"); prompts the user to input a number.

Input Reading and Conversion:
int inputNum = Integer.parseInt(scanner.nextLine()); reads the input from the user and converts it to an integer
 using Integer.parseInt.

Break Condition:
The loop checks if the input number is 0. If it is, the loop breaks, terminating the input process.

Count Increment:
For each valid (non-zero) input, the count variable is incremented to keep track of the total number of inputs.

Output the Result:
After the loop terminates, the program prints the total count of numbers entered using System.out.println("Number
 of numbers: " + count);.

Close Scanner:
scanner.close(); is called at the end to close the Scanner object and free up resources.*/