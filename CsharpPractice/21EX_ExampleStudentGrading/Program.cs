/* 
You're developing a Student Grading application that automates the calculation of grades for each student in a class. The parameters for your application are:

Create a C# console application.

Start with four students. Each student has five exam scores.

Each exam score is an integer value, 0-100, where 100 represents 100% correct.

A student's overall exam score is the average of their five exam scores.

Criteria for extra credit assignments:

Include extra credit assignment scores in the student's scores array.
Extra credit assignments are worth 10% of an exam score (when calculating the final numeric grade).
Add extra credit assignment scores to the student's total exam score before calculating the final numeric grade.
Your application needs to automatically assign letter grades based on the calculated final score for each student.

Your application needs to output/display each student’s name and formatted grade.

Your application needs to support adding other students and scores with minimal impact to the code.

You've already completed an initial version of the application. The Starter code project for this Guided project module includes a Program.cs file that provides the following code features:

The code declares variables used to define student names and individual exam scores for each student.
The code includes the variables and algorithms used to sum the exam scores and calculate the average exam score for each student.
The code includes a hard coded letter grade that the developer must apply manually.
The code includes Console.WriteLine() statements to display the student grading report.
Your goal is to update the existing code to include the following features:

Use arrays to store student names and assignment scores.

Use a foreach statement to iterate through the student names as an outer program loop.

Use an if statement within the outer loop to identify the current student name and access that 
student's assignment scores.

Use a foreach statement within the outer loop to iterate through the assignment scores array and
sum the values.

Use an updated algorithm within the outer loop to calculate the average exam score for each
student.

Use an if-elseif-else construct within the outer loop to evaluate the average exam score and 
assign a letter grade automatically.

Integrate extra credit scores when calculating the student's final score and letter grade as
follows:

Your code must detect extra credit assignments based on the number of elements in the student's 
scores array.
Your code must apply the 10% weighting factor to extra credit assignments before adding extra
credit scores to the sum of exam scores.
- use the following report format to report student grades: 

    Student         Grade

    Sophia:         92.2    A-
    Andrew:         89.6    B+
    Emma:           85.6    B
    Logan:          91.2    A-

grading chart that shows the letter grade corresponding to numeric scores.
   97 - 100   A+
   93 - 96    A
   90 - 92    A-
   87 - 89    B+
   83 - 86    B
   80 - 82    B-
   77 - 79    C+
   73 - 76    C
   70 - 72    C-
   67 - 69    D+
   63 - 66    D
   60 - 62    D-
   0  - 59    F
*/

using System;

namespace ExampleStudentGrading
{
   internal class Program
   {
      public static void Main(string[] args)
      {
         // Array to store student names
         string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

         // Arrays to store each student's exam scores, including extra credit scores
         int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
         int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
         int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
         int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
         int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
         int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
         int[] ericScores = new int[] { 80, 90, 50, 80, 90, 100, 80, 90 };
         int[] gregorScores = new int[] { 91, 70, 91, 55, 91, 91, 91 };

         // Variable to store the current student's letter grade
         string currentStudentLetterGrade = "";

         // Number of regular exam assignments
         int examAssignments = 5;

         // Temporary array to store the current student's scores
         int[] currentStudentScores = new int[10];

         // Print the header for the grade report
         Console.WriteLine("Student\t\tGrade");
         Console.WriteLine("=================================");

         // Iterate through each student
         foreach (string name in studentNames)
         {
            string currentStudent = name;

            // Assign the correct score array to the current student
            if (currentStudent == "Sophia")
               currentStudentScores = sophiaScores;
            else if (currentStudent == "Andrew")
               currentStudentScores = andrewScores;
            else if (currentStudent == "Emma")
               currentStudentScores = emmaScores;
            else if (currentStudent == "Logan")
               currentStudentScores = loganScores;
            else if (currentStudent == "Becky")
               currentStudentScores = beckyScores;
            else if (currentStudent == "Chris")
               currentStudentScores = chrisScores;
            else if (currentStudent == "Eric")
               currentStudentScores = ericScores;
            else if (currentStudent == "Gregor")
               currentStudentScores = gregorScores;
            else
               continue;

            // Variables to sum scores and count graded assignments
            int sumAssignmentScores = 0;
            decimal currentStudentGrade = 0.0M;
            int gradedAssignments = 0;

            // Sum the scores for the current student
            foreach (int score in currentStudentScores)
            {
               gradedAssignments += 1;

               // Check if the score is for a regular exam or extra credit
               if (gradedAssignments <= examAssignments)
                  sumAssignmentScores += score;  // Regular exam score
               else
                  sumAssignmentScores += score / 10;  // Extra credit score
            }

            // Calculate the average score for the student
            currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

            // Determine the letter grade based on the numeric grade
            if (currentStudentGrade >= 97)
               currentStudentLetterGrade = "A+";
            else if (currentStudentGrade >= 93)
               currentStudentLetterGrade = "A";
            else if (currentStudentGrade >= 90)
               currentStudentLetterGrade = "A-";
            else if (currentStudentGrade >= 87)
               currentStudentLetterGrade = "B+";
            else if (currentStudentGrade >= 83)
               currentStudentLetterGrade = "B";
            else if (currentStudentGrade >= 80)
               currentStudentLetterGrade = "B-";
            else if (currentStudentGrade >= 77)
               currentStudentLetterGrade = "C+";
            else if (currentStudentGrade >= 73)
               currentStudentLetterGrade = "C";
            else if (currentStudentGrade >= 70)
               currentStudentLetterGrade = "C-";
            else if (currentStudentGrade >= 67)
               currentStudentLetterGrade = "D+";
            else if (currentStudentGrade >= 63)
               currentStudentLetterGrade = "D";
            else if (currentStudentGrade >= 60)
               currentStudentLetterGrade = "D-";
            else
               currentStudentLetterGrade = "F";

            // Print the current student's name and grade
            Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade:F1}\t{currentStudentLetterGrade}");
         }

         // Pause the console to view the results
         Console.ReadLine();
      }
   }
}

/*Explanation and Comments:
Namespace and Class Definition:
The namespace and internal class Program are defined to encapsulate the program.

Main Method:
The Main method is the entry point of the console application.

Student Names Array:
An array studentNames is created to store the names of the students.

Scores Arrays:
Arrays for each student's scores are defined, including extra credit scores.

Current Student Letter Grade Variable:
A string variable to store the current student's letter grade.

Number of Regular Exams:
examAssignments is set to 5, representing the number of regular exams.

Temporary Array for Scores:
currentStudentScores is used to temporarily hold the scores of the current student.

Print Header:
A header is printed for the grade report.

Iterate Through Students:
A foreach loop iterates through each student in studentNames.

Assign Current Student Scores:
An if-else construct assigns the appropriate scores array to currentStudentScores.

Sum Scores and Count Assignments:
sumAssignmentScores accumulates the total score, and gradedAssignments counts the assignments.

Iterate Through Scores:
A nested foreach loop iterates through the scores array.

Calculate Total Score:
Regular exam scores are added directly, and extra credit scores are divided by 10 before adding.

Calculate Average Grade:
The average grade is calculated by dividing the total score by the number of regular exams.

Determine Letter Grade:
An if-else construct assigns a letter grade based on the numeric average.

Print Student Grade:
The student's name, numeric grade, and letter grade are printed.

Pause Console:
Console.ReadLine is used to pause the console to view the results*/