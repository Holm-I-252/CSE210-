public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public void displayCustomerInfo()
    {
        Console.WriteLine($"Customer Name: {_name}");
        Console.WriteLine($"Address: {_address.getFullAddress()}");
    }
    
    public bool isInUSA()
    {
        return _address.isInUSA();
    }
}