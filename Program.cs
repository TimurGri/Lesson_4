//Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
Console.Clear();

int SumOfDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = number % 10 + sum;
        number /= 10;
    }
    return sum;
}
bool PressQtoExit(string s)
{
    if (s == "q") return true;
    return false;
}

bool exit = false;

do
{

    bool result;
    Console.WriteLine("Input a value (To exit please input 'q' or sum digits of number is even)");
    string input = Console.ReadLine();
    result = int.TryParse(input, out int number);
    if (result == true && SumOfDigits(number) % 2 == 0) exit = true;
    if (result == false && PressQtoExit(input)) exit = true;



} while (!exit);


