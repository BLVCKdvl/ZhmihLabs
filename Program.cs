using System;

namespace Program
{
    static class Program
    {
        static void Main()
        {
            Student[] students = new[]
            {
                new Student { FirstName = "Dmitry", LastName = "Makanov", Age = 20 },
                new Student { FirstName = "Dmitry", LastName = "Korzhitsky", Age = 18 }
            };

            Student.PrintInfo(students[0]);
            Student.PrintInfo(students[1]);
        }
    }
}