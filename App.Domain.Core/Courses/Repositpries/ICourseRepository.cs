using App.Domain.Core.Courses.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Courses.Repositpries
{
    public interface ICourseRepository
    {
        public List<Course> GetCourses();
    }
}
