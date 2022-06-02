using EmployeeManagementPortal.Shared.Enums;
using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementPortal.Shared.Models
{
    public class EmergencyContact
    {
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; } = string.Empty;

        [StringLength(100, MinimumLength = 2)]
        public string MobileNumber { get; set; } = string.Empty;

        public Relationship Relationship { get; set; }
    }

    public class EmergencyContactValidator : AbstractValidator<EmergencyContact>
    {
        public EmergencyContactValidator()
        {
            RuleFor(e => e.Name).NotEmpty().WithMessage("Please enter a name.")
                .MaximumLength(10).WithMessage("Sorry short name only.");
            RuleFor(e => e.MobileNumber).NotEmpty().MaximumLength(10);
        }
    }
}
