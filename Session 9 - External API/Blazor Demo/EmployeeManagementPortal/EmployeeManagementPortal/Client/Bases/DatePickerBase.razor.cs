using Microsoft.AspNetCore.Components;

namespace EmployeeManagementPortal.Client.Bases
{
    public partial class DatePickerBase : ComponentBase
    {
        [Parameter]
        public DateTimeOffset Value { get; set; }

        public void SetValue(DateTimeOffset value) => this.Value = value;

        [Parameter]
        public EventCallback<DateTimeOffset> ValueChanged { get; set; }

        private Task OnValueChanged(ChangeEventArgs changeEventArgs)
        {
            this.Value = DateTimeOffset.Parse(changeEventArgs.Value.ToString());
            return ValueChanged.InvokeAsync(this.Value);
        }
    }
}
