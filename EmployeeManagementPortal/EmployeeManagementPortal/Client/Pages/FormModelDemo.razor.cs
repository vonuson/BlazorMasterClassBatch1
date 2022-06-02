using EmployeeManagementPortal.Shared.Models;

namespace EmployeeManagementPortal.Client.Pages
{
    public partial class FormModelDemo
    {
        public EmergencyContact EmergencyContact { get; set; } = new EmergencyContact();
        private string demo = string.Empty;

        public void HandleValidSubmit()
        {
            demo = $"The form is valid: {EmergencyContact.Name}";
        }

        public void HandleInvalidSubmit()
        {
            demo = $"The form is invalid: {EmergencyContact.Name}";
        }

        public void ClearForm()
        {
            EmergencyContact = new EmergencyContact();
        }
    }
}
