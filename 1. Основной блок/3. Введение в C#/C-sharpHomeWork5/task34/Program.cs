// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Массив из случайных чисел:
int[] GetArray(int size, int minVal, int maxVal)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++) arr[i] = new Random().Next(minVal, maxVal + 1);
    return arr;
}

// Считаеи количество четных чисел в массиве:
int GetEvenNumber(int[] arr)
{
    int number = 0;
    foreach (int al in arr) if (al % 2 == 0) number++;
    return number;
}

int[] array = GetArray(10, 100, 999);
int num = GetEvenNumber(array);
Console.WriteLine($"Количество четных чисел в массиве [{String.Join(", ", array)}] N = {num}\n");