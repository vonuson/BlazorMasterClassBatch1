using EmployeeManagementPortal.Client.Bases;
using EmployeeManagementPortal.Client.Shared;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagementPortal.Client.Components
{
    public partial class StudentRegistrationComponent : ComponentBase
    {
        public ComponentState State { get; set; }

        public TextBoxBase TextBox { get; set; }

        public void ButtonClicked()
        {
            string value = TextBox.Value;
        }

        protected override void OnInitialized()
        {
            this.State = ComponentState.Content;
        }
    }
}
