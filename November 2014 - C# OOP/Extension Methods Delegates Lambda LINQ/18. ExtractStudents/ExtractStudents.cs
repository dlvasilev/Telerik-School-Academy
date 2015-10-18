using System;
using System.Linq;

namespace _18.ExtractStudents
{
    class ExtractStudents
    {
        static void Main()
        {
            var students = new[]
            {
                new {Name = "Mila", Group = "Physics"},
                new {Name = "George", Group = "Math"},
                new {Name = "Kiril", Group = "Literature"},
                new {Name = "Forest", Group = "Art"}
            };

            var selectedByGroup = students.OrderBy(st => st.Group);
            foreach (var item in selectedByGroup)
            {
                Console.WriteLine("{0} -> {1}", item.Name, item.Group);
            }
        }
    }
}
