using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Order 1:");
        Address address1 = new Address("123 Test St", "Test Town", "ID", "USA");
        Customer customer1 = new Customer("Jimmy", address1);
        Order order1 = new Order(customer1);
        Product product1 = new Product("Pizza", 10, 2, "A123");
        Product product2 = new Product("Soda", 2, 3, "B456");
        Product product3 = new Product("Salad", 5, 1, "C789");

        order1.addProduct(product1);
        order1.addProduct(product2);
        order1.addProduct(product3);

        Console.WriteLine($"Total Price: ${order1.calculateTotalPrice()}");
        order1.PackingLabel();
        order1.ShippingLabel();

        Console.WriteLine("\nOrder 2:");
        Address address2 = new Address("456 Example Ave", "Example City", "ID", "NotUSA");
        Customer customer2 = new Customer("Winston", address2);
        Order order2 = new Order(customer2);
        Product product4 = new Product("Burger", 8, 1, "D321");
        Product product5 = new Product("Fries", 3, 2, "E654");
        Product product6 = new Product("Shake", 4, 1, "F987");
        order2.addProduct(product4);
        order2.addProduct(product5);
        order2.addProduct(product6);

        Console.WriteLine($"Total Price: ${order2.calculateTotalPrice()}");
        order2.PackingLabel();
        order2.ShippingLabel();

    }
}