public class Address
{
    private string _streetAddress;
    private string _theCity;
    private string _state;
    private string _country;
    public Address(string streetAddress, string theCity, string state, string country)
    {
        _streetAddress = streetAddress;
        _theCity = theCity;
        _state = state;
        _country = country;
    }
    public bool IsInUSA()
    {
        return _country == "USA";
    }
    public string GetAddress()
    {
        return $"{_streetAddress}, {_theCity}, {_state}, {_country}";
    }
}
   
