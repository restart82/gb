#include <stdio.h>
#include <stdbool.h>

// Проверить строку состоящую из скобок "(" и ")" на корректность.

#define CHAR_BUFER 100

bool checkString(char str[CHAR_BUFER])
{
    int i = 0, count = 0;
    while (str[i] != '\0')
    {
        switch (str[i])
        {
        case '(':
            count++;
            break;
        case ')':
            count--;
            break;
        }
        i++;
    }
    return (count == 0);
}

int main(int argc, char const *argv[])
{
    char string[CHAR_BUFER];
    fgets(string, CHAR_BUFER, stdin);
    checkString(string) ? printf("YES") : printf("NO");
    return 0;
}
