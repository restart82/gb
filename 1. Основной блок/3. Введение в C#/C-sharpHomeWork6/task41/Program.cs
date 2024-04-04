// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int M = 5;

int[] InputData(string message)
{
    int[] result = new int[M];
    Console.Write(message);
    for (int i = 0; i < M; i++) result[i] = int.Parse(Console.ReadLine()!);
    return result;
}

int HowMuchGreaterZero(int[] arr)
{
    int k = 0;
    foreach (int al in arr) if (al > 0) k++;
    return k;
}

int[] array = InputData($"Введите {M} чисел:\n");
int n = HowMuchGreaterZero(array);
Console.WriteLine($"Вы ввели {n} числа > 0");