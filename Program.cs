using System;
// 1. Write a program that allows the user to enter a number then print it.
Console.WriteLine("--- Program 1 ---");
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("You entered: " + number);

// 2. Write C# program that converts a string to an integer, but the string contains non-numeric characters.
Console.WriteLine("\n--- Program 2 ---");
string input = "Mohamed38";
try
{
    int convertedNumber = int.Parse(input);
    Console.WriteLine("Converted: " + convertedNumber);
}
catch (FormatException)
{
    Console.WriteLine("Error: String contains non-numeric characters.");
}
// the code will return an error message but i used try catch to prevent it from terminating the program

// 3. Write C# program that Perform a simple arithmetic operation with floating-point numbers
Console.WriteLine("\n--- Program 3 ---");
double num1 = 0.1;
double num2 = 0.2;
double sum = num1 + num2;
Console.WriteLine("Sum: " + sum); 
// it performs the arithmatic operation with a slite Error in its calc

// 4. Write C# program that Extract a substring from a given string.
Console.WriteLine("\n--- Program 4 ---");
string text = "Hello, World!";
string substring = text.Substring(7, 5);
// the comma and the white space both count as chharacters plus that the index starts from 0 so we start the substring from the 8th char (W in World)
Console.WriteLine("Substring: " + substring);

// 5. Write C# program that Assigning one value type variable to another and modifying the value
Console.WriteLine("\n--- Program 5 ---");
int Value = 10;
int copiedValue = Value;
copiedValue = 20;
Console.WriteLine($"Original: {Value}, Copied: {copiedValue}");
// the copied value changes while the original remains the same

// 6. Write C# program that Assigning one reference type variable to another and modifying the object
Console.WriteLine("\n--- Program 6 ---");
int[] Array = { 1, 2, 3 };
int[] referenceArray = Array;
referenceArray[0] = 99;
Console.WriteLine($"Original array[0]: {Array[0]}, Copied array[0]: {referenceArray[0]}");
// both values change since both have the same value in mem

// 7. Write C# program that take two string variables and print them as one variable
Console.WriteLine("\n--- Program 7 ---");
string first = "Hello";
string second = "World";
string combined = first + " " + second;
Console.WriteLine(combined);

// 8. Which statement is correct about the code snippet?
Console.WriteLine("\n--- Question 8 ---");
int d;
d = Convert.ToInt32(!(30 < 20));
Console.WriteLine("Value of d: " + d); // Outputs 1 (Answer: A value 1 will be assigned to d)

// 9. Which is the correct output for the code?
Console.WriteLine("\n--- Question 9 ---");
Console.WriteLine(13 / 2 + " " + 13 % 2); // Outputs "6 1" (Answer: 6 1)

// 10. What will be the output of the code?
Console.WriteLine("\n--- Question 10 ---");
int num = 1, z = 5;
if (!(num <= 0))
    Console.WriteLine(++num + z++ + " " + ++z); // Outputs "7 7" (Answer: 7 7)
else
    Console.WriteLine(--num + z-- + " " + --z);