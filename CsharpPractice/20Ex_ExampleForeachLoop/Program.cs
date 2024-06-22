/*The high-level purpose of this code is to  count the number of times a 
 particular character appears.*/

using System;

namespace CharacterCount
{
   internal class Program
   {
      public static void Main(string[] args)
      {
         // The string in which we want to count occurrences of a particular character
         string sentenceWords = "The quick brown fox jumps over the lazy dog.";

         // The character we are looking for
         char findChar = 'o';

         // Counter to keep track of the number of occurrences
         int counter = 0;

         // Enhanced for loop (foreach) to iterate over each character in the string
         foreach (char c in sentenceWords.ToCharArray())
         {
            // Check if the current character matches the character we are looking for
            if (c.Equals(findChar))
            {
               // If it matches, increment the counter
               counter = counter + 1;
               // or counter++;
            }
         }

         // Print the result
         Console.WriteLine($"Character '{findChar}' found {counter} times");

         // Keep the console open until a key is pressed
         Console.ReadLine();
      }
   }
}
/*The IEnumerable<char> interface in C# allows strings to be treated as sequences of characters
 * that can be iterated over using the foreach loop. This provides a simple and consistent way to
 * handle string iteration, leveraging the power of the .NET collections framework. By 
 * implementing IEnumerable<char>, the string class provides a built-in mechanism for iterating 
 * over its characters, enhancing code readability and maintainability.*/