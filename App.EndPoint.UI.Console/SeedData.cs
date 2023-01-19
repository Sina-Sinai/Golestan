using App.Domain.Core.Courses.Entities;
using App.Domain.Core.Courses.Enums;
using App.Domain.Core.Students.Entities;
using GolestanFramework.JsonFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.EndPoint.UI.Console
{
    public static class SeedData
    {
        public static void Seed()
        {
            List<Course> Courses = new List<Course>()
            {
                new Course()
                {
                    Id = 1,
                    Name = "Operating System",
                    Unit = 3,
                    DayOfClass = DaysOfWeekEnum.Saturday,
                    StartTime = new TimeOnly(10, 0),
                    EndTime = new TimeOnly(11, 30),
                    TeacherName = "rasool yekta"
                },
                new Course()
                {
                    Id = 2,
                    Name = "Database",
                    Unit = 3,
                    DayOfClass = DaysOfWeekEnum.Saturday,
                    StartTime = new TimeOnly(12, 0),
                    EndTime = new TimeOnly(13, 30),
                    TeacherName = "rasool yekta"
                },
                new Course()
                {
                    Id = 3,
                    Name = "Database",
                    Unit = 3,
                    DayOfClass = DaysOfWeekEnum.Sunday,
                    StartTime = new TimeOnly(12, 0),
                    EndTime = new TimeOnly(13, 30),
                    TeacherName = "rasool yekta"
                },
                new Course()
                {
                    Id = 4,
                    Name = "Operating System",
                    Unit = 3,
                    DayOfClass = DaysOfWeekEnum.Sunday,
                    StartTime = new TimeOnly(12, 0),
                    EndTime = new TimeOnly(13, 30),
                    TeacherName = "amir mohebi"
                },
            };

            List<Student> Students = new List<Student>();

            var st1 = new Student(1, 821410301, "amir", "salami", "09121234567", 20)
            {
                Email = "amirsalami@gmail.com",
            };
            var result1 = st1.AddCourse(Courses.Where(p => p.Id == 1).Single());
            var result2 = st1.AddCourse(Courses.Where(p => p.Id == 2).Single());
            st1.Activate();
            Students.Add(st1);

            var st2 = new Student(2, 821410302, "reza", "hasani", "09121234568", 20)
            {
                Email = "reza hasani@gmail.com",
            };
            var result3 = st2.AddCourse(Courses.Where(p => p.Id == 1).Single());
            var result4 = st2.AddCourse(Courses.Where(p => p.Id == 3).Single());
            st2.Activate();
            Students.Add(st2);

            JsonFileUtils.Write(Courses, "Courses.json");
            JsonFileUtils.Write(Students, "Students.json");
        }
    }
}
