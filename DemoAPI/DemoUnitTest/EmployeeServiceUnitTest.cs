using Core.Model;
using Core.RepoInterface;
using Infrastructure.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoUnitTest
{
    [TestClass]
    public class EmployeeServiceUnitTest
    {
        // arrange: set up 
        private Mock<IEmployeeRepository> _mockEmployeeRepo;
        private static List<Employee> _employees;
        private EmployeeService _sut;

        [TestInitialize]

        public void OneTimeSetup()
        {

            this._mockEmployeeRepo = new Mock<IEmployeeRepository>();
            // setup service return 
            this._mockEmployeeRepo.Setup(emp => emp.GetAllEmployees()).ReturnsAsync(_employees);
            // setup emplpyee service to use mockEmployeeRepo
            this._sut = new EmployeeService(this._mockEmployeeRepo.Object);

        }

        [ClassInitialize]
        // setup in memory data 
        public static void SetUp(TestContext context)
        {
            _employees = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Abby", Gender ="Female"},
                new Employee() { Id = 2, Name = "Bobby", Gender = "Male" },
                new Employee() { Id = 3, Name = "Chris", Gender ="Male"},
                new Employee() { Id = 4, Name = "Daisy", Gender ="Female"},
                new Employee() { Id = 5, Name = "Emma", Gender ="Female"},



            };



        }


        [TestMethod]
        public async Task TestGetAllEmployees()
        {

            // act => invoke the actual method 
            var employees = await _sut.GetAllEmployees();

            // assert 

            Assert.IsNotNull(employees);
            Assert.IsInstanceOfType(employees, typeof(List<Employee>));
            Assert.AreEqual(5, employees.Count);
            Assert.AreEqual(_employees, employees);



        }
    }
}