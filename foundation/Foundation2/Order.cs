using System;
using System.Text;
public class Order
{
    // Attributes for Order class
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    // Constructor for Order class
    public Order(Customer customer)
    {
        _customer = customer;
    }

    //Method to add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    //Method to get total cost and return total cost plus shipping cost
    public decimal GetTotalCost()
    {
        decimal totalCost = _products.Sum(p => p.GetTotalCost());
        decimal shippingCost = _customer.IsInUSA() ? 5 : 35;
        return totalCost + shippingCost;
    }

    // Method to get the packing label
    public string GetPackingLabel()
    {
        var label = new StringBuilder("Packing Label:\n");
        foreach (var product in _products)
        {
            label.AppendLine($"{product.GetName()} - {product.GetProductId}");
        }
        return label.ToString();
    }

    // Method to get shipping label
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}