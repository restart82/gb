public class Laptop {
    
    double diagonal;
    String color;
    String brand;
    String os;
    int ram;
    int ssd;
    int price;

    @Override
    public String toString() {
        return  "\nДиагональ: " + diagonal + "\"" +
                "\nЦвет: " + color +
                "\nФирма: " + brand +
                "\nОперационная система: " + os +
                "\nОперативная память: " + ram + " Гб" +
                "\nЖесткий диск: " + ssd + " Гб" +
                "\nЦена: " + price / 1000 + " " + price % 1000 + " руб.";
    }

    @Override
    public boolean equals(Object obj) {
        if (this == obj){
            return true;
        }
        if (!(obj instanceof Laptop)){
            return false;
        }
        Laptop laptop = (Laptop) obj;
        return  diagonal == laptop.diagonal &&
                color.equals(laptop.color) &&
                brand.equals(laptop.brand) &&
                os.equals(laptop.os) &&
                ram == laptop.ram &&
                ssd == laptop.ssd &&
                price == laptop.price;    
    }

    @Override
    public int hashCode() {
        return  5 * brand.hashCode() +
                2 * os.hashCode() +
                3 * ram +
                17 * price;
    }

}

