using System.ComponentModel.DataAnnotations;

namespace ShoppingCartApp;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Order> Orders { get; set; }

    public Customer(int Id, string Name, List<Order> Orders)
    {
        this.Id = Id;
        this.Name = Name;
        this.Orders = Orders;
    }

    public void Display()
    {
        Console.WriteLine("Customer ID : " + this.Id);
        Console.WriteLine("Customer Name : " + this.Name);
        Console.WriteLine("Order History : ");
        foreach (var order in Orders)
        {
            order.Display();
            order.CalculateOrderPrice();
        }
    }
}
