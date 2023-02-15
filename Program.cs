// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void FillArrayRandom3Digit(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
        numbers[i] = new Random().Next(100, 1000);
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
        Console.Write(numbers[i] + " ");
    Console.Write("]");
    Console.WriteLine();
}
Console.Write("Input size of array = ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandom3Digit(numbers);
Console.WriteLine("Array: ");
PrintArray(numbers);
int count = 0;

for (int a = 0; a < numbers.Length; a++)
    if (numbers[a] % 2 == 0)
        count++;

Console.WriteLine($"There are {count} even numbers in array");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void FillRandomArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        numbers[i] = new Random().Next(-10,10);
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        Console.Write(numbers[i] + " ");
    Console.Write("]");
    Console.WriteLine();
}
Console.Write("Input size of array = ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillRandomArray(numbers);
Console.WriteLine("Array: ");
PrintArray(numbers);
int sum = 0;

for (int a = 0; a < numbers.Length; a+=2)
    sum = sum + numbers[a];

Console.WriteLine($"Sum of Numbers on odd position is {sum}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void FillRandomArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100, 100000)) / 100;
        // 2 знака после запятой задала не сложением целой и дробной частей, а делением целого числа на 100
    }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
Console.Write("Input size of array = ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillRandomArray(numbers);
Console.WriteLine("Array: ");
PrintArray(numbers);
double min = numbers[0];
double max = numbers[0];

for (int a = 0; a < numbers.Length; a++)
{
    if (numbers[a] > max)
    {
        max = numbers[a];
    }
    if (numbers[a] < min)
    {
        min = numbers[a];
    }
}
Console.WriteLine($"Maximum is {max}, minimum is {min}, difference between max and min value is {Math.Round((max - min), 2)}");