using Core.Model;
using Core.RepoInterface;

namespace Infrastructure.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {

        //private readonly DbContext _context;

        //public EmployeeRepository(DbContext context)
        //{
        //    this._context = context;
        //}

        // we will have dbset to talk to db 
        // just using mock data
        public async Task<List<Employee>> GetAllEmployees()
        {
            var employees = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Abby", Gender ="Female", Phone= "1234567890", Email= "123@gamil.com", Address= "1000 bronson avenue, SF, CA"},
                new Employee() { Id = 2, Name = "Bobby", Gender = "Male" , Phone= "1234567890", Email= "123@gamil.com", Address= "1000 bronson avenue, SF, CA"},
                new Employee() { Id = 3, Name = "Chris", Gender ="Male", Phone= "1234567890", Email= "123@gamil.com", Address= "1000 bronson avenue, SF, CA"},
                new Employee() { Id = 4, Name = "Daisy", Gender ="Female", Phone= "1234567890", Email= "123@gamil.com", Address= "1000 bronson avenue, SF, CA"},
                new Employee() { Id = 5, Name = "Emma", Gender ="Female", Phone= "1234567890", Email= "123@gamil.com", Address= "1000 bronson avenue, SF, CA"},



            };
            return await Task.FromResult(employees);



            //return await Task.FromResult(employees);

        }
    }
}
