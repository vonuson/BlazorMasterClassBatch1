using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementPortal.Shared.Validators
{
    public class BirthdayValidator : ValidationAttribute
    {
        public int MinimumAge { get; set; }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            DateTime birthdate;

            #region validation
            if (DateTime.TryParse(value?.ToString(), out birthdate))
            {
                if (birthdate < DateTime.Now.AddYears(MinimumAge * -1))
                {
                    return null;
                }
                else
                {
                    return new ValidationResult($"Person must be at least {MinimumAge}.",
                        new[] { validationContext.MemberName });
                }
            }
            #endregion

            return new ValidationResult("Invalid birthday", new[] { validationContext.MemberName });
        }
    }
}
