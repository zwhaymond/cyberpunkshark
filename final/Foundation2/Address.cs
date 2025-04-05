using System;

public class Address
{
    public string StreetAddress { get; private set; }
    public string City { get; private set; }
    public string StateProvince { get; private set; }
    public string Country { get; private set; }

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        StreetAddress = streetAddress;
        City = city;
        StateProvince = stateProvince;
        Country = country;
    }

    public bool IsInUSA()
    {
        return Country.ToUpper() == "USA";
    }

    public string FullAddress()
    {
        return $"{StreetAddress}\n{City}, {StateProvince}\n{Country}";
    }
}
