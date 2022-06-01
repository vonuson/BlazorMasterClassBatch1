using EmployeeManagementPortal.Enums;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementPortal.Models
{
	public class Employee
	{
		public int EmployeeId { get; set; }

		public bool IsActive { get; set; }

		[Required]
		public string FirstName { get; set; }

		public string? MiddleName { get; set; }

		[Required]
		public string LastName { get; set; }

		[Required]
		public Gender Gender { get; set; }

		[Required]
		public DateTime DateOfBirth { get; set; }

		[Required]
		public string BirthCountry { get; set; }

		public string? BirthState { get; set; }

		[Required]
		public string ContactNumber { get; set; }

		public EmergencyContact? EmergencyContact { get; set; }

		[Required]
		public string EmailAddress { get; set; }

		public MaritalStatus MaritalStatus { get; set; }

		public Address Address { get; set; }
		public string? Description { get; set; }
	}
}
