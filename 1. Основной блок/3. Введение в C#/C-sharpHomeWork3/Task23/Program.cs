// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int P = 3; // Степень числа

// Считываем данные с консоли:
int InputData(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

// Проверяем данные:
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

// Готовим сообщение:
string OutputMessage(int pow)
{
    string message;
    switch (pow)
    {
        case 2:
            message = "квадратов";
            break;
        case 3:
            message = "кубов";
            break;
        default:
            message = $"степени {pow}";
            break;
    }
    return message;
}

// Выводим таблицу:
void PowTable(int number)
{
    string message = OutputMessage(P);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"Таблица {message} числа '{number}': ");
    int i = 1;
    while (i <= number)
    {
        if (i == number)
        {
            Console.WriteLine(Math.Pow(i, P) + ".");
            
        }
        else
        {
            Console.Write(Math.Pow(i, P) + ", ");
        }
        i++;
    }
    Console.ResetColor();
}

// --Тело--

int Number = InputData("Введите число N >");

if (ValidateNumber(Number))
{
    PowTable(Number);
}

