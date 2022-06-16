using EmployeeManagementPortal.Shared.Models;

namespace EmployeeManagementPortal.Client.Pages
{
    public partial class TypedOptionDemo
    {
        private List<Sample>? samples;

        protected override async Task OnInitializedAsync()
        {
            samples = await Http.GetSamplesAsync();
        }
    }
}
