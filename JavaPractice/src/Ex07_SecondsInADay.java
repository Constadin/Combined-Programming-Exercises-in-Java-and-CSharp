 import java.util.Scanner;
public class Ex07_SecondsInADay {
    public static void main(String[] args){
        Scanner scan = new Scanner(System.in);

        int hoursInAday = 24;
        int minutesInAHour = 60;
        int secondInAMinutes = 60;

        System.out.println("How many days would you like to Convert to seconds");
        int inputDays = Integer.valueOf(scan.nextLine());

        int seconds = inputDays * hoursInAday * minutesInAHour * secondInAMinutes;

        System.out.printf("%d Days is equal to %d sec.%n",inputDays,seconds);

        scan.close();  // Closing the Scanner object to release resources
    }
}

/*Explanation:
Import Statement:

import java.util.Scanner;: Imports the Scanner class from the java.util package, which is used for reading user input.

Scanner Initialization:

Scanner scan = new Scanner(System.in);: Creates a new Scanner object scan to read input from the standard input (keyboard).

Constants for Time Conversion:

int hoursInADay = 24;: Defines the number of hours in a day.
int minutesInAnHour = 60;: Defines the number of minutes in an hour.
int secondsInAMinute = 60;: Defines the number of seconds in a minute.
User Input:

System.out.println("How many days would you like to convert to seconds?");: Prompts the user to enter
the number of days.
int inputDays = Integer.valueOf(scan.nextLine());: Reads the user input as a string (scan.nextLine())
and converts it to an integer (Integer.valueOf()).

Calculation:

int seconds = inputDays * hoursInADay * minutesInAnHour * secondsInAMinute;: Computes the total number of
seconds by multiplying the number of days (inputDays) by the number of hours, minutes, and seconds in each day.

Output:

System.out.printf("%d Days is equal to %d sec.%n", inputDays, seconds);: Outputs the result using formatted string
(printf method), where %d is replaced by the corresponding values of inputDays and seconds.

Notes:
Scanner Usage: Scanner is used to read input from the user. scan.nextLine() reads the entire line as a string,
and Integer.valueOf() converts it to an integer.
Formatted Output: System.out.printf() is used for formatted output, which allows for precise control over how data
is displayed.
Constants: Using constants (hoursInADay, minutesInAnHour, secondsInAMinute) makes the code more readable and helps
in easy modification if the time units ever change.
This Java program efficiently converts days into seconds based on user input and demonstrates basic input handling,
arithmetic operations, and formatted output using printf.*/