/*Addition (+): Adds num1 and num2.
Subtraction (-): Subtracts num2 from num1.
Multiplication (*): Multiplies num1 by num2.
Division (/): Divides num1 by num2, checking first to ensure num2 is not zero to avoid division
 by zero.
Modulus (%): Computes the remainder of num1 divided by num2, again checking to ensure num2 is
not zero.*/

/*Logical AND (&&): True if both bool1 and bool2 are true.
Logical OR (||): True if either bool1 or bool2 is true.
Logical NOT (!): Negates the boolean value.
Combined Logical Operation: Demonstrates a more complex boolean expression.*/


/*Greater than (>): Checks if compNum1 is greater than compNum2.
Less than (<): Checks if compNum1 is less than compNum2.
Greater than or equal to (>=): Checks if compNum1 is greater than or equal to compNum2.
Less than or equal to (<=): Checks if compNum1 is less than or equal to compNum2.
Equal to (==): Checks if compNum1 is equal to compNum2.
Not equal to (!=): Checks if compNum1 is not equal to compNum2.*/

import java.util.Scanner;

public class Ex04_z_Operations {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Basic Arithmetic Operations
        System.out.println("Arithmetic Operations:");
        System.out.print("Enter the first number: ");
        double num1 = Double.valueOf(scanner.nextLine());

        System.out.print("Enter the second number: ");
        double num2 = Double.valueOf(scanner.nextLine());

        // Addition
        double addition = num1 + num2;
        System.out.println(num1 + " + " + num2 + " = " + addition);

        // Subtraction
        double subtraction = num1 - num2;
        System.out.println(num1 + " - " + num2 + " = " + subtraction);

        // Multiplication
        double multiplication = num1 * num2;
        System.out.println(num1 + " * " + num2 + " = " + multiplication);

        // Division
        if (num2 != 0) {
            double division = num1 / num2;
            System.out.println(num1 + " / " + num2 + " = " + division);
        } else {
            System.out.println("Division by zero is not allowed.");
        }

        // Modulus
        if (num2 != 0) {
            double remainder = num1 % num2;
            System.out.println(num1 + " % " + num2 + " = " + remainder);
        } else {
            System.out.println("Modulus by zero is not allowed.");
        }

        // Boolean Operations
        System.out.println("\nBoolean Operations:");
        System.out.print("Enter the first boolean (true/false): ");
        boolean bool1 = Boolean.valueOf(scanner.nextLine());

        System.out.print("Enter the second boolean (true/false): ");
        boolean bool2 = Boolean.valueOf(scanner.nextLine());

        // Logical AND
        boolean andResult = bool1 && bool2;
        System.out.println(bool1 + " AND " + bool2 + " = " + andResult);

        // Logical OR
        boolean orResult = bool1 || bool2;
        System.out.println(bool1 + " OR " + bool2 + " = " + orResult);

        // Logical NOT
        boolean notBool1 = !bool1;
        boolean notBool2 = !bool2;
        System.out.println("NOT " + bool1 + " = " + notBool1);
        System.out.println("NOT " + bool2 + " = " + notBool2);

        // Combined logical operations
        boolean combinedResult = (bool1 && bool2) || (!bool1 && !bool2);
        System.out.println("(" + bool1 + " AND " + bool2 + ") OR (NOT " + bool1 + " AND NOT " + bool2 + ") = " + combinedResult);

        // Comparison Operations
        System.out.println("\nComparison Operations:");
        System.out.print("Enter the first number: ");
        int compNum1 = Integer.valueOf(scanner.nextLine());

        System.out.print("Enter the second number: ");
        int compNum2 = Integer.valueOf(scanner.nextLine());

        // Greater than
        System.out.println(compNum1 + " > " + compNum2 + " : " + (compNum1 > compNum2));

        // Less than
        System.out.println(compNum1 + " < " + compNum2 + " : " + (compNum1 < compNum2));

        // Greater than or equal to
        System.out.println(compNum1 + " >= " + compNum2 + " : " + (compNum1 >= compNum2));

        // Less than or equal to
        System.out.println(compNum1 + " <= " + compNum2 + " : " + (compNum1 <= compNum2));

        // Equal to
        System.out.println(compNum1 + " == " + compNum2 + " : " + (compNum1 == compNum2));

        // Not equal to
        System.out.println(compNum1 + " != " + compNum2 + " : " + (compNum1 != compNum2));

        scanner.close();
    }

}
