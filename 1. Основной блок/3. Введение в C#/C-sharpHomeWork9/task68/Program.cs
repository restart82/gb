// Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m != 0 && n == 0) return Ackermann(m - 1, 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}

int InputData(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

bool ValidNumber(int number)
{
    if (number < 0) return false;
    else return true;
}

int numberM = InputData("Введите число m >"),
    numberN = InputData("Введите число n >");

if (ValidNumber(numberM) & ValidNumber(numberN))
{
    int a = Ackermann(numberM, numberN);
    Console.WriteLine(a);
}
else Console.WriteLine("Числа должны быть натуральными");