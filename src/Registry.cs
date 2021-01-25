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

        public string GetEmployees()
        {
            string result = "";
            foreach (var employee in registry)
            {
                result += employee.ToString() + "\n";
            }
            return result;
        }

    }
}