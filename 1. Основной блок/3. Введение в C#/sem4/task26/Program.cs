// Задача 26:
// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


long InputData(string message)
{
    Console.Write(message);
    long result = long.Parse(Console.ReadLine()!);
    return result;
}

int GetNumberOfDigits(long number)
{
    if (number == 0)
    {
        return 1;
    }
    int i = 0;
    while (Math.Abs(number) > 0)
    {
        number = number / 10;
        i++;
    }
    return i;
}

long N = InputData("Введите число >");
int Q = GetNumberOfDigits(N);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Количество цифр в числе {N} = {Q}");
Console.ResetColor();
