namespace ShoppingCartApp;

public class Lineitem
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    public Product Product { get; set; }

    public Lineitem(int Id, int Quantity, Product Product)
    {
        this.Id = Id;
        this.Quantity = Quantity;
        this.Product = Product;
    }

    public void Display()
    {
        Console.WriteLine("Line Item ID : " + this.Id);
        Console.WriteLine("Line Item Quantity : " + this.Quantity);
        Console.WriteLine("Product ID : "  + Product.Id);
        Console.WriteLine("Product Name : " + Product.Name);
        Console.WriteLine("Product Price : " + Product.Price);
        Console.WriteLine("Product Discount Percentage : " + Product.DiscountPercentage);
    }

    public double GetLineItemPrice()
    {
        double totalLineItemPrice = 0;
        totalLineItemPrice = Product.Price * Quantity;
        return totalLineItemPrice;
    }
}
