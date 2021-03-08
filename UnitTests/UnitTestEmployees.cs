using NUnit.Framework;
using Business;

namespace UnitTests
{
    public class Tests
    {
        private readonly EmployeesLogic _employeesLogic;
        public Tests()
        {
            _employeesLogic = new EmployeesLogic();
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetEmployees()
        {
            var result = _employeesLogic.Get();
            Assert.Greater(result[0].id, 0);
        }

        [Test]
        public void GetEmployee()
        {
            string employeeId = "1";
            var result = _employeesLogic.Get(employeeId);
            Assert.AreEqual(result[0].id, 1);
        }
    }
}