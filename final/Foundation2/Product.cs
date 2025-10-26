public class Product
{
    private string _name;
    private decimal _price;
    private int _quantity;
    private string _id;
    public Product(string name, decimal price, int quantity, string id)
    {
        _name = name;
        _price = price;
        _quantity = quantity;
        _id = id;
    }
    public string getName()
    {
        return _name;
    }
    public string getId()
    {
        return _id;
    }

    public void setQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public int totalPrice()
    {
        return (int)(_price * _quantity);
    }
}