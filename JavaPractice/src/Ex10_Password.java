import java.util.Scanner;

public class Ex10_Password {
    public static void main(String[] args){

        Scanner reader = new Scanner(System.in);

        System.out.println("Give a Password");
        String inputPassword = reader.nextLine();

        if(inputPassword.equals("Caput Draconis")){
            System.out.println("Welcome!");
        }else{
            System.out.println("Off with you!");
        }
        reader.close();  // Closing the Scanner object to release resources
    }
}

/*Important Comments and Explanation:
Scanner reader = new Scanner(System.in);: Creates a Scanner object reader to read input from the console.
System.out.println("Give a Password");: Prompts the user to input a password.
String inputPassword = reader.nextLine();: Reads the user input as a string and assigns it to inputPassword.
if(inputPassword.equals("Caput Draconis")){: Checks if inputPassword is equal to the string "Caput Draconis".
Explanation: The equals() method in Java compares the contents of two strings. Here, it checks if the user
input (inputPassword) matches the exact string "Caput Draconis".
System.out.println("Welcome!");: Prints this message if the condition inputPassword.equals("Caput Draconis") is true.
System.out.println("Off with you!");: Prints this message if the condition inputPassword.equals("Caput Draconis")
is false, indicating that the user input does not match the expected password.
Explanation:
This Java program prompts the user to enter a password using Scanner, reads the input, and compares it to the string
"Caput Draconis". If the input matches, it prints "Welcome!", indicating successful authentication. If the input
does not match, it prints "Off with you!", indicating access denial. */
