using Core.Model;
using Core.RepoInterface;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly DbContext _context;

        public EmployeeRepository(DbContext context)
        {
            this._context = context;
        }

        // we will have dbset to talk to db 
        // just using mock data
        public async Task<List<Employee>> GetAllEmployees()
        {
            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee() { Id = 1, Name = "Abby", Gender ="Female"},
            //    new Employee() { Id = 2, Name = "Bobby", Gender = "Male" },
            //    new Employee() { Id = 3, Name = "Chris", Gender ="Male"},
            //    new Employee() { Id = 4, Name = "Daisy", Gender ="Female"},
            //    new Employee() { Id = 5, Name = "Emma", Gender ="Female"},



            //};

            return await this._context.Set<Employee>().ToListAsync();



            //return await Task.FromResult(employees);

        }
    }
}
