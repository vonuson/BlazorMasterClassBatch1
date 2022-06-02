using Microsoft.AspNetCore.Components;

namespace EmployeeManagementPortal.Client.Pages
{
    public class CounterBase : ComponentBase
    {
        protected int currentCount = 20;

        protected void IncrementCount()
        {
            currentCount++;
        }
    }
}
