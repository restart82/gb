// Задача 25:
// Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputData(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

bool ValidateNumber(int number)
{
    if (number < 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"!!!Число B должно быть натуральным!!!");
        Console.ResetColor();
        return false;
    }
    return true;
}

int MyPow(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result *= A;
    }
    return result;
}

int NumberA = InputData("Введите число A >");
int NumberB = InputData("Введите число B >");

if (ValidateNumber(NumberB))
{
    Console.WriteLine($"{NumberA} ^ {NumberB} = {MyPow(NumberA, NumberB)}");
}