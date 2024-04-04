// Напишите функцию printPrimeNums, которая выведет на экран все простые
// числа в промежутке от 1 до 1000, каждое на новой строке.

public class Task2 {
    public static void main(String[] args) {
        for (int a = 1; a <= 1000; a++) {
            int count = 0;
            for (int i = 2; i < a; i++) {
                if (a % i == 0){
                    count++;
                }
            }
            if (count == 0){
                System.out.println(a);
            }
        }
    }
}
