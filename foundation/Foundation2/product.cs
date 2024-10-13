public class Product
{
    private string _name;
    private int _productID;
    private decimal _price;
    private int _quantity;
    public Product(string name, int productID, decimal price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;

    }
    public string GetName()
    {
        return _name;
    }
    public int GetProductID()
    {
        return _productID;
    }
    public decimal GetTotal()
    {
        return _price * _quantity;
    }
}   