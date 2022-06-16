using EmployeeManagementPortal.Shared.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace EmployeeManagementPortal.Client.Components
{
    public partial class StudentListComponent : ComponentBase
    {
        public List<Student> Students { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Students = await Http.GetFromJsonAsync<List<Student>>("api/Student");
        }


    }
}
