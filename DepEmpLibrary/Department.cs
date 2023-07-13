using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace DepEmpLibrary
{

    [Serializable]
    public class Department
    {
        [XmlAttribute("DepartmentName")]
        [JsonPropertyName("Department")]
        public string DepartmentName { get; set; }
        [XmlIgnore]
        [JsonIgnore]
        public int DepartmentId { get; set; }
        [XmlElement("EmployeeList")]
        [JsonPropertyName("EmployeeList")]
        public List<Employee> Employees { get; set; }

        public Department(string name)
        {
            DepartmentName = name;
            Employees = new List<Employee>();
        }


        public Department()
        {
            DepartmentName = null;
            Employees = new List<Employee>();
        }
    }
}
