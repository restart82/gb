// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] InputData(int number)
{
    double[] dot = new double[2];
    Console.Write($"Задайте {number}-ю прямую (y = k{number}*x + b{number}):\n");
    string[] mes = {"k", "b"};
    for (int i = 0; i < 2; i++)
    {
        Console.Write(mes[i] + number + " = ");
        dot[i] = int.Parse(Console.ReadLine()!);
    }
    return dot;
}

double[] GetCross(double[] dot1, double[] dot2)
{
    double[] crossCoord = new double[2];
    crossCoord[0] = (dot2[1] - dot1[1]) / (dot1[0] - dot2[0]);
    crossCoord[1] = dot1[0] * crossCoord[0] + dot1[1];
    return crossCoord;
}

bool ValidCoord(double[] dot1, double[] dot2)
{
    if (dot1[0] == dot2[0]) return false;
    else return true;
}

double[] dot1 = InputData(1);
double[] dot2 = InputData(2);

if (ValidCoord(dot1, dot2))
{
    double[] cross = GetCross(dot1, dot2);
    Console.WriteLine($"Точка пересечения: ({String.Join("; ", cross)})\n");
}
else Console.WriteLine("Точки не пересекаются\n");







