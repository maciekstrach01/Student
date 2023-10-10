using System;
using System.Collections.Generic;
using myStudent;
using myStudentManager;


class Program
{
    public static List<myStudent.Student> listStudents = new List<myStudent.Student>();

    static void Main(string[] args)
    {
       
    StudentManager.InitializeStudents();
    try
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. List of all students");
            Console.WriteLine("2. Search for a student by index number");
            Console.WriteLine("3. Add a student to the university");
            Console.WriteLine("4. Dismiss a student from university");
            Console.WriteLine("5. Exit");

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    myStudentManager.StudentManager.DisplayStudentsList();
                    break;
                case "2":
                    myStudentManager.StudentManager.SearchStudent();
                    break;
                case "3":
                    myStudentManager.StudentManager.AddStudent();
                    break;
                case "4":
                    myStudentManager.StudentManager.WriteOutStudent();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Incorrect choice. Try again.");
                    break;
            }
        }

    }
            catch (Exception ex)
    {
        Console.WriteLine("An error occurred: " + ex.Message);
    }
    }


}