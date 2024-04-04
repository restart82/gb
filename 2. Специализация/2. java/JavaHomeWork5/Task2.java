
import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.Map;
import java.util.TreeMap;

public class Task2 {

    private static String[] staffNames;

    // Написать программу, которая найдет и выведет повторяющиеся имена с количеством повторений.
    // Отсортировать по убыванию популярности.
    public static void main(String[] args) {

        Map<Integer, List<String>> map = new TreeMap<>(Comparator.reverseOrder());
        
        
        String staffList = "Иван Иванов, Светлана Петрова, Кристина Белова, " + 
                            "Анна Мусина, Анна Крутова, Иван Юрин, Петр Лыков, Павел Чернов, " + 
                            "Петр Чернышов, Мария Федорова, Марина Светлова, Мария Савина, Мария Рыкова, " +
                            "Марина Лугова, Анна Владимирова, Иван Мечников, Петр Петин, Иван Ежов";

        String[] staff = staffList.split(", "); //Список сотрудников имя и фамилия
        staffNames = new String[staff.length]; //Список имен сотрудников
        
        for (int i = 0; i < staffNames.length; i++) {
            String[] string = staff[i].split(" ");
            staffNames[i] = string[0];
        }

        for (int i = 0; i < staffNames.length; i++) {
            int count = 0;
            for (String string : staffNames) {
                if (staffNames[i].equals(string)) {
                    count++;
                }
            }
            if (map.containsKey(count)) {
                List<String> list = map.get(count);
                if (!list.contains(staffNames[i])) {
                    list.add(staffNames[i]);
                }
            } else {
                List<String> list = new ArrayList<>();
                list.add(staffNames[i]);
                map.put(count, list);
            }
        }

        //System.out.println(map1);

        for (Map.Entry<Integer, List<String>> string : map.entrySet()) {
            for (String string2 : string.getValue()) {
                System.out.println(string2 + " (" + string.getKey() + ")");
            }
        }
    }
}
