using System.ComponentModel.DataAnnotations;
using FluentValidation;

namespace EmployeeManagementPortal.Shared.Models
{
    public class Address
    {
        public string? HouseNumber { get; set; }
        public string? Street { get; set; }
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
    }

    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(a => a.City).NotEmpty();
            RuleFor(a => a.Country).NotEmpty();
        }
    }
}
