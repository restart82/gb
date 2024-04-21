#include <stdio.h>

// Составить функцию, которая определяет наибольший общий делитель двух
// натуральных и привести пример ее использования

int nod(int a, int b)
{
    while (a != b)
    {
      (a > b) ? (a -= b) : (b -= a); 
    }
    return a;
}

int main(void)
{
    int numberA, numberB;
    scanf("%d %d", &numberA, &numberB);
    printf("%d", nod(numberA, numberB));
    return 0;
}