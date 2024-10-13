public class Customer
{
    private string _customername;
    private Address _address;
    public Customer(string customername, Address address)
    {

    }
    public bool fromUSA()
    {
        return _address.IsInUSA();
    }
    public string GetCustomerName()
    {
        return "";
    }
    public string GetCustomerAddress()
    {
        return "";
    }
}