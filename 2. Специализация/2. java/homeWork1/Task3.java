// Напишите класс Calculator, который будет выполнять математические операции (+, -, *, /)
// над двумя числами и возвращать результат. В классе должен быть метод calculate, который
// принимает оператор и значения аргументов и возвращает результат вычислений.

public class Task3 {
    public static void main(String[] args) {
        char op = '+';
        int a = 5;
        int b = 6;

        int res = 0;

        switch (op) {
            case '+':
                res = a + b;
                break;
            case '-':
                res = a - b;
                break;
            case '*':
                res = a * b;
                break;
            case '/':
                res = a / b;
                break;
            default:
                System.out.println("Некорректный оператор: " + op);
                break;
        }

        System.out.println(res);

    }
}
