using System;

// Define a class with a method that performs a mathematical operation
public class MathOperation
{
    // Define a method that performs a mathematical operation
    // and displays the second parameter
    public void PerformOperation(int number1, int number2)
    {
        // The mathematical operation could be anything; here it's an addition for example
        int result = number1 + number2;

        // Displaying the second parameter
        Console.WriteLine("The second number is: " + number2);
    }
}

public class Program
{
    // The Main method is the entry point of the console application
    public static void Main()
    {
        // Instantiating the MathOperation class
        MathOperation mathOp = new MathOperation();

        // Calling the PerformOperation method with two integer parameters
        mathOp.PerformOperation(5, 10);

        // Calling the method again, this time specifying the parameters by name
        mathOp.PerformOperation(number1: 5, number2: 10);

        // Waiting for a key press before closing the console window
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
