#include <stdio.h>

// Ввести целое число и «перевернуть» его, так чтобы первая цифра стала
// последней и т.д.

int main(void)
{
    int number, reverse, order = 1;

    scanf("%d", &number);

    while ((number / order) > 0)
    {
        reverse *= 10;
        reverse += ((number / order) % 10);
        order *= 10;
    }
    
    printf("%d", reverse);

    return 0;
}