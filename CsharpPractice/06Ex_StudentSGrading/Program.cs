using System;  // Importing the System namespace which contains fundamental classes for basic input/output operations

namespace StudentsGrading  // Declaring a namespace called StudentsGrading
{
   internal class Program  // Declaring an internal class named Program
   {
      public static void Main(string[] args)  // Main method, the entry point of the program
      {
         // Number of current assignments
         int currentAssignments = 5;

         // Scores for Sophia's assignments
         int sophia1 = 93;
         int sophia2 = 87;
         int sophia3 = 98;
         int sophia4 = 95;
         int sophia5 = 100;

         // Scores for Nicolas' assignments
         int nicolas1 = 80;
         int nicolas2 = 83;
         int nicolas3 = 82;
         int nicolas4 = 88;
         int nicolas5 = 85;

         // Scores for Zahirah's assignments
         int zahirah1 = 84;
         int zahirah2 = 96;
         int zahirah3 = 73;
         int zahirah4 = 85;
         int zahirah5 = 79;

         // Scores for Jeong's assignments
         int jeong1 = 90;
         int jeong2 = 92;
         int jeong3 = 98;
         int jeong4 = 100;
         int jeong5 = 97;

         // Calculating the sum of scores for each student
         int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
         int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
         int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
         int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

         // Calculating the average score for each student
         decimal sophiaScore = (decimal)sophiaSum / currentAssignments;
         decimal nicolasScore = (decimal)nicolasSum / currentAssignments;
         decimal zahirahScore = (decimal)zahirahSum / currentAssignments;
         decimal jeongScore = (decimal)jeongSum / currentAssignments;

         // Displaying the student names, their average scores, and corresponding grades
         Console.WriteLine("Student\t\tGrade\n");
         Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
         Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
         Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
         Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");

         // Waiting for user input to keep the console window open
         Console.ReadLine();
      }
   }
}

/*Here's a brief explanation for each part of the code:

The using System; directive includes the System namespace, which is necessary for basic input/output operations.
The namespace StudentsGrading declaration creates a namespace named StudentsGrading to contain your class.
The internal class Program declaration defines a class named Program with internal accessibility, meaning it is 
accessible only within its containing assembly.
The public static void Main(string[] args) method is the entry point of the program where execution starts.
Scores for assignments are declared and initialized for each student.
The sum of scores for each student is calculated.
The average score for each student is calculated by dividing the sum by the number of assignments.
The Console.WriteLine method is used to print the student names, their average scores, and corresponding grades to 
the console.
Console.ReadLine is used to wait for user input before closing the console window.*/
