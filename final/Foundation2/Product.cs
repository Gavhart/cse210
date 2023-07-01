using System;
using System.Collections.Generic;

class Product
{
    private string _name;
    private int _productID;
    private double _price;
    private int _quantity;

    public Product(string name, int productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public string Name;
    public int ProductID;
    public double Price;
    public int Quantity;

    public double GetTotalPrice()
    {
        return _price * _quantity;
    }
}