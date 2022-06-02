using EmployeeManagementPortal.Shared.Models;
using Microsoft.AspNetCore.Components.Forms;

namespace EmployeeManagementPortal.Client.Pages
{
    public partial class FormEditContextDemo
    {
        public EmergencyContact EmergencyContact { get; set; } = new EmergencyContact();
        private EditContext? editContext;
        private string demo = string.Empty;

        protected override void OnInitialized()
        {
            editContext = new EditContext(EmergencyContact);
        }

        public void HandleSubmit()
        {
            if (editContext != null && editContext.Validate())
            {
                demo = $"The form is valid {EmergencyContact.Name}";
            }
            else
            {
                demo = $"The form is invalid {EmergencyContact.Name}";
            }
        }

        public void ClearForm()
        {
            EmergencyContact = new EmergencyContact();
            editContext = new EditContext(EmergencyContact);
        }
    }
}
