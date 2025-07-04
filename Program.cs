using System;
using System.Collections.Generic;
// 1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

Console.WriteLine("------ IsDividable ------");
try
{
    Console.Write("Enter a number: ");
    int input1 = Convert.ToInt32(Console.ReadLine());
    
    if ((input1%3==0) && (input1%4==0))
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}
catch (Exception e)
{
    Console.WriteLine("Please try again and enter a valid number");
}

// 2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.

Console.WriteLine("------ Negative or Positive ------");
try
{
    Console.Write("Enter a number: ");
    int input2 = Convert.ToInt32(Console.ReadLine());
    
    if (input2<0)
    {
        Console.WriteLine("Negative");
    }
    else
    {
        Console.WriteLine("Positive");
    }
}
catch (Exception e)
{
    Console.WriteLine("Please try again and enter a valid number");
}

// 3- Write a program that takes 3 integers from the user then prints the max element and the min element.

Console.WriteLine("------ Min & Max ------");
try
{
    Console.Write("Enter the first number: ");
    int input31 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the second number: ");
    int input32 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the third number: ");
    int input33 = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine($"Min: {Math.Min(Math.Min(input31, input32), input33)}, Max: {Math.Max(Math.Max(input31, input32), input33)}");
}
catch (Exception e)
{
    Console.WriteLine("Please try again and enter a valid number");
}

// 4- Write a program that allows the user to insert an integer number then check If a number is even or odd.

Console.WriteLine("------ Even or Odd ------");
try
{
    Console.Write("Enter a number: ");
    int input4 = Convert.ToInt32(Console.ReadLine());
    
    if (input4%2==0)
    {
        Console.WriteLine("Even");
    }
    else
    {
        Console.WriteLine("Odd");
    }
}
catch (Exception e)
{
    Console.WriteLine("Please try again and enter a valid number");
}

// 5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

Console.WriteLine("------ Vowel or Consonant ------");
char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
try
{
    Console.Write("Enter a character: ");
    char inputKey = Console.ReadKey().KeyChar;
    Console.ReadLine();
    
    if (vowels.Contains(char.ToLower(inputKey)))
    {
        Console.WriteLine("Vowel");
    }
    else if (char.IsLetter(inputKey))
    {
        Console.WriteLine("Consonant");
    }
    else
    {
        Console.WriteLine("Please try again and enter a valid character");
    }
}
catch (Exception e)
{
    Console.WriteLine("Please try again and enter a valid character");
}