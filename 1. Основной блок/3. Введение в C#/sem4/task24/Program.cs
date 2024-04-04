// Задача 24: Напишите программу, которая принимает на вход число
// (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


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
        Console.WriteLine($"!!!Число A должно быть > 0!!!");
        Console.ResetColor();
        return false;
    }
    return true;
}

int SumNum(int number)
{
    int result = 0;
    for (int i = 1; i <= number; i++)
    {
        result = result + i;
    }
    return result;
}

int A = InputData("Введите число А >");

if (ValidateNumber(A))
{
    int S = SumNum(A);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Сумма числ от 1 до {A} = {S}");
    Console.ResetColor();
}
