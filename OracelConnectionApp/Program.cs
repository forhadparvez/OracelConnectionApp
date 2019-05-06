using System;
using System.Data.Entity;
using OracleConnectionApp.Models;

namespace OracleConnectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<OracleDbContext>());

            using (var ctx = new OracleDbContext())
            {
                var emp = new Employee
                {
                    Name = "Tom 2",
                    HireDate = DateTime.Now
                };

                ctx.Employees.Add(emp);
                ctx.SaveChanges();

                var dept = new Department
                {
                    Name = "Accounting",
                    ManagerId = emp.EmployeeId
                };

                ctx.Departments.Add(dept);
                ctx.SaveChanges();
            }

            Console.WriteLine(@"Successfully created Employee and Department tables.");
            Console.ReadLine();
        }
    }
}