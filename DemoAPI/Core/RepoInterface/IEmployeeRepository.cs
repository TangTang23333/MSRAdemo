using Core.Model;

namespace Core.RepoInterface
{
    public interface IEmployeeRepository
    {
        public Task<List<Employee>> GetAllEmployees();
    }
}
