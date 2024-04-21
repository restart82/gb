#include "task.h"

void addExtantion(char* file, int pos)
{
    char* extantion = ".html";
    int i = 0;

    for (i; i < strlen(extantion); i++)
    {
        *(file + pos + i) = *(extantion + i);
    }

    *(file + pos + i) = '\0';
}

fileAddress_t parseAddress(char* string)
{
    printf("%s\n", string);
    fileAddress_t fileAddress = {
        .directoryName = (char*)malloc(STRING_BUFER * sizeof(char)),
        .fileName = (char*)malloc(STRING_BUFER * sizeof(char))
    };

    int i = 1, j = 0;

    while (string[i] != '/')
    {
        fileAddress.directoryName[j++] = string[i++];
    }
    fileAddress.directoryName[j] = '\0';
    j = 0;
    i++;
    while (string[i] != '\0')
    {
        fileAddress.fileName[j++] = string[i++];
    }
    fileAddress.fileName[j] = '\0';
    
    printf("%s %s\n", fileAddress.directoryName, fileAddress.fileName);

    return fileAddress;
}

void changeFileName(fileAddress_t* fileAddress)
{
    printf("%s\n", fileAddress->fileName);

    int i = 0;
    while (fileAddress->fileName[++i] != '.' && fileAddress->fileName[i] != '\0');

    addExtantion(fileAddress->fileName, i);

    printf("%s\n", fileAddress->fileName);
}

void buildString(char* string, fileAddress_t fileAddress)
{
    int i = 0, j = 0;
    string[i++] = '/';

    while (fileAddress.directoryName[j] != '\0')
    {
        string[i++] = fileAddress.directoryName[j++];
    }

    string[i++] = '/';
    j = 0;

    while (fileAddress.fileName[j] != '\0')
    {
        string[i++] = fileAddress.fileName[j++];
    }

    string[i] = '\0';

    printf("%s\n", string);
}
