// Задача 32:
// Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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

int[] ReversArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
    return arr;
}

int[] a = GetArray(4, -9, 9);
int[] b = ReversArray(a);