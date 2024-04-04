// Задача 33:
// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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

bool NumberIsHere(int number, int[] arr)
{
    bool res = false;
    foreach (int al in arr) if (number == al) res = true;
    return res;
}

int[] a = GetArray(10, 0, 20);
if (NumberIsHere(4, a)) Console.WriteLine("Yes");
else Console.WriteLine("No");