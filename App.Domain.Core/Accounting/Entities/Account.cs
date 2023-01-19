using App.Domain.Core.Accounting.Enums;
using App.Domain.Core.Entities.Users;
using App.Domain.Core.Students.Entities;
using App.Domain.Core.Students.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Accounting.Entities
{
    public class Account
    {
        private readonly IStudentRepository _studentRepository;

        public Account(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;

            Students=_studentRepository.GetStudents();
        }





        public User CurrentUser { get; set; }
        public RoleEnum CurrentUserRole { get; set; }
        private List<Student> Students { get; set; }
        //private List<Operator> Operators { get; set; }

        public Tuple<bool, string> LoginStudent(string username, string password)
        {
            var student = Students.Where(p => p.userName == username).FirstOrDefault();
            if (student == null)
                return new Tuple<bool, string>(false, "Username or Password is incorrect.");
            else if (!student.isActived)
                return new Tuple<bool, string>(false, "Student is Inactive.");
            else if (!student.CheckPassWord(password))
                return new Tuple<bool, string>(false, "Username or Password is incorrect.");

            CurrentUser = student;
            CurrentUserRole = RoleEnum.Student;
            return new Tuple<bool, string>(true, "Login Success.");
        }
    }
}
