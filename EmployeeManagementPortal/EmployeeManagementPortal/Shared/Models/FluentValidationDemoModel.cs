using FluentValidation;

namespace EmployeeManagementPortal.Shared.Models
{
    public class FluentValidationDemoModel
    {
        public string? Name { get; set; }
        public int? Age { get; set; }
        public EmergencyContact EmergencyContact { get; set; } = new EmergencyContact();
    }
    public class FluentValidationDemoModelValidator : AbstractValidator<FluentValidationDemoModel>
    {
        public FluentValidationDemoModelValidator()
        {
            RuleFor(e => e.Name).NotNull();
            RuleFor(e => e.Age).NotNull();
            RuleFor(e => e.EmergencyContact).SetValidator(new EmergencyContactValidator());
        }
    }
}
