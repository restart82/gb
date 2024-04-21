#include <stdio.h>

// Ввести целое число и определить, верно ли, что в нём ровно 3 цифры.

int main(void)
{
    int number;
    scanf("%d", &number);

    ((number >= 100) && (number <= 999)) ? printf("YES") : printf("NO");

    return 0;
}