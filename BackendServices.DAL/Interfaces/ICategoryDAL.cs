using BackendServices.Domain;

namespace BackendServices.DAL;

public interface ICategoryDAL : ICrud<Category>
{
    IEnumerable<Category> GetCategoriesByName(string name);
}
