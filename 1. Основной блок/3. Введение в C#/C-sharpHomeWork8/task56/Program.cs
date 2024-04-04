// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

int[,] GetArray(int m, int n, int minValue, int maxValue)
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

void ShowArray(int[,] array, string message)
{
    Console.WriteLine($"\n{message} [{array.GetLength(0)}x{array.GetLength(1)}]:\n");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine("\n");
    }
}

int MinRowNumber(int[,] array)
{
    int minRowNum = 0;
    int m = array.GetLength(0), n = array.GetLength(1);
    int minSum = int.MaxValue;
    for (int i = 0; i < m; i++)
    {
        int sum = 0;
        for (int j = 0; j < n; j++) sum += array[i, j];
        if (minSum > sum)
        {
            minSum = sum;
            minRowNum = i;
        }
        // Console.WriteLine(sum);
    }
    return minRowNum + 1;
}

Console.Clear();
int rows = new Random().Next(2, 10), cols = new Random().Next(2, 10);
int[,] matrix = GetArray(rows, cols, 0, 10);
ShowArray(matrix, "Массив");
Console.WriteLine("Номер строки с наименьшей суммой элементов: " + MinRowNumber(matrix));