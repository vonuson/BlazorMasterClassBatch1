using EmployeeManagementPortal.Shared.Models;

namespace EmployeeManagementPortal.Client.Pages
{
    public partial class ComplexValidation
    {
        public ComplexDemoModel ComplexDemoModel { get; set; } = new ComplexDemoModel();
        private string demo = string.Empty;

        public void HandleValidSubmit()
        {
            demo = $"The form is valid: {ComplexDemoModel.DataAnnotationDemoModel.Name}";
        }

        public void ClearForm()
        {
            ComplexDemoModel = new ComplexDemoModel();
        }
    }
}
