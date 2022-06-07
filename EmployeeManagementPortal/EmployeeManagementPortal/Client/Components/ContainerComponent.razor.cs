using EmployeeManagementPortal.Client.Shared;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagementPortal.Client.Components
{
    public partial class ContainerComponent : ComponentBase
    {
        [Parameter]
        public ComponentState State { get; set; }

        [Parameter]
        public RenderFragment Content { get; set; }

        [Parameter]
        public string Error { get; set; }
    }
}
