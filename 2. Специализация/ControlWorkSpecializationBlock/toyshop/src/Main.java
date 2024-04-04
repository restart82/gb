
import exceptions.FileInitException;
import toyshop.Toyshop;


public class Main {
    public static final int NUMBER_OF_LAUNCHES = 10;
    public static void main(String[] args) {

        Toyshop toyshop = new Toyshop();
        toyshop.put("2 конструктор 2");
        toyshop.put("2 робот 3");
        toyshop.put("6 кукла 5");
        toyshop.put("1 машинка 2");
        System.out.println(toyshop.getInfo());

        toyshop.changeWeight(1, 3);
        System.out.println(toyshop.getInfo());
        int toyQuantity = toyshop.getToyTotalQuantity();

        toyshop.fileInit();
        int count = 0;
        for (int i = 0; i < NUMBER_OF_LAUNCHES; i++) {
            if (i >= toyQuantity) {
                System.out.println("Игрушек больше нет :(");
                break;
            }
            try {
                toyshop.get();
                count++;
            } catch (FileInitException e) {
                System.out.println(e.getMessage());
            }
            if (count == NUMBER_OF_LAUNCHES) {
                System.out.println("Запись прошла успешно!");
            }
        }
    }
}