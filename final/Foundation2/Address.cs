using System;
using System.Collections.Generic;

class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddres, string city, string state, string country)
    {
        _streetAddress = streetAddres;
        _city = city;
        _state = state;
        _country = country;
    }

    public string StreetAddress { get => _streetAddress; set => _streetAddress = value; }
    public string City { get => _city; set=> _city = value; }
    public string State { get => _state; set => _state = value; }
    public string Country { get => _country; set => _country = value; }

    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_state}\n{_country}";
    }
}