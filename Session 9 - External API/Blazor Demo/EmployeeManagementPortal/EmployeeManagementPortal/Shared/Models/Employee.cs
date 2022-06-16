using EmployeeManagementPortal.Shared.Enums;
using FluentValidation;

namespace EmployeeManagementPortal.Shared.Models
{
    public class Employee
	{
		public int EmployeeId { get; set; }

		public string FirstName { get; set; } = string.Empty;

		public string? MiddleName { get; set; }

		public string LastName { get; set; } = string.Empty;

		public Gender Gender { get; set; }

		public DateTime DateOfBirth { get; set; } = DateTime.Now;

		public string MobileNumber { get; set; } = string.Empty;

		public string EmailAddress { get; set; } = string.Empty;

		public string? Description { get; set; }

		public MaritalStatus MaritalStatus { get; set; }

		public EmergencyContact EmergencyContact { get; set; } = new EmergencyContact();

		public Address Address { get; set; } = new Address();
	}

	public class EmployeeValidator : AbstractValidator<Employee>
    {
		public EmployeeValidator()
        {
			RuleFor(e => e.FirstName).NotEmpty().WithMessage("Enter a firstname");
			RuleFor(e => e.Address).SetValidator(new AddressValidator());
        }
    }
}
