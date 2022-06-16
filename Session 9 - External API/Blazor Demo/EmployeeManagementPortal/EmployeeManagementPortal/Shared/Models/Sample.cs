using EmployeeManagementPortal.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
