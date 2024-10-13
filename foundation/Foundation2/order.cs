public class Order
{
    private List<Product> _product = new List<Product>();
    private Customer _customer;
    private const decimal _shippingCostUSA = 5m ;
    private const decimal _shippingCostInt = 35m;
    public Order(Customer customer)
    {
        _customer = customer;
    }
    public decimal GetTotalCost()
    {
        decimal total = 0;

        foreach(Product product in _product)
        {
            total += product.GetTotal();
        }
        if (_customer.fromUSA())
        {
            total += _shippingCostUSA;
        }
        else {
            total += _shippingCostInt;
        }
        return total;
    }
    public string GetPackingLabel()
    {
        string label = "";
        foreach(Product product in _product)
        {
            label += $"{product.GetName()}({product.GetProductID()})\n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        return $"{_customer.GetCustomerName()}\n{_customer.GetCustomerAddress()}";
    }
    public void addProduct(Product product)
    {
        _product.Add(product);
    }
}