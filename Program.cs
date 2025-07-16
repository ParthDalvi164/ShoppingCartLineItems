using System;

namespace ShoppingCartApp;

public class Program
{
    public static void Main(string[] args)
    {
        Product product1 = new Product(2384, "Patanjali Shampoo", 230, 10);
        Product product2 = new Product(6553, "Maggi", 20, 5);
        Product product3 = new Product(9273, "Nestle Coffee", 543, 20);
        Product product4 = new Product(3438, "Trimmer", 499, 15);

        List<Lineitem> lineitems1 = new List<Lineitem>()
        {
            new Lineitem(12, 2, product1),
            new Lineitem(13, 4, product2)
        };

        List<Lineitem> lineitems2 = new List<Lineitem>()
        {
            new Lineitem(14, 2, product3),
            new Lineitem(15, 1, product4)
        };

        List<Order> orders = new List<Order>()
        {
            new Order(001, new DateTime(2025, 11, 3), lineitems1),
            new Order(001, new DateTime(2025, 7, 25), lineitems2)
        };

        Customer customer = new Customer(134334, "Parth", orders);

        customer.Display();
    }

}