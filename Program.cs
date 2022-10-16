/* Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */
Console.Clear();

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

NumberCollection(number);

void NumberCollection(int num)
{
    if (num > 1)

    {
        Console.Write($"{num}, ");
        NumberCollection(num - 1);

    }
    else if (num == 1)
    {
        Console.Write($"{num}");
    }
}