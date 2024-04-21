#ifndef _TASK_H
#define _TASK_H

#include "config.h"

typedef struct
{
    char* directoryName;
    char* fileName;
}fileAddress_t;

fileAddress_t parseAddress(char* string);

void changeFileName(fileAddress_t* fileAddress);

void buildString(char* string, fileAddress_t fileAddress);

#endif