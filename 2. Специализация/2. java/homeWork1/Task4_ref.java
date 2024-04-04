import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class Task4_ref {
    /*
В файле задано уравнение вида q + w = e (q, w, e >= 0).
Некоторые цифры могут быть заменены знаком вопроса, например 2? + ?5 = 69.
Восстановите выражение до верного равенства.
Предложите хотя бы одно решение или сообщите, что его нет.
*/
    public static void main(String[] args) {
        String filePath = "src/lesson1/homeWork/primer.txt";
        String answer = getSolution(filePath);
        System.out.println(answer);
    }

    public static String getSolution(String filePath) {
        char[] primer = getPrimer(filePath);
        int[] questionIndexes = getQuestionIndexes(primer);
        int[] perebor = new int[questionIndexes.length];
        while (!checkPrimer(primer, questionIndexes, perebor)){
            if (!nextPerebor(perebor)){
                return "No solution";
            }
        }
        String line = String.valueOf(primer);
        return "Result: " + line;
    }

    /**
     * @param filePath
     * @return
     */
    static char[] getPrimer(String filePath) {
        File file = new File(filePath);
        Scanner scanner = null;
        try {
            scanner = new Scanner(file);
            String line = scanner.nextLine();
            System.out.println("Given the equation: " + line);
            return line.toCharArray();
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
        return null;
    }

    static int[] getQuestionIndexes(char[] primer) {
        int count = 0;
        for (int i = 0; i < primer.length; i++) {
            if (primer[i] == '?'){
                count++;
            }
        }
        int[] questionIndexes = new int[count];
        count = 0;
        for (int i = 0; i < primer.length; i++) {
            if (primer[i] == '?'){
                questionIndexes[count++] = i;
            }
        }
        return questionIndexes;
    }

    static boolean checkPrimer(char[] primer, int[] questionIndexes, int[] perebor){
        for (int i = 0; i < questionIndexes.length; i++) {
            int index = questionIndexes[i];
            int codeDigit = perebor[i] + 48;
            primer[index] = (char) codeDigit;
        }
        return checkEquation(primer);
    }

    static boolean checkEquation(char[] primer) {
        String line = String.valueOf(primer);
        String[] nums = line.split("[+=]");
        int num1 = Integer.parseInt(nums[0].trim());
        int num2 = Integer.parseInt(nums[1].trim());
        int num3 = Integer.parseInt(nums[2].trim());
        return num1 + num2 == num3;
    }

    static boolean nextPerebor(int[] perebor) {
        for (int i = perebor.length - 1; i >= 0; i--) {
            if (perebor[i] == 9){
                perebor[i] = 0;
            } else {
                perebor[i]++;
                return true;
            }
        }
        return false;
    }
}
