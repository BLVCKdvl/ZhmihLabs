using System;

public class Student
{
	public string? FirstName;
	public string? LastName;
	public int Age;
	public override string ToString()
    {
		return $"{FirstName,10} {LastName} ({Age} y.o.)";
    }
}
