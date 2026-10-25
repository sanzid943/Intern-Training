namespace EfCoreExample;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Department { get; set; }

    public Student(int id, string name, int age, string department)
    {
        Id = id;
        Name = name;
        Age = age;
        Department = department;
    }
}
