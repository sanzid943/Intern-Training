//var list = new List<int> { 1, 2, 3 };

//var filteredList = list;

//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine();

//foreach (var item in filteredList)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine();

//var printList = list.ToArray();

//Array.ForEach(printList, x => Console.WriteLine(x));

//var linkedList = new LinkedList<int>(list);


// 1. Where()




List<Student> students = new List<Student>
{
    new Student { Name = "Rahim", Department = "CSE", Marks = 85 },
    new Student { Name = "Karim", Department = "EEE", Marks = 70 },
    new Student { Name = "Nila", Department = "CSE", Marks = 95 },
    new Student { Name = "Sumi", Department = "EEE", Marks = 80 },
    new Student { Name = "Rafi", Department = "CSE", Marks = 60 }
};

//var result = students.Where(x => x.p);

//foreach (var student in result)
//{
//    Console.WriteLine($"{student.Name} - {student.Marks}");
//}


// 2. select 
//var result = students.Select(s => s.Name);

//foreach (var name in result)
//{
//    Console.WriteLine(name);
//}

// 3. order by

//var result = students.OrderByDescending(s => s.Marks);

//foreach (var student in result)
//{
//    Console.WriteLine($"{student.Name} - {student.Marks}");
//}

// 4. group by

//var result = students.GroupBy(s => s.Department);

//foreach (var group in result)
//{
//    Console.WriteLine($"Department: {group.Key}");

//    foreach (var student in group)
//    {
//        Console.WriteLine($"  {student.Name} - {student.Marks}");
//    }
//}

var x = new Student();

x.Marks = 65;
x.Name = "Rahim";

x.Address = new Address
{
    Street = "123 Main St",
    City = "Dhaka"
};



class Student
{
    public string Name { get; set; }
    public string Department { get; set; }
    public int Marks { get; set; }

    public Address Address { get; set; }

    public void Print()
    {
        Console.WriteLine($"Name: {Name}, Department: {Department}, Marks: {Marks}");
    }
}

class Address 
{
    public string Street { get; set; }
    public string City { get; set; }
}






