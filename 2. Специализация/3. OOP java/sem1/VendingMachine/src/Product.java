

public class Product {
    
    private int id;
    private double price;
    private String name;

    public String getName() {
        return name;
    }

    public int getId() {
        return id;
    }

    public double getPrice() {
        return price;
    }

    public Product(int id, String name, double price) {
        this.id = id;
        this.name = name;
        this.price = price;
    }

    @Override
    public String toString() {
        return  "id: " + id +
                ", name: " + name +
                ", price: " + price;
    }


}
