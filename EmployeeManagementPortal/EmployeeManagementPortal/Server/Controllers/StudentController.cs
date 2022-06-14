using EmployeeManagementPortal.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace EmployeeManagementPortal.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> _logger;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly IMemoryCache _cache;
        private readonly string _cacheKey = "secretkey";

        private string ConvertToBase64String(string path)
        {
            string wwwRootPath = _hostEnvironment.ContentRootPath + path;

            byte[] imageArray = System.IO.File.ReadAllBytes(wwwRootPath);
            return Convert.ToBase64String(imageArray);
        }

        public StudentController(ILogger<StudentController> logger, IWebHostEnvironment hostEnvironment, IMemoryCache cache)
        {
            _logger = logger;
            _hostEnvironment = hostEnvironment;
            _cache = cache;
            InitializeStudents();
        }

        private void InitializeStudents()
        {
            if (GetStudentsCached() == null)
            {
                List<Student> students = new()
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
                SetStudentsCached(students);
            }
        }

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return GetStudentsCached();
        }

        [HttpPost]
        public Student Add(Student student)
        {
            var students = GetStudentsCached();

            student.Image = ConvertToBase64String("/Images/timothee.jpg");
            student.DateOfBirth = DateTime.Now.AddYears(-30);
            student.Gender = StudentGender.Other;

            students.Add(student);

            SetStudentsCached(students);

            return student;
        }

        private void SetStudentsCached(List<Student> students)
        {
            var cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromMinutes(60));
            _cache.Set<List<Student>>(_cacheKey, students, cacheEntryOptions);
        }

        private List<Student> GetStudentsCached()
        {
            _cache.TryGetValue<List<Student>>(_cacheKey, out var students);
            return students;
        }
    }
}

