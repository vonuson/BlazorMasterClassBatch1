using EmployeeManagementPortal.Shared.Models;

namespace EmployeeManagementPortal.Client.Pages
{
    public partial class FluentValidation
    {
        public FluentValidationDemoModel Demo { get; set; } = new FluentValidationDemoModel();
        private string demo = string.Empty;

        public void HandleValidSubmit()
        {
            demo = $"The form is valid: {Demo.Name}";
        }

        public void ClearForm()
        {
            Demo = new FluentValidationDemoModel();
        }
    }
}
