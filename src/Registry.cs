using System.Text;
using System.Collections.Generic;

namespace EmployeesEx1
{
    public class Registry
    {
        private List<Employee> registry;

        public Registry()
        {
            registry = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            registry.Add(employee);
        }

        public void AddEmployee(string name, int salary)
        {
            registry.Add(new Employee(name, salary));
        }

        public string GetEmployees()
        {
            StringBuilder result = new StringBuilder();
            foreach (var employee in registry)
            {
                result.AppendLine(employee.ToString());
            }
            return result.ToString();
        }

    }
}