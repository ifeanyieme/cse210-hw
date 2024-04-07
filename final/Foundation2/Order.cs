// Order.cs
using System;
using System.Collections.Generic;
using System.Linq;

public class Order
{
    public List<Product> Products { get; set; } = new List<Product>();
    public Customer Customer { get; set; }

    public Order(Customer customer)
    {
        Customer = customer;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public decimal CalculateTotal()
    {
        decimal total = Products.Sum(product => product.CalculateTotalCost());
        return total + (Customer.IsUsaCustomer() ? 5 : 35);
    }

    public string GeneratePackingLabel()
    {
        return $"Packing Label for {Customer.Name}'s Order:\n" +
               string.Join("\n", Products.Select(product => $"{product.Name} - Product ID: {product.ProductId}"));
    }

    public string GenerateShippingLabel()
    {
        return $"Shipping Label for {Customer.Name}:\n{Customer.Address.GetFullAddress()}";
    }
}