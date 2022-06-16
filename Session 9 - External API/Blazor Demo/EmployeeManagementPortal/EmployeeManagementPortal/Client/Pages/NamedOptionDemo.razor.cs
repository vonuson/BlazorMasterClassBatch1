using EmployeeManagementPortal.Shared.Models;
using System.Net.Http.Json;

namespace EmployeeManagementPortal.Client.Pages
{
    public partial class NamedOptionDemo
    {
        private List<Sample>? samples;

        protected override async Task OnInitializedAsync()
        {
            var client = ClientFactory.CreateClient("NamedDemo");
            samples = await client.GetFromJsonAsync<List<Sample>>("api/samples");
        }
    }
}
