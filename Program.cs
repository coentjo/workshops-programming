// Here you can find info about the basics of programming
// @https://stasemsoft.github.io/FontysICT-sem1/docs/basic/

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Simple counting program
Console.WriteLine("Welcome to the counting program!");

// Loop from 1 to 5
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Number: {i}");
    
    // Add a small delay to make it easier to see each number
    Thread.Sleep(500);
}

Console.WriteLine("Counting finished!");
Console.WriteLine("Press the any key to exit...");
Console.ReadKey();

// While loop counting from 0 to 9 and showing multiplication table of 27
Console.WriteLine("\nMultiplication table of 27 using while loop:");
int count = 0;
while (count < 10)
{
    Console.WriteLine($"{count} x 27 = {count * 27}");
    count = count + 1;
}

// For loop doing the same thing
Console.WriteLine("\nMultiplication table of 27 using for loop:");
for (int k = 0; k < 10; k = k + 1)
{
    Console.WriteLine($"{k} x 27 = {k * 27}");
}

// Introduction to Methods:
// 1. A simple method that calculates the square of a number
static int Square(int number)
{
    return number * number;
}

// 2. A method that returns a multiplication for the table
static int MultiplyBy27(int number)
{
    return number * 27;
}

// 3. A more flexible method that can multiply by any number
static int Multiply(int number, int multiplier)
{
    return number * multiplier;
}

// Testing our methods:
Console.WriteLine("\nTesting methods:");
Console.WriteLine("Let's calculate some squares:");
for (int n = 1; n <= 5; n = n + 1)
{
    Console.WriteLine($"The square of {n} is: {Square(n)}");
}

Console.WriteLine("\nNow using our multiplication method:");
for (int n = 0; n < 10; n = n + 1)
{
    Console.WriteLine($"{n} x 27 = {MultiplyBy27(n)}");
}

// Testing our flexible multiplication method:
Console.WriteLine("\nTesting flexible multiplication method:");
// First with 7
Console.WriteLine("Table of 7:");
for (int n = 0; n < 10; n = n + 1)
{
    Console.WriteLine($"{n} x 7 = {Multiply(n, 7)}");
}

// Then with 12
Console.WriteLine("\nTable of 12:");
for (int n = 0; n < 10; n = n + 1)
{
    Console.WriteLine($"{n} x 12 = {Multiply(n, 12)}");
}

// Compare with our earlier method:
Console.WriteLine("\nComparing methods:");
int testNumber = 5;
Console.WriteLine($"Using MultiplyBy27: {testNumber} x 27 = {MultiplyBy27(testNumber)}");
Console.WriteLine($"Using Multiply:     {testNumber} x 27 = {Multiply(testNumber, 27)}");
// Both give the same result, but Multiply is more flexible!

// 4. A method that prints an entire multiplication table
static void PrintMultiplicationTable(int tableNumber)
{
    Console.WriteLine($"\nMultiplication table of {tableNumber}:");
    for (int n = 0; n < 10; n = n + 1)
    {
        // We reuse our Multiply method here!
        Console.WriteLine($"{n} x {tableNumber} = {Multiply(n, tableNumber)}");
    }
}

// Testing our table printing method:
Console.WriteLine("\nTesting our table printing method:");
PrintMultiplicationTable(6);  // Table of 6
PrintMultiplicationTable(8);  // Table of 8

// Now we can print any table with just one line of code!
Console.WriteLine("\nIsn't this much cleaner than writing the loop every time?");
PrintMultiplicationTable(13);
