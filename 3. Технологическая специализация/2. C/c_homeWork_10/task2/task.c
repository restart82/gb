#include "task.h"

void delete(char* str, int i)
{
    while (str[i] != '\0')
    {
        *(str + i) = *(str + i + 1);
        i++;
    }
}

void deleteSpases(char* string)
{
    printf("%s\n", string);

    while (*(string) == ' ')
    {
        delete(string, 0);
    }

    int spaceCounter = 0,
        i = 0;

    while (string[i] != '\0')
    {
        if (string[i] == ' ' && spaceCounter == 0)
        {
            spaceCounter++;
            i++;
        }
        else if (string[i] == ' ' && spaceCounter > 0)
        {
            delete(string, i);
        }
        else
        {
            i++;
        }
    }
    

    printf("%s\n", string);
}