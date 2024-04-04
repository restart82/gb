# Требуется найти в массиве A[1..N] самый близкий по
# величине элемент к заданному числу X. Пользователь в первой строке
# вводит натуральное число N – количество элементов в массиве. В
# последующих строках записаны N целых чисел Ai
# . Последняя строка
# содержит число X

import math

number_n = int(input("Введите число N >"))
list_1 = list()
print("Введите массив:")

for i in range(number_n):
    n = int(input())
    list_1.append(n)

number_x = int(input("Введите число X >"))

d_min = math.fabs(list_1[0] - number_x)
number = list_1[0]

for i in list_1[1:]:
    if math.fabs(i - number_x) < d_min:
        d_min = math.fabs(i - number_x)
        number = i

print(number)

