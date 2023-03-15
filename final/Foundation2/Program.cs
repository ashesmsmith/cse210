using System;

class Program
{
    static void Main(string[] args)
    {
        // Setup Individual Products
        Product prod1 = new Product("T-Shirt Small", 101, 9.99, 1);
        Product prod2 = new Product("T-Shirt Large", 102, 9.99, 1);
        Product prod3 = new Product("Hoodie Small", 103, 19.99, 1);
        Product prod4 = new Product("Hoodie Large", 104, 19.99, 1);
        Product prod5 = new Product("Sticker Small", 105, 1.99, 3);
        Product prod6 = new Product("Sticker Large", 106, 2.99, 2);

        // Customer 1
        Console.WriteLine("");
        Customer customer1 = new Customer("First Customer", "123 This St.", "That City", "ID", "98765", "USA");

        List<Product> list1 = new List<Product>();
        list1.Add(prod1);
        list1.Add(prod3);
        list1.Add(prod5);

        Order order1 = new Order(customer1.GetName(), list1);
        order1.DisplayShipLabel(customer1.GetName(), customer1.GetAddress());
        order1.DisplayPackLabel();
        order1.CalculateTotal(customer1.GetCountry());

        // Customer 2
        Console.WriteLine("");
        Customer customer2 = new Customer("Second Customer", "456 That Rd.", "This City", "AB", "12345", "Canada");

        List<Product> list2 = new List<Product>();
        list2.Add(prod2);
        list2.Add(prod4);
        list2.Add(prod6);

        Order order2 = new Order(customer2.GetName(), list2);
        order1.DisplayShipLabel(customer2.GetName(), customer2.GetAddress());
        order1.DisplayPackLabel();
        order1.CalculateTotal(customer2.GetCountry());
    }
}