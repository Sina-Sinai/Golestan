using App.Domain.Core.Students.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Students.Repositories
{
    public interface IStudentRepository
    {
        public List<Student> GetStudents();
        public void Update(Student student);
    }
}
