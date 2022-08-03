using System;

public class Student
{
	public string? FirstName;
	public string? LastName;
	public int Age;

	public static void PrintInfo(Student student)
    {
		Console.WriteLine($"{student.FirstName,10} {student.LastName} ({student.Age} y.o.)");
    }
}
