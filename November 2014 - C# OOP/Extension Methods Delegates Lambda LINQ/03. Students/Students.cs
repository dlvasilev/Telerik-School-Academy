using System;
using System.Collections;
using System.Linq;


namespace _03.Students
{
    class Students
    {
        static void Print(IEnumerable list)
        {
            foreach (var item in list) Console.WriteLine(item);

            Console.WriteLine();
        }

        static void Main()
        {
            var students = new[] {
            new { FirstName = "Arya", LastName = "Stark", Age = 16 },
            new { FirstName = "Jon", LastName = "Snow", Age = 19 },
            new { FirstName = "Oberyn",  LastName = "Martell", Age = 39 }
        };

            // Exercise 3
            Print(students.Where(student =>
                student.FirstName.CompareTo(student.LastName) < 0
            ));

            // Exercise 4
            Print(students.Where(student =>
                18 < student.Age && student.Age < 24
            ));

            // Exercise 5 Lambda
            Print(students.OrderByDescending(student =>
                student.FirstName
            ).ThenByDescending(student =>
                student.LastName
            ));

            // Exercise 5 - Linq
            Print(
                from student in students

                orderby student.FirstName descending,
                        student.LastName descending

                select student
            );
        }
    }
}
