using App.Domain.Core.Students.Entities;
using App.Domain.Core.Students.Repositories;
using GolestanFramework.JsonFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.File.Students
{
    public class StudentRepository : IStudentRepository
    {
        public List<Student> GetStudents()
        {
            return JsonFileUtils.Read<List<Student>>("Students.json");
        }

        public void Update(Student student)
        {
            var students = GetStudents();
            var st =students.FirstOrDefault(p => p.StudentNo == student.StudentNo);
            st.Courses = student.Courses;
            st.FirstName = student.FirstName;
        }
    }
}
