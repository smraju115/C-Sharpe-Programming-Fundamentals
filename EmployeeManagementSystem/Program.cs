using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Employee
{
    private static int _idCounter = 1;

    public int Id { get; }
    public string Name { get; }
    public string Department { get; }
    public decimal Salary { get; }
    public DateTime DateOfBirth { get; }

    public Employee(string name, string department, decimal salary, string dob)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be empty.");

        if (salary < 0)
            throw new ArgumentException("Salary cannot be negative.");

        if (!DateTime.TryParseExact(dob, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDob))
            throw new ArgumentException("Invalid date format. Use dd-MM-yyyy.");

        Id = _idCounter++;
        Name = name;
        Department = department;
        Salary = salary;
        DateOfBirth = parsedDob;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Dept: {Department}, Salary: {Salary}, DOB: {DateOfBirth:dd-MM-yyyy}";
    }
}

class Program
{
    static List<Employee> employees = new List<Employee>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Employee Management ---");
            Console.WriteLine("1. Add New Employee");
            Console.WriteLine("2. View All Employees");
            Console.WriteLine("3. Search by Name");
            Console.WriteLine("4. Show Employees with Salary > 1500");
            Console.WriteLine("5. Department-wise Employee Count");
            Console.WriteLine("6. Total Salary Paid");
            Console.WriteLine("7. Department-wise Salary Paid");
            Console.WriteLine("8. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1": AddEmployee(); break;
                case "2": ViewAllEmployees(); break;
                case "3": SearchByName(); break;
                case "4": ShowHighSalaryEmployees(); break;
                case "5": DepartmentWiseCount(); break;
                case "6": TotalSalaryPaid(); break;
                case "7": DepartmentWiseSalary(); break;
                case "8": return;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }

    static void AddEmployee()
    {
        try
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Department: ");
            string department = Console.ReadLine();

            Console.Write("Enter Salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Date of Birth (dd-MM-yyyy): ");
            string dob = Console.ReadLine();

            Employee emp = new Employee(name, department, salary, dob);
            employees.Add(emp);
            Console.WriteLine("Employee added successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void ViewAllEmployees()
    {
        if (employees.Count == 0)
        {
            Console.WriteLine("No employees found.");
            return;
        }

        foreach (var emp in employees)
            Console.WriteLine(emp);
    }

    static void SearchByName()
    {
        Console.Write("Enter name to search: ");
        string name = Console.ReadLine().ToLower();

        var results = employees.Where(e => e.Name.ToLower().Contains(name)).ToList();

        if (results.Count == 0)
            Console.WriteLine("No matching employees found.");
        else
            results.ForEach(e => Console.WriteLine(e));
    }

    static void ShowHighSalaryEmployees()
    {
        var highEarners = employees.Where(e => e.Salary > 1500).ToList();

        if (highEarners.Count == 0)
            Console.WriteLine("No employees with salary > 1500.");
        else
            highEarners.ForEach(e => Console.WriteLine(e));
    }

    static void DepartmentWiseCount()
    {
        var deptCounts = employees
            .GroupBy(e => e.Department)
            .Select(g => new { Department = g.Key, Count = g.Count() });

        foreach (var item in deptCounts)
            Console.WriteLine($"{item.Department}: {item.Count} employee(s)");
    }

    static void TotalSalaryPaid()
    {
        decimal total = employees.Sum(e => e.Salary);
        Console.WriteLine($"Total Salary Paid: {total}");
    }

    static void DepartmentWiseSalary()
    {
        var deptSalaries = employees
            .GroupBy(e => e.Department)
            .Select(g => new { Department = g.Key, TotalSalary = g.Sum(e => e.Salary) });

        foreach (var item in deptSalaries)
            Console.WriteLine($"{item.Department}: {item.TotalSalary} total salary");
    }
}