using System;
using System.Collections.Generic;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _zipcode;

    public Address(string street, string city, string state, string zipcode)
    {
        _street = street;
        _city = city;
        _state = state;
        _zipcode = zipcode;
    }

    public string Street
    {
        get { return _street; }
        set { _street = value; }
    }

    public string City
    {
        get { return _city; }
        set { _city = value; }
    }

    public string State
    {
        get { return _state; }
        set { _state = value; }
    }

    public string ZipCode
    {
        get { return _zipcode; }
        set { _zipcode = value; }
    }

    public string GetFullAddress()
    {
        return $"{_street}, {_city}, {_state} {_zipcode}";
    }
}