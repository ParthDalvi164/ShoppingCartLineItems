namespace ShoppingCartApp;

public class Order
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public List<Lineitem> Lineitems { get; set; }

    public Order(int Id, DateTime Date, List<Lineitem> lineitems)
    {
        this.Id = Id;
        this.Date = Date;
        this.Lineitems = lineitems;
    }

    public void Display()
    {
        Console.WriteLine("Order ID : " + this.Id);
        Console.WriteLine("Order Date : " + this.Date);
        Console.WriteLine("Line Items : ");
        foreach (var lineitem in Lineitems)
        {
            lineitem.Display();
        }
    }

    public void CalculateOrderPrice()
    {
        double totalOrderPrice = 0;
        foreach (Lineitem lineitem in Lineitems)
        {
            totalOrderPrice = totalOrderPrice + lineitem.GetLineItemPrice();
        }
        Console.WriteLine("Total order price : " + totalOrderPrice);
    }
}
