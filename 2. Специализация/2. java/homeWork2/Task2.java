import java.io.IOException;
import java.util.Arrays;
import java.util.logging.FileHandler;
import java.util.logging.Handler;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.logging.SimpleFormatter;

public class Task2 {

    // Реализуйте алгоритм сортировки пузырьком числового массива, результат после каждой итерации запишите в лог-файл.

    static Logger logger;
    public static void main(String[] args) {
        createLogger();
        int[] arr = new int[] {9, 4, 8, 3, 1};
        int[] res = new int[arr.length];
        res = sort(arr);
        System.out.println(Arrays.toString(res));
        closeLogger();
    }

    static int[] sort(int[] arr){
        int temp;
        for (int i = 0; i < arr.length; i++) {
            for (int j = 0; j < arr.length - 1; j++) {
                if (arr[j] > arr[j + 1]) {
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
            logger.log(Level.INFO, Arrays.toString(arr) + "\n");
        }
        return arr;
    }

    static void createLogger(){
        logger = Logger.getAnonymousLogger();
        FileHandler fileHandler = null;
        try {
            fileHandler = new FileHandler("log_task2.txt", true);
            SimpleFormatter formatter = new SimpleFormatter();
            fileHandler.setFormatter(formatter);
        } catch (IOException e) {
            e.printStackTrace();
        }
        logger.addHandler(fileHandler);
    }

    static void closeLogger(){
        Handler[] handlers = logger.getHandlers();
        for (int i = 0; i < handlers.length; i++) {
            handlers[i].close();
        }
    }
}
