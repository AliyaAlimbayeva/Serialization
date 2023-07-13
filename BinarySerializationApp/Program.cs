using DepEmpLibrary;
using System.Runtime.Serialization.Formatters.Binary;

namespace BinarySerializationApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Linda");
            Employee emp2 = new Employee("Marta");

            Department dep = new Department("IT");
            dep.Employees.Add(emp1);
            dep.Employees.Add(emp2);


            // создаем объект BinaryFormatter
            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("Depart.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, dep);

                Console.WriteLine("Объект сериализован");
            }

            // десериализация из файла people.dat
            using (FileStream fs = new FileStream("Depart.dat", FileMode.OpenOrCreate))
            {
                Department newDep = (Department)formatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Название департамента: {newDep.DepartmentName}");
                foreach (Employee emp in newDep.Employees)
                {
                    Console.WriteLine($"Имя сотрудника: {emp.EmployeeName}");
                }
            }

            Console.ReadLine();
        }
    }
}