public class Ex19_ForeachLoop {
    public static void main(String[] args){


        /* Initializing the inventory array with some example integers
        int[] inventory = new int[5];

        // Assigning values to the inventory array
        inventory[0] = 10;  // First element
        inventory[1] = 20;  // Second element
        inventory[2] = 30;  // Third element
        inventory[3] = 40;  // Fourth element
        inventory[4] = 50;  // Fifth element*/

         int[] inventory = { 200, 450, 700, 175, 250 };

        // Displaying the items in the inventory
        // Note: Array indices start at 0, so inventory[0] is the first item
        System.out.println("first  " + inventory[0]);
        System.out.println("second " + inventory[1]);
        System.out.println("third  " + inventory[2]);
        System.out.println("fourth " + inventory[3]);
        System.out.println("fifth  " + inventory[4]);

        System.out.println("------------------------------");
        System.out.println("Permeation Array");
        System.out.println("------------------------------");
        for(int element : inventory){
           System.out.println("Element of array with value: " + element);
        }
    }
}
/*The statement for(int element : inventory) is an example of the enhanced for loop
(also known as the foreach loop) in Java. This type of loop is used to iterate over elements in arrays or collections,
simplifying the process of accessing each element.
How it works:
The loop iterates over each element in the inventory array.
In each iteration, the current element is assigned to the element variable.
The code inside the loop body executes for each element in the inventory array.
The enhanced for loop automatically handles the indexing of the array or collection, making thefor loops.
It is especially useful when you only need to access each element directly and do not need the index of the elements.
This loop cannot be used if you need to modify the array
 */