public class Ex06_StudentSGrading {

    public static void main(String[] args){
        // Number of current assignments
        int currentAssignments = 5;

        // Scores for Sophia
        int sophia1 = 93;
        int sophia2 = 87;
        int sophia3 = 98;
        int sophia4 = 95;
        int sophia5 = 100;

        // Scores for Nicolas
        int nicolas1 = 80;
        int nicolas2 = 83;
        int nicolas3 = 82;
        int nicolas4 = 88;
        int nicolas5 = 85;

        // Scores for Zahirah
        int zahirah1 = 84;
        int zahirah2 = 96;
        int zahirah3 = 73;
        int zahirah4 = 85;
        int zahirah5 = 79;

        // Scores for Jeong
        int jeong1 = 90;
        int jeong2 = 92;
        int jeong3 = 98;
        int jeong4 = 100;
        int jeong5 = 97;

        // Calculate total sum of scores for each student
        int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
        int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
        int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
        int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

        // Calculate average score for each student
        double sophiaScore = sophiaSum / (double) currentAssignments;
        double nicolasScore = nicolasSum / (double) currentAssignments;
        double zahirahScore = zahirahSum / (double) currentAssignments;
        double jeongScore = jeongSum / (double) currentAssignments;

        // Display the results
        System.out.println("Student\t\tGrade");
        System.out.println("Sophia:\t\t" + sophiaScore);
        System.out.println("Nicolas:\t" + nicolasScore);
        System.out.println("Zahirah:\t" + zahirahScore);
        System.out.println("Jeong:\t\t" + jeongScore);
    }
}

/*Explanation:
Variables:

currentAssignments: Represents the number of assignments each student has scores for.
sophia1 to sophia5, nicolas1 to nicolas5, etc.: Individual scores for each student across their assignments.

Calculations:

sophiaSum, nicolasSum, zahirahSum, jeongSum: Calculate the total sum of scores for each student by adding up their
individual assignment scores.

Average Calculation:

sophiaScore, nicolasScore, zahirahScore, jeongScore: Calculate the average score for each student by dividing their
total sum of scores (...Sum) by currentAssignments. Using (double) before currentAssignments ensures that the division
results in a double, preserving decimal precision.

Display:

System.out.println(): Outputs the results to the console, displaying each student's name followed
by their average grade.

Notes:
Data Types: The use of (double) for division ensures that the average scores are represented accurately with decimal
places, as integer division (/) would truncate the decimal part.
Output Formatting: Each student's name and their corresponding average grade are displayed neatly
using System.out.println().
This Java program efficiently calculates and displays the average grades for four students based on their assignment
scores, using appropriate data types and arithmetic operations.*/