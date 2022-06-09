using EmployeeManagementPortal.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagementPortal.Client.Bases
{
    public partial class GridBase<TItem> : ComponentBase
    {
        [Parameter]
        public IList<TItem> Items { get; set; }

        [Parameter]
        public RenderFragment<TItem> Columns { get; set; }
    }
}
