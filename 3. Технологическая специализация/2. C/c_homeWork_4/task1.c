#include <stdio.h>

// Ввести два целых числа a и b (a ≤ b) и вывести сумму квадратов всех чисел от a
// до b.

int main(void)
{
    int a, b, sum = 0;
    scanf("%d %d", &a, &b);

    if (a > b)
    {
        printf("(a <= b)");
        return 1;
    }

    for (int i = a; i <= b; i++)
    {
        sum += i * i;
    }

    printf("%d", sum);

    return 0;
}