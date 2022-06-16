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

            using(var client = new HttpClient())
            {
                // CRUD operations
            }
        }

        public async Task<List<Sample>> GetSamplesAsync()
        {
            return await http.GetFromJsonAsync<List<Sample>>("api/samples") ?? new List<Sample>();
        }
    }
}
