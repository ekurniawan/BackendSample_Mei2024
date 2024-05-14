using BackendServices.Domain;

namespace BackendServices.DAL;

public interface IEmployeeDAL : ICrud<Employee>
{
    IEnumerable<Employee> GetEmployeesByName(string name);
}
