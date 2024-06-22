/*Suppose you work for a manufacturing company. The company needs you to complete an inventory of
 * your warehouse to determine the number of products that are ready to ship. In addition to the
 * total number of finished products, you need to report the number of finished products stored in
 * each individual bin in your warehouse, along with a running total. This running total will be 
 * used to create an audit trail so you can double-check your work and identify "shrinkage".*/

using System;

namespace ForeachLoop;

internal class Program
{
   public static void Main(string[] args)
   {
      string[] fraudulentOrderIDs = new string[3];

      /* To declare the array initialize values in a single statement, enter the following code:
       
        string[] fraudulentOrderIDs = {"A123", "B456", "C789"} 

      */

      fraudulentOrderIDs[0] = "A123";//is the first item
      fraudulentOrderIDs[1] = "B456";
      fraudulentOrderIDs[2] = "C789";


      Console.WriteLine($"First: {fraudulentOrderIDs[0]}");//is the first item
      Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
      Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

      fraudulentOrderIDs[0] = "F000";

      Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");


      //foreach loop

      /*The foreach statement provides a simple, clean way to iterate through the elements of an 
       * array.
       * The foreach statement processes array elements in increasing index order, starting with
       * index 0 and ending with index Length - 1. It uses a temporary variable to hold the
       * value of 
       * the array element associated with the current iteration. Each iteration will run the 
       * code block that's located below the foreach declaration.*/

      Console.WriteLine("------------------------------");
      Console.WriteLine("Permeation Array");
      Console.WriteLine("------------------------------");
      foreach (string element in fraudulentOrderIDs)
      {
         Console.WriteLine("Element of array with value: " + element);
      }

      Console.ReadLine();
   }
}
