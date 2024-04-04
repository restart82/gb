# def calk1(a, b):
#     return a + b
# ~~ лямбда фунция
calk1 = lambda a, b: a + b

def calk2(a, b):
    return a * b

def math(op, x, y):
    print(op(x, y))


math(calk1, 5, 4)
math(calk2, 5, 4)
