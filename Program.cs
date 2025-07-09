using System;

// 19- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

Console.WriteLine("------ identity ------");
Console.Write("Enter the value of n: ");
int value = Convert.ToInt32(Console.ReadLine());
int[,] arr1 = new int[value, value];
for (int i = 0; i < value; i++)
{
    for (int j = 0; j < value; j++)
    {
        if (i == j)
        {
            arr1[i, j] = 1;
            Console.Write("1");
        }
        else
        {
            arr1[i, j] = 0;
            Console.Write("0");
        }
        Console.Write(" ");
    }
    Console.WriteLine("");
}

// 20- Write a program in C# Sharp to find the sum of all elements of the array.

Console.WriteLine("------ arr sum ------");
int[] arr2_1d = {1,2,3,4,5,6};
double[,] arr2_2d = {{1,2,3,4,5,6}, {7,8,9,10,11,12}};
int[,,] arr2_3d = {{{1,2,3,4,5}, {6,7,8,9,10}}, {{11,12,13,14,15}, {16,17,18,19,20}}};

var sum = 0;

double ArrSum(Array arr)
{
    foreach (var item in arr2_1d)
    {
        sum += item;
    }
    return sum;
}

Console.WriteLine(ArrSum(arr2_1d));
Console.WriteLine(ArrSum(arr2_2d));
Console.WriteLine(ArrSum(arr2_3d));
// Note: it works for any dimensionality

// 21- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

Console.WriteLine("------ MergeSort ------");
int[] arr3_1 = {1,3,6,2};
int[] arr3_2 = {9,7,4,5,8};

static int[] MergeAndSortTwoArrays(int[] arr1, int[] arr2)
{
    int[] combined = new int[arr1.Length + arr2.Length];
    Array.Copy(arr1, 0, combined, 0, arr1.Length);
    Array.Copy(arr2, 0, combined, arr1.Length, arr2.Length);

    MergeSort(combined);

    return combined;
}

static void MergeSort(int[] array)
{
    if (array.Length <= 1)
        return;

    int[] temp = new int[array.Length];
    MergeSortRecursive(array, temp, 0, array.Length - 1);
}

static void MergeSortRecursive(int[] array, int[] temp, int left, int right)
{
    if (left < right)
    {
        int mid = left + (right - left) / 2;
        MergeSortRecursive(array, temp, left, mid);
        MergeSortRecursive(array, temp, mid + 1, right);
        Merge(array, temp, left, mid, right);
    }
}

static void Merge(int[] array, int[] temp, int left, int mid, int right)
{
    for (int i = left; i <= right; i++)
    {
        temp[i] = array[i];
    }

    int leftStart = left;
    int rightStart = mid + 1;
    int current = left;

    while (leftStart <= mid && rightStart <= right)
    {
        if (temp[leftStart] <= temp[rightStart])
        {
            array[current] = temp[leftStart];
            leftStart++;
        }
        else
        {
            array[current] = temp[rightStart];
            rightStart++;
        }
        current++;
    }

    while (leftStart <= mid)
    {
        array[current] = temp[leftStart];
        current++;
        leftStart++;
    }
}

int[] arr3 = MergeAndSortTwoArrays(arr3_1, arr3_2);
foreach (var item in arr3)
{
    Console.Write(item + " ");
}
Console.WriteLine();
// Note: the mergesort algorithm was used here

// 22- Write a program in C# Sharp to count the frequency of each element of an array.\

Console.WriteLine("------ item freq ------");
static void CountFrequency(int[] arr)
{
    Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

    foreach (int num in arr)
    {
        if (frequencyMap.ContainsKey(num))
            frequencyMap[num]++;
        else
            frequencyMap[num] = 1;
    }

    foreach (var pair in frequencyMap)
    {
        Console.WriteLine($"{pair.Key} occurs {pair.Value} time");
    }
}


int[] arr4 = { 1, 2, 3, 2, 4, 1, 5, 2, 3 };
Console.WriteLine("Frequency of each element:");
CountFrequency(arr4);
// Note: dictionary was used here to store as key and value pairs to make it easier to deal with, and genarics ware used to determine its datatypes

// 23- Write a program in C# Sharp to find maximum and minimum element in an array

Console.WriteLine("------ min & max ------");
int[] arr5 = { 2, 32, 3, 23, 76 };
int min = arr5[0];
int max = arr5[0];
foreach (int num in arr5)
{
    if (num < min)
        min = num;
    if (num > max)
        max = num;
}
Console.WriteLine("min: "+min+" max: "+max);

// 24- Write a program in C# Sharp to find the second largest element in an array.

Console.WriteLine("------ second largest ------");
int[] arr6 = {34, 54, 23, 4, 6};
max = arr6[0];
int secmax = arr6[0];
foreach (int num in arr6)
{
    if (num > max)
        max = num;
    else if (num > secmax)
        secmax = num;
}
Console.WriteLine("Second largest number: "+secmax);

// 25-. Consider an Array of Integer values with size N, having values as in this Example

Console.WriteLine("------ space between ------");
Console.Write("Enter array elements (space-separated integers):");
int[] arr7 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        
Dictionary<int, List<int>> indices = new Dictionary<int, List<int>>();
        
for (int i = 0; i < arr7.Length; i++)
{
    if (!indices.ContainsKey(arr7[i]))
        indices[arr7[i]] = new List<int>();
    indices[arr7[i]].Add(i);
}
        
int maxDistance = 0;
foreach (var item in indices)
{
    if (item.Value.Count >= 2)
    {
        int distance = item.Value[item.Value.Count - 1] - item.Value[0] - 1;
        if (distance > maxDistance)
            maxDistance = distance;
    }
}
        
Console.WriteLine($"Longest distance between two equal cells: {maxDistance}");
// Note: sorry i once again used dicts and generics once more

// 26- Given a list of space separated words, reverse the order of the words.

Console.WriteLine("------ reverse ------");
Console.Write("Enter a sentence:");
string input = Console.ReadLine();
        
string[] words = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
Array.Reverse(words);
        
Console.WriteLine("Reversed order: " + string.Join(" ", words));

// 27- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array.
// Now copy all the elements of first array on second array and print second array.

Console.WriteLine("----- coping arrays ------");
Console.Write("Enter number of rows: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Enter number of columns: ");
int cols = int.Parse(Console.ReadLine());
        
int[,] arr8_1 = new int[rows, cols];
int[,] arr8_2 = new int[rows, cols];
        
Console.WriteLine("Enter matrix elements (row-wise):");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        arr8_1[i, j] = int.Parse(Console.ReadLine());
        arr8_2[i, j] = arr8_1[i, j];
    }
}
        
Console.WriteLine("\nCopied array:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(arr8_2[i, j]+ " ");
    }
    Console.WriteLine();
}

// 28- Write a Program to Print One Dimensional Array in Reverse Order

Console.WriteLine("------ print reversed array ------");
int[] arr9 = {1,2,3,4,5,6};
        
Console.Write("Array in reverse order:");
for (int i = arr9.Length - 1; i >= 0; i--)
{
    Console.Write(arr9[i] + " ");
}