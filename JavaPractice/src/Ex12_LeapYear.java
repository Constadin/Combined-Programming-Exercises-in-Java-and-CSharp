/*A year is a leap year if it is divisible by 4. However, if the year is divisible by 100,
then it is a leap year only when it is also divisible by 400.
Write a program that reads a year from the user, and checks whether or not it is a leap year.*/
import java.util.Scanner;

public class Ex12_LeapYear {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);  // Scanner object for reading input from console

        System.out.println("Give a year");  // Prompting user to input a year
        int inputYear = Integer.valueOf(scan.nextLine());  // Reading user input as an integer for the year

        // Checking if the input year is a leap year
        if((inputYear % 4 == 0 && inputYear % 100 != 0) || (inputYear % 400 == 0)){
            System.out.println("The year is a leap year.");  // Output if the year is a leap year
        }else{
            System.out.println("The year is not a leap year.");  // Output if the year is not a leap year
        }

        scan.close();  // Closing the Scanner object to release resources
    }
}

/*Important Comments and Explanation:
Scanner scan = new Scanner(System.in);: Creates a Scanner object scan to read input from the console.
System.out.println("Give a year");: Prompts the user to input a year.
int inputYear = Integer.valueOf(scan.nextLine());: Reads the user input as a string, converts it to an integer (int),
and assigns it to inputYear.
if((inputYear % 4 == 0 && inputYear % 100 != 0) || (inputYear % 400 == 0)){: Checks if inputYear is a leap year based
on the following conditions:
The year must be divisible by 4 (inputYear % 4 == 0).
It should not be divisible by 100 (inputYear % 100 != 0), unless...
It is also divisible by 400 (inputYear % 400 == 0).
Explanation: This condition checks the rules for determining leap years:
Years divisible by 4 are potential leap years.
Years divisible by 100 are not leap years unless they are also divisible by 400.
System.out.println("The year is a leap year.");: Prints this message if the condition for leap year is true.
System.out.println("The year is not a leap year.");: Prints this message if the condition for leap year is false.
scan.close();: Closes the Scanner object scan to release system resources.
Explanation:
This Java program determines whether a given year (input by the user) is a leap year or not based on the rules:
Leap years are divisible by 4.
They are not leap years if divisible by 100, unless they are also divisible by 400.*/

