public class Customer
{
    private string _customername;
    private Address _address;
    public Customer(string customername, Address address)
    {
        _customername = customername;
        _address = address;
    }
    public bool fromUSA()
    {
        return _address.IsInUSA();
    }
    public string GetCustomerName()
    {
        return $"{_customername}";
    }
    public string GetCustomerAddress()
    {
        return $"{_address.GetAddress()}";
    }
}