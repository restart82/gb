public class DataPacket {
    private final static int PACKET_SIZE = 6;
    private String firstName;
    private String lastName;
    private String patronymic;
    private String birthDate;
    private String phoneNumber;
    private String gender;
    private DataPacket(String packet){
        String[] parsPacket = packet.split(" ");
        this.firstName = parsPacket[0];
        this.lastName = parsPacket[1];
        this.patronymic = parsPacket[2];
        this.birthDate = parsPacket[3];
        this.phoneNumber = parsPacket[4];
        this.gender = parsPacket[5];
    }

    public String getFirstName() {
        return firstName;
    }

    public String getLastName() {
        return lastName;
    }

    public String getPatronymic() {
        return patronymic;
    }

    public String getBirthDate() {
        return birthDate;
    }

    public String getPhoneNumber() {
        return phoneNumber;
    }

    public String getGender() {
        return gender;
    }

    @Override
    public String toString() {
        return "<" +
                firstName +
                ">" +
                "<" +
                lastName +
                ">" +
                "<" +
                patronymic +
                ">" +
                "<" +
                birthDate +
                ">" +
                "<" +
                phoneNumber +
                ">" +
                "<" +
                gender +
                ">";
    }


    public static DataPacket create(String packet) throws PacketSizeException{
        String[] parsPacket = packet.split(" ");
        if (parsPacket.length != PACKET_SIZE) {
            throw new PacketSizeException("Некорректная длина посылки", parsPacket.length);
        }
        if (!dateCheck(parsPacket[3])){
            throw new RuntimeException("Некорректная дата рождения (dd.mm.yyyy)");
        }
        if (!isDigit(parsPacket[4])){
            throw new RuntimeException("Номер телефона должен состоять из цифр");
        }
        if (!((parsPacket[5].equals("m")) || (parsPacket[5].equals("f")))){
            throw new RuntimeException("Введен некорректный пол (m / f)");
        }
        return new DataPacket(packet);
    }

    private static boolean dateCheck(String strDate){
        String[] parseDate = strDate.split("\\.");
        return (parseDate.length == 3) &&
                (isDigit(parseDate[0])) &&
                (isDigit(parseDate[1])) &&
                (isDigit(parseDate[2])) &&
                (parseDate[0].length() == 2) &&
                (parseDate[1].length() == 2) &&
                (parseDate[2].length() == 4);
    }

    public static boolean isDigit(String str) {
        try {
            Double.parseDouble(str);
            return true;
        } catch(NumberFormatException e){
            return false;
        }
    }

}
