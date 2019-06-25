using Newtonsoft.Json;
using StudentLibrary;
using System.Collections.Generic;
using System.IO;

namespace JsonEx
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student { Id = 1, Name = "And" };

            var s2 = new Student { Id = 2, Name = "And 2" };

            var list = new List<Student>();

            list.Add(s1);

            list.Add(s2);

            var s1Ser = JsonConvert.SerializeObject(list);
            File.WriteAllText("students.json", s1Ser);

            var serData = File.ReadAllText("students.json");
            var allStudents = JsonConvert.DeserializeObject<List<Student>>(serData);
        }
    }
}
