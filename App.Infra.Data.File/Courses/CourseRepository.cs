using App.Domain.Core.Courses.Entities;
using App.Domain.Core.Courses.Repositpries;
using App.Domain.Core.Students.Entities;
using GolestanFramework.JsonFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.File.Courses
{
    public class CourseRepository : ICourseRepository
    {
        public List<Course> GetCourses()
        {
            return JsonFileUtils.Read<List<Course>>("Courses.json");
        }
    }
}
