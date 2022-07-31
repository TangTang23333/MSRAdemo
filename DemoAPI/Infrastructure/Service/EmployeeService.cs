using Core.Model;
using Core.RepoInterface;
using Core.ServiceInterface;

namespace Infrastructure.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepo;

        public EmployeeService(IEmployeeRepository employeeRepo)
        {
            this._employeeRepo = employeeRepo;

        }


        public async Task<List<Employee>> GetAllEmployees()
        {



            return await this._employeeRepo.GetAllEmployees();
        }
    }
}
