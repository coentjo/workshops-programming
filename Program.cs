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
