using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Employee
{
    class EmployeeList : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            return employees.GetEnumerator();
        }
        List<Employee> employees = new List<Employee>();
        public EmployeeList(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                Employee employee = new Employee();
                Random rand = new Random();
                employee.Id = 999 + i;
                employee.phone = 99 + i;
                employees.Add(employee);
            }
        }

        public List<Employee> SortByN(int x)
        {
            var employeesSort = employees.OrderBy(t => t);
            switch (x)
            {
                case 0:
                    employeesSort = employees.OrderBy(t => t.Id);
                    break;
                case 1:
                    employeesSort = employees.OrderBy(t => t.surname);
                    break;
                case 2:
                    employeesSort = employees.OrderBy(t => t.name);
                    break;
                case 3:
                    employeesSort = employees.OrderBy(t => t.patronymic);
                    break;
                case 4:
                    employeesSort = employees.OrderBy(t => t.department);
                    break;
                case 5:
                    employeesSort = employees.OrderBy(t => t.phone);
                    break;
                default:
                    throw new ArgumentException();
            }
            employees = new List<Employee>() { };
            foreach (Employee employee in employeesSort)
                employees.Add(employee);
            return employees;
        }

        public Employee OutputById(int id)
        {
            IEnumerable<Employee> employeesSorted = employees.Where(t => t.Id == id);

            Employee employee = employeesSorted.FirstOrDefault();

            return employee;
        }

        public void CountDepartment()
        {
            var info = employees.GroupBy(t => t.department)
                            .Select(g => new { Name = g.Key, Count = g.Count() });

            foreach (var infoobj in info)
            {
                Console.WriteLine($"{infoobj.Name} : {infoobj.Count}");
            }
        }
    }
}
