using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("70 Ossie Dr", "Ripton", "CA", "Canada");
        Customer customer = new Customer("John Doe", address);

        Order order1 = new Order(customer);
        Product product1 = new Product("Gaming Mouse", "AB1987", 20, 2);
        Product product2 = new Product("Dog Toy", "BA1987", 100, 1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine($"Total Price: ${order1.TotalPrice()}.00");
        
        
        Console.WriteLine();


        Address address2 = new Address("156 East Waterbury", "Ogden", "UT", "US");
        Customer customer2 = new Customer("Jane Doe", address2);

        Order order2 = new Order(customer2);
        Product product3 = new Product("Speaker", "AB1987", 20, 2);
        Product product4 = new Product("Phone", "BA1987", 100, 1);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine($"Total Price: ${order2.TotalPrice()}.00");
        
        
        



    }
}