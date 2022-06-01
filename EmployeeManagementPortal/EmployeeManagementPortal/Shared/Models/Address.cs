using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementPortal.Shared.Models
{
	public class Address
	{
		public string? HouseNumber { get; set; }
		public string? Street { get; set; }

		[Required]
		public string City { get; set; }

		[Required]
		public string Country { get; set; }
	}
}
