using Microsoft.AspNetCore.Components;

namespace EmployeeManagementPortal.Client.Bases
{
    public partial class LabelBase : ComponentBase
    {
        [Parameter]
        public string Value { get; set; }

        public void SetValue(string value)
        {
            this.Value = value;
            StateHasChanged();
        }
    }
}
