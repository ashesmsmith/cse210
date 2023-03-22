using System;

public class Customer
{
    // ATTRIBUTES
    private string _name;
    private Address _address;

    // CONSTRUCTORS
    public Customer(string name, string street, string city, string state, string zip, string country)
    {
        _name = name;
        _address = new Address(street, city, state, zip, country);
    }

    // METHODS
    public string GetName()
    {
        return _name;
    }   

    public string GetAddress()
    {
        return _address.GetAddressString();
    } 

    public string GetCountry()
    {
        return _address.GetCountry();
    }
}