// Задача 19
// Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int N = 5; // Количество знаков в полиндроме (вот так вот получилось решение в общем виде)

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
    if (number < (int)Math.Pow(10, N - 1) || number >= (int)Math.Pow(10, N)) //Проверка на N-значность
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"!!!Число должно быть {N}-значным!!!");
        Console.ResetColor();
        return false;
    }
    return true;
}

// Проверка на палиндром:
bool ThisIsPalindrome(int number)
{
    int i = 1;
    while (i <= N / 2)
    {
        if (number / (int)Math.Pow(10, i - 1) % 10 == number / (int)Math.Pow(10, N - i) % 10) i++;
        else break;
    }
    if (i == N / 2 + 1) // Если число - палиндром, то цикл дошел до конца.
    {
        return true;
    }
    return false;
}


// ---Тело программы---

int Number = InputData($"Введите {N}-значное число >");

if(ValidateNumber(Number))
{
    if (ThisIsPalindrome(Number))
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Число '{Number}' ЯВЛЯЕТСЯ палиндромом :)");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Число '{Number}' НЕ ЯВЛЯЕТСЯ палиндромом :(");
    }
    Console.ResetColor();
}
