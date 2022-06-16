using EmployeeManagementPortal.Shared.Models;
using Microsoft.AspNetCore.Components.Forms;

namespace EmployeeManagementPortal.Client.Pages
{
    public partial class DataAnnotationDemo
    {
        public DataAnnotationDemoModel Demo { get; set; } = new DataAnnotationDemoModel();
        private string demo = string.Empty;

        public void HandleValidSubmit()
        {
            demo = $"The form is valid: {Demo.Name}";
        }

        public void HandleUploadPhoto(InputFileChangeEventArgs e)
        {
            demo = $"File Name: {e.File.Name} | File Size: {e.File.Size} | File Type: {e.File.ContentType} | Last Modified: {e.File.LastModified}";
        }
        public void ClearForm()
        {
            Demo = new DataAnnotationDemoModel();
        }
    }
}
