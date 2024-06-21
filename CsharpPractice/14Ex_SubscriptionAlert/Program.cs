/*You've been asked to add a feature to your company's software. The feature is intended to 
 * improve the renewal rate of subscriptions to the software. Your task is to display a 
 * renewal message when a user logs into the software system and is notified their 
 * subscription will soon end. You'll need to add a couple of decision statements to properly
 * add branching logic to the application to satisfy the requirements.*/

using System;

namespace SubscriptionAlert
{
   internal class Program
   {
      public static void Main(string[] args)
      {
         // Create an instance of the Random class to generate random numbers.
         Random random = new Random();

         // Generate a random number between 0 and 11 (inclusive) to simulate days until subscription expiration.
         int daysUntilExpiration = random.Next(12);

         // Initialize the discount percentage variable to 0. This will be adjusted based on the days until expiration.
         int discountPercentage = 0;

         // Output the randomly generated number of days until expiration for debugging purposes.
         Console.WriteLine("Days Until Expiration: " + daysUntilExpiration);

         // Check if the subscription will expire within more than 5 but less than or equal to 10 days.
         if (daysUntilExpiration <= 10 && daysUntilExpiration > 5)
         {
            Console.WriteLine("Your subscription will expire soon. Renew now!");
         }
         // Check if the subscription will expire within 2 to 5 days.
         else if (daysUntilExpiration <= 5 && daysUntilExpiration > 1)
         {
            Console.WriteLine("Your subscription will expire soon. Renew now!");
            // Provide a 10% discount if the subscription will expire within 2 to 5 days.
            Console.WriteLine($"Renew now and save {discountPercentage + 10}%!");
         }
         // Check if the subscription will expire within 1 day.
         else if (daysUntilExpiration == 1)
         {
            Console.WriteLine("Your subscription expires within a day!");
            // Provide a 20% discount if the subscription will expire within 1 day.
            Console.WriteLine($"Renew now and save {discountPercentage + 20}%!");
         }
         // Check if the subscription has already expired.
         else if (daysUntilExpiration == 0)
         {
            Console.WriteLine("Your subscription has expired.");
         }
         Console.ReadLine();
      }
   }
}

/*Explanation:
Random Number Generation:

Random random = new Random(); initializes a random number generator.
int daysUntilExpiration = random.Next(12); generates a random number between 0 and 11 to
imulate the days remaining until the subscription expires.
Variable Initialization:

int discountPercentage = 0; initializes the discount percentage, which will be used to 
offerdiscounts based on how soon the subscription is expiring.
Debug Output:

Console.WriteLine("Days Until Expiration: " + daysUntilExpiration); prints the randomly
enerated days until expiration to the console. This is useful for debugging and Understanding
the flow of the program.
Conditional Statements:

The program uses if-else if statements to determine the appropriate message and discount 
based on the daysUntilExpiration value.
If daysUntilExpiration is between 6 and 10 (inclusive), it reminds the user to renew soon.
If daysUntilExpiration is between 2 and 5 (inclusive), it offers a 10% discount.
If daysUntilExpiration is 1, it offers a 20% discount and stresses the urgency.
If daysUntilExpiration is 0, it informs the user that the subscription has expired.
This setup ensures the user receives timely notifications and incentives to renew their 
subscription based on how close they are to the expiration date.*/