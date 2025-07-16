namespace ShoppingCartApp;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public double DiscountPercentage { get; set; }

    public Product(int Id, string Name, double Price, double DiscountPercentage)
    {
        this.Id = Id;
        this.Name = Name;
        this.Price = Price;
        this.DiscountPercentage = DiscountPercentage;
        ApplyDiscount();
    }

    public void ApplyDiscount()
    {
        this.Price = this.Price - (this.Price * DiscountPercentage / 100);
    }
}
