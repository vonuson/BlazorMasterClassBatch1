using Microsoft.AspNetCore.Components;
using System.Collections;

namespace EmployeeManagementPortal.Client.Bases
{
    public partial class ValidationSummaryBase : ComponentBase
    {
        [Parameter]
        public IDictionary ValidationData { get; set; }

        [Parameter]
        public string Key { get; set; }

        public IEnumerable<string> Errors
        {
            get => this.ValidationData?[Key] as IEnumerable<string>;
            set => this.Errors = value;
        }
    }
}
