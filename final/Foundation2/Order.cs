public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void addProduct(Product product)
    {
        _products.Add(product);
    }

    public int calculateTotalPrice()
    {
        int total = 0;
        foreach (Product product in _products)
        {
            total += product.totalPrice();
        }
        if (_customer.isInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }

    public void PackingLabel()
    {
        Console.WriteLine("Packing Label:");
        foreach (Product product in _products)
        {
            Console.WriteLine($"Product: {product.getName()} | ID: {product.getId()}");
        }
    }

    public void ShippingLabel()
    {
        Console.WriteLine("Shipping Label:");
        _customer.displayCustomerInfo();
    }
}