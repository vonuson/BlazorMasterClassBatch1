using Microsoft.AspNetCore.Components;

namespace EmployeeManagementPortal.Pages
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
