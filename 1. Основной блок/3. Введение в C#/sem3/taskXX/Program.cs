// Напишите программу, которая принимает
// на вход координаты двух точек и находит расстояние
// между ними в 2D пространстве.

int InputData(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

double GetRadius(int XA, int YA, int XB, int YB)
{
    double result = Math.Sqrt(Math.Pow((XB - XA), 2) + Math.Pow((YB - YA), 2));
    return result;
}

int point1_x = InputData("Введите координату Х первой точки > ");
int point1_y = InputData("Введите координату У первой точки > ");
int point2_x = InputData("Введите координату Х второй точки > ");
int point2_y = InputData("Введите координату У второй точки > ");

double radius = GetRadius(point1_x, point1_y, point2_x, point2_y);
Console.WriteLine("Вот расстояние между точками: " + Math.Round(radius, 2));





