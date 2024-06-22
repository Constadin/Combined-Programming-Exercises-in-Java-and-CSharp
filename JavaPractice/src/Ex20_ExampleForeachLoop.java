/*The high-level purpose of this code is to  count the number of times a
 particular character appears.*/
public class Ex20_ExampleForeachLoop {

    public static void main(String[] args){
        String sentenceWords = "The quick brown fox jumps over the lazy dog.";

        char findChar = 'o';
        int counter = 0;

        for(char c : sentenceWords.toCharArray() ){

            if(c == findChar) {
                counter = counter + 1;
            }
        }
        System.out.println("Character " + "\'" + findChar + "\'" + " find " + counter + "times");
    }
}

/*Explanation:
String Initialization:

String sentenceWords = "The quick brown fox jumps over the lazy dog.";
This initializes a string variable sentenceWords with a sample sentence.
Character to Find:

char findChar = 'o';
Specifies the character 'o' that you want to count occurrences of in sentenceWords.
Counter Initialization:

int counter = 0;
Initializes an integer variable counter to store the count of occurrences of findChar.
For-each Loop:

for(char c : sentenceWords.toCharArray()) { ... }
Iterates over each character c in the array of characters obtained from sentenceWords using toCharArray() method.
This method converts the string sentenceWords into an array of characters, allowing you to iterate over each character
individually.
Conditional Check:

if(c == findChar) { counter = counter + 1; }
Checks if the current character c is equal to findChar.
If true, increments the counter by 1, indicating that findChar has been found at this position in the string.
Output the Result:

System.out.println("Character " + "\'" + findChar + "\'" + " find " + counter + " times");
Prints the result after the loop completes.
Constructs a string that indicates which character (findChar) was searched for and how many times it was found (counter).
Key Points:
Usage of toCharArray():

Converts the string into an array of characters, which is useful when you need to iterate through each character individually.
Comparison with ==:

For primitive types like char, use == to compare values directly.
This checks if the current character (c) is equal to the specified character (findChar).
Incrementing the Counter:

Increases the counter each time findChar is found in the string.
This code effectively achieves its purpose of counting occurrences of a specific character within a string using
 a for-each loop and basic conditional logic. It's a straightforward and efficient way to perform such a task in Java.*/
