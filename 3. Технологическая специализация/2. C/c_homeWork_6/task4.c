#include <stdio.h>

// Дана последовательность целых чисел через пробел, завершающаяся числом
// 0. Выведите все нечетные числа из этой последовательности, сохраняя их
// порядок.

int main(int argc, char const *argv[])
{
    char c;
    int number = 0;
    while ((c = getchar()) != '0')
    {
        if(c >= '0' && c <= '9')
        {
            number = number * 10 + c - '0';
        }
        if (c == ' ')
        {
            if (number % 2 == 1)
            {
                printf("%d ", number);
            }
            number = 0;
        }
    }

    return 0;
}

