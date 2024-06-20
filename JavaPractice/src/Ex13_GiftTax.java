/* https://www.vero.fi/en/individuals/property/gifts/: A gift is a transfer of property to another person against no compensation or payment.
If the total value of the gifts
 you receive from the same donor in the course of 3 years is €5,000 or more, you must pay gift tax.
When a gift is given by a close relative or a family member, the amount of gift tax is determined by the following table
(source vero.fi):
For example 6000€ gift implies 180€ of gift tax (100 + (6000-5000) * 0.08), and 75000€ gift implies 7100€ of gift tax
(4700 + (75000-55000) * 0.12).
Write a program that calculates the gift tax for a gift from a close relative or a family member. This is how the
program should work:
Sample output
Value of the gift?
3500*/

import java.util.Scanner;
public class Ex13_GiftTax {
    public static void main(String[] args){

        Scanner scan = new Scanner(System.in);

        System.out.println("Value of the gift?");  // Prompting user for the value of the gift
        double inputGift = Double.valueOf(scan.nextLine());  // Reading user input and converting it to a double

        // Checking different ranges of gift values to calculate tax
        if(inputGift >= 5000 && inputGift <= 25000){
            double lowGift = 5000;
            double lowTax = 100;
            double rateTax = 0.08;

            // Calculating tax based on the formula provided
            double tax = (lowTax + (inputGift - lowGift) * rateTax);
            System.out.println("Tax: " + tax);  // Displaying calculated tax amount
        } else if(inputGift > 25000 && inputGift <= 55000){
            double lowGift = 25000;
            double lowTax = 1700;
            double rateTax = 0.10;

            double tax = (lowTax + (inputGift - lowGift) * rateTax);
            System.out.println("Tax: " + tax);
        } else if(inputGift > 55000 && inputGift <= 200000){
            double lowGift = 55000;
            double lowTax = 4700;
            double rateTax = 0.12;

            double tax = (lowTax + (inputGift - lowGift) * rateTax);
            System.out.println("Tax: " + tax);
        } else if(inputGift > 200000 && inputGift <= 1000000){
            double lowGift = 200000;
            double lowTax = 22100;
            double rateTax = 0.15;

            double tax = (lowTax + (inputGift - lowGift) * rateTax);
            System.out.println("Tax: " + tax);
        } else if(inputGift > 1000000){
            double lowGift = 1000000;
            double lowTax = 142100;
            double rateTax = 0.17;

            double tax = (lowTax + (inputGift - lowGift) * rateTax);
            System.out.println("Tax: " + tax);
        } else {
            System.out.println("No tax!");  // Output if the gift amount does not require tax payment
        }

        scan.close();  // Closing the Scanner object to release resources
    }
}

/*Important Comments and Explanation:
Scanner scan = new Scanner(System.in);: Creates a Scanner object scan to read input from the console.
System.out.println("Value of the gift?");: Prompts the user to input the value of the gift.
double inputGift = Double.valueOf(scan.nextLine());: Reads the user input as a string, converts it to a double
(double), and assigns it to inputGift.
The program uses multiple if-else statements to determine the tax amount based on the value of inputGift.
Each if-else block checks a specific range of gift values and calculates tax accordingly using predefined
variables lowGift, lowTax, and rateTax.
System.out.println("Tax: " + tax);: Displays the calculated tax amount based on the input gift value.
System.out.println("No tax!");: Prints this message if the gift value is below the taxable thresholds.
scan.close();: Closes the Scanner object scan to release system resources after reading input.
Explanation:
This Java program calculates gift tax based on the value of a gift entered by the user. It uses a series
of if-else statements to check different ranges of gift values and applies tax rates accordingly. The tax calculation
formula for each range is predefined using variables (lowGift, lowTax, rateTax), ensuring accurate tax computation
based on the input gift amount. The program concludes by printing the calculated tax amount or indicating no tax if
the gift amount is below the taxable thresholds.*/