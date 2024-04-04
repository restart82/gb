// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] Get2DArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

double[] AverageInColumns(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        result[j] = sum / array.GetLength(0);
    }
    return result;
}

void ShowArray(int[,] array)
{
    Console.WriteLine($"\nВот наш двумерный массив [{array.GetLength(0)}x{array.GetLength(1)}]:\n");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine("\n");
    }
}

Console.Clear();
int[,] arr = Get2DArray(5, 8, 0, 10);
double[] average = AverageInColumns(arr);
ShowArray(arr);
Console.WriteLine("Среднее арифметическое элементов в каждом столбце:\n");
Console.WriteLine(String.Join("\t", average));

