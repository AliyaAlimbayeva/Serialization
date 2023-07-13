using System.Runtime.Serialization.Formatters.Binary;

namespace Task2App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of MyClass
            Person person = new Person("Aiya", 40);

            // Serialize the object to a binary stream
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, person);

            // Deserialize the object from the binary stream
            stream.Position = 0;
            Person deserPerson = (Person)formatter.Deserialize(stream);

            // Display the deserialized object's properties
            Console.WriteLine("Deserialized Person:");
            Console.WriteLine("Name: " + deserPerson.Name);
            Console.WriteLine("Age: " + deserPerson.Age);
        }
    }
}