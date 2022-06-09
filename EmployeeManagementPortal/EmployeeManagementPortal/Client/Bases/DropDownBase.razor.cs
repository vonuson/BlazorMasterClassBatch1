using Microsoft.AspNetCore.Components;

namespace EmployeeManagementPortal.Client.Bases
{
    public partial class DropDownBase<TEnum> : ComponentBase
    {
        [Parameter]
        public TEnum Value { get; set; }        

        public void SetValue(TEnum value) => this.Value = value;

        [Parameter]
        public EventCallback<TEnum> ValueChanged { get; set; }

        private Task OnValueChanged(ChangeEventArgs changeEventArgs)
        {
            this.Value = (TEnum) Enum.Parse(typeof(TEnum), changeEventArgs.Value.ToString());
            return ValueChanged.InvokeAsync(this.Value);
        }
    }
}
