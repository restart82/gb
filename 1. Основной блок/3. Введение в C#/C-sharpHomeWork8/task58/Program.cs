// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

bool ValidateMatrixProd(int[,] martixA, int[,] matrixB)
{
    if (martixA.GetLength(1) == matrixB.GetLength(0)) return true;
    else
    {
        Console.WriteLine("Произведение данных матриц невозможно!");
        return false;
    }
}

int[,] MatrixProd(int[,] matrixA, int[,] matrixB)
{
    int m = matrixA.GetLength(0);
    int n = matrixA.GetLength(1);
    int p = matrixB.GetLength(1);
    int[,] matrixC = new int[m, p];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < p; j++)
        {
            matrixC[i, j] = 0;
            for (int k = 0; k < n; k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}

int InputData(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int m = InputData("Введите количесво строк матрицы A >");
int n1 = InputData("Введите количесво сторбцов матрицы A >");
int n2 = InputData("Введите количесво строк матрицы B >");
int p = InputData("Введите количесво столбцов матрицы B >");
int[,] A = GetArray(m, n1, 0, 10);
int[,] B = GetArray(n2, p, 0, 10);
if (ValidateMatrixProd(A, B))
{
    int[,] C = MatrixProd(A, B);
    ShowArray(A, "Матрица A");
    ShowArray(B, "Матрица B");
    ShowArray(C, "Матрица C = A x B");
}
