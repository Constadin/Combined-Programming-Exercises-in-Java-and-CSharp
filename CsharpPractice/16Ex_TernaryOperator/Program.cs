using System; // Import the System namespace for basic functionalities like input/output.

namespace TernaryOperator // Define a namespace for organization and scope control.
{
   internal class Program // Main class of the program.
   {
      public static void Main(string[] strings) // Entry point of the program.
      {
         Console.WriteLine("Give a number"); // Prompt the user to enter a number.

         // Read the input from the user, convert it to a double, and store it in inputNumber.
         double inputNumber = Convert.ToDouble(Console.ReadLine());

         // If-else structure to handle the input based on its value.
         if (inputNumber == 0) // Check if the input number is zero.
         {
            int bufferNumber = (int)inputNumber; // Cast the input number to an integer.
            Console.WriteLine("Display inside (if): " + bufferNumber); // Display the result within the if-block.
         }
         else if (inputNumber > 0) // Check if the input number is greater than zero.
         {
            int bufferNumber = (int)(inputNumber + 1); // Increment the input number by 1 and cast to integer.
            Console.WriteLine("Display inside (else if): " + bufferNumber); // Display the result within the else-if block.
         }

         // Using a ternary operator to achieve the same conditional logic in a more compact form.
         int bufferNum = (inputNumber == 0) ? (int)inputNumber : (int)(inputNumber + 1);
         Console.WriteLine("Display with Ternary Operator: " + bufferNum); // Display the result using the ternary operator.

         Console.ReadLine();
      }
   }
}

/*Explanation :
 * 
Namespace and Class:
namespace TernaryOperator: Groups the program into a logical namespace.
internal class Program: The main class of the program.

Main Method:
public static void Main(string[] strings): The entry point of the program.

User Input and Conversion:
double inputNumber = Convert.ToDouble(Console.ReadLine());: Reads and converts the user input to a double.

If-Else Structure:
Handles input values of zero and greater than zero with conditional logic, casting to integer, and displaying 
the results.

Ternary Operator:
int bufferNum = (inputNumber == 0) ? (int)inputNumber : (int)(inputNumber + 1);: Uses a ternary operator for 
concise conditional logic.

Output:
Displays the results based on the if-else structure and the ternary operator.*/