using System;

class Program
{
    static void Main(string[] args)
    {
        // -------------------------
        // ORDER 1 - USA CUSTOMER
        // -------------------------

        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA"
        );

        Customer customer1 = new Customer(
            "John Smith",
            address1
        );

        Product product1 = new Product(
            "Laptop",
            "LAP123",
            850.00,
            1
        );

        Product product2 = new Product(
            "Wireless Mouse",
            "MOU456",
            25.00,
            2
        );

        Product product3 = new Product(
            "Keyboard",
            "KEY789",
            45.00,
            1
        );

        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);


        // -------------------------
        // ORDER 2 - INTERNATIONAL CUSTOMER
        // -------------------------

        Address address2 = new Address(
            "45 Allen Avenue",
            "Lagos",
            "Lagos State",
            "Nigeria"
        );

        Customer customer2 = new Customer(
            "David Johnson",
            address2
        );

        Product product4 = new Product(
            "Headphones",
            "HDP111",
            75.00,
            1
        );

        Product product5 = new Product(
            "USB Cable",
            "USB222",
            10.00,
            3
        );

        Product product6 = new Product(
            "Webcam",
            "WEB333",
            60.00,
            1
        );

        Order order2 = new Order(customer2);

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);


        // -------------------------
        // DISPLAY ORDER 1
        // -------------------------

        Console.WriteLine("=================================");
        Console.WriteLine("ORDER 1");
        Console.WriteLine("=================================");

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");


        // -------------------------
        // DISPLAY ORDER 2
        // -------------------------

        Console.WriteLine("\n=================================");
        Console.WriteLine("ORDER 2");
        Console.WriteLine("=================================");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}

