import java.util.LinkedList;

public class Task1 {
    /*Напишите класс LLTasks с методом revert, который принимал бы на вход LinkedList и возвращает “перевернутый” список. */
    public static void main(String[] args) {
        LinkedList<Object> LinList = new LinkedList<>();
        LinList.add(1);
        LinList.add("One");
        LinList.add(2);
        LinList.add("Two");
        System.out.println(LinList);
        LLTasks answer = new LLTasks();
        LinkedList<Object> reversedList = answer.revert(LinList);
        System.out.println(reversedList);
    }
}

class LLTasks {
    public LinkedList<Object> revert(LinkedList<Object> ll) {
        for (int i = 0; i < ll.size() / 2; i++) {
            Object temp = ll.get(i);
            ll.set(i, ll.get(ll.size() - i - 1));
            ll.set(ll.size() - i - 1, temp);
        }
        return ll;
    }
}
