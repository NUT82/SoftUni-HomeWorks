using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEmployees = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>(numberOfEmployees);

            for (int i = 0; i < numberOfEmployees; i++)
            {
                string[] line = Console.ReadLine().Split();
                Employee employee = new Employee(line[0], double.Parse(line[1]), line[2]);
                employees.Add(employee);
            }

            List<string> allDepartments = new List<string>(employees.Count);
            foreach (Employee employee in employees)
            {
                if (!allDepartments.Contains(employee.Department))
                {
                    allDepartments.Add(employee.Department);
                }
            }

            double avgHighSalary = 0;
            string departmentWithHighSalary = "";
            foreach (string department in allDepartments)
            {
                double currDepartmentAvgSalary = Employee.GetAvgSalary(employees, department);
                if (currDepartmentAvgSalary > avgHighSalary)
                {
                    avgHighSalary = currDepartmentAvgSalary;
                    departmentWithHighSalary = department;
                }
            }

            Console.WriteLine($"Highest Average Salary: {departmentWithHighSalary}");
            foreach (Employee employee in employees.Where(x => x.Department == departmentWithHighSalary).OrderByDescending(y => y.Salary))
            {
                Console.WriteLine(employee.ToString());
            }
        }

    }

    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        public Employee(string name, double salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }

        internal static double GetAvgSalary(List<Employee> employees, string department)
        {
            double avgSalary = 0;
            int count = 0;
            foreach (Employee employee in employees.Where(x => x.Department == department))
            {
                avgSalary += employee.Salary;
                count++;
            }
            return avgSalary / count;
        }

        public override string ToString()
        {
            return $"{Name} {Salary:F2}";
        }
    }
}
