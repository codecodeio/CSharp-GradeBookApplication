using System;
using GradeBook.GradeBooks;
using GradeBook.UserInterfaces;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#=======================#");
            Console.WriteLine("# Welcome to GradeBook! #");
            Console.WriteLine("#=======================#");
            Console.WriteLine();

            //RankedGradeBook book = new RankedGradeBook("Test Grade Book");
            //Student student1 = new Student("Matt", Enums.StudentType.Honors, Enums.EnrollmentType.Campus);
            //student1.AddGrade(100);
            //student1.DisplayStudent();
            //Student student2 = new Student("Blam", Enums.StudentType.DualEnrolled, Enums.EnrollmentType.International);
            //student2.AddGrade(75);
            //student2.DisplayStudent();
            //Student student3 = new Student("Alama", Enums.StudentType.Standard, Enums.EnrollmentType.National);
            //student3.AddGrade(50);
            //student3.DisplayStudent();
            //Student student4 = new Student("Ding", Enums.StudentType.DualEnrolled, Enums.EnrollmentType.State);
            //student4.AddGrade(25);
            //student4.DisplayStudent();
            //Student student5 = new Student("Dong", Enums.StudentType.Honors, Enums.EnrollmentType.Campus);
            //student5.AddGrade(0);
            //student5.DisplayStudent();

            //Console.WriteLine();

            //book.AddStudent(student1);
            //book.AddStudent(student2);
            //book.AddStudent(student3);
            //book.AddStudent(student4);
            //book.AddStudent(student5);
            //Console.WriteLine("Student List:");
            //book.ListStudents();
            //Console.WriteLine("Statistics:");
            //book.CalculateStatistics();

            StartingUserInterface.CommandLoop();

            Console.WriteLine();
            Console.WriteLine("Thank you for using GradeBook!");
            Console.WriteLine("Have a nice day!");
            //Console.Read();
        }
    }
}