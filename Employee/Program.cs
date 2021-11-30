using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Employee
{
    class Program
    {
        static void Main()
        {
            EmployeeList employees = new EmployeeList(15);
            Console.WriteLine($"{"№",-10}{"Фамилия",-15}{"Имя",-15}{"Отчество",-16}{"Отдел",-16}{"Номер",-20}");
            foreach (Employee x in employees)
                x.GetInfo();

            Console.WriteLine();

            Console.WriteLine("Введите столбец:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine();

            List<Employee> employeesSorted = employees.SortByN(number);
            foreach (Employee x in employees)
                x.GetInfo();

            Console.WriteLine();

          m1: Console.WriteLine("Введите Id интересуещего вас работника:");
            int id = int.Parse(Console.ReadLine());
            if (id > 999 && id < 1015)
            {
                Console.WriteLine();

                Employee employee = employees.OutputById(id);
                Console.WriteLine("Информация о работнике:\n ");
                employee.GetInfo();
                Console.WriteLine("\nСчётчик компаний:\n");

                employees.CountDepartment();
            }
            else
            {
                Console.WriteLine("Введенного айди не существует! Введите существуещее айди: ");
                goto m1;
            }
            Console.WriteLine("\n Ещё раз? 1 - Да ");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a==1)
            {
                Main();
            }
        }
    }
}
