// Задача 35:
// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] GetArray(int size, int minVal, int maxVal)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minVal, maxVal + 1);
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
    return arr;
}

int NumberInInterval(int minVal, int maxVal, int[] arr)
{
    int number = 0;
    foreach (int al in arr) if (al >= minVal && al <= maxVal) number++;
    return number;
}

int[] a = GetArray(123, 0, 200);
int n = NumberInInterval(10, 99, a);
Console.WriteLine(n);