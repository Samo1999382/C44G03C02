using System;
// 6- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

Console.WriteLine("------ All numbers between 1 and n ------");
Console.Write("Enter an integer: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.Write(i + (i < n ? ", " : ""));
}
Console.WriteLine();

// 7- Write a program that allows the user to insert an integer then print a multiplication table up to 12.

Console.WriteLine("------ multiplication table ------");
Console.Write("Enter an integer: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= 12; i++)
{
    Console.Write(num * i + " ");
}
Console.WriteLine();

// 8- Write a program that allows to user to insert number then print all even numbers between 1 to this number

Console.WriteLine("------ even numbers between 1 and n ------");
Console.Write("Enter an integer: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= number; i += 2)
{
    Console.Write(i + " ");
}
Console.WriteLine();

// 9- Write a program that takes two integers then prints the power.

Console.WriteLine("------ exponential ------");
Console.Write("Enter base: ");
int baseNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter exponent: ");
int exponent = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 0; i < exponent; i++)
{
    result *= baseNum;
}
Console.WriteLine(result);

// 10- Write a program to enter marks of five subjects and calculate total, average and percentage.

Console.WriteLine("------ marks ------");
Console.Write("Enter marks of five subjects(e.g. 92 93 94 95 96): ");
string[] marks = Console.ReadLine().Split();
int total = 0;
foreach (string mark in marks)
{
    total += int.Parse(mark);
}
Console.WriteLine($"Total marks = {total}");
Console.WriteLine($"Average Marks = {total / 5}");
Console.WriteLine($"Percentage = {total / 5}%");
// Note: I used an array and a string method here to save time even tho we didn't get to it in our course

// 11- Write a program to input the month number and print the number of days in that month.

Console.WriteLine("------ month days ------");
Console.Write("Enter month number (1-12): ");
int month = Convert.ToInt32(Console.ReadLine());
int days = month switch
{
    4 or 6 or 9 or 11 => 30,
    2 => 28,
    _ => 31
};
Console.WriteLine($"Days in Month: {days}");
// Note: I assumed that it is not a leap year to feb is 28 days

// 12- Write a program to create a Simple Calculator.

Console.WriteLine("------ simple calculator ------");
Console.Write("Enter two numbers and operator (e.g., 5 + 3): ");
string[] parts = Console.ReadLine().Split();
double a = Convert.ToDouble(parts[0]);
char op = Convert.ToChar(parts[1]);
double b = Convert.ToDouble(parts[2]);
double result1 = op switch
{
    '+' => a + b,
    '-' => a - b,
    '*' => a * b,
    '/' => a / b,
    _ => 0
};
Console.WriteLine($"Result: {result1}");

// 13- Write a program to allow the user to enter a string and print the REVERSE of it.

Console.WriteLine("------ reverse a tring ------");
Console.Write("Enter a string: ");
string input = Console.ReadLine();
char[] chars = input.ToCharArray();
Array.Reverse(chars);
Console.WriteLine(new string(chars));
// Note: I could also have looped over it but there is an array method to do that

// 14- Write a program to allow the user to enter int and print the REVERSED of it.

Console.WriteLine("------ reverse an int ------");
Console.Write("Enter an integer: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int reversed = 0;
while (num2 != 0)
{
    reversed = reversed * 10 + num2 % 10;
    num2 /= 10;
}
Console.WriteLine(reversed);

// 15- Write a program in C# Sharp to find prime numbers within a range of numbers.

Console.WriteLine("------ prime numbers ------");
static bool IsPrime(int n)
{
    if (n <= 1) return false;
    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0) return false;
    }
    return true;
}
Console.WriteLine();

Console.Write("Enter start and end of range (e.g., 1 50): ");
string[] range = Console.ReadLine().Split();
int start = Convert.ToInt32(range[0]);
int end = Convert.ToInt32(range[1]);
Console.Write("Prime numbers: ");
for (int i = start; i <= end; i++)
{
    if (IsPrime(i)) Console.Write(i + " ");
}

// 16- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.

Console.WriteLine("------ IsCollinear ------");
Console.WriteLine("Enter coordinates for three points:");
Console.Write("Enter x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter x3: ");
double x3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter y3: ");
double y3 = Convert.ToDouble(Console.ReadLine());
double area = 0.5 * (x1*(y2 - y3) + x2*(y3 - y1) + x3*(y1 - y2)); // from the internet
if (Math.Abs(area) < 0.0001)
{
    Console.WriteLine("These points are COLLINEAR (lie on the same straight line)");
}
else
{
    Console.WriteLine("These points are NOT COLLINEAR");
}

// 18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
// - If the worker completes the job within 2 to 3 hours, they are considered highly efficient. 
// - If the worker takes 3 to 4 hours, they are instructed to increase their speed. 
// - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed. 
// - If the worker takes more than 5 hours, they are required to leave the company. 
//     To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.

Console.WriteLine("------ worker's effixiancy ------");
Console.Write("Enter time taken (hours): ");
double hours = Convert.ToDouble(Console.ReadLine());
string message = hours switch
{
    >= 2 and <= 3 => "Highly efficient",
    > 3 and <= 4 => "Increase speed",
    > 4 and <= 5 => "Needs training",
    > 5 => "Terminate employment",
    _ => "Invalid time"
};
Console.WriteLine(message);