using EmployeeManagementPortal.Shared.Models;
using System.Net.Http.Json;

namespace EmployeeManagementPortal.Client.HttpClients
{
    public class TypedDemoHttpClient
    {
        private readonly HttpClient http;

        public TypedDemoHttpClient(HttpClient http)
        {
            this.http = http;
        }

        public async Task<List<Sample>> GetSampleAsync()
        {
            return await http.GetFromJsonAsync<List<Sample>>("api/samples");
        }
    }
}
