using ECommerceApp.Models;

namespace ECommerceApp.Repositories.Interfaces;
public interface IDashboardRepository
{
   List<RevenueModel> GetProductsData();

}