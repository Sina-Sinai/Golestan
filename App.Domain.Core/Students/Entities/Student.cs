using App.Domain.Core.Courses.Entities;
using App.Domain.Core.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Students.Entities
{
    public class Student : User
    {
        public Student(int userId, int studentNo, string firstName, string lastName, string mobile, int maxUnit) : base(userId, studentNo.ToString(), mobile)
        {
            StudentNo = studentNo;
            FirstName = firstName;
            LastName = lastName;
            Mobile = mobile;
            MaxUnit = maxUnit;
        }

        public int StudentNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; }
        public string Mobile { get; set; }
        public int MaxUnit { get; set; }
        public List<Course> Courses { get; private set; } = new List<Course>();

        public override bool Activate()
        {
            if (Email is null)
                return false;
            base.isActived = true;
            return true;
        }

        public Tuple<bool, string> AddCourse(Course course)
        {
            if (Courses.Sum(p => p.Unit) + course.Unit > MaxUnit)
                return new Tuple<bool, string>(false, "The number of units exceeds the quota");
            foreach (var item in Courses)
            {
                if (!(item.DayOfClass != course.DayOfClass || item.StartTime >= course.EndTime ||
                    item.EndTime <= course.StartTime))
                {
                    return new Tuple<bool, string>(false, $"the course has conflict with {item.Name}");
                }
            }
            Courses.Add(course);
            return new Tuple<bool, string>(true, "the course add successfully.");
        }

        public Tuple<bool, string> RemoveCourse(Course course)
        {
            if (Courses.All(p => p.Id != course.Id))
                return new Tuple<bool, string>(false, "the course not selected");
            Courses.Remove(course);
            return new Tuple<bool, string>(true, "the course remove successfully.");
        }
    }
}
