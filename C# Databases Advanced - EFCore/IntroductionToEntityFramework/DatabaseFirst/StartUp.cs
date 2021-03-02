using Microsoft.EntityFrameworkCore;
using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace SoftUni
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var db = new SoftUniContext();
            
            string output = ""; //chose from methods above
            Console.WriteLine(output); 
        }

        public static string RemoveTown(SoftUniContext context)
        {
            const string townToDelete = "Seattle";

            var addresses = context.Addresses.Where(a => a.Town.Name == townToDelete).ToArray();
            foreach (var item in addresses)
            {
                item.TownId = null;
            }

            var town = context.Towns.FirstOrDefault(t => t.Name == townToDelete);
            if (town != null)
            {
                context.Towns.Remove(town);
            }

            context.SaveChanges();

            return $"{addresses.Count()} addresses in {townToDelete} were deleted";
        }

        public static string DeleteProjectById(SoftUniContext context)
        {
            const int projectToDelete = 2;
            var employeeProjects = context.EmployeesProjects.Where(ep => ep.ProjectId == projectToDelete).ToList();
            if (employeeProjects.Count > 0)
            {
                context.RemoveRange(employeeProjects);
            }
            
            var project = context.Projects.Find(projectToDelete);
            if (project != null)
            {
                context.Remove(project);
            }
            
            context.SaveChanges();

            return string.Join(Environment.NewLine, context.Projects.Select(p => p.Name).Take(10));
        }

        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            var employees = context.Employees
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.JobTitle,
                    e.Salary,
                })
                .Where(e => e.FirstName.StartsWith("Sa"))
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToArray();

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in employees)
            {
                stringBuilder.AppendLine($"{item.FirstName} {item.LastName} - {item.JobTitle} - (${item.Salary:f2})");
            }

            return stringBuilder.ToString();
        }

        
        public static string IncreaseSalaries(SoftUniContext context)
        {
            string[] filter = new string[] { "Engineering", "Tool Design", "Marketing", "Information Services" };
            var employees = context.Employees
                .Where(e => filter.Contains(e.Department.Name))
                .ToArray();

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in employees.OrderBy(e => e.FirstName).ThenBy(e => e.LastName))
            {
                item.Salary *= 1.12M;
                stringBuilder.AppendLine($"{item.FirstName} {item.LastName} (${item.Salary:f2})");
            }

            context.SaveChanges();
            return stringBuilder.ToString();
        }

        public static string GetLatestProjects(SoftUniContext context)
        {
            var projects = context.Projects
                .Select(p => new
                {
                    p.Name,
                    p.Description,
                    p.StartDate
                })
                .OrderByDescending(p => p.StartDate)
                .Take(10)
                .OrderBy(p => p.Name)
                .ToArray();

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var project in projects)
            {
                stringBuilder.AppendLine(project.Name);
                stringBuilder.AppendLine(project.Description);
                stringBuilder.AppendLine(project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture));
            }

            return stringBuilder.ToString();
        }

        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            var departments = context.Departments
                .Where(d => d.Employees.Count() > 5)
                .OrderBy(d => d.Employees.Count())
                .ThenBy(d => d.Name)
                .Select(d => new { d.Name, ManagerFirstName = d.Manager.FirstName, ManagerLastName = d.Manager.LastName, Employees = d.Employees.Select(e => new { e.FirstName, e.LastName, e.JobTitle }) })
                .ToArray();

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var department in departments)
            {
                stringBuilder.AppendLine($"{department.Name} - {department.ManagerFirstName} {department.ManagerLastName}");
                foreach (var employee in department.Employees.OrderBy(e => e.FirstName).ThenBy(e => e.LastName))
                {
                    stringBuilder.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");
                }
            }

            return stringBuilder.ToString();
        }

        public static string GetEmployee147(SoftUniContext context)
        {
            var employee147 = context.Employees
                .Where(e => e.EmployeeId == 147)
                .Select(e => new { e.FirstName, e.LastName, e.JobTitle, Projects = e.EmployeesProjects.Select(p => new { p.Project.Name })})
                .FirstOrDefault();

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{employee147.FirstName} {employee147.LastName} - {employee147.JobTitle}");
            foreach (var item in employee147.Projects.OrderBy(pn => pn.Name))
            {
                stringBuilder.AppendLine($"{item.Name}");
            }

            return stringBuilder.ToString();
        }

        public static string GetAddressesByTown(SoftUniContext context)
        {
            var addresses = context.Addresses
                .Select(a => new { a.AddressText, Count = a.Employees.Count(), TownName = a.Town.Name })
                .OrderByDescending(a => a.Count)
                .ThenBy(a => a.TownName)
                .ThenBy(a => a.AddressText)
                .Take(10)
                .ToArray();

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in addresses)
            {
                stringBuilder.AppendLine($"{item.AddressText}, {item.TownName} - {item.Count} employees");
            }

            return stringBuilder.ToString();
        }

        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            var employeesWithProject = context.Employees
                //.Include(x => x.EmployeesProjects)
                //.ThenInclude(x => x.Project)
                .Where(e => e.EmployeesProjects.Any(p => p.Project.StartDate.Year >= 2001 && p.Project.StartDate.Year <= 2003))
                .Select(e => new { e.FirstName, e.LastName, ManagerFirstName = e.Manager.FirstName, ManagerLastName = e.Manager.LastName, Projects = e.EmployeesProjects.Select(p => new { ProjectName = p.Project.Name, ProjectStartDate = p.Project.StartDate, ProjectEndDate = p.Project.EndDate })})
                .Take(10)
                .ToArray();

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var employee in employeesWithProject)
            {
                stringBuilder.AppendLine($"{employee.FirstName } {employee.LastName} - Manager: {employee.ManagerFirstName} {employee.ManagerLastName}");
                string endDate = "not finished";
                
                foreach (var project in employee.Projects)
                {
                    if (project.ProjectEndDate != null)
                    {
                        endDate = $"{project.ProjectEndDate.Value.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)}";
                    }
                    stringBuilder.AppendLine($"--{project.ProjectName} - {project.ProjectStartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)} - {endDate}");
                }
            }

            return stringBuilder.ToString();
        }

        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            context.Employees
                .Where(e => e.LastName == "Nakov")
                .FirstOrDefault()
                .Address = new Address() { AddressText = "Vitoshka 15", TownId = 4 };
            context.SaveChanges();

            var info = context.Employees
                .Select(e => new { AT = e.Address.AddressText, e.AddressId })
                .OrderByDescending(e => e.AddressId)
                .Take(10)
                .ToArray();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in info)
            {
                stringBuilder.AppendLine($"{item.AT}");
            }

            return stringBuilder.ToString();

        }

        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            var info = context.Employees
                .Select(e => new { e.FirstName, e.MiddleName, e.LastName, e.JobTitle, e.Salary, e.EmployeeId })
                .OrderBy(e => e.EmployeeId)
                .ToArray();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in info)
            {
                stringBuilder.AppendLine($"{item.FirstName} {item.LastName} {item.MiddleName} {item.JobTitle} {item.Salary:F2}");
            }

            return stringBuilder.ToString();
        }

        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            var info = context.Employees
                .Select(e => new { e.FirstName, e.Salary })
                .Where(e => e.Salary > 50000)
                .OrderBy(e => e.FirstName)
                .ToArray();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in info)
            {
                stringBuilder.AppendLine($"{item.FirstName} - {item.Salary:F2}");
            }

            return stringBuilder.ToString();
        }

        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            var info = context.Employees
                .Where(e => e.Department.Name == "Research and Development")
                .Select(e => new { e.FirstName, e.LastName, DN = e.Department.Name, e.Salary })
                .OrderBy(e => e.Salary)
                .ThenByDescending(e => e.FirstName)
                .ToArray();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in info)
            {
                stringBuilder.AppendLine($"{item.FirstName} {item.LastName} from {item.DN} - ${item.Salary:F2}");
            }

            return stringBuilder.ToString();
        }
    }
}
