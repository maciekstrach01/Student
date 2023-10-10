using System;
using System.Collections.Generic;
using myStudent;

namespace myStudentManager
{

public class StudentManager
{
    private static List<Student> listStudents = new List<Student>();

    public static void InitializeStudents()
    {
        Student student1 = new Student("Kowalski", 134678);
        listStudents.Add(student1);
        Student student2 = new Student("Nowak", 135588);
        listStudents.Add(student2);
        Student student3 = new Student("Krawczyk", 134611);
        listStudents.Add(student3);
        Student student4 = new Student("Morawski", 133223);
        listStudents.Add(student4);
        Student student5 = new Student("Jurski", 133999);
        listStudents.Add(student5);
    }

    public static void DisplayStudentsList()
    {
        Console.WriteLine("List of all students:");

        foreach (var student in listStudents)
        {
            Console.WriteLine($"Last name: {student.Surname}, Identifier: {student.Identifier}");
        }
    }

    public static void SearchStudent()
    {
        try
        {
            Console.Write("Enter the student's index number to search: ");
            int identifier = Convert.ToInt32(Console.ReadLine());

            var student = listStudents.Find(s => s.Identifier == identifier);

            if (student != null)
            {
                Console.WriteLine($"Student found: Last name: {student.Surname}, Identifier: {student.Identifier}");
            }
            else
            {
                Console.WriteLine("A student with the specified ID was not found.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    public static void AddStudent()
    {
        try
        {
            Console.Write("Enter the student's name: ");
            string surname = Console.ReadLine();

            Console.Write("Enter the student's ID: ");
            if (!int.TryParse(Console.ReadLine(), out int identifier))
            {
                throw new FormatException("Invalid input. Please enter a valid integer for the student's ID.");
            }

            Student student = new Student(surname, identifier);
            listStudents.Add(student);

            Console.WriteLine("Student added to university.");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }


    public static void WriteOutStudent()
    {
    try
    {
        Console.Write("Provide the student's index number for sign-out: ");
        if (!int.TryParse(Console.ReadLine(), out int identifier))
        {
            throw new FormatException("Invalid input. Please enter a valid integer for the student's ID.");
        }

        var student = listStudents.Find(s => s.Identifier == identifier);

        if (student != null)
        {
            Console.WriteLine($"Student removed: Last name: {student.Surname}, Identifier: {student.Identifier}");
            listStudents.Remove(student);
        }
        else
        {
            Console.WriteLine("A student with the specified ID was not found.");
        }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        }
}
}


