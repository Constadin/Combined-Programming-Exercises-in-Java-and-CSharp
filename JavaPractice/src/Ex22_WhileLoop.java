/*A loop consists of an expression that determines whether or not the code within the loop should be repeated,
 along with a block containing the source code to be repeated.
 A loop takes the following form.
 The loop can be broken out of with command 'break'. When a computer executes the command 'break',
 the program execution moves onto the next command following the loop block.
 */

import java.util.Scanner;
//Write a program by using the loop example that asks "Shall we carry on?" until the user inputs the string "no".


public class Ex22_WhileLoop {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        // Infinite loop to repeatedly ask the user if they want to continue
        while (true) {
            System.out.println("Shall we carry on?");

            String inputChoice = scan.nextLine();

            // Check if the user input is "no"
            if (inputChoice.equals("no") || inputChoice.equals("NO")) {
                break;  // Exit the loop if the user input is "no"
            } else {
                System.out.println("Ok! Let's carry on!");
            }
        }

        System.out.println("System terminated");
        System.exit(1);  // Terminate the program
    }
}

/*Explanation of Test
Initialization:
Scanner scan = new Scanner(System.in); initializes a Scanner object to read input from the user.

While Loop:
while (true) starts an infinite loop, repeatedly executing the code inside until a break statement is encountered.

Prompt User:
System.out.println("Shall we carry on?"); asks the user if they want to continue.

Read Input:
String inputChoice = scan.nextLine(); reads the user's input.

Check Input:
if (inputChoice.equals("no")) { checks if the user entered "no".
If true, break; exits the loop.
Otherwise, System.out.println("Ok! Let's carry on!"); prints a message indicating that the loop will continue.

Termination:
System.out.println("System terminated"); prints a termination message after exiting the loop.
System.exit(1); terminates the program explicitly.*/