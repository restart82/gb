import java.util.HashMap;
import java.util.Map;
import java.util.Stack;

public class Task3 {
    
    /*Написать программу, определяющую правильность расстановки скобок в выражении.
    Пример 1: a+(d*3) - истина
    Пример 2: [a+(1*3]) - ложь
    Пример 3: [6+(3*3)] - истина
    Пример 4: {a}[+]{(d*3)} - истина
    Пример 5: <{a}+{(d*3)}> - истина
    Пример 6: {a+]}{(d*3)} - ложь*/

    public static void main(String[] args) {
        String line = "[a+(1*3])";
        System.out.println(check(line));
    }

    static boolean check(String line){
        Stack<Character> stack = new Stack<>();
        char[] chars = line.toCharArray();

        Map<Character, Character> map = new HashMap<>();
        map.put('(', ')');
        map.put('[', ']');
        map.put('<', '>');
        map.put('{', '}');

        for (char c: chars){
            if (map.containsKey(c)){
                stack.push(c);
            }
            if (map.containsValue(c)){
                if (stack.empty() || map.get(stack.pop()) != c){
                    return false;
                }
            }
        }
        return stack.empty();
    }
}
