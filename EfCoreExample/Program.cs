using EfCoreExample;
using ConsoleTables;

using var db = new AppDbContext();

db.Database.EnsureCreated();

while (true)
{
    Console.Clear();

    Console.WriteLine("\nSTUDENT MANAGEMENT\n");

    Console.WriteLine("1. Create");
    Console.WriteLine("2. Read");
    Console.WriteLine("3. Update");
    Console.WriteLine("4. Delete");

    Console.Write("\nEnter your choice: ");
    string choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.Clear();

        Console.Write("Enter ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter age:");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter department: ");
        string department = Console.ReadLine();

        Student student = new Student(id, name, age, department);

        db.Students.Add(student);
        db.SaveChanges();

        Console.WriteLine("\nStudent created successfully!");
    }


    else if (choice == "2")
    {
        Console.Clear();

        ConsoleTable table = new ConsoleTable("Id", "Name", "Age", "Department");

        foreach (var student in db.Students)
        {
            table.AddRow(student.Id, student.Name, student.Age, student.Department);
        }

        table.Write();
    }


    else if (choice == "3")
    {
        Console.Clear();

        ConsoleTable table = new ConsoleTable("Id", "Name", "Age", "Department");

        foreach (var st in db.Students)
        {
            table.AddRow(st.Id, st.Name, st.Age, st.Department);
        }

        table.Write();

        Console.Write("\nEnter the ID of the student to update: ");
        int id = int.Parse(Console.ReadLine());

        var student = db.Students.Find(id);

        if (student != null)
        {
            Console.Write("Enter new name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter new age: ");
            student.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter new department: ");
            student.Department = Console.ReadLine();

            db.SaveChanges();

        }

        else
        {
            Console.WriteLine("\nStudent not found!");
        }
    }


    else if (choice == "4")
    {
        Console.Clear();

        ConsoleTable table = new ConsoleTable("Id", "Name", "Age", "Department");

        foreach (var st in db.Students)
        {
            table.AddRow(st.Id, st.Name, st.Age, st.Department);
        }

        table.Write();

        Console.Write("\nEnter the ID of the student to delete: ");
        int id = int.Parse(Console.ReadLine());

        var student = db.Students.Find(id);

        if (student != null)
        {
            db.Students.Remove(student);
            db.SaveChanges();

            Console.WriteLine("\nStudent deleted successfully!\n");
        }

        else
        {
            Console.WriteLine("\nStudent not found!");
        }
    }


    else if (choice == "5")
    {
        break;
    }


    else
    {
        Console.WriteLine("\nInvalid choice!");
    }


    Console.WriteLine("\nPress Enter to continue..");
    Console.ReadLine();

}