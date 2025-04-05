using System;
using System.Collections.Generic;

public class Order
{
    public List<Product> Products { get; private set; }
    public Customer Customer { get; private set; }
    private const double DomesticShippingCost = 5.0;
    private const double InternationalShippingCost = 35.0;

    public Order(Customer customer)
    {
        Products = new List<Product>();
        Customer = customer;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public double TotalPrice()
    {
        double totalProductCost = 0;
        foreach (var product in Products)
        {
            totalProductCost += product.TotalCost();
        }

        double shippingCost = Customer.IsInUSA() ? DomesticShippingCost : InternationalShippingCost;
        return totalProductCost + shippingCost;
    }

    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in Products)
        {
            label += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"Shipping Label:\n{Customer.Name}\n{Customer.CustomerAddress.FullAddress()}";
    }
}
