// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int DeleteSecondNumber(int num)
{
    int result = (num / 100) * 10 + num % 10;
    return result;
}

int RandNumber = new Random().Next(100, 1000);
Console.WriteLine("Вот трехзначное число: " + RandNumber);
int Number = DeleteSecondNumber(RandNumber);
Console.WriteLine("Вот двухзначное число: " + Number);



