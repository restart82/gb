#include <stdio.h>
#include "funk.h"

int m;
int main(void)
{
    int a,b;
    scanf("%d%d", &a, &b);
    m = max(a, b);
    printf("max(%d %d) = %d\n", a, b, m);
    return 0;
}