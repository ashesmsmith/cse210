using System;

public class Product
{
    // ATTRIBUTES
    private string _prodName;
    private int _prodID;
    private double _prodPrice;
    private int _quantity;

    // CONSTRUCTORS
    public Product(string name, int ID, double price, int quantity)
    {
        _prodName = name;
        _prodID = ID;
        _prodPrice = price;
        _quantity = quantity;
    }

    // METHODS
    public string GetProdName()
    {
        return _prodName;
    }

    public int GetProdID()
    {
        return _prodID;
    }

    public double GetProdPrice()
    {
        return _prodPrice;
    }

    public int GetProdQuantity()
    {
        return _quantity;
    }

    public double CalculatePrice(double price, int quantity)
    {
        double prodPrice = price * quantity;

        return prodPrice;
    }
}