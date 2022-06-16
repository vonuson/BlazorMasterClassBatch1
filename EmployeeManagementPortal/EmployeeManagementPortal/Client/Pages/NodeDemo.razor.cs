using EmployeeManagementPortal.Shared.Models;
using System.Net.Http.Json;

namespace EmployeeManagementPortal.Client.Pages
{
    public partial class NodeDemo
    {
        private List<NodeDemoModel>? nodeDemos;

        protected override async Task OnInitializedAsync()
        {
            var client = ClientFactory.CreateClient("NodeDemo");
            nodeDemos = await client.GetFromJsonAsync<List<NodeDemoModel>>("users") ?? new List<NodeDemoModel>();
        }
    }
}
