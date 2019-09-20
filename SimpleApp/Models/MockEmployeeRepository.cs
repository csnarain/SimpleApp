using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> _employeeList;

        public MockEmployeeRepository(/*List<Employee> employeeList*/)
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){ Id = 1, Name = "Laks", Email = "jdskjd@skdjs.com", Department = "HR"},
                new Employee(){Id = 2, Name = "Vaibhav", Email = "sssj@sjks.com", Department = "Finance"},
                new Employee() {Id = 3, Name = "Uthra", Email = "sjs@sjs.com", Department = "Accounting"}

            };
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault((e) => e.Id == Id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }
    }
}
