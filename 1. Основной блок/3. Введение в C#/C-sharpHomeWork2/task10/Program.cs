// Задача 10:
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int GetSecondNumber(int num)
{
    int result = (num / 10) % 10;
    return result;
}

Console.Write("Введите трехначное число: ");
int Number = int.Parse(Console.ReadLine()!);
int SecN = GetSecondNumber(Number);
Console.WriteLine("Это его вторая цифра - " + SecN);