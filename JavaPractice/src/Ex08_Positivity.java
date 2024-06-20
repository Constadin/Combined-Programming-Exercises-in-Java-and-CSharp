import java.util.Scanner;

public class Ex08_Positivity {
    public static void main(String[] args){

        Scanner scanner = new Scanner(System.in);  // Scanner object for reading input from console

        System.out.println("Give a number");  // Prompting user for input
        double inputNum = Double.valueOf(scanner.nextLine());  // Reading user input as a double

        if(inputNum > 0){
            System.out.println("The number is positive");  // Output if input is greater than 0
        }else{
            System.out.println("The number is not positive");  // Output if input is 0 or negative
        }
        scanner.close();  // Closing the Scanner object to release resources
    }
}

/*Important Comments:
Scanner scanner = new Scanner(System.in);: Creates a Scanner object to read input from the console.
System.out.println("Give a number");: Prompts the user to input a number.
double inputNum = Double.valueOf(scanner.nextLine());: Reads the input from the user as a string, converts it to
 a double, and assigns it to inputNum.
if(inputNum > 0){: Checks if the inputNum is greater than 0.
System.out.println("The number is positive");: Prints this message if the condition inputNum > 0 is true.
System.out.println("The number is not positive");: Prints this message if the condition inputNum > 0 is false
 (i.e., if inputNum is 0 or negative).
*/
