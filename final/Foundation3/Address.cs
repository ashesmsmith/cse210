using System;

public class Address
{
    // ATTRIBUTES
    private string _street;
    private string _city;
    private string _state;
    private int _zip;
    private string _country;

    // CONSTRUCTORS
    public Address(string street, string city, string state, int zip, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _zip = zip;
        _country = country;
    }

    // METHODS
    public string GetAddressString()
    {
        string address = $"{_street} \n{_city}, {_state}, {_zip} \n{_country}";

        return address;
    }
}