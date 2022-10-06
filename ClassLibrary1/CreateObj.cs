using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class CreateObj
    {
        public static void Create()
        {
            List<Employee> employees = new List<Employee>() {
                new Employee("James", 25, new DateTime(2022, 05, 01)),
                new Employee("Jane", 21, new DateTime(2012, 05, 03)),
                new Employee("Jane", 21, new DateTime(2014, 05, 03)),
                new Employee("Frank", 21, new DateTime(2018, 05, 05)),
                new Employee("Naomie", 21, new DateTime(2011, 05, 05)),
               // new Employee("Emma", 21, new DateTime(2015, 05, 05))

            };



            //employees.Sort();
            employees.Sort(new EmployeeComparer(CompareBy.HireDate));
            Console.WriteLine(employees[0].Name);
            Console.WriteLine(employees[1].Equals(employees[2]));
            Console.WriteLine(employees[2]==employees[2]);

            var emp2015 = employees.Any(x => x.HireDate.Year == 2015);
            Console.WriteLine("Is there any employee that was hired in 2015? "+emp2015);

            var empAbove18 = employees.All(x => x.Age > 18);
            Console.WriteLine("Are all employees above 18? " + empAbove18);

            var empLongest = employees.OrderBy(x => x.HireDate).ToList();
            Console.WriteLine("Employee who has been in the company longest: "+ empLongest[0].Name);

            //If there is no employee above 50, returns null
            var orderedEmp = employees.OrderBy(x => x.Name).OrderBy(y => y.HireDate).SingleOrDefault();
            Console.WriteLine("First employee ordered by name and then hireDate: "+ orderedEmp.Name);

            var uniqueEmp = employees.Select(x=>x.Name).Distinct();

            var emp50 = employees.Where(x => x.Age > 50).FirstOrDefault();

            //var empJane=
           

            Console.ReadLine();

        }
    }
}
