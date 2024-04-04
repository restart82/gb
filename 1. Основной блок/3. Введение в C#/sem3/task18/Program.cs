// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

int InputData(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

bool ValidateQuart(int number)
{
    if (number < 1 || number > 4)
    {
        Console.WriteLine("Четвертей всего 4");
        return false;
    }
    return true;
}

void GetRang(int QNumber)
{
    switch (QNumber)
    {
        case 1:
        Console.WriteLine("x > 0; y > 0");
        break;
        case 2:
        Console.WriteLine("x < 0; y > 0");
        break;
        case 3:
        Console.WriteLine("x < 0; y < 0");
        break;
        case 4:
        Console.WriteLine("x > 0; y < 0");
        break;
    }
}

int Num = InputData("Номер четверти > ");

if (ValidateQuart(Num))
{
    GetRang(Num);
}


