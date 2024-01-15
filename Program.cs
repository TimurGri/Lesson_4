//Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

int CountEvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}

int[] GetRandomArray(int len, int min, int max)
{
    int[] array = new int[len];
    Random rnd = new();
    for (int i = 0; i < len; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

bool exit = false;

do
{
    Console.WriteLine("Input length of an array");
    bool result = int.TryParse(Console.ReadLine(), out int len);
    if (result == true)
    {
        int[] array = GetRandomArray(len, 100, 1000);
        PrintArray(array);
        Console.WriteLine($"{CountEvenNumber(array)} elements of array is even");
        exit = true;
    }
    if (result == false)
    {
        Console.WriteLine("Invalid input");
        Console.WriteLine("Try again: ");
    }
}
while (!exit);