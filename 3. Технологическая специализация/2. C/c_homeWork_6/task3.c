#include <stdio.h>

// Дано натуральное число N. Посчитать количество «1» в двоичной записи
// числа.

int getOnesQuantity(int num)
{
    int ones = 0;
    while (num > 0)
    {
        ones += num % 2;
        num /= 2;
    }
    return ones;
}

int main(int argc, char const *argv[])
{
    int number;
    scanf("%d", &number);
    printf("%d", getOnesQuantity(number));
    return 0;
}
