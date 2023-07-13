using DepEmpLibrary;
using System.Text.Json;
namespace JsonSerializationApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Linda");
            Employee emp2 = new Employee("Marta");

            Department dep = new Department("IT");
            dep.DepartmentId = 1;
            dep.Employees.Add(emp1);
            dep.Employees.Add(emp2);
            
            string json = JsonSerializer.Serialize(dep);
            using (FileStream fs = new FileStream("dep.json", FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize<Department>(fs, dep);
            }
            Console.WriteLine("Объект сериализован");

            // десериализуем объект
            using (FileStream fs = new FileStream("dep.json", FileMode.OpenOrCreate))
            {
                Department? department = JsonSerializer.Deserialize<Department>(fs);
                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Название департамента: {department.DepartmentName}");
                foreach (Employee emp in department.Employees)
                {
                    Console.WriteLine($"Имя сотрудника: {emp.EmployeeName}");
                }
            }
        }
    }
}