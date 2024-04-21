#include <stdio.h>

/*Ввести три числа, найти их сумму
Нужно напечатать сумму трех чисел*/

int main(void)
{
    int a, b, c;
    scanf("%d %d %d", &a, &b, &c);
    printf("%d+%d+%d=%d", a, b, c, a + b + c);

    return 0;
}