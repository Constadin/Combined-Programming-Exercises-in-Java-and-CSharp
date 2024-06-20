/*https://www.vero.fi/en/individuals/property/gifts/: A gift is a transfer of property to another person against no compensation or payment. If the total value of the gifts you receive from the same donor in the course of 3 years is €5,000 or more, you must pay gift tax.

When a gift is given by a close relative or a family member, the amount of gift tax is determined by the following table (source vero.fi):
For example 6000€ gift implies 180€ of gift tax (100 + (6000-5000) * 0.08), and 75000€ gift implies 7100€ of gift tax (4700 + (75000-55000) * 0.12).

Write a program that calculates the gift tax for a gift from a close relative or a family member. This is how the program should work:

Sample output
Value of the gift?
3500
No tax!*/


using System;

namespace GiftTax
{
   internal class Program
   {
      public static void Main(string[] args)
      {
         // Prompting the user to input the value of the gift
         Console.WriteLine("Value of the gift?");
         double giftValue = Convert.ToDouble(Console.ReadLine());

         // Checking if gift tax is applicable based on the value
         if (giftValue < 5000)
         {
            Console.WriteLine("No tax!");
         }
         else
         {
            // Calculating gift tax based on the provided table
            double giftTax = 0;

            if (giftValue <= 55000)
            {
               giftTax = 100 + (giftValue - 5000) * 0.08;
            }
            else if (giftValue <= 200000)
            {
               giftTax = 4700 + (giftValue - 55000) * 0.12;
            }
            else if (giftValue <= 1000000)
            {
               giftTax = 22100 + (giftValue - 200000) * 0.15;
            }
            else
            {
               giftTax = 142100 + (giftValue - 1000000) * 0.17;
            }

            // Displaying the calculated gift tax
            Console.WriteLine($"Gift tax amount: {giftTax} $");
         }

         // Waiting for user input to keep the console window open
         Console.ReadLine();
      }
   }
}

/*Explanation:
Namespace and Class Declaration:

namespace GiftTax defines the namespace.
internal class Program declares the class Program.

Main Method:

public static void Main(string[] args) is the entry point of the program.

User Input:

The program prompts the user to input the value of the gift with Console.WriteLine("Value of the gift?");.
Convert.ToDouble(Console.ReadLine()) reads the input string from the console and converts it to a double, 
storing it in giftValue.

Gift Tax Calculation:

The program checks if the giftValue is less than 5000. If true, it prints "No tax!".
If the giftValue is 5000 or more, it calculates the gift tax based on the provided table:
From €5,000 to €55,000: Tax = €100 + (giftValue - €5,000) * 0.08
From €55,001 to €200,000: Tax = €4,700 + (giftValue - €55,000) * 0.12
From €200,001 to €1,000,000: Tax = €22,100 + (giftValue - €200,000) * 0.15
Above €1,000,000: Tax = €142,100 + (giftValue - €1,000,000) * 0.17
The calculated gift tax is stored in the giftTax variable.
Output:

If no tax is applicable (giftValue < 5000), it prints "No tax!".
If tax is applicable, it prints the calculated gift tax using {giftTax:C} to format it as currency.
Pause Execution:

Console.ReadLine(); waits for the user to press Enter before closing the console window. This allows the user 
to see the output before the program terminates.*/