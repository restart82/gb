import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class PhoneBook {
    private Map<String, List<String>> map = new HashMap<>(); //(имя, [телефоны])

    void addСontact(String name, String number) {
        if (map.containsKey(name)) {
            List<String> list = map.get(name);
            list.add(number);
        } else {
            List<String> list = new ArrayList<>();
            list.add(number);
            map.put(name, list);
        }
    }

    void deleteContact(String name) {
        if (map.containsKey(name)) {
            map.remove(name);
        }
    }

    String getContact(String name) {
        StringBuilder stringBuilder = new StringBuilder();
        if (map.containsKey(name)) {
            stringBuilder.append(name);
            stringBuilder.append(": ");
            List<String> numbers = map.get(name);
            for (String number : numbers) {
                stringBuilder.append(number);
                stringBuilder.append(" ");
            }
            stringBuilder.append("\n");
        } else {
            stringBuilder.append("no contact");
        }
        return stringBuilder.toString();
    }

    String getBook() {
        StringBuilder stringBuilder = new StringBuilder();
        for (Map.Entry<String, List<String>> contact : map.entrySet()) {
            String name = contact.getKey();
            List<String> numbers = contact.getValue();
            stringBuilder.append(name);
            stringBuilder.append(": ");
            for (String string : numbers) {
                stringBuilder.append(string);
                stringBuilder.append(" ");
            }
            stringBuilder.append("\n");
        }
        return stringBuilder.toString();
    }

}