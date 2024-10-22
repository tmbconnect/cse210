using System;
public class Customer
{
    // Attributes for Customer class
    private string _name;
    private Address _address;

    // Customer constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method to get customer name
    public string GetName()
    {
        return _name;
    }

    // Method to Get Address
    public Address GetAddress()
    {
        return _address;
    }

    // Verify that country is in the usa
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }
}