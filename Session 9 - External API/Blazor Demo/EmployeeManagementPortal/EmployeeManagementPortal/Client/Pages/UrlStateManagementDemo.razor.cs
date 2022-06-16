using Microsoft.AspNetCore.Components;

namespace EmployeeManagementPortal.Client.Pages
{
    public partial class UrlStateManagementDemo
    {
        [Parameter]
        public string Id { get; set; }

        [Parameter]
        public string Secret { get; set; }

        [Parameter]
        [SupplyParameterFromQuery]
        public int Page { get; set; }
    }
}
