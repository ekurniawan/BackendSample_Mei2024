using System.Data.SqlClient;
using BackendServices.Domain;
using Microsoft.Extensions.Configuration;

namespace BackendServices.DAL;

public class CategoryDAL : ICategoryDAL
{
    private readonly IConfiguration _configuration;
    public CategoryDAL(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    private string GetConnectionString()
    {
        return _configuration.GetConnectionString("DefaultConnection");
    }

    public Category Add(Category entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Category> GetAll()
    {
        using (SqlConnection conn = new SqlConnection(GetConnectionString()))
        {
            conn.Open();
            string strSql = @"SELECT * FROM Categories";
            using (SqlCommand cmd = new SqlCommand(strSql, conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    List<Category> categories = new List<Category>();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Category category = new()
                            {
                                CategoryId = Convert.ToInt32(reader["CategoryId"]),
                                CategoryName = reader["CategoryName"].ToString()
                            };
                            categories.Add(category);
                        }
                    }
                    return categories;
                }
            }
        }
    }

    public Category GetById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Category> GetCategoriesByName(string name)
    {
        throw new NotImplementedException();
    }

    public Category Update(Category entity)
    {
        throw new NotImplementedException();
    }
}
