import java.util.Scanner;

public class Ex17_SwitchCase {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        System.out.println("Give a Character A, B, C, D");

        // Read a line of input from the user and extract the first character
        char inputChar = scan.nextLine().charAt(0);

        // Switch statement to evaluate the input character
        switch (inputChar) {
            case 'A':
                System.out.println("Inside case A");
                break;
            case 'B':
                System.out.println("Inside case B");
                break;
            case 'C':
                System.out.println("Inside case C");
                break;
            case 'D':
                System.out.println("Inside case D");
                break;
            default:
                System.out.println("Default case");
                break;
        }

        scan.close(); // Close the Scanner object to release resources
    }
}

/*Switch Statement:

switch (inputChar) { ... }: This statement evaluates the value of inputChar and executes the corresponding
case block based on its value.

charAt(0) Method:
char inputChar = scan.nextLine().charAt(0);
scan.nextLine() reads the entire line of input entered by the user.
charAt(0) extracts the character at index 0 from the input string. In this case, it retrieves the first character
entered by the user.

Switch Cases:
Each case represents a possible value of inputChar.
When inputChar matches 'A', 'B', 'C', or 'D', the corresponding block of code executes:
For example, if inputChar is 'A', it prints "Inside case A".

Default Case:
default: is executed if none of the case values match inputChar.
In this code, it prints "Default case" when the user enters a character other than 'A', 'B', 'C', or 'D'.*/