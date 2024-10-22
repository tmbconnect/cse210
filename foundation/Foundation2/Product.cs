using System;
public class Product
{
    // Attributes for Product class
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;
    
    // Product constructor
    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    //Method to ge product name
    public string GetName()
    {
        return _name;
    }

    //Method to get productId
    public string GetProductId()
    {
        return _productId;
    }

    // Method to get total cost of product (price*quantity)
    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }

}