using ECommerceApp.Models;
using ECommerceApp.Repositories.Interfaces;
using ECommerceApp.Services.Interfaces;

namespace ECommerceApp.Services;
public class CustomerService:ICustomerService{
    private readonly ICustomerRepository _repo;
    public CustomerService(ICustomerRepository repo){
        this._repo=repo;
    }
    public bool InsertCustomer(Customer customer)=>_repo.InsertCustomer(customer);
}