// Задача 37:
// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetArray(int size, int minVal, int maxVal)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minVal, maxVal + 1);
        Console.Write(arr[i] + "\t");
    }
    Console.WriteLine();
    return arr;
}

int[] MultPairs(int[] arr)
{
    int size = (int)Math.Ceiling((double)arr.Length / 2);
    int[] multArr = new int[size];
    for (int i = 0; i < size; i++)
    {
        multArr[i] = arr[i] * arr[arr.Length - i - 1];
        if (i == arr.Length - i - 1) multArr[i] = arr[i];
        Console.Write(multArr[i] + "\t");
    }
    Console.WriteLine();
    return multArr;
}

int[] a = GetArray(15, -20, 20);
int[] m = MultPairs(a);
Console.WriteLine();