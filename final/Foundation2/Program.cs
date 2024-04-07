using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of Product, Address, Customer, and Order
        Product product1 = new Product("Laptop", 101, 1200, 2);
        Product product2 = new Product("Phone", 102, 800, 1);

        Address address = new Address("123 Main St", "Cityville", "CA", "USA");

        Customer customer = new Customer("Eme Ifeanyi", address);

        Order order = new Order(customer);
        order.AddProduct(product1);
        order.AddProduct(product2);

        // Display order information
        Console.WriteLine($"Total Price: ${order.CalculateTotal():F2}\n");
        Console.WriteLine(order.GeneratePackingLabel());
        Console.WriteLine(order.GenerateShippingLabel());
    }
}