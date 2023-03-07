namespace ECommerceApp.Models;
public class OrderHistory
{
    private int quantity;
    private double unitPrice;

    public int OrderId {get;set;}
    public string Title { get; set; }
    public double UnitPrice { get => unitPrice; set => unitPrice = value; }
    public int Quantity { get => quantity; set => quantity = value; }
    public DateTime OrderDate { get; set; }
    public DateTime DeliveryDate { get; set; }

    public double TotalPrice{
        get{return unitPrice*quantity;}
    }
}