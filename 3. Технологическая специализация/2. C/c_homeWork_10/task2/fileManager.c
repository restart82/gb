#include "fileManager.h"

void readFile(char* string)
{
    FILE* file;
    char c;
    int i = 0;

    if ((file = fopen(INPUT_FILE_NAME, "r")) == NULL)
    {
        perror("Error occured while opening input file!");
        exit (1);
    }

    while ((c = fgetc(file)) != EOF)
    {
        string[i++] = c;
    }

    string[i] = '\0';
    fclose(file);
}

void writeFile(char* string)
{
    FILE *file = fopen(OUTPUT_FILE_NAME, "w");
    fprintf(file, "%s", string);
    fclose(file);
}