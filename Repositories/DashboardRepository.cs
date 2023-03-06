using System.Data;
using ECommerceApp.Models;
using ECommerceApp.Repositories.Interfaces;
using MySql.Data.MySqlClient;
namespace ECommerceApp.Repositories;
public class DashboardRepository : IDashboardRepository
{

    public static string conString = "server=localhost;port=3306;user=root;password=password;database=Ecommerce";

    public List<object> GetProductsData(List<Product> products)
    {
        var productList = new List<Object>();
        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString = conString;
        try
        {
            connection.Open();
            foreach (Product product in products)
            {

                MySqlCommand command = new MySqlCommand("getrevenue", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("@productid", product.ProductId));
                command.Parameters.Add(new MySqlParameter("@totalrevenue", MySqlDbType.Double));
                command.Parameters["@totalrevenue"].Direction = ParameterDirection.Output;
                command.ExecuteNonQuery();

                var revenue = command.Parameters["@totalrevenue"].Value;

                var productJson = new
                {
                    Id = product.ProductId,
                    title = product.Title,
                    TotalRevenue = revenue
                };
                productList.Add(productJson);
            }
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            connection.Close();
        }
        return productList;
    }
}