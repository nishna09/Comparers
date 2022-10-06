using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Employee : IEquatable<Employee> //: IComparable 
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime HireDate { get; set; }

        public Employee(string name, int age, DateTime hireDate)
        {
            Name = name;
            Age = age;
            HireDate = hireDate;
        }

        //The following overrides the operator == and =! such that when we are comparing 2 employees (e.g: emp1==emp2), the Equals method will be called
        public static bool operator == (Employee x, Employee y) =>x.Equals (y);
        public static bool operator != (Employee x, Employee y) =>x.Equals (y);

        public bool Equals(Employee other)
        {
            return Age == other.Age && HireDate == other.HireDate && Name == other.Name;
        }

        /* public int CompareTo(object obj)
         {
            return  Age.CompareTo((obj as Employee).Age);
         }*/
    }

    public class EmployeeComparer : IComparer<Employee>
    {

        public CompareBy _compareBy;

        public EmployeeComparer(CompareBy compareBy)
        {
            _compareBy = compareBy;
        }

        public int Compare(Employee x, Employee y)
        {
            if (_compareBy == CompareBy.Age)
                return x.Age.CompareTo(y.Age);

            return x.HireDate.CompareTo(y.HireDate);
        }
    }
}

    
