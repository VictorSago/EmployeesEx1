namespace EmployeesEx1 
{
    public class Employee
    {
        // Jag har beslutat att inte använda Properties i den här övningen
        private string name;
        private int salary;

        public Employee(string name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public string GetName()
        {
            return name;
        }

        public int GetSalary()
        {
            return salary;
        }

        public override string ToString()
        {
            return $"Name: {name}, Salary: {salary}";
        }

    }
}