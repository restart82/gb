// Задача 31:
// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.


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

void GetSum(int[] arr)
{
    int pSum = 0;
    int nSum = 0;
    foreach (int al in arr)
    {
        if (al > 0) pSum += al;
        else nSum += al;
    }
    Console.WriteLine("Сумма отрицательных чисел: " + nSum);
    Console.WriteLine("Сумма положительных чисел: " + pSum);
}

int[] a = GetArray(12, -9, 9);
GetSum(a);

