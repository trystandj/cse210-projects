using System;

class Product
{
    private string _name;
    private string _productID;
    private int _price;
    private int _quantity;

    public Product(string name, string productID, int price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalPrice()
    {
        return _price * _quantity;
    }

        public string GetName()
    {
        return _name;
    }

    public string ProductID
    {
        get { return _productID; }
    }
}
