using EmployeeManagementPortal.Shared.Enums;
using EmployeeManagementPortal.Shared.Validators;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementPortal.Shared.Models
{
    public class DataAnnotationDemoModel
    {
        [Required]
        [StringLength(25)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a description")]
        [StringLength(100, MinimumLength = 5)]
        public string Description { get; set; } = string.Empty;

        [Range(1, 10)]
        public int StarRating { get; set; }

        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [RegularExpression(@"^(09|\+639)\d{9}$")]
        public string Phone { get; set; } = string.Empty;

        [Url]
        public string Website { get; set; } = string.Empty;
        
        [Required]
        public string Password { get; set; } = string.Empty;
        
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; } = string.Empty;

        // Additional
        public Gender? Gender { get; set; }

        public MaritalStatus MaritalStatus { get; set; }

        public DateTime DemoDate { get; set; } = DateTime.Now;

        public bool IsLive { get; set; }

        // Additiona 2

        [BirthdayValidator(MinimumAge = 18)]
        public DateTime Birthday { get; set; } = DateTime.Now;
    }
}
