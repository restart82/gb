#include <stdio.h>

// Составить логическую функцию, которая определяет, верно ли, что в заданном
// числе сумма цифр равна произведению.


int is_happy_number(int n)
{
    int sum = 0, mult = 1, result;
    while (n > 0)
    {
        sum += n % 10;
        mult *= n % 10;
        n /= 10;
    }
    (sum == mult) ? (result = 1) : (result = 0);
    return result;
}

int main(int argc, char const *argv[])
{
    int number;
    scanf("%d", &number);
    is_happy_number(number) ? printf("YES") : printf("NO");
    return 0;
}
