using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTutorial
{

    class Program
    {
        public class Employee
        {
            public int Id { get; set; }
            public int age { get; set; }
            public string name { get; set; }
            public string gender { get; set; }

        }

        public class Department
        {
            public int id { get; set; }
            public string Departments { get; set; }
            public string Location { get; set; }
        }
        public class selectedProperty
        {
            public int EmployeeId { get; set; }
            public string EmployeeName { get; set; }
            public string Department { get; set; }
            public string Location { get; set; }


        }
        static void Main(string[] args)
        {
            //   There are two basic ways to write a LINQ query to IEnumerable collection or IQueryable data sources.
            //   Query Syntax or Query Expression Syntax
            //   Method Syntax or Method Extension Syntax or Fluent


            List<Employee> li = new List<Employee>();
            li.Add(new Employee
            { Id = 1, age = 19, name = "Ritesh", gender = "M" });
            li.Add(new Employee
            { Id = 2, age = 20, name = "sujit", gender = "M" });
            li.Add(new Employee
            { Id = 3, age = 23, name = "Kabir", gender = "F" });
            li.Add(new Employee
            { Id = 4, age = 3, name = "mantu", gender = "F" });
            li.Add(new Employee
            { Id = 5, age = 24, name = "Kamlesh", gender = "M" });
            li.Add(new Employee
            { Id = 6, age = 28, name = "Manoj", gender = "M" });


            List<Department> Deli = new List<Department>();
            Deli.Add(new Department
            { id = 2, Departments = "IT", Location = "Bangalore" });
            Deli.Add(new Department
            { id = 8, Departments = "IT", Location = "Bangalore" });
            Deli.Add(new Department
            { id = 3, Departments = "HR", Location = "Bangalore" });
            Deli.Add(new Department
            { id = 7, Departments = "HR", Location = "Bangalore" });
            Deli.Add(new Department
            { id = 6, Departments = "Account", Location = "Bangalore" });

            // INNER JOIN

            var result = from emp in li
                         join de in Deli on emp.Id equals de.id
                         select new
                         {
                             EmployeeId = emp.Id,
                             EmployeeName = emp.name,
                             Department = de.Departments,
                             Location = de.Location
                         };


            var result4 = from emp in li
                         join de in Deli on emp.Id equals de.id
                         select new
                         {
                             EmployeeId = emp.Id,
                             EmployeeName = emp.name,
                             Department = de.Departments,
                             Location = de.Location
                         };
            var result1 = li.Join(Deli, x => x.Id, y => y.id, (L, D) => new selectedProperty
            {
                EmployeeId = L.Id,
                EmployeeName = L.name,
                Department = D.Departments,
                Location = D.Location
            });
            var result3 = li.Join(Deli, x => x.Id, y => y.id, (L, D) => new selectedProperty
            {
                EmployeeId = L.Id,
                EmployeeName = L.name,
                Department = D.Departments,
                Location = D.Location
            });
            Console.WriteLine("ID\t\tName\t\tDepartmentName\t\tLocation");
           
            foreach (var obj in result)
            {

                Console.WriteLine(obj.EmployeeId + "\t\t" + obj.EmployeeName +
                "\t\t" + obj.Department + "\t\t\t" + obj.Location);

            }
            Console.WriteLine("\n");
            // using Method Syntax or Method Extension Syntax or Fluent
            Console.WriteLine("ID\t\tName\t\tDepartmentName\t\tLocation");

            foreach (var obj in result1)
            {

                Console.WriteLine(obj.EmployeeId + "\t\t" + obj.EmployeeName +
                "\t\t" + obj.Department + "\t\t\t" + obj.Location);

            }

            Console.WriteLine("\n");
            // using Method Syntax or Method Extension Syntax or Fluent
            Console.WriteLine("ID\t\tName\t\tDepartmentName\t\tLocation");

            foreach (var obj in result3)
            {

                Console.WriteLine(obj.EmployeeId + "\t\t" + obj.EmployeeName +
                "\t\t" + obj.Department + "\t\t\t" + obj.Location);

            }

            Console.WriteLine("\n");
            Console.WriteLine("ID\t\tName\t\tDepartmentName\t\tLocation");

            foreach (var obj in result3)
            {

                Console.WriteLine(obj.EmployeeId + "\t\t" + obj.EmployeeName +
                "\t\t" + obj.Department + "\t\t\t" + obj.Location);

            }

            Console.ReadLine();
        }
    }
}
