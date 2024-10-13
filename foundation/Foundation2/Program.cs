using System;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Durian", "Balayan City", "Calamity", "Namek");
        Address address2 = new Address("Project 1", "Balesteros City", "Calamity", "Namek");
        Address address3 = new Address("Bronx", "New City", "Massachusett", "USA");

        Customer customer1 = new Customer("Piccolo",address1);
        Customer customer2 = new Customer("Dende", address2);
        Customer customer3 = new Customer("Son Goku",address3);

        Product product1 = new Product("1 star dragon ball", 1, 1000000000000.01m, 1);
        Product product2 = new Product("2 star dragon ball", 2, 1000000000000.01m, 1);
        Product product3 = new Product("3 star dragon ball", 3, 1000000000000.01m, 1);
        Product product4 = new Product("4 star dragon ball", 4, 1000000000000.01m, 1);
        Product product5 = new Product("5 star dragon ball", 5, 1000000000000.01m, 1);

        Order order1 = new Order(customer1);
        order1.addProduct(product1);
        Order order2 = new Order(customer2);
        order2.addProduct(product2);
        order2.addProduct(product3);
        Order order3 = new Order(customer3);
        order3.addProduct(product4);
        order3.addProduct(product5);

        Console.WriteLine("Order1");
        Console.WriteLine("Packing Label: ");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Prices: $" + order1.GetTotalCost());
        Console.WriteLine();

         Console.WriteLine("Order2");
        Console.WriteLine("Packing Label: ");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Prices: $" + order2.GetTotalCost());
        Console.WriteLine();

         Console.WriteLine("Order3");
        Console.WriteLine("Packing Label: ");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine("Total Prices: $" + order3.GetTotalCost());
        Console.WriteLine();
    }
}