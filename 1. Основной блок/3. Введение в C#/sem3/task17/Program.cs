// Задача №17.
// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
// в которой находится эта точка.

int InputData(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

bool ValidateCoord(int x, int y)
{
    if (x == 0 || y == 00)
    {
        Console.WriteLine("X и Y должны быть не= 0");
        return false;
    }
    return true;
}

void GetPurtNum(int x, int y)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Первая четверть");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Вторая четверть");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Третья четверть");
    }
    else
    {
        Console.WriteLine("Четвертая четверть");
    }
}

int X = InputData("Введите Х > ");
int Y = InputData("Введите У > ");

if (ValidateCoord(X, Y))
{
    GetPurtNum(X, Y);
}

