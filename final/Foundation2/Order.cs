using System;

public class Order
{
    // ATTRIBUTES
    private string _customer;

    private List<Product> _products = new List<Product>();

    // CONSTRUCTORS
    public Order(string customer, List<Product> list)
    {
        _customer = customer;
        _products = list;
    }

    // METHODS
    public double CalculateShipping(string country)
    {
        double shipping = 5.00;

        if (country != "USA")
        {
            shipping = 35.00;
        }

        return shipping;
    }

    public void CalculateTotal(string country)
    {
        double shipping = CalculateShipping(country);
        double subtotal = 0;

        foreach (Product product in _products)
        {
            double price = product.GetProdPrice();
            int quantity = product.GetProdQuantity();

            subtotal = subtotal + product.CalculatePrice(price, quantity);
        }

        double finalTotal = Math.Round((subtotal + shipping), 2);

        Console.WriteLine($"Shipping: ${shipping.ToString("0.00")}");
        Console.WriteLine($"Order Total: ${finalTotal}");
    }

    public void DisplayPackLabel()
    {
        Console.WriteLine("Packing Label:");
        foreach (Product product in _products)
        {
            Console.WriteLine($"ID{product.GetProdID()} - {product.GetProdName()}: Qty{product.GetProdQuantity()}");
        }
        Console.WriteLine("");
    }

    public void DisplayShipLabel(string name, string address)
    {
        Console.WriteLine("Shipping Label:");
        Console.WriteLine($"{name} \n{address}");
        Console.WriteLine("");
    }
}