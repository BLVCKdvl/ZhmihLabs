
List<Student> students = new List<Student>(){
 new Student { FirstName = "Dmitry", LastName = "Makanov", Age = 20 },
 new Student { FirstName = "Dmitry", LastName = "Korzhitsky", Age = 18 }
};

foreach (var student in students)
{
    Console.WriteLine(student);
}
