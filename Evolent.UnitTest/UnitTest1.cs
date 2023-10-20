using Evolent.DomainLayer.Models;
using ServiceLayer.CustomServices;

namespace Evolent.UnitTest
{
    public class Tests
    {
        private EmployeeService _employeeservice;
        
        [SetUp]
        public void Setup()
        {
            //_employeeservice = new EmployeeService();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}