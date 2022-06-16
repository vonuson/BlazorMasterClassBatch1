using EmployeeManagementPortal.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementPortal.Shared.Models
{
    public class Sample
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Nationality { get; set; }
        public Gender Gender { get; set; }
    }
}
