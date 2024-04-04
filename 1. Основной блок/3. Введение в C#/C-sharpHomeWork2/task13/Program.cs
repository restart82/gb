// Задача 13:
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void GetThirdNumber(int num)
{

    // Определим порядок числа:
    // 666 -> 3
    // 666666 -> 6
    int exp = 0;
    int StartNum = num;
    while(StartNum > 0)
    {
        StartNum = StartNum / 10;
        exp++;
    }
    //Console.WriteLine("порядок - " + exp);
    
    if(exp < 3) //если порядок числа < 3
        Console.Write("Третьей цифры нет");
    else
    {
        //int result = (num / (10^(exp - 3))) % 10;
        int result = (num / (int)Math.Pow(10, (exp - 3))) % 10; //Pow выдает double. Что-бы на выходе получить int, можно перед функцией указать (int)
        //double result = Math.Round(result1, MidpointRounding.ToZero);
        Console.WriteLine("Вот его третья цифра - " + result);
    }
    }


Console.Write("Введите число: ");
int Number = int.Parse(Console.ReadLine()!);

// Вызываем метод:
GetThirdNumber(Number);


