// Задайте значение N. Напишите программу, которая выведет все натуральные
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// Рекурсивный метод:
void ShowN(int n)
{
    if (n > 0)
    {
    Console.Write(n + " ");
    ShowN(n - 1);
    }
}

int InputData(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int number = InputData("Введите число N >");
Console.WriteLine("Все натуральные числа в промежутке от 1 до " + number + ":");
ShowN(number);



