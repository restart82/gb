// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// Массив из случайных чисел:
int[] GetArray(int size, int minVal, int maxVal)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++) arr[i] = new Random().Next(minVal, maxVal + 1);
    return arr;
}

// Считаем сумму:
int GetSum(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2) sum += arr[i];
    return sum;
}

int[] array = GetArray(10, -99, 99);
int Sum = GetSum(array);
Console.WriteLine($"Сумма элементов в массиве [{String.Join(", ", array)}],\nстоящих на нечетных позициях: sum = {Sum}\n");