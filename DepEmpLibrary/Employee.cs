namespace DepEmpLibrary
{
    [Serializable]
    public class Employee
    {
        public string EmployeeName { get; set; }
        public Employee(string name) { EmployeeName = name; }
        public Employee() { EmployeeName = null; }
    }
}
