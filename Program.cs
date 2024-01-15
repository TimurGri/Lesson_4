//Задача 3: Заполните массив на N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9. 
//Сформируйте целое число, которое будет состоять из цифр из массива.
// Старший разряд числа находится на 0-м индексе, младший – на последнем.
Console.Clear();

int ConvertArrayToInt(int[] array)
{
    int number = 0, sum = 0;
    for (int i = array.Length - 1, k = 0; i >= 0; k++, i--)
    {
        number = array[k] * (int)Math.Pow(10, i);
        sum += number;
    }
    return sum;
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
    Console.WriteLine("Input a length of array");
    bool result = int.TryParse(Console.ReadLine(), out int len);
    if (result == true && len <= 8)
    {
        int[] array = GetRandomArray(len, 1, 10);
        int number = ConvertArrayToInt(array);
        PrintArray(array);
        Console.WriteLine(number);
        exit = true;
    }
    if (result == false || len > 8)
    {
        Console.WriteLine("Length of array more than 8 or invalid input");
        Console.WriteLine("Try again: ");
    }
}
while (!exit);