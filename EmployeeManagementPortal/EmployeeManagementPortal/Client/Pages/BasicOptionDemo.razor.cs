using EmployeeManagementPortal.Shared.Models;
using System.Net.Http.Json;

namespace EmployeeManagementPortal.Client.Pages
{
    public partial class BasicOptionDemo
    {
        private List<Sample>? samples;

        protected override async Task OnInitializedAsync()
        {
            var client = ClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:7197");
            samples = await client.GetFromJsonAsync<List<Sample>>("api/samples") ?? new List<Sample>();
        }
    }
}
