using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementPortal.Shared.Models
{
    public class ComplexDemoModel
    {
        [Required]
        public string RegularProperty { get; set; } = string.Empty;

        [ValidateComplexType]
        public DataAnnotationDemoModel DataAnnotationDemoModel { get; set; } = new DataAnnotationDemoModel();
    }
}
