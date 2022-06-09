using EmployeeManagementPortal.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementPortal.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> _logger;
        private readonly IWebHostEnvironment _hostEnvironment;

        private string ConvertToBase64String(string path)
        {
            string wwwRootPath = _hostEnvironment.ContentRootPath + path;

            byte[] imageArray = System.IO.File.ReadAllBytes(wwwRootPath);
            return Convert.ToBase64String(imageArray);
        }

        private List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student()
                {
                    FirstName = "Leo",
                    LastName = "DiCaprio",
                    Gender = StudentGender.Male,
                    DateOfBirth = new DateTimeOffset(1974, 11, 11, 0, 0, 0, new TimeSpan()),
                    Image = ConvertToBase64String("/Images/leo.jpg")
                },
                new Student()
                {
                    FirstName = "Meryl",
                    LastName = "Streep",
                    Gender = StudentGender.Female,
                    DateOfBirth = new DateTimeOffset(1949, 6, 22, 0, 0, 0, new TimeSpan()),
                    Image = ConvertToBase64String("/Images/meryl.jpg"),
                },
                new Student()
                {
                    FirstName = "Jennifer",
                    LastName = "Lawrence",
                    Gender = StudentGender.Female,
                    DateOfBirth = new DateTimeOffset(1990, 8, 15, 0, 0, 0, new TimeSpan()),
                    Image = ConvertToBase64String("/Images/jennifer.jpg")
                },
                new Student()
                {
                    FirstName = "Timothee",
                    LastName = "Chalamet",
                    Gender = StudentGender.Male,
                    DateOfBirth = new DateTimeOffset(1995, 12, 27, 0, 0, 0, new TimeSpan()),
                    Image = ConvertToBase64String("/Images/timothee.jpg")
                },
                new Student()
                {
                    FirstName = "Cate",
                    LastName = "Blanchett",
                    Gender = StudentGender.Other,
                    DateOfBirth = new DateTimeOffset(1969, 5, 14, 0, 0, 0, new TimeSpan()),
                    Image = ConvertToBase64String("/Images/cate.jpg")
                }
            };
        }

        public StudentController(ILogger<StudentController> logger, IWebHostEnvironment hostEnvironment)
        {
            _logger = logger;
            _hostEnvironment = hostEnvironment;
        }

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return GetStudents();
        }
    }
}

