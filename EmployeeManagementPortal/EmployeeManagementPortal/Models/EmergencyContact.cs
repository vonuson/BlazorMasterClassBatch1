using EmployeeManagementPortal.Enums;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementPortal.Models
{
	public class EmergencyContact
	{
		[Required]
		public string Name { get; set; }

		[Required]
		public string ContactNumber { get; set; }

		[Required]
		public Relationship Relationship { get; set; }

		[Required]
		public bool IsPrimaryContact { get; set; }
	}
}
