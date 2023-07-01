using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Laptop", 1, 1000, 1);
        Product product2 = new Product("Mouse", 2, 20, 2);
        Product product3 = new Product("Keyboard", 3, 50, 1);
        Product product4 = new Product("Monitor", 4, 200, 1);

        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Market St", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("Alice", address1);
        Customer customer2 = new Customer("Bob", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        DisplayOrderDetails(order1);
        System.Console.WriteLine("\n------------------\n");
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        System.Console.WriteLine(order.GetPackingLabel());
        System.Console.WriteLine(order.GetShippingLabel());
        System.Console.WriteLine($"Total Price: ${order.CalculateTotalCost():0.00}");
    }
}