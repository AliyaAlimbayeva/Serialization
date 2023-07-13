using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Task3App
{
    [Serializable]
    public class Department : ICloneable
    {
      
        public string DepartmentName { get; set; }
        public int DepartmentId { get; set; }
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
        public object Clone()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                if (this.GetType().IsSerializable)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, this);
                    stream.Position = 0;
                    return formatter.Deserialize(stream);
                }
                return null;
            }
        }
    }
}
