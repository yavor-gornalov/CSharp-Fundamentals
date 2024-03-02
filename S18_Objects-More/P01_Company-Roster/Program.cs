
internal class Program
{
    static void Main()
    {
        List<Department> departments = new List<Department>();

        int N = int.Parse(Console.ReadLine());

        DepartmentsConstructor(departments, N);

        Department highestPaidDepartment = GetHighestPaidDepartment(departments);

        if (highestPaidDepartment != null)
        {
            Console.WriteLine(highestPaidDepartment.ToString());
        }
    }



    private static void DepartmentsConstructor(List<Department> departments, int N)
    {
        for (int i = 0; i < N; i++)
        {
            string[] tokens = Console.ReadLine()
                .Split()
                .ToArray();

            string employeeName = tokens[0];
            double employeeSalary = double.Parse(tokens[1]);
            string departmentName = tokens[2];

            Department currentDepartment = GetDepartmentByName(departments, departmentName);

            if (currentDepartment == null)
            {
                currentDepartment = new Department(departmentName);
                departments.Add(currentDepartment);
            }

            Employee newEmploeye = new Employee(employeeName, employeeSalary, currentDepartment.Name);
            currentDepartment.AddEmployee(newEmploeye);
        }
    }

    //HELPERS
    private static Department? GetHighestPaidDepartment(List<Department> departments)
        => departments.OrderByDescending(d => d.GetAverageSalary()).FirstOrDefault();

    public static Department? GetDepartmentByName(List<Department> departments, string departmentName)
        => departments.FirstOrDefault(d => d.Name == departmentName);
}

public class Employee
{
    public Employee(string name, double salary, string department)
    {
        this.Name = name;
        this.Salary = salary;
        this.Department = department;
    }

    public string Name { get; set; }
    public double Salary { get; set; }
    public string Department { get; set; }

    public override string ToString()
        => $"{Name} {Salary:F2}";
}

public class Department
{
    private List<Employee> employees;

    public Department(string name)
    {
        this.Name = name;
        this.employees = new List<Employee>();
    }

    public string Name { get; set; }

    public double GetAverageSalary()
        => employees.Count > 0 ? (double)employees.Sum(e => e.Salary) / employees.Count : 0;


    public void AddEmployee(Employee employee)
        => employees.Add(employee);

    public override string ToString()
    {
        List<string> result = new List<string>()
        {
            $"Highest Average Salary: {Name}"
        };
        foreach (Employee e in employees.OrderByDescending(e => e.Salary))
        {
            result.Add($"{e.Name} {e.Salary:F2}");
        }
        return string.Join("\n", result);
    }
}