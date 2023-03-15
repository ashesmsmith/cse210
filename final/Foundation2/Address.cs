using System;

public class Address
{
    // ATTRIBUTES
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _zip;
    private string _country;

    // CONSTRUCTORS
    public Address(string street, string city, string state, string zip, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = state;
        _zip = zip;
        _country = country;

        GetAddressString();
    }
    
    // METHODS
    public string GetCountry()
    {
        return _country;
    }

    public string GetAddressString()
    {
        string address = ($"{_street} \n{_city}, {_stateProvince}, {_zip} \n{_country}");

        return address;
    }
}