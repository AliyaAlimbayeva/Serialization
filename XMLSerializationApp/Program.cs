using DepEmpLibrary;
using System.Xml.Serialization;

namespace XMLSerializationApp
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

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Department));
            using (FileStream fs = new FileStream("dep.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, dep);
            }
            Console.WriteLine("Объект сериализован");

            // десериализуем объект
            using (FileStream fs = new FileStream("dep.xml", FileMode.OpenOrCreate))
            {
                Department? department = xmlSerializer.Deserialize(fs) as Department;
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