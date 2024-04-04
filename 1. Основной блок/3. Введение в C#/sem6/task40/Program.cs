// Задача 40:
// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.

int InputData(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

bool Theorem(int ab, int bc, int ac)
{
    if (ab < bc + ac && bc < ab + ac && ac < ab + bc) return true;
    else return false;
}

int ab = InputData("Введите длину первой стороны >");
int bc = InputData("Введите длину второй стороны >");
int ac = InputData("Введите длину третей стороны >");

if (Theorem(ab, bc, ac)) Console.WriteLine("Yes");
else Console.WriteLine("No");
