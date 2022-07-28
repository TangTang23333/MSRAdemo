using Core.Model;

namespace Core.ServiceInterface
{
    public interface IEmployeeService
    {


        public Task<List<Employee>> GetAllEmployees();



    }
}
