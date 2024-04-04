// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// Рекурсивный метод:
int MToNSum(int m, int n)
{
    int sum = m;
    if (m < n) sum += MToNSum(m + 1, n);
    return sum; 
}

int InputData(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int numberM = InputData("Введите число M >"),
    numberN = InputData("Введите число N >"),
    sum = MToNSum(numberM, numberN);

Console.WriteLine($"Сумма натуральных элементов в промежутке от '{numberM}' до '{numberN}' = {sum}");