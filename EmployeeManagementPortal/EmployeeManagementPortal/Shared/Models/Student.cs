namespace EmployeeManagementPortal.Shared.Models
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public StudentGender Gender { get; set; }

        public DateTimeOffset DateOfBirth { get; set; }

        public string Image { get; set; }
    }
}
