using ProjectSchool_GD.Domain;
using ProjectSchool_GD.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSchool_GD.Services
{
    public class SchoolService : ISchool
    {
        public Dictionary<int, Student> Students = new Dictionary<int, Student>();
        public string AddStudent(int IdNumber, Student student)
        {
                if (!Students.ContainsKey(IdNumber))
                {
                    Students.Add(IdNumber, student);
                    return "Add student";
                }
            return "This ID already exists";
        }

        public int GetStudentPoint(int IdNumber)
        {
            int point = -1;
            foreach (var item in Students)
            {
                if (item.Key == IdNumber)
                {
                    point = item.Value.Point;
                }
            }

            return point;
        }
       

        public string RemoveStudent(int IdNumber)
        {
            foreach (var item in Students)
            {
                if (item.Key == IdNumber)
                {
                    Students.Remove(IdNumber);
                    return "Success";
                }
            }
            return "Not Found";
        }

        public string SetPoint(int IdNumber, int point)
        {
            foreach (var item in Students)
            {
                if (item.Key == IdNumber)
                {
                    item.Value.Point = point;
                    return "Set sucsess";
                }
            }
            return "Not Found";

        }

        public Dictionary<int, Student> GetStudents()
        {
            return Students;
        }
    }
}
