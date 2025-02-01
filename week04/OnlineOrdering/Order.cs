using System;
using System.Runtime.CompilerServices;

class Order
{
    private List<Product> products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double TotalPrice()
    {
        double subtotal = 0;

        foreach (var product in products)
        {
            subtotal += product.GetTotalPrice();
        }

        double shipping = _customer.IsAmerican() ? 5 : 35;

        return subtotal + shipping;
    }

    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in products)
        {
            label += $"{product.ProductID} - {product.GetName()}\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"Name: {_customer.GetName()} Shipping to: {_customer.GetAddress()}";
    }
}
