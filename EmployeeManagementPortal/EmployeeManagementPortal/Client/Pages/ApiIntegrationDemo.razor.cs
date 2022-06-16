using EmployeeManagementPortal.Shared.Models;
using System.Net.Http.Json;

namespace EmployeeManagementPortal.Client.Pages
{
    public partial class ApiIntegrationDemo
    {
        private List<Sample>? samples;
        public Sample Sample { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            samples = await Http.GetFromJsonAsync<List<Sample>>("api/samples") ?? new List<Sample>();
        }

        private void ClearForm()
        {
            Sample = new Sample();
        }

        private async Task HandleValidSubmit()
        {
            var response = await Http.PostAsJsonAsync("api/samples", Sample);
            var createdSample = await response.Content.ReadFromJsonAsync<Sample>();
            samples?.Add(createdSample);
            ClearForm();
        }

        private async void DeleteSample(Sample sample)
        {
            samples?.Remove(sample);
            await Http.DeleteAsync($"api/samples/{sample.Id}");
        }

        private async void EditName(Sample sample)
        {
            if (sample != null && !string.IsNullOrWhiteSpace(sample.Name))
            {
                await Http.PutAsJsonAsync($"api/samples/{sample.Id}", sample);
            }
        }
    }
}
