import java.util.ArrayDeque;
import java.util.Deque;

public class Task3 {
    public static void main(String[] args) {
        int a, b, c, d;
        char op, op2, undo;
        a = 3;
        op = '+';
        b = 7;
        c = 4;
        op2 = '+';
        d = 7;
        undo = '<';
        Calculator calculator = new Calculator();
        int result1 = calculator.calculate(op, a, b);
        int result2 = calculator.calculate(op2, c, d);
        int result3 = calculator.calculate(undo, 0, 0);
        System.out.println(result1);
        System.out.println(result2);
        System.out.println(result3);
    }
    
}



class Calculator {
    public Deque<Integer> deqArray = new ArrayDeque<Integer>();
    public int calculate(char op, int a, int b) {
        int result = 0;
        switch (op) {
            case '+':
                result = a + b;
                deqArray.addLast(result);
                break;
            case '-':
                result = a - b;
                deqArray.addLast(result);
                break;
            case '*':
                result = a * b;
                deqArray.addLast(result);
                break;
            case '/':
                result = a / b;
                deqArray.addLast(result);
                break;
            case '<':
                deqArray.removeLast();
                result = deqArray.getLast();
                break;
        }
        return result;
    }
}
