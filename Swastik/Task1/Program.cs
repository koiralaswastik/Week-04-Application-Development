//Task1
using System;

class Program
{
    static void Main(string[] args)
    {
        // creating first student object
        Student s1 = new Student();
        s1.name = "Ram";
        s1.age = 20;
        s1.address = "Kathmandu";

        // creating second student object
        Student s2 = new Student();
        s2.name = "Sita";
        s2.age = 19;
        s2.address = "Pokhara";

        // printing first student details
        Console.WriteLine("Student 1 Details:");
        Console.WriteLine("Name: " + s1.name);
        Console.WriteLine("Age: " + s1.age);
        Console.WriteLine("Address: " + s1.address);

        Console.WriteLine();

        // printing second student details
        Console.WriteLine("Student 2 Details:");
        Console.WriteLine("Name: " + s2.name);
        Console.WriteLine("Age: " + s2.age);
        Console.WriteLine("Address: " + s2.address);

        Console.WriteLine();

        // printing static field (same for all)
        Console.WriteLine("School Name: " + Student.schoolName);
    }
}
