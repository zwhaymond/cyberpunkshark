using System;

public class Program
{
    public static void Main()
    {
        // Create address for customer 1
        var address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        var customer1 = new Customer("John Doe", address1);
        var order1 = new Order(customer1);
        
        // Add products to the order
        order1.AddProduct(new Product("Widget A", 101, 10.0, 2));
        order1.AddProduct(new Product("Widget B", 102, 5.0, 3));

        // Create address for customer 2 (International)
        var address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        var customer2 = new Customer("Jane Smith", address2);
        var order2 = new Order(customer2);

        // Add products to the order
        order2.AddProduct(new Product("Gadget X", 201, 15.0, 1));
        order2.AddProduct(new Product("Gadget Y", 202, 8.0, 2));

        // Display details for order 1 (USA customer)
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Price for Order 1: ${order1.TotalPrice():0.00}\n");

        // Display details for order 2 (International customer)
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Price for Order 2: ${order2.TotalPrice():0.00}");
    }
}
