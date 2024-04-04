// Задача 28:
// Напишите программу, которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

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
        Console.WriteLine($"!!!Число N должно быть > 0!!!");
        Console.ResetColor();
        return false;
    }
    return true;
}

long GetMult(int number)
{
    long result = 1;
    for (int i = 1; i <= number; i++)
    {
        result *= i;
    }
    return result;
}

int N = InputData("Введите число N >");

if (ValidateNumber(N))
{
    long M = GetMult(N);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Произведение чисел от 1 до {N} = {M}");
    Console.ResetColor();
}
