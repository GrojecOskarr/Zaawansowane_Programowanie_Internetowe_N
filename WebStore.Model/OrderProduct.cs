namespace WebStore.Model;

public class OrderProduct
{
    public int Quanitity { get; set; }


    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public Order? Order { get; set; }
    public Product? Product { get; set; }
}