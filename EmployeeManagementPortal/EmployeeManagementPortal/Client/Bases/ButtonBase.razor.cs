using Microsoft.AspNetCore.Components;

namespace EmployeeManagementPortal.Client.Bases
{
    public partial class ButtonBase : ComponentBase
    {
        [Parameter]
        public string Label { get; set; }

        [Parameter]
        public Action OnClick { get; set; }

        public void Click() => OnClick?.Invoke();
    }
}
