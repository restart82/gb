// Задача 42: 
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

int InputData(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

string ToBinary(int number)
{
    string result = "";
    if (number == 0) return "0";
    while (number > 0)
    {
        result = number % 2 + result;
        number /= 2;
    }
    return result;
}

int n = InputData("Введите число >");
string nBin = ToBinary(n);
Console.WriteLine(nBin + "\n");