// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

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
        Console.WriteLine("N > 0");
        return false;
    }
    return true;
}

void ShowSquares(int number)
{
    Console.Write("Таблица числа N: ");
    for (int i = 1; i <= number; i++)
    {
        if (i == number)
        {
            Console.WriteLine(i*i + ".");
        }
        else
        {
            Console.Write(i*i + ", ");
        }
    }
}

int N = InputData("Введите число N >");

if (ValidateNumber(N)) ShowSquares(N);
