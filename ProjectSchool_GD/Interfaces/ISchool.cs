using ProjectSchool_GD.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSchool_GD.Interfaces
{
    public interface ISchool
    {
        string AddStudent(int IdNumber, Student student);
        string SetPoint(int IdNumber, int point);
        string RemoveStudent(int IdNumber);
        int GetStudentPoint(int IdNumber);

        Dictionary<int, Student> GetStudents();


    }
}
