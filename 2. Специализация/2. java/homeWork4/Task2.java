import java.util.LinkedList;

class MyQueue<T> {
        // Напишите свое решение ниже
    private T[] array = new T[10];
    private int size = 0;


    public void enqueue(T element){
        // Напишите свое решение ниже
        if (array.length <= size){
            T[] array2 = (T[]) new Object[array.length*2];
            System.arraycopy(array, 0, array2, 0, array.length);
            array = array2;
        }
        array[size++] = element;
    }

    // public T dequeue(){
    //     // Напишите свое решение ниже

    // }

    // public T first(){
    //     // Напишите свое решение ниже

    // }

    // public LinkedList<T> getElements() {
    //     // Напишите свое решение ниже

    // }
}

// Не удаляйте этот класс - он нужен для вывода результатов на экран и проверки
public class Task2 {
    public static void main(String[] args) {
        MyQueue<Integer> queue;
        queue = new MyQueue<>();

        if (args.length == 0) {
        // При отправке кода на Выполнение, вы можете варьировать эти параметры
            queue.enqueue(1);
            queue.enqueue(10);
            queue.enqueue(15);
            queue.enqueue(5);
        } else {
            queue.enqueue(Integer.parseInt(args[0]));
            queue.enqueue(Integer.parseInt(args[1]));
            queue.enqueue(Integer.parseInt(args[2]));
            queue.enqueue(Integer.parseInt(args[3]));
        }
        System.out.println(queue);

        // System.out.println(queue.getElements());

        // queue.dequeue();
        // queue.dequeue();
        // System.out.println(queue.getElements());

        // System.out.println(queue.first());
    }
}