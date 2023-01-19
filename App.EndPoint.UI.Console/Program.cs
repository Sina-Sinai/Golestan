
using App.Domain.Core.Accounting.Entities;
using App.Domain.Core.Courses.Entities;
using App.Domain.Core.Courses.Repositpries;
using App.Domain.Core.Students.Entities;
using App.Domain.Core.Students.Repositories;
using App.EndPoint.UI.Console;
using App.Infra.Data.File.Courses;
using App.Infra.Data.File.Students;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
            .AddScoped<ICourseRepository,CourseRepository>()
            .AddScoped<IStudentRepository, StudentRepository>()
            .AddScoped<Account>()
            .BuildServiceProvider();

SeedData.Seed();


Console.WriteLine("Please enter username:");
var username = Console.ReadLine();
Console.WriteLine("please enter your password:");
var password = Console.ReadLine();


var result =serviceProvider.GetService<Account>().LoginStudent(username,password);

Student st =(Student) serviceProvider.GetService<Account>().CurrentUser;

List<Course> Courses = serviceProvider.GetService<ICourseRepository>().GetCourses();

foreach (var item in st.Courses)
{
    var course = Courses.FirstOrDefault(c => c.Id == item.Id);
    Courses.Remove(course);
}

st.ChangePassWord("fsd", "fsdf");



Console.WriteLine(st.FirstName + " " + st.LastName);

foreach (var item in st.Courses)
{
    Console.WriteLine($"{item.Name} {item.Unit} {item.TeacherName}");
}

Console.WriteLine("----------------------------------------");

foreach (var item in Courses)
{
    Console.WriteLine($"{item.Name} {item.Unit} {item.TeacherName}");
}