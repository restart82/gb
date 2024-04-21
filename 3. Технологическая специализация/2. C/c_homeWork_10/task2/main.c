#include "config.h"
#include "task.h"
#include "fileManager.h"

// В файле .txt записаны символы. Необходимо разработать функцию, которая
// меняет местами пары соседних символов не обращая внимание на символы
// пробел. Если количество символов нечетно (пробелы не считаем), то
// последний символ не меняем. Результат записать в файл .txt.

int main(int argc, char const *argv[])
{
    char* text = (char*)malloc(STRING_BUFER * sizeof(char));
    readFile(text);
    deleteSpases(text);
    writeFile(text);

    return 0;
}
