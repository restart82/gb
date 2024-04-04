// Задача 44:
// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.

// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int InputData(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int[] FibanacciRow(int number)
{
    int[] fib = new int[number];
    fib[0] = 0; fib[1] = 1;
    for (int i = 2; i < number; i++) fib[i] = fib[i - 2] + fib[i - 1];
    return fib;
}

int n = InputData("Введите число >");
int[] fibanacci = FibanacciRow(n);
Console.WriteLine(String.Join(" ", fibanacci) + "\n");