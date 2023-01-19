using App.Domain.Core.Courses.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Courses.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DaysOfWeekEnum DayOfClass { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public int Unit { get; set; }
        public string TeacherName { get; set; }

    }
}
