namespace Task3App
{
    public class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department("IT");
            department.DepartmentId = 1;
            department.Employees.Add(new Employee("Alisa"));
            department.Employees.Add(new Employee("Jane"));

            Department clonedDepartment = (Department)department.Clone();

            // Update the properties of the cloned object
            clonedDepartment.DepartmentName = "HR";
            clonedDepartment.DepartmentId = 2;
            clonedDepartment.Employees[0].EmployeeName = "Mike";

            // Display the original object's properties
            Console.WriteLine("Original Object:");
            DisplayValues(department);
            // Display the cloned object's properties
            Console.WriteLine("Cloned Object:");
            DisplayValues(clonedDepartment);
        }

        public static void DisplayValues(Department depart)
        {
            Console.WriteLine("DepartmentName: " + depart.DepartmentName);
            Console.WriteLine("DepartmentId: " + depart.DepartmentId);
            foreach (Employee emp in depart.Employees)
            {
                Console.WriteLine("EmployeeName: " +emp.EmployeeName);
            }
        }
    }
}