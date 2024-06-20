import java.math.BigDecimal;  // Importing the BigDecimal class from java.math package

public class Ex03_Variables {

    public static void main(String[] args){

        // Declaring and initializing variables of various types
        long longNum = 152389566L;  // long type
        System.out.println(longNum);

        int integerNum = 60000;  // int type
        System.out.println(integerNum);

        byte byteNum = -5;  // byte type
        System.out.println(byteNum);

        short shortNum = 3;  // short type
        System.out.println(shortNum);

        float floatNum = 0.2F;  // float type
        System.out.println(floatNum);

        double doubleNum = 52.5;  // double type
        System.out.println(doubleNum);

        char charType = 'a';  // char type
        System.out.println(charType);

        String stringType = "java";  // String type (a class in Java)
        System.out.println(stringType);

        boolean boolType = false;  // boolean type
        System.out.println(boolType);

        // Using BigDecimal for precise decimal values
        //Using BigDecimal with a String constructor is recommended for applications that require
        // precise decimal arithmetic, such as financial calculations or scientific computations
        // involving large or exact numbers.
        BigDecimal decimalNum = new BigDecimal("3.254578545655214554444114455522");
        System.out.println(decimalNum);
    }
}

/*Explanation:
Variable Declarations and Initialization:

long longNum = 152389566L;: Declares a variable longNum of type long initialized with value 152389566L.
int integerNum = 60000;: Declares a variable integerNum of type int initialized with value 60000.
byte byteNum = -5;: Declares a variable byteNum of type byte initialized with value -5.
short shortNum = 3;: Declares a variable shortNum of type short initialized with value 3.
float floatNum = 0.2F;: Declares a variable floatNum of type float initialized with value 0.2F.
double doubleNum = 52.5;: Declares a variable doubleNum of type double initialized with value 52.5.
char charType = 'a';: Declares a variable charType of type char initialized with character 'a'.
String stringType = "java";: Declares a variable stringType of type String (which is a class in Java) initialized with
 "java".
boolean boolType = false;: Declares a variable boolType of type boolean initialized with value false.

BigDecimal for Precise Decimal Values:

BigDecimal decimalNum = new BigDecimal("3.254578545655214554444114455522");: Uses BigDecimal to declare a variable
decimalNum initialized with a precise decimal value "3.254578545655214554444114455522".
BigDecimal is used here because it provides arbitrary-precision arithmetic and is suitable for handling precise
calculations involving decimal numbers with a large number of digits.

Outputting Variable Values:

System.out.println(variableName);: Prints the value of each variable to the console using println() method.

Notes:
Java supports different data types such as int, long, byte, short, float, double, char, String, boolean, and others.
BigDecimal is used when precise calculations are required, especially with decimal values that may exceed the range
of float or double.
This program demonstrates the basic usage of different data types and BigDecimal in Java, showcasing their roles
in handling various kinds of data and calculations*/