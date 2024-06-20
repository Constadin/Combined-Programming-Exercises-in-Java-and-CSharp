import java.util.Scanner;  // Importing the Scanner class from java.util package

public class Ex02_InputScanner {
    public static void main(String[] args){
        Scanner scan = new Scanner(System.in);  // Creating a Scanner object for user input

        System.out.println("Write a message");  // Prompting the user to input a message

        String msg = scan.nextLine();  // Reading the entire input line from the user
        System.out.println("typing :" + msg);  // Displaying the input message prefixed with "typing :"

        scan.close();  // Closing the Scanner object to release resources
    }
}

/*

Explanation:
Import Statement:

import java.util.Scanner;: Imports the Scanner class from the java.util package, allowing us to use it in our code
to read input from the user.

Class Declaration:

public class Ex02_InputScanner  Defines a public class named Ex02_InputScanner.

Main Method:

public static void main(String[] args) {: This is the main method, which serves as the entry point for the program.

Creating a Scanner Object:

Scanner scan = new Scanner(System.in);: Creates a new Scanner object named scan that reads input from the standard
input stream (System.in). This allows the program to read user input from the console.

Prompting User Input:

System.out.println("Write a message");: Prints the message "Write a message" to the console, prompting the user to
input a message.

Reading User Input:

String msg = scan.nextLine();: Reads the entire line of input entered by the user and stores it in the variable msg of
type String. nextLine() reads the input until it encounters a newline character (\n).

Displaying User Input:

System.out.println("typing :" + msg);: Prints the message "typing :" followed by the user input (msg) to the console.
 The + operator concatenates the strings together.

Notes:
Scanner class is used for obtaining input of primitive types (int, double, etc.) and strings. It provides various
methods like nextLine() to read different types of input.
scan.nextLine() waits for the user to enter a complete line of text and then captures that input.
System.out.println() is used to print the output to the console along with a newline character, moving to the next line
after printing.
This Java program demonstrates how to use Scanner to read user input and then display that input back to the
console with a prefixed message, providing basic interaction between the user and the program.*/
