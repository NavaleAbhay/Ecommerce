using ECommerceApp.Models;
using ECommerceApp.Repositories.Interfaces;
using MySql.Data.MySqlClient;
namespace ECommerceApp.Repositories;
public class CustomerRepository : ICustomerRepository
{

    public static string conString="server=localhost;port=3306;user=root;password=password;database=Ecommerce";
    public bool InsertCustomer(Customer customer){
        bool status=false;
        MySqlConnection connection=new MySqlConnection(conString);
        try{
            MySqlCommand command=new MySqlCommand();
            command.CommandText=$"INSERT INTO customers(first_name,last_name,email,contact_number,password)VALUES('{customer.FirstName}','{customer.LastName}','{customer.Email}','{customer.ContactNumber}','{customer.Password}')";
            command.Connection=connection;
            connection.Open();
            command.ExecuteNonQuery();
            status=true;
        }
        catch(Exception e){
            throw e;
        }
        finally{
            connection.Close();
        }
      return status;      
    }
}