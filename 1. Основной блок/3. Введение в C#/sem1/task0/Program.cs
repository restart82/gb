//Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).

//Например:
//4 -> 16
//-3 -> 9
//-7 -> 49

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
// int.Parse(...) - переводит из sring в int
// Console.ReadLine() принимает строковое значение
// ! - просто убирает предупреждение

int number_sq = number * number;

Console.WriteLine("А вот квадрат этого числа: " + number_sq);





