// Задача 15:
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Прописал метод, который выдает строковые значения
string Weekend(int Day)
{
    string message;
    if((Day >= 1) && (Day <= 5))
        message = "нет";
    else if((Day == 6) || (Day == 7))
        message = "да";
    else
        message = "такого дня не бывает";
    return message;
}

Console.Write("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine()!);
string weekend = Weekend(day);
Console.WriteLine(weekend);