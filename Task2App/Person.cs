using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Task2App
{
    [Serializable]
    public class Person : ISerializable
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Person(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Age", Age);
        }

        protected Person(SerializationInfo info, StreamingContext context)
        {
            Age = info.GetInt32("Age");
            Name = info.GetString("Name");
        }
    }
}
