#include <stdio.h>

// Составить функцию, которая определяет сумму всех чисел от 1 до N и
// привести пример ее использования.

typedef unsigned int uint;

uint getSum(int n)
{
    uint sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += i;
    }
    return sum;
}

int main(int argc, char const *argv[])
{
    int number;
    scanf("%d", &number);
    printf("%d", getSum(number));
    return 0;
}
