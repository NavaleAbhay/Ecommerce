using ECommerceApp.Models;
using ECommerceApp.Repositories.Interfaces;
using ECommerceApp.Services.Interfaces;

namespace ECommerceApp.Services;
public class OrderDetailsService:IOrderDetailsService{
    private readonly IOrderDetailsRepository _repo;
    public OrderDetailsService(IOrderDetailsRepository repo){
        this._repo=repo;
    }

    public List<Product> GetOrderdProducts(int orderId)=> _repo.GetOrderdProducts(orderId);

    

    public bool InsertOrderdetails(int orderId, int productId, int quantity) => _repo.InsertOrderdetails(orderId,productId,quantity);

    public List<OrderHistory> OrderHistory(int customerId) => _repo.OrderHistory(customerId);
}
