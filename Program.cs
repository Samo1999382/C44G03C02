using System;

// 1- Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

Console.WriteLine("------ passing val type by value VS ref ------");
// passing by value is like passing a copy of the variable where the values of the old and new variables are the same but the memory addresses are not (the old variable doesnt get affecte).
// code example:
static void passByValue(int number)
{
    number = 10;
    Console.WriteLine("The new variable after passing by value: "+number);
}

int number = 5;
Console.WriteLine("The old variable before passing by value: "+number);
passByValue(number);
Console.WriteLine("The old variable after passing by value: "+number);
Console.WriteLine();
// while passing by reference, if like passing a value pointing to the address of the old variable, where any change that would happen to the old/new would affect the other one.
static void passByRef(ref int number)
{
    number = 20;
    Console.WriteLine("The new variable after passing by ref: "+number);
}

number = 5;
Console.WriteLine("The old variable before passing by ref: "+number);
passByRef(ref number);
Console.WriteLine("The old variable after passing by ref: "+number);
Console.WriteLine();

// 2- Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

Console.WriteLine("------ passing ref type by value VS ref");



// passing ref parameter by value (which is the default behavior) is like passing a copy of the pointer, it can change the methods properties but cant reassign the pointer to a new object
// code example: 
void passCatByValue(Cat cat)
{
    cat = new Cat("White");
    Console.WriteLine("The new cat's color after passing by value: "+cat.Color);
}

Cat cat1 = new Cat("gray");
Console.WriteLine("The old cat's color before passing by value: "+cat1.Color);
passCatByValue(cat1);
Console.WriteLine("The old cat's color after passing by value: "+cat1.Color);
Console.WriteLine();

// while passing ref type parameters by fer is passing the actual ref pointer, not a copy of it which gives it the ability to reassign it to a new object
void passCatByRef(ref Cat cat)
{
    cat = new Cat("Black");
    Console.WriteLine("The new cat's color after passing by ref: "+cat.Color);
}

Cat cat2 = new Cat("orange");
Console.WriteLine("The old cat's color before passing by ref: "+cat2.Color);
passCatByRef(ref cat2);
Console.WriteLine("The old cat's color after passing by ref: "+cat2.Color);
Console.WriteLine();

// 3- Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

Console.WriteLine("------ Add & Sub ------");

(int, int) addSub(int[] nums)
{
    return (nums[0]+nums[1], nums[2]-nums[3]);
}
int[] nums = new int[4];
string[] words = {"first", "second", "third", "fourth"};
for (int i = 0; i < 4; i++)
{
    Console.Write(($"Enter the {words[i]} number: "));
    nums[i] = Convert.ToInt32(Console.ReadLine());
}
(int sum, int sub) = addSub(nums);
Console.WriteLine("\nThe sum of the first two numbers id: "+sum);
Console.WriteLine("The difference between the last two numbers is: "+sub);

Console.WriteLine();
// Note: sorry i use tuple even tho we didnt get to it yet in the course

// 4- Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

Console.WriteLine("------ sum digits ------");
Console.Write("Enter a number: ");
string num = Console.ReadLine();
int digitSum = 0;
foreach (char digit in num)
{
    digitSum += digit-'0';
}
Console.WriteLine($"\nThe sum of digits in {num} equals: "+digitSum);
// Note: i subtracted the digit's char by the chat 0 cuz when converting it converts fo the representing number of that char in the ASCII table, also there is no need to implicitly convert the char to int since both are technically storing numbers

// 5- Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

Console.WriteLine("\n------ IsPrime ------");
bool IsPrime(int number)
{
    if (number <= 1)
        return false;
    if (number == 2)
        return true;
    if (number % 2 == 0)
        return false;

    // Check divisors up to square root of the number
    for (int i = 3; i <= Math.Sqrt(number); i += 2)
    {
        if (number % i == 0)
            return false;
    }

    return true;
}
Console.WriteLine($"The number 7 is {(IsPrime(7)?"":"not ")}prime while 6 is {(IsPrime(6)?"":"not")}");

// 6- Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

Console.WriteLine("\n------ Min&Max arr ------");
int[] arr = { 1, 2, 3, 4, 5 };

(int min, int max) MinMax(int[] arr)
{
    int min = arr[0];
    int max = arr[0];
    foreach (int i in arr)
    {
        if (i < min)
        {
            min = i;
        }

        if (i > max)
        {
            max = i;
        }
    }
    return (min, max);
}

(int min, int max) = MinMax(nums);
Console.WriteLine($"The min number in the array is {min}, and the max number in the array is {max}");

// 7- Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

Console.WriteLine("\n------ factorial ------");
int factorial(int number)
{
    int ret = 1;
    for (int i = number; i >= 1; i--)
    {
        ret *= i;
    }
    return ret;
}

Console.Write("Enter a number: ");
int input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"\nThe factorial of the number {input} is {factorial(input)}");

// 8- Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

Console.WriteLine("\n------ changeChar ------");
Console.Write("Enter a word: ");
string word = Console.ReadLine();
Console.Write("Enter the index of the number to change: ");
int index = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the letter to change it with: ");
string letter = Convert.ToString(Console.ReadKey().KeyChar);
Console.ReadLine();

string ChangeChar(string word, int index, string letter)
{
    return word.Remove(index, 1).Insert(index, letter);;
}
Console.WriteLine($"\nThe word now after changing the letter is {ChangeChar(word, index, letter)}");

// ----------------------------------------------------------- dont mind this -----------------------------------------------------------

class Cat
{
    public string Color {get; set;}

    public Cat(string color)
    {
        this.Color = color;
    }
}
// Note: i had to move this class to the bottom of the code cuz i am suing top-level statements