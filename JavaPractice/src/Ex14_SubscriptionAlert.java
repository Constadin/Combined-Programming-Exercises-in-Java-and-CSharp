/*You've been asked to add a feature to your company's software. The feature is intended to
 * improve the renewal rate of subscriptions to the software. Your task is to display a
 * renewal message when a user logs into the software system and is notified their
 * subscription will soon end. You'll need to add a couple of decision statements to properly
 * add branching logic to the application to satisfy the requirements.*/

import java.util.Random;
public class Ex14_SubscriptionAlert {

    public static void main(String[] args){

        Random random = new Random();
        int daysUntilExpiration = random.nextInt(12);
        int discountPercentage = 0;

        System.out.println("Discount Percentage :" + daysUntilExpiration);

        if(daysUntilExpiration <= 10 && daysUntilExpiration > 5){
            System.out.println("Your subscription will expire soon. Renew now!");

        }else if(daysUntilExpiration <= 5 && daysUntilExpiration >1){
            System.out.println("Your subscription will expire soon. Renew now!");
            System.out.println("Renew now and save " + (discountPercentage + 10) + "%!");

        }else if(daysUntilExpiration == 1){
            System.out.println("Your subscription expires within a day!.");
            System.out.println("Renew now and save " + (discountPercentage + 20) + "%!");

        }else if(daysUntilExpiration == 0){
            System.out.println("Your subscription has expired.");
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

Conditional Statements:

The program uses if-else if statements to determine the appropriate message and discount
based on the daysUntilExpiration value.
If daysUntilExpiration is between 6 and 10 (inclusive), it reminds the user to renew soon.
If daysUntilExpiration is between 2 and 5 (inclusive), it offers a 10% discount.
If daysUntilExpiration is 1, it offers a 20% discount and stresses the urgency.
If daysUntilExpiration is 0, it informs the user that the subscription has expired.
This setup ensures the user receives timely notifications and incentives to renew their
subscription based on how close they are to the expiration date.*/