using Microsoft.Win32;
/* 
 * Exercise 1 in Lexicon's dotNET course
 * An Employee registry
 * @Author: Victor Sago, mailto:VictorSago01@gmail.com
 */

using System;

namespace EmployeesEx1
{
    
    class Program
    {
        static Registry registry = new Registry();

        static void Main(string[] args)
        {
            Populate(registry);

            string output = registry.GetEmployees();
            Console.WriteLine(output);

            Console.WriteLine("Goodbye!");
        }

        private static void Populate(Registry reg)
        {
            reg.AddEmployee("Arthur Dent", 1);
            reg.AddEmployee("Ford Prefect", 15000);
            var presidentOfTheGalaxy = new Employee("Zaphod Beeblebrox", 1000000);
            var presidentsGirlfriend = new Employee("Tricia 'Trillian' McMillan", 100000);
            reg.AddEmployee(presidentOfTheGalaxy);
            reg.AddEmployee(presidentsGirlfriend);
            reg.AddEmployee("Marvin the Paranoid Android", 0);

        }
    }
}
