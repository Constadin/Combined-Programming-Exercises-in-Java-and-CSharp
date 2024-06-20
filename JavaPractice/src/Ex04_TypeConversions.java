public class Ex04_TypeConversions {
    public static void main(String[] args){
        // int to long conversion
        long longType = 5235L; // Declare and initialize a long variable
        int intType = 500; // Declare and initialize an int variable

        longType = intType; // Implicit conversion from int to long
        System.out.print("Type of :" + ((Object) longType).getClass().getSimpleName()); // Output the type of longType
        System.out.println(" " + longType); // Output the value of longType

        // float to double conversion
        double doubleType = 5.256; // Declare and initialize a double variable
        float floatType = 2.5F; // Declare and initialize a float variable

        doubleType = floatType; // Implicit conversion from float to double
        System.out.print("Type of :" + ((Object) doubleType).getClass().getSimpleName()); // Output the type of doubleType
        System.out.println(" " + doubleType); // Output the value of doubleType

        // explicit type conversion (float to double)
        floatType = (float) doubleType; // Explicit conversion from double to float
        System.out.println("double to float: " + floatType); // Output the value of floatType

        // byte + byte results in an int, need explicit type conversion back to byte
        byte firstByte = 1; // Declare and initialize a byte variable
        byte secondByte = 2; // Declare and initialize a byte variable
        byte sumBytes = (byte) (firstByte + secondByte); // Sum of bytes converted back to byte

        System.out.println("Sum of Bytes: " + sumBytes); // Output the value of sumBytes

        //Notes:
        //Java supports implicit type conversion (widening conversion) from smaller to larger
        // data types (e.g., int to long, float to double).
        //Explicit type conversion (narrowing conversion) is required when converting from larger
        // to smaller data types or when mixing data types in expressions that result in a larger data type.
        //Operations involving byte, short, and char are promoted to int in expressions, so explicit
        // type casting is necessary to assign the result back to byte if needed.
    }
}

/*Explanation:
int to long Conversion:

long longType = 5235L;: Declares and initializes a long variable longType.
int intType = 500;: Declares and initializes an int variable intType.
longType = intType;: Implicitly converts intType to long and assigns it to longType.
System.out.print("Type of :" + ((Object) longType).getClass().getSimpleName());: Outputs the type of longType.
System.out.println(" " + longType);: Outputs the value of longType.

float to double Conversion:

double doubleType = 5.256;: Declares and initializes a double variable doubleType.
float floatType = 2.5F;: Declares and initializes a float variable floatType.
doubleType = floatType;: Implicitly converts floatType to double and assigns it to doubleType.
System.out.print("Type of :" + ((Object) doubleType).getClass().getSimpleName());: Outputs the type of doubleType.
System.out.println(" " + doubleType);: Outputs the value of doubleType.

Explicit Type Conversion (float to double):

floatType = (float) doubleType;: Explicitly converts doubleType to float and assigns it to floatType.
System.out.println("double to float: " + floatType);: Outputs the value of floatType.

Byte Addition and Conversion:

byte firstByte = 1;: Declares and initializes a byte variable firstByte.
byte secondByte = 2;: Declares and initializes a byte variable secondByte.
byte sumBytes = (byte) (firstByte + secondByte);: Sums firstByte and secondByte (resulting in an int), then converts the result back to byte.
System.out.println("Sum of Bytes: " + sumBytes);: Outputs the value of sumBytes.

Notes:
Java supports implicit type conversion (widening conversion) from smaller to larger data types (e.g., int to long, float to double).
Explicit type conversion (narrowing conversion) is required when converting from larger to smaller data types or when mixing data types in expressions that result in a larger data type.
Operations involving byte, short, and char are promoted to int in expressions, so explicit type casting is necessary to assign the result back to byte if needed.
This Java program demonstrates various type conversions and the use of explicit type casting to handle data of different types effectively.*/

