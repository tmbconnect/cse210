using System;

class Program
{
    static void Main(string[] args)
    {
        // Create two customers with different addresses
        Address address1 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer1 = new Customer("Jane Smith", address1);

        Address address2 = new Address("123 Elm St", "New York", "NY", "USA");
        Customer customer2 = new Customer("Jhon Doe", address2);

        // Create products
        Product product1 = new Product("Laptop", "Lap123", 1200.99m, 1);
        Product product2 = new Product("Mouse", "MOU456", 25.99m, 2);
        Product product3 = new Product("Keyboard", "KEY789", 45.50m, 1); 
        Product product4 = new Product("Monitor", "MON101", 300.00m, 1);

        // Create two orders and add product to them
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        //Display packing labels, shipping labels, and total prices
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);

        static void DisplayOrderDetails(Order order)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.GetTotalCost():F2}\n");
        }
    }
}