// Задача 21
// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int N = 3; // N-мерное пространство
int[] point_A = new int[N]; // Массив для координат точки А
int[] point_B = new int[N]; // Массив для координат точки B

// Считываем данные с консоли:
int InputData(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

// Найдем расстояние между точками:
double FindRadius(int[] point1, int[] point2)
{
    double result = 0;
    for (int i = 0; i < N; i++)
    {
        result = result + Math.Pow(point1[i] - point2[i], 2);
    }
    return Math.Sqrt(result);
}


// --Тело--

for (int i = 0; i < N; i++)
{
    point_A[i] = InputData($"Введите {i + 1}-ю координату точки A >");
}
for (int i = 0; i < N; i++)
{
    point_B[i] = InputData($"Введите {i + 1}-ю координату точки B >");
}

double rad = Math.Round(FindRadius(point_A, point_B), 2);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Расстояние между точками A и B в {N}D пространстве = " + rad);
Console.ResetColor();


