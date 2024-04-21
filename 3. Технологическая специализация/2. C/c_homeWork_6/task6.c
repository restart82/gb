#include <stdio.h>

// Написать рекурсивную функцию возведения целого числа n в степень p.

int recurs_power(int n, int p)
{
    if (p > 0)
    {
        return n * recurs_power(n, --p);
    }
    else
    {
        return 1;
    }
}

int main(int argc, char const *argv[])
{
    int n, p, pow;
    scanf("%d %d", &n, &p);
    printf("%d", recurs_power(n, p)); 
    return 0;
}
