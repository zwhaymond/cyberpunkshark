using System;

public class Product
{
    public string Name { get; private set; }
    public int ProductId { get; private set; }
    public double PricePerUnit { get; private set; }
    public int Quantity { get; private set; }

    public Product(string name, int productId, double pricePerUnit, int quantity)
    {
        Name = name;
        ProductId = productId;
        PricePerUnit = pricePerUnit;
        Quantity = quantity;
    }

    public double TotalCost()
    {
        return PricePerUnit * Quantity;
    }
}
