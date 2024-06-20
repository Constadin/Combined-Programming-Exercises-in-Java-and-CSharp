public class Ex05_FahrenheitToCelsius {
    public static void main(String[] args){

        int fahrenheit = 94;  // Temperature in Fahrenheit

        // Convert Fahrenheit to Celsius using the formula: (Fahrenheit - 32) * (5/9)
        double celsius = ((fahrenheit - 32) * (5.0 / 9.0));

        // Print the converted temperature in Celsius
        System.out.println("Temp Celsius: " + celsius);
    }
}

/*Explanation:
Variable Declaration and Initialization:

int fahrenheit = 94;: Declares and initializes an integer variable fahrenheit with the value 94, representing the
temperature in Fahrenheit.

Temperature Conversion Formula:

double celsius = ((fahrenheit - 32) * (5.0 / 9.0));: Calculates the temperature in Celsius using the formula
 (Fahrenheit - 32) * (5/9).
(5.0 / 9.0) ensures that the division results in a double value to maintain precision in the calculation.

Printing the Result:

System.out.println("Temp Celsius: " + celsius);: Outputs the converted temperature in Celsius to the console.
The + celsius appends the value of the celsius variable to the end of the string "Temp Celsius: ".

Notes:
Fahrenheit to Celsius Conversion Formula: (Fahrenheit - 32) * (5/9) is a standard formula used to convert temperatures
from Fahrenheit to Celsius.

Data Types: Using double for celsius ensures that fractional parts of the temperature are accurately represented,
as temperatures in Celsius can have decimal values.
Output: System.out.println() is used to print the result to the console, followed by the value of celsius.
This Java program demonstrates a straightforward conversion from Fahrenheit to Celsius using basic arithmetic
operations and ensures clarity with the output message.*/