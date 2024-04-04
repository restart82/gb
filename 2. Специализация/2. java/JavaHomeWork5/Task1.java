public class Task1 {
    // Реализуйте структуру телефонной книги с помощью HashMap, учитывая, что 1 человек может иметь несколько телефонов.

    public static void main(String[] args) {
        PhoneBook phoneBook = new PhoneBook();
        phoneBook.addСontact("Petr", "123456");
        phoneBook.addСontact("Gregr", "741456");
        phoneBook.addСontact("Masha", "74179");
        phoneBook.addСontact("Petr", "4411233");
        phoneBook.addСontact("Vika", "745365");

        System.out.println(phoneBook.getBook());

        phoneBook.deleteContact("Gregr");

        System.out.println(phoneBook.getBook());

        System.out.println(phoneBook.getContact("Petr"));
    }
}