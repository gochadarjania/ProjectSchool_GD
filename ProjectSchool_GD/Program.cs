using ProjectSchool_GD.Domain;
using ProjectSchool_GD.Interfaces;
using ProjectSchool_GD.Services;
using System;
using System.Collections.Generic;

namespace ProjectSchool_GD
{
    class Program
    {
        static void Main(string[] args)
        {
            ISchool school = new SchoolService();
            Student student = new Student();
            Dictionary<int, Student> _students;

            string start = "y";

            while (start=="y")
            {
                Console.WriteLine("1 - Add New Student");
                Console.WriteLine("2 - Remove Student");
                Console.WriteLine("3 - Student Point");
                Console.WriteLine("4 - Edit Student Point");

                Console.Write("Enter Command: ");
                int command = Convert.ToInt32(Console.ReadLine());

                switch (command)
                {
                    case 1:
                        Console.WriteLine("Student Id");
                        student.IdNumber = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Student Full Name");
                        student.FullName = Console.ReadLine();

                        Console.WriteLine("Student Age");
                        student.Age = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(school.AddStudent(student.IdNumber, student));

                        _students = school.GetStudents();

                        PrintStudents(_students);
                        Console.WriteLine("-----------");
                        Console.WriteLine("For a repeat operation, enter: y\nExit: n");
                        start = Console.ReadLine();
                        break;
                    case 2:

                        Console.WriteLine("Student Id");

                        Console.WriteLine(school.RemoveStudent(Convert.ToInt32(Console.ReadLine())));

                        _students = school.GetStudents();

                        PrintStudents(_students);
                        Console.WriteLine("-----------");
                        Console.WriteLine("For a repeat operation, enter: y\nExit: n");
                        start = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Student Id");
                        int idStudent = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Edit Student Point");
                        int studentPoint = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(school.SetPoint(idStudent, studentPoint));

                        _students = school.GetStudents();

                        PrintStudents(_students);
                        Console.WriteLine("-----------");
                        Console.WriteLine("For a repeat operation, enter: y\nExit: n");
                        start = Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Student Id");
                        int point = school.GetStudentPoint(Convert.ToInt32(Console.ReadLine()));
                        if (point == -1)
                        {
                            Console.WriteLine("not found id");
                            return;
                        }

                        Console.WriteLine("Student Point: " + point);

                        _students = school.GetStudents();

                        PrintStudents(_students);

                        _students = school.GetStudents();

                        PrintStudents(_students);
                        Console.WriteLine("-----------");
                        Console.WriteLine("For a repeat operation, enter: y\nExit: n");
                        start = Console.ReadLine();
                        break;
                    default:

                        break;
                }
            }

            Console.ReadKey();
        }

        public static void PrintStudents(Dictionary<int, Student> students)
        {
            foreach (var item in students)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("Print All Student");

                Console.WriteLine("Id: "+item.Value.IdNumber);
                Console.WriteLine("Full Name: " + item.Value.FullName);
                Console.WriteLine("Point: " + item.Value.Point);
                Console.WriteLine("Age: " + item.Value.Age);
            }
        }
    }
}
