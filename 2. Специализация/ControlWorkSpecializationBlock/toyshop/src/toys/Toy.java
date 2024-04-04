package toys;

public class Toy implements ToyItem {
    private int id;
    private int weight;
    private String name;
    private int quantity;
    public Toy (int id, int weight, String name, int quantity) {
        this.id = id;
        this.weight = weight;
        this.name = name;
        this.quantity = quantity;
    }

    public int getID() {
        return id;
    }

    public int getWeight() {
        return weight;
    }

    public void setWeight(int weight) {
        this.weight = weight;
    }

    public int getQuantity() {
        return quantity;
    }

    public void setQuantity(int quantity) {
        this.quantity = quantity;
    }

    public String getName() {
        return name;
    }

    @Override
    public String toString() {
        return  "ID" +
                id +
                ":\tИгрушка -\t\t" +
                name +
                "\n\t\tВес выпадания -\t" +
                weight +
                "\n\t\tКоличество -\t" +
                quantity +
                "\n\n";
    }

}
