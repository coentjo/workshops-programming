// more info  and lesson material:   https://stasemsoft.github.io/FontysICT-sem1/
// of which the basics are explained in the following link:
// https://stasemsoft.github.io/FontysICT-sem1/docs/basic/
// and more advanced topics are explained in the following link:
// https://stasemsoft.github.io/FontysICT-sem1/docs/objects/


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

// Programming Basics Workshop
Console.WriteLine("Programming Basics Workshop!");

// Example of variables and types
int age = 18;
string message = "Welcome to programming!";
Console.WriteLine(message);

// If statement without else
if (age >= 18)
{
    Console.WriteLine("You are an adult");
}

// If-else statement
if (age < 21)
{
    Console.WriteLine("You cannot drink in the US");
}
else
{
    Console.WriteLine("You can drink in the US");
}

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();

// While loop counting 0-9
Console.WriteLine("\nCounting with while loop:");
int counter = 0;
while (counter < 10)
{
    Console.WriteLine(counter);
    counter++;
}

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();

// For loop counting 0-9
Console.WriteLine("\nCounting with for loop:");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
