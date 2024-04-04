
public class Main {

    public static void main(String[] args) {
        int id = 0;
        VendingMachine vendingMachine = new VendingMachine();

        Product product1 = new Product(id++, "twix", 100);
        Product product2 = new Bottle(id++, "coca-cola", 90, 0.5);
        Product product3 = new Product(id++, "lays", 70);
        
        vendingMachine.addProduct(product1);
        vendingMachine.addProduct(product2);
        vendingMachine.addProduct(product3);
        
        System.out.println(vendingMachine);
    }

}
