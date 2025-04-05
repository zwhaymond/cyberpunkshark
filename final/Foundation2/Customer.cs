using System;

public class Customer
{
    public string Name { get; private set; }
    public Address CustomerAddress { get; private set; }

    public Customer(string name, Address customerAddress)
    {
        Name = name;
        CustomerAddress = customerAddress;
    }

    public bool IsInUSA()
    {
        return CustomerAddress.IsInUSA();
    }
}
