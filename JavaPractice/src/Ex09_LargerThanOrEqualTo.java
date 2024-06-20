import java.util.Scanner;

public class Ex09_LargerThanOrEqualTo {
    public static void main(String[] args){

        Scanner scan = new Scanner(System.in);  // Scanner object for reading input from console

        System.out.println("Give the first number");  // Prompting user for the first number
        double firstNum = Double.valueOf(scan.nextLine());  // Reading user input as a double for the first number

        System.out.println("Give the second number");  // Prompting user for the second number
        double secondNum = Double.valueOf(scan.nextLine());  // Reading user input as a double for the second number

        if(firstNum > secondNum){
            System.out.println("Greater number is: "  + firstNum);  // Output if firstNum is greater than secondNum
        }else if(firstNum < secondNum){
            System.out.println("Greater number is: " + secondNum);  // Output if secondNum is greater than firstNum
        }else{
            System.out.println("The numbers are equal!");  // Output if both numbers are equal
        }
        scan.close();  // Closing the Scanner object to release resources
    }
}

/*Important Comments:
Scanner scan = new Scanner(System.in);: Creates a Scanner object to read input from the console.
System.out.println("Give the first number");: Prompts the user to input the first number.
double firstNum = Double.valueOf(scan.nextLine());: Reads the user input as a string, converts it to a double,
 and assigns it to firstNum.
System.out.println("Give the second number");: Prompts the user to input the second number.
double secondNum = Double.valueOf(scan.nextLine());: Reads the user input as a string, converts it to a double,
and assigns it to secondNum.
if(firstNum > secondNum){: Checks if firstNum is greater than secondNum.
System.out.println("Greater number is: " + firstNum);: Prints this message if firstNum is greater than secondNum.
else if(firstNum < secondNum){: Checks if firstNum is less than secondNum.
System.out.println("Greater number is: " + secondNum);: Prints this message if secondNum is greater than firstNum.
else{: Executes if neither of the above conditions is true, indicating that firstNum is equal to secondNum.
System.out.println("The numbers are equal!");: Prints this message if firstNum is equal to secondNum.*/
