using EmployeeManagementPortal.Shared.Models;

namespace EmployeeManagementPortal.Client.Services
{
    public class StudentService
    {
        public event Action OnChange;

        public List<Student> Students { get; private set; } = new();

        public StudentService()
        {
            Students.AddRange(new List<Student>() {
                new Student
                {
                    FirstName = "Norben",
                    LastName = "Oriarte"
                },
                new Student
                {
                    FirstName = "Von",
                    LastName = "Uson"
                },
                new Student
                {
                    FirstName = "Reyn",
                    LastName = "Adonay"
                }
            });
        }

        public async Task AddStudent(Student student)
        {
            Students.Add(student);
            NotifyChanged();
        }

        public async Task ClearStudents()
        {
            Students.Clear();
            NotifyChanged();
        }

        private void NotifyChanged() => OnChange?.Invoke();
    }
}
