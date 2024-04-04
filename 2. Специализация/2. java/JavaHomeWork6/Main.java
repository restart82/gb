import java.util.HashSet;
import java.util.Map;
import java.util.Scanner;
import java.util.Set;
import java.util.TreeMap;

public class Main {

    public static void main(String[] args) {
        
        Set<Laptop> laptops = new HashSet<>();

        Laptop laptop1 = addLaptop( "ASUS",
                                    "Черный",
                                    15.6,
                                    "Windows",
                                    79_999,
                                    16,
                                    512);
        
        Laptop laptop2 = addLaptop( "Xiaomi",
                                    "Серый",
                                    15.6,
                                    "Windows",
                                    44_999,
                                    8,
                                    256);

        Laptop laptop3 = addLaptop( "ASUS",
                                    "Синий",
                                    17.3,
                                    "Windows",
                                    67_999,
                                    16,
                                    512);

        Laptop laptop4 = addLaptop( "Apple",
                                    "Серый",
                                    13.3,
                                    "macOS",
                                    93_799,
                                    8,
                                    256);

        Laptop laptop5 = addLaptop( "Apple",
                                    "Золотистый",
                                    13.6,
                                    "macOS",
                                    133_399,
                                    8,
                                    256);

        Laptop laptop6 = addLaptop( "Lenovo",
                                    "Серый",
                                    15.6,
                                    "Windows",
                                    23_999,
                                    4,
                                    256);

        Laptop laptop7 = addLaptop( "Dell",
                                    "Черный",
                                    15.6,
                                    "Linux",
                                    25_799,
                                    4,
                                    256);

        laptops.add(laptop1);
        laptops.add(laptop2);
        laptops.add(laptop3);
        laptops.add(laptop4);
        laptops.add(laptop5);
        laptops.add(laptop6);
        laptops.add(laptop7);
        //printSet(laptops);
        
        Map<Integer, String> criteria = setCriteria();
        //System.out.println(criteria);

        Set<Laptop> selectLaptops = findLaptop(laptops, criteria);

        System.out.println("Подходящие вам ноутбуки:");
        if (selectLaptops.isEmpty()) {
            System.out.println("Ничего для вас не нашлось");
        } else {
            printSet(selectLaptops);
        }
    }

    static Laptop addLaptop (   String brand,
                                String color,
                                double diagonal,
                                String os,
                                int price,
                                int ram,
                                int ssd) {
        Laptop newLaptop = new Laptop();
        newLaptop.brand = brand;
        newLaptop.color = color;
        newLaptop.diagonal = diagonal;
        newLaptop.os = os;
        newLaptop.price = price;
        newLaptop.ram = ram;
        newLaptop.ssd = ssd;
        return newLaptop;
    }

    static void printSet(Set<Laptop> set){
        for (Laptop laptop: set){
            System.out.println(laptop);
        }
    }

    static Map<Integer, String> setCriteria() {
        Map<Integer, String> criteria = new TreeMap<>();
        String[] messages = new String[] {  "Какая диагональ вам нужна?",
                                            "Какую фирму хотите?",
                                            "Какой цвет вам больше нравится?",
                                            "Какая операционная система вам подходит?",
                                            "Задайте нужный диапазон оперативной памяти:",
                                            "Задайте нужный диапазон памяти жесткого диска:",
                                            "Задайте диапазон цены:"};
        loop: while (true) {
            sendInstruction();
            Scanner scanner = new Scanner(System.in);
            int key = scanner.nextInt();
            String value = "";
            clearTerminal();
            switch (key) {
                case 1, 5, 6, 7:
                {
                    Scanner sc = new Scanner(System.in);
                    System.out.println(messages[key - 1]);
                    System.out.println("от >");
                    value += sc.nextLine();
                    value += " ";
                    System.out.println("до >");
                    value += sc.nextLine();          
                    criteria.put(key, value);
                    break;
                }
                case 2, 3, 4:
                {
                    Scanner sc = new Scanner(System.in);
                    System.out.println(messages[key - 1]);
                    value += sc.nextLine();        
                    criteria.put(key, value);
                    break;
                }
                case 8:
                    break loop;
                default:
                    System.out.println("Такого критерия нет!");
            }

        }
        return criteria;
    }

    static Set<Laptop> findLaptop(Set<Laptop> laptops, Map<Integer, String> criteria) {
        Set<Laptop> res = new HashSet<>();
        int len = criteria.size();
        for (Laptop laptop : laptops) {
            int count = 0;
            for (Map.Entry<Integer, String> crit : criteria.entrySet()) {
                int key = crit.getKey();
                String value = crit.getValue();
                switch (key) {
                    case 1: {
                        String[] vals = value.split(" ");
                        double min = Double.parseDouble(vals[0]);
                        double max = Double.parseDouble(vals[1]);

                        if (laptop.diagonal <= max && laptop.diagonal >= min) {
                            ++count;
                        }
                        break;
                    }
                    case 2: {
                        if (laptop.brand.equals(value)) {
                            ++count;
                        }
                        break;
                    }
                    case 3: {
                        if (laptop.color.equals(value)) {
                            ++count;
                        }
                        break;
                    }
                    case 4: {
                        if (laptop.os.equals(value)) {
                            ++count;
                        }
                        break;
                    }
                    case 5, 6, 7: {
                        String[] vals = value.split(" ");
                        int min = Integer.parseInt(vals[0]);
                        int max = Integer.parseInt(vals[1]);

                        switch (key) {
                            case 5: {
                                if (laptop.ram <= max && laptop.ram >= min) {
                                    ++count;
                                } 
                                break;
                            }
                            case 6: {
                                if (laptop.ssd <= max && laptop.ssd >= min) {
                                    ++count;
                                }
                                break; 
                            }
                            case 7: {
                                if (laptop.price <= max && laptop.price >= min) {
                                    ++count;
                                }
                                break; 
                            }
                        }
                    }
                    break;
                }
                if (count == len) {
                    res.add(laptop);
                }
            }
        }
        return res;
    }

    static void sendInstruction() {
        clearTerminal();
        String instruction =    "Введите цифру, соответствующую необходимому критерию:\n" + 
                            "  1. Диагональ\n" +
                            "  2. Фирма\n" + 
                            "  3. Цвет\n" + 
                            "  4. Операционная система\n" + 
                            "  5. Оперативная память\n" + 
                            "  6. Память SSD\n" +
                            "  7. Цена\n" + 
                            "  8. Найти ноутбук\n"; 
        System.out.println(instruction);
    }

    static void clearTerminal() {
        for (int i = 0; i < 20; i++) {
            System.out.println("\n");
        }
    }
}