using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("12 Main St", "Sacramento", "CA", "USA");
        Address address2 = new Address("34 King St", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("Jake Sully", address1);
        Customer customer2 = new Customer("Ellen Ripley", address2);

        Product product1 = new Product("Hardback Book", "B001", 11.99, 2);
        Product product2 = new Product("Paperback Book", "B005", 4.99, 4);
        Product product3 = new Product("E-book", "B004", 6.99, 1);
        Product product4 = new Product("Audiobook", "B003", 13.99, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);


        Console.WriteLine("--------Order 1---------");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");
        Console.WriteLine();


        Console.WriteLine("--------Order 2---------");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");

    }



  
}