using Microsoft.AspNetCore.Components;
using Blazored.SessionStorage;

namespace EmployeeManagementPortal.Client.Pages
{
    public partial class SessionStorageDemo
    {
        [Inject]
        ISessionStorageService sessionStorage { get; set; }

        public string Name { get; set; } = "Name";
        public List<string> RecentSearches { get; set; } = new List<string>();
        private string search;
        private int sessionStorageLength;
        private string sessionStorageKey0;
        private bool sessionStorageHasName;

        protected override async Task OnInitializedAsync()
        {
            Name = await sessionStorage.GetItemAsStringAsync("name");
            RecentSearches = await sessionStorage.GetItemAsync<List<string>>("recent-searches") ?? new List<string>();
        }

        private async Task SaveName()
        {
            await sessionStorage.SetItemAsStringAsync("name", Name);
        }

        private async Task SaveSearch()
        {
            RecentSearches.Add(search);
            await sessionStorage.SetItemAsync("recent-searches", RecentSearches);
            search = string.Empty;
        }

        private async Task ClearSearches()
        {
            await sessionStorage.RemoveItemAsync("recent-searches");
            RecentSearches?.Clear();
            search = string.Empty;
        }

        private async Task ClearSessionStorage()
        {
            await sessionStorage.ClearAsync();
            RecentSearches?.Clear();
            search = string.Empty;
            Name = string.Empty;
        }

        private async Task DemoOtherProperties()
        {
            sessionStorageLength = await sessionStorage.LengthAsync();
            sessionStorageKey0 = await sessionStorage.KeyAsync(0);
            sessionStorageHasName = await sessionStorage.ContainKeyAsync("name");
        }
    }
}
