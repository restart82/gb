// Задача 27:
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputData(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

bool ValidateNumber(int number)
{
    if (number < 1)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"!!!Число должно быть > 0!!!");
        Console.ResetColor();
        return false;
    }
    return true;
}

int NumberSum(int n)
{
    int result = 0;
    while (n >= 1)
    {
        result += n % 10;
        n /= 10;
    }
    return result;
}

int Number = InputData("Введите число >");

if (ValidateNumber(Number))
{
    Console.WriteLine("Сумма цифр числа = " + NumberSum(Number));
}