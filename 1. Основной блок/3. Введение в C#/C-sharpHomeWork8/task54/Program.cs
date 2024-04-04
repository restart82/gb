// Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

// Метод упорядочивает элементы с помощью встренных функций:
int[,] RowSorting(int[,] array2D)
{
    int m = array2D.GetLength(0), n = array2D.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        int[] row = new int[n];
        for (int j = 0; j < n; j++)
        {
            row[j] = array2D[i, j];
        }
        Array.Sort(row);
        Array.Reverse(row);
        for (int j = 0; j < n; j++)
        {
            array2D[i, j] = row[j];
        }
    }
    return array2D;
}

Console.Clear();
int rows = new Random().Next(2, 10), cols = new Random().Next(2, 10);
int[,] matrix = GetArray(rows, cols, 0, 10);
ShowArray(matrix, "Исходный массив");
ShowArray(RowSorting(matrix), "Массив с отсортированными строками в порядке убывания");